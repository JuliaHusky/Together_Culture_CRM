using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace BeaversCRM_1
{
    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string type { get; set; }
        public string location { get; set; }
        public int tagId { get; set; }
        public int numberOfAttendees { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }

        public static DataRowCollection getEventsFromDb(string eventType, int offset)
        {
            try
            {
                Database db = new Database();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(eventType, db.connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@offset", offset);
                    return db.getDataFromDb(adapter).Tables[0].Rows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting events data from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void createDbRecord()
        {
            try
            {
                Database db = new Database();
                using (MySqlCommand cmd = new MySqlCommand(Constants.INSERT_EVENT, db.connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@tagId", tagId);
                    cmd.Parameters.AddWithValue("@attendees", numberOfAttendees);
                    cmd.Parameters.AddWithValue("@location", location);
                    db.putDataIntoDb(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting event into database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isInDbTable()
        {
            try
            {
                Database db = new Database();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Constants.CHECK_IF_EVENT_EXISTS, db.connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@name", name);
                    adapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                    DataTable eventTable = db.getDataFromDb(adapter).Tables[0];
                    if (eventTable.Rows.Count != 0)
                    {
                        List<string> parameters = new List<string>();
                        foreach (object eventAttribute in eventTable.Rows[0].ItemArray)
                        {
                            if (eventAttribute.ToString().Trim('\n','\r',' ').Length == 0 && type.Trim('\n', '\r',' ') != "" && endDate.ToString() != "" && description.Trim('\n','\r',' ') != "" && Array.IndexOf(eventTable.Rows[0].ItemArray, eventAttribute) != 0)
                            {
                                parameters.Add(string.Format("{0} = @{0}", eventTable.Columns[Array.IndexOf(eventTable.Rows[0].ItemArray, eventAttribute)].ColumnName));
                            }
                        }

                        if (parameters.Count != 0)
                        {
                            db.initialiseConnection();
                            using (MySqlCommand cmd = new MySqlCommand(Constants.UPDATE_EVENT.Replace("@columns", string.Join(", ", parameters)), db.connection))
                            {
                                foreach (string parameter in parameters)
                                {
                                    if (parameter.Split('=')[0].Trim() == "EventType")
                                    {
                                        cmd.Parameters.AddWithValue("@EventType", type);
                                    }
                                    else if (parameter.Split('=')[0].Trim() == "EventEndTime")
                                    {
                                        cmd.Parameters.AddWithValue("@EventEndTime", endDate);
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@EventDescription", description);
                                    }
                                }
                                cmd.Parameters.AddWithValue("@eventid", eventTable.Rows[0][0]);
                                db.putDataIntoDb(cmd);
                            }
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for event in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        
         public static void updateDbEvents()
         {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://www.togetherculture.com/events");
                    request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.6367.118 Safari/537.36");
                    string html = client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
                    HtmlDocument htmlDoc = new HtmlDocument();
                    htmlDoc.LoadHtml(html);
                    foreach (var eventHtml in htmlDoc.DocumentNode.SelectNodes("//*[@id=\"sections\"]/section[2]/div[2]/div/div/ul/li"))
                    {
                        Event newEvent = new Event();
                        newEvent.name = eventHtml.ChildNodes[3].ChildNodes[1].ChildNodes[1].InnerText.Trim();
                        newEvent.description = eventHtml.ChildNodes[3].ChildNodes[1].ChildNodes[3].ChildNodes[2].InnerText.Trim();
                        string rawDateTime = eventHtml.ChildNodes[3].ChildNodes[1].ChildNodes[3].ChildNodes[1].InnerText;
                        string date = string.Format("{0}-{1}", rawDateTime.Split(',')[0].Split(' ')[1],  rawDateTime.Split(',')[0].Split(' ')[2]);
                        if (date.Split('-')[0].Length != 2)
                        {
                            date = "0" + date;
                        }
                        string rawStartTime = rawDateTime.Split(',')[1].Split('-')[0].Trim();
                        string rawEndTime = rawDateTime.Split(',')[1].Split('-')[1].Trim();
                        if (rawStartTime.EndsWith("."))
                        {
                            rawStartTime = rawStartTime.Substring(0, rawStartTime.Length - 1);
                        }
                        if (rawStartTime.Contains(".") && !(rawStartTime.Contains("pm") || rawStartTime.Contains("am")))
                        {
                            if (rawStartTime.Split('.')[0].Length != 2)
                            {
                                rawStartTime = "0" + rawStartTime;
                            }

                            if (rawEndTime.Contains("pm"))
                            {
                                rawStartTime = rawStartTime.Replace(".", ":") + " PM";
                            }
                            else
                            {
                                rawStartTime = rawStartTime.Replace(".", ":") + " AM";
                            }
                        }
                        else if (rawStartTime.Contains(".") && (rawStartTime.Contains("pm") || rawStartTime.Contains("am")))
                        {
                            if (rawStartTime.Split('.')[0].Length != 2)
                            {
                                rawStartTime = "0" + rawStartTime;
                            }

                            if (rawStartTime.Contains("pm"))
                            {
                                rawStartTime = rawStartTime.Replace(".", ":").Replace("pm", "") + " PM";
                            }
                            else
                            {
                                rawStartTime = rawStartTime.Replace(".", ":").Replace("am", "") + " AM";
                            }
                        } else if (!rawStartTime.Contains(".") && !(rawStartTime.Contains("pm") || rawStartTime.Contains("am")))
                        {
                            if (rawStartTime.Length != 2)
                            {
                                rawStartTime = "0" + rawStartTime;
                            }
                            if (rawEndTime.Contains("pm"))
                            {
                                rawStartTime = rawStartTime + ":00" + " PM";
                            }
                            else
                            {
                                rawStartTime = rawStartTime + ":00" + " AM";
                            }
                        }
                        else
                        {
                            if (rawStartTime.Length != 4)
                            {
                                rawStartTime = "0" + rawStartTime;
                            }
                            if (rawStartTime.Contains("pm"))
                            {
                                rawStartTime = rawStartTime.Replace("pm", "") + ":00" + " PM";
                            }
                            else
                            {
                                rawStartTime = rawStartTime.Replace("am", "") + ":00" + " AM";
                            }
                        }

                        if (rawEndTime.Contains("."))
                        {
                            if (rawEndTime.Split('.')[0].Length != 2)
                            {
                                rawEndTime = "0" + rawEndTime;
                            }

                            if (rawEndTime.Contains("pm"))
                            {
                                rawEndTime = rawEndTime.Replace(".", ":").Replace("pm", "") + " PM";
                            }
                            else
                            {
                                rawEndTime = rawEndTime.Replace(".", ":").Replace("am", "") + " AM";
                            }
                        }
                        else
                        {
                            if (rawEndTime.Length != 4)
                            {
                                rawEndTime = "0" + rawEndTime;
                            }
                            
                            if (rawEndTime.Contains("pm"))
                            {
                                rawEndTime = rawEndTime.Replace("pm", "") + ":00" + " PM";
                            }
                            else
                            {
                                rawEndTime = rawEndTime.Replace("am", "") + ":00" + " AM";
                            }
                        }
                        if (rawDateTime.Split(',').Length == 3)
                        {
                            newEvent.type = "Online";
                        }
                        else
                        {
                            newEvent.type = "Onsite";
                        }
                        
                        DateTime startTime = DateTime.ParseExact(date + " " + rawStartTime, "dd-MMMM hh:mm tt", CultureInfo.InvariantCulture);
                        DateTime endTime = DateTime.ParseExact(date + " " + rawEndTime, "dd-MMMM hh:mm tt", CultureInfo.InvariantCulture);
                        if (startTime.Month < DateTime.Now.Month)
                        {
                            newEvent.startDate = startTime.AddYears(1);
                            newEvent.endDate = endTime.AddYears(1);
                        }
                        else
                        {
                            newEvent.startDate = startTime;
                            newEvent.endDate = endTime;
                        }

                        if (newEvent.isInDbTable())
                        {
                            continue;
                        }
                        Console.WriteLine("event added");
                        newEvent.tagId = 1;
                        newEvent.numberOfAttendees = 50;
                        newEvent.location = "";
                        newEvent.image = client.GetByteArrayAsync(eventHtml.ChildNodes[1].ChildNodes[1].ChildNodes[1].GetAttributeValue("src", "")).Result;
                        newEvent.createDbRecord();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating events in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}