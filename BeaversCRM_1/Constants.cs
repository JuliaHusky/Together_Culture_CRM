using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BeaversCRM_1
{
    class Constants
    {
        // Used in Register class
        public static string INSERT_USER_DB = "INSERT INTO users (FirstName, LastName, Gender, Email, Password, Intention, MarketEmails) " +
                                                 "VALUES (@firstName, @lastName, @gender, @email, @password, @intention, @marketingEmails)";
        
        // Used in Register class
        public static string INSERT_PAYMENT_DB = "INSERT INTO payment_details (UserID, CardNumber, Expiry, CVV) " +
                                                "VALUES (@UserID, @CardNumber, @Expiry, @CVV)";
        
        // Used in Validation class for log in
        public static string CHECK_USER_LOGIN_DB = "SELECT Password FROM Users WHERE Email = @Email";
      
        // Used in Validation class for log in
        public static string SELECT_USER_BY_EMAIL = "SELECT * FROM Users WHERE Email = @Email";

        // Used in log in page, to sign user upto newsletter
        public static string INSERT_NEWSLETTER_USER = "INSERT INTO potential_member (FirstName, LastName, Email) VALUES (@newsFName, @newsLName, @newsEmail)";

        // Used to retrieve user's documents
        public static string SELECT_USER_DOCUMENTS_BY_USERID = "SELECT DocumentId, UserId, DocumentName, DocumentType FROM Documents WHERE UserId = @UserId";


        // Used to update user's password
        public static string UPDATE_PASSWORD = "UPDATE Users SET Password = @newPassword WHERE UserID = @UserID";


        // Used to update user's membership type 
        public static string UPDATE_MEMBERSHIP = "UPDATE Users SET MembershipType = @newMembershipType WHERE UserID = @UserID";

        // View user's booked events in account settings page
        public static string VIEW_USER_EVENTS = @"SELECT ea.UserID, e.EventName, e.EventStartTime
                                                  FROM EventAttendance ea
                                                  JOIN Event e ON ea.EventID = e.EventID
                                                  WHERE ea.UserID = @UserID";

        // Get list of events to display in combo box for event searching
        public static string EVENT_MANAGEMENT_EVENT_LIST = "SELECT EventName, EventStartTime FROM Event";


        // Display event tag on Event management page
        public static string DISPLAY_EVENT_TAG = @"SELECT T.TagName
                                                   FROM Event E
                                                   INNER JOIN Tag T ON E.TagID = T.TagID
                                                   WHERE E.EventName = @EventName ";


        // Display all events on Event management page
        public static string DISPLAY_ALL_EVENTS = @"SELECT 
                                                        e.EventName,
                                                        e.EventType,
                                                        e.EventLocation,
                                                        e.EventStartTime,
                                                        e.EventEndTime,
                                                        COUNT(ea.EventID) AS TotalAttendees
                                                    FROM 
                                                        Event e
                                                    LEFT JOIN
                                                        eventattendance ea ON e.EventID = ea.EventID
                                                    GROUP BY
                                                        E.EventID";

        // Display all attendee information for a specified event in event management
        public static string EVENT_ATTENDANCE = @"SELECT 
                                                    u.FirstName,
                                                    u.LastName,
                                                    u.MembershipType,
                                                    u.Intention,
                                                    ea.AttendeeStatus,
                                                    ea.CheckInTime,
                                                    ea.CheckOutTime
                                                FROM 
                                                    Event e
                                                JOIN 
                                                    EventAttendance ea ON e.EventID = ea.EventID
                                                JOIN 
                                                    Users u ON ea.UserID = u.UserID
                                                WHERE 
                                                    e.EventName = @EventName
                                                AND e.EventStartTime = @EventStartTime;";

        // Calculate the number of attendees for a specific event in event management
        public static string EVENT_ATTENDANCE_SPECIFIC_EVENT = @"SELECT
                                                                    COUNT(ea.EventID) AS TotalAttendees
                                                                 FROM
                                                                    Event e
                                                                 LEFT JOIN
                                                                    eventattendance ea ON e.EventID = ea.EventID
                                                                 WHERE
                                                                    e.EventName = @EventName AND
                                                                    e.EventStartTime = @EventStartTime;";
        // Display events filtered by dates in event management
        public static string EVENTS_FILTERED_BY_DATE = @"SELECT 
                                                            e.EventName,
                                                            e.EventType,
                                                            e.EventLocation,
                                                            e.EventStartTime,
                                                            e.EventEndTime,
                                                            COUNT(ea.EventID) AS TotalAttendees
                                                        FROM 
                                                            Event e
                                                        LEFT JOIN
                                                            eventattendance ea ON e.EventID = ea.EventID
                                                        WHERE 
                                                            e.EventStartTime BETWEEN @StartDate AND @EndDate
                                                        GROUP BY
                                                            e.EventID;";

        // Used to create an event in event management
        public static string INSERT_EVENT_INTO_DB = "INSERT INTO event " +
                                                "(EventName, EventType, EventDetails, EventLocation, EventStartTime, EventEndTime ) " +
                                            "VALUES " +
                                                "(@EventName, @EventType, @EventDetails, @EventLocation, @EventStartTime, @EventEndTime )";

        // Used to insert new events received from together culture website
        public const string INSERT_EVENT = "INSERT INTO Event (EventName, EventStartTime, EventEndTime, EventDescription, EventImage, EventType, NumberOfAttendees, TagID, EventLocation) VALUES (@name, @startDate, @endDate, @description, @image, @type, @attendees, @tagId, @location)";

        // Used to check if event retrieved from website is already in event table in database
        public const string CHECK_IF_EVENT_EXISTS = "SELECT EventID, EventType, EventEndTime, EventDescription FROM EVENT WHERE EventName = @name AND EventStartTime = @startDate;";

        // Used to get past events from database as batches of 10 events each time
        public const string GET_PAST_EVENTS = "SELECT * FROM EVENT WHERE EventEndTime < NOW() LIMIT 10 OFFSET @offset";

        // Used to get upcoming events from database as batches of 10 events each time
        public const string GET_UPCOMING_EVENTS = "SELECT * FROM EVENT WHERE EventStartTime > NOW() LIMIT 10 OFFSET @offset";

        // Used to update event table record if some values from it are missing during updating events from website
        public const string UPDATE_EVENT = "UPDATE event SET @columns WHERE EventID = @eventid";

        // Used to load membership requests related data from database
        public const string GET_MEMBERSHIP_REQUESTS = "SELECT membershiprequest.PaymentStatus, membershiprequest.ApprovalStatus, membershiptype.Name, users.FirstName, users.LastName, users.Email, users.PhoneNumber, users.IsAdmin, tag.TagName, users.userID, membershiptype.MembershipTypeID\nFROM membershiprequest\nINNER JOIN membershiptype ON membershiprequest.MembershipTypeID = membershiptype.MembershipTypeID\nINNER JOIN users ON membershiprequest.UserID = users.userID\nINNER JOIN usertags ON membershiprequest.UserID = usertags.UserID\nINNER JOIN tag ON usertags.TagID = tag.TagID WHERE membershiprequest.ApprovalStatus = 'Pending'";

        // Used to order membership requests by date oldest first
        public const string ORDER_REQUESTS_BY_DATE_OLDEST = "ORDER BY membershiprequest.CreationDate ASC";

        // Used to order membership requests by date latest first
        public const string ORDER_REQUESTS_BY_DATE_LATEST = "ORDER BY membershiprequest.CreationDate DESC";

        // Used to filter membership requests by search from search bar
        public const string FILTER_REQUESTS_BY_SEARCH_TEXT = "AND (membershiprequest.PaymentStatus LIKE '%@text%' OR membershiprequest.ApprovalStatus LIKE '%@text%' OR membershiptype.Name LIKE '%@text%' OR users.FirstName LIKE '%@text%' OR users.LastName LIKE '%@text%' OR users.Email LIKE '%@text%' OR users.PhoneNumber LIKE '%@text%')";

        // Used to approve membership request and change approval status to approved
        public const string APPROVE_REQUEST = "UPDATE membershiprequest SET membershiprequest.ApprovalStatus = 'Approved' WHERE membershiprequest.UserID = @userid";

        // Used to decline membership request and change approval status to declined
        public const string DECLINE_REQUEST = "UPDATE membershiprequest SET membershiprequest.ApprovalStatus = 'Declined' WHERE membershiprequest.UserID = @userid";

        // Used to create membership record if membership request has been accepted
        public const string INSERT_MEMBERSHIP = "INSERT INTO membership (UserID, MembershipTypeID, MembershipExpiryDate, MembershipJoinDate) VALUES (@userid, @typeid, @expirydate, @joindate)";

        // Used to get event attendance info of a user
        public const string GET_EVENT_ATTENDANCE = "SELECT eventattendance.AttendeeStatus, eventattendance.CheckInTime, eventattendance.CheckOutTime, event.EventName FROM eventattendance INNER JOIN users ON users.UserID = eventattendance.UserID INNER JOIN event ON eventattendance.EventID = event.EventID WHERE eventattendance.UserID = @userid ORDER BY eventattendance.CheckInTime DESC;";

        // Used to get popularity of membership type
        public const string GET_MEMBERSHIP_AMOUNT_SUMMARY = "SELECT Name, ShareInMemberships FROM membershiptype";

        // Used to insert membership request
        public const string INSERT_MEMBERSHIP_REQUEST = "INSERT INTO membershiprequest (UserID, MembershipTypeID, PaymentStatus, ApprovalStatus, CreationDate) VALUES ((SELECT userID FROM users WHERE Email = @email), (SELECT MembershipTypeID FROM membershiptype WHERE Name = @typename), @paymentstatus, @approvalstatus, @creationdate)";

        // Used to insert tag for user
        public const string INSERT_USER_TAG = "INSERT INTO usertags (UserID, TagID) VALUES ((SELECT userID FROM users WHERE Email = @email), (SELECT TagID FROM tag WHERE TagName = @tagName))";
    }
}