-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 14, 2024 at 01:04 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tc_crm`
--

-- --------------------------------------------------------

--
-- Table structure for table `bulletinboard`
--

CREATE TABLE `bulletinboard` (
  `PostID` int(5) NOT NULL,
  `DigitalConnectionID` int(5) NOT NULL,
  `Skill` varchar(50) DEFAULT NULL,
  `DatePosted` datetime DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `TagID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bulletinboard`
--

INSERT INTO `bulletinboard` (`PostID`, `DigitalConnectionID`, `Skill`, `DatePosted`, `Description`, `TagID`) VALUES
(13, 113, 'Crafts', '2024-11-20 00:00:00', 'A skill for creating decorative or functional items by hand, often using materials like wood, paper, or fabric.', 2),
(14, 111, 'Crafts', '2024-11-06 00:00:00', 'A skill for creating handmade clothing, accessories, and home décor items.', 1),
(15, 112, 'Speaking', '2024-12-05 00:00:00', 'The ability to craft and share engaging narratives that connect, inspire, and entertain. It helps foster empathy, build community, and communicate experiences or ideas in a meaningful way.', 2);

-- --------------------------------------------------------

--
-- Table structure for table `digitalconnectionprofile`
--

CREATE TABLE `digitalconnectionprofile` (
  `DigitalConnectionID` int(5) NOT NULL,
  `userID` int(5) NOT NULL,
  `Skill` varchar(50) DEFAULT NULL,
  `TagID` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `digitalconnectionprofile`
--

INSERT INTO `digitalconnectionprofile` (`DigitalConnectionID`, `userID`, `Skill`, `TagID`) VALUES
(111, 1, 'Sewing', 3),
(112, 2, 'Storytelling', 2),
(113, 3, 'Crafting', 1),
(114, 35, 'Storytelling', 2),
(115, 36, 'Writing', 2);

-- --------------------------------------------------------

--
-- Table structure for table `documents`
--

CREATE TABLE `documents` (
  `DocumentID` int(5) NOT NULL,
  `userID` int(5) NOT NULL,
  `DocumentName` varchar(50) NOT NULL,
  `DocumentType` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `documents`
--

INSERT INTO `documents` (`DocumentID`, `userID`, `DocumentName`, `DocumentType`) VALUES
(1, 1, 'TC Handbook', 'PDF'),
(2, 1, 'TC terms and conditions', 'Word Doc'),
(3, 2, 'TC Events guide', 'PDF'),
(4, 2, 'TC terms and conditions', 'Word Doc'),
(5, 35, 'TC Welcome ', 'PDF'),
(6, 36, 'TC Welcome', 'PDF'),
(7, 3, 'TC terms and conditions', 'Word Doc'),
(8, 3, 'TC Member Handbook', 'PDF');

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `EventID` int(9) NOT NULL,
  `EventName` varchar(50) DEFAULT NULL,
  `EventType` varchar(50) DEFAULT NULL,
  `EventLocation` varchar(255) DEFAULT NULL,
  `TagID` int(2) DEFAULT NULL,
  `NumberOfAttendees` int(9) DEFAULT NULL,
  `EventDetails` varchar(255) NOT NULL,
  `EventStartTime` datetime DEFAULT NULL,
  `EventEndTime` datetime DEFAULT NULL,
  `EventImage` longblob DEFAULT NULL,
  `EventDescription` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`EventID`, `EventName`, `EventType`, `EventLocation`, `TagID`, `NumberOfAttendees`, `EventDetails`, `EventStartTime`, `EventEndTime`, `EventImage`, `EventDescription`) VALUES
(1, 'Painting (example)', 'Onsite', '5 Fitzroy street', 5, 10, 'Painting with Janet.', '2024-12-02 19:00:00', '2024-12-02 21:00:00', NULL, 'Come to learn how to paint with Janet'),
(2, 'Storytelling (example)', 'Onsite', '5 Fitzroy street', 2, NULL, 'Come to speak and tell us spooky stories for Halloween!', '2024-10-21 19:30:00', '2024-10-21 21:30:00', NULL, 'Come to speak and tell us spooky stories for Halloween!');

-- --------------------------------------------------------

--
-- Table structure for table `eventattendance`
--

CREATE TABLE `eventattendance` (
  `EventID` int(9) NOT NULL,
  `CheckInTime` datetime DEFAULT NULL,
  `CheckOutTime` datetime DEFAULT NULL,
  `UserID` int(11) NOT NULL,
  `AttendeeStatus` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `eventattendance`
--

INSERT INTO `eventattendance` (`EventID`, `CheckInTime`, `CheckOutTime`, `UserID`, `AttendeeStatus`) VALUES
(1, '2024-12-02 19:10:00', '2024-12-02 21:00:00', 1, 'Late'),
(1, '2024-12-02 19:00:00', '2024-12-02 19:00:00', 2, 'Attended'),
(1, '2024-12-02 19:00:00', '2024-12-02 19:00:00', 35, 'Attended'),
(2, '2024-10-21 19:30:00', '2024-10-21 21:30:00', 1, 'Attended'),
(2, '2024-10-21 19:30:00', '2024-10-21 21:30:00', 2, 'Attended'),
(2, '2024-10-21 19:30:00', '2024-10-21 21:30:00', 3, 'Attended'),
(2, '2024-10-21 19:45:00', '2024-10-21 21:30:00', 35, 'Late'),
(2, '2024-10-21 19:40:00', '2024-10-21 21:30:00', 36, 'Late');

-- --------------------------------------------------------

--
-- Table structure for table `membership`
--

CREATE TABLE `membership` (
  `UserID` int(5) NOT NULL,
  `MembershipTypeID` int(1) NOT NULL,
  `MembershipExpiryDate` datetime DEFAULT NULL,
  `MembershipJoinDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `membership`
--

INSERT INTO `membership` (`UserID`, `MembershipTypeID`, `MembershipExpiryDate`, `MembershipJoinDate`) VALUES
(1, 2, '2024-12-01 18:53:58', '2025-12-01 18:53:58'),
(2, 1, '2024-12-01 18:53:58', '2025-12-01 18:53:58');

--
-- Triggers `membership`
--
DELIMITER $$
CREATE TRIGGER `update_membership_type_share_on_delete` AFTER DELETE ON `membership` FOR EACH ROW UPDATE membershiptype SET membershiptype.ShareInMemberships = 
TRUNCATE((SELECT (SELECT COUNT(*) FROM membership WHERE MembershipTypeID = membershiptype.MembershipTypeID)/ COUNT(*) * 100
FROM membership), 2)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `update_membership_type_share_on_insert` AFTER INSERT ON `membership` FOR EACH ROW UPDATE membershiptype SET membershiptype.ShareInMemberships = 
TRUNCATE((SELECT (SELECT COUNT(*) FROM membership WHERE MembershipTypeID = membershiptype.MembershipTypeID)/ COUNT(*) * 100
FROM membership), 2)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `membershiprequest`
--

CREATE TABLE `membershiprequest` (
  `UserID` int(5) NOT NULL,
  `MembershipTypeID` int(1) NOT NULL,
  `PaymentStatus` varchar(30) DEFAULT NULL,
  `ApprovalStatus` varchar(30) DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `membershiprequest`
--

INSERT INTO `membershiprequest` (`UserID`, `MembershipTypeID`, `PaymentStatus`, `ApprovalStatus`, `CreationDate`) VALUES
(35, 1, 'Pending', 'Pending', '2024-12-13 19:05:42'),
(36, 1, 'Pending', 'Pending', '2024-12-13 19:07:03');

--
-- Triggers `membershiprequest`
--
DELIMITER $$
CREATE TRIGGER `UpdateIsVerified` AFTER UPDATE ON `membershiprequest` FOR EACH ROW BEGIN
    IF NEW.ApprovalStatus != OLD.ApprovalStatus THEN
        IF NEW.ApprovalStatus = 'Approved' THEN
            UPDATE users
            SET IsVerified = 1
            WHERE userID = NEW.userID;
        END IF;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `membershiptype`
--

CREATE TABLE `membershiptype` (
  `MembershipTypeID` int(1) NOT NULL,
  `Name` varchar(30) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `Price` decimal(5,2) DEFAULT NULL,
  `ShareInMemberships` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `membershiptype`
--

INSERT INTO `membershiptype` (`MembershipTypeID`, `Name`, `Description`, `Price`, `ShareInMemberships`) VALUES
(1, 'Community Membership', 'Membership provides free or discounted tickets to all events, collaborative and creative skills development workshops, participation in the annual  Citizens’ Studio, and a voice in decision about new social enterprises developed in Together Culture’s incubator. Plus, you’ll have a City Centre base that you can call home, have a (free) coffee with your friends, host your next bookclub, do some work, be inspired, or just be. ', 18.50, 50.00),
(2, 'Workspace  Membership', 'Enjoy all the perks of Community Membership, plus 24/7 access to Together Culture Fitzroy including a dedicated workspace, storage space, and cohort of Workspace Members with which to build collaborative relationships. \r\n\r\n', 70.00, 50.00),
(3, 'Business Unusual Membership', 'Looking for ways to find more fulfillment in your career? \r\nWant to develop skills that help you unblock barriers holding you back from bringing your authentic self to work? \r\nTime to make new friendships that build connections across industries and sectors?  \r\nWant to develop new ways to collaborate and work more creatively?\r\nTogether Culture Cambridge Business Unusual Membership might be for you and your team!', 375.00, 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `payment_details`
--

CREATE TABLE `payment_details` (
  `PaymentID` int(5) NOT NULL,
  `UserID` int(5) NOT NULL,
  `CardNumber` bigint(20) NOT NULL,
  `Expiry` varchar(5) NOT NULL,
  `CVV` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment_details`
--

INSERT INTO `payment_details` (`PaymentID`, `UserID`, `CardNumber`, `Expiry`, `CVV`) VALUES
(8, 35, 1234123412341234, '12/27', 456),
(9, 36, 1234123412341234, '12/33', 124);

-- --------------------------------------------------------

--
-- Table structure for table `potential_member`
--

CREATE TABLE `potential_member` (
  `PotentialMemberID` int(5) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tag`
--

CREATE TABLE `tag` (
  `TagID` int(3) NOT NULL,
  `TagName` varchar(20) NOT NULL,
  `TagDescription` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tag`
--

INSERT INTO `tag` (`TagID`, `TagName`, `TagDescription`) VALUES
(1, 'Learning', 'It\'s about how to train people up to facilitate events, share workshops and courses with each other.'),
(2, 'Sharing', 'It\'s about upskilling people so that they\'re able to do the repairs and think of new ways of sharing skills and time'),
(3, 'Working', 'It\'s about making sure there are affordable dedicated workspaces for entrepreneurs, artists, for anyone who wants to work remotely from Together Culture'),
(4, 'Happening', 'It\'s about local heritage and co-creative process, about developing experience that shows different side of Cambridge, separate from University of Cambridge'),
(5, 'Caring', ' ');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userID` int(5) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `PhoneNumber` bigint(13) NOT NULL,
  `password` char(64) DEFAULT NULL,
  `Gender` varchar(50) NOT NULL,
  `Intention` varchar(50) NOT NULL,
  `MembershipID` int(5) NOT NULL,
  `MembershipType` varchar(50) NOT NULL,
  `IsAdmin` tinyint(1) DEFAULT 0,
  `IsVerified` tinyint(1) DEFAULT NULL,
  `MarketEmails` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `FirstName`, `LastName`, `Email`, `PhoneNumber`, `password`, `Gender`, `Intention`, `MembershipID`, `MembershipType`, `IsAdmin`, `IsVerified`, `MarketEmails`) VALUES
(1, 'John', 'Doe', '1', 77845236785, '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 'Male', 'Learning', 1, 'Key Access Membership', 1, 1, 1),
(2, 'Jane', 'Smith', '2', 77889966452, 'd4735e3a265e16eee03f59718b9b5d03019c07d8b6c51f90da3a666eec13ab35', 'Female', 'Creating', 2, 'Community Membership', 0, 1, 0),
(3, 'Mike', 'Johnson', '3', 778895546213, '4e07408562bedb8b60ce05c1decfe3ad16b72230967de01f640b7e4729b49fce', 'Male', 'Learning', 3, 'Community Membership', 0, 0, 1),
(35, 'Julia', 'Adamson', 'julia@example.com', 0, '4b6f869d9db4d43fc8beb7006132d7291d2215f6cadc7427a46a86ef5c709209', 'Female', 'Sharing', 0, 'Community Membership', 0, NULL, 1),
(36, 'Dino', 'Adamson', 'dino@example.com', 0, 'c7b292df11247938be013dfed0dd837f0f6e85f7409f1697a7518fba90d0a153', 'Male', 'Working', 0, 'Community Membership', 0, NULL, 1);

--
-- Triggers `users`
--
DELIMITER $$
CREATE TRIGGER `hash_passwords_before_insert` BEFORE INSERT ON `users` FOR EACH ROW SET NEW.password = SHA2(NEW.password, 256)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `hash_passwords_before_update` BEFORE UPDATE ON `users` FOR EACH ROW BEGIN
    -- Only update the password hash if the password column changes
    IF NEW.password != OLD.password THEN
        SET NEW.password = SHA2(NEW.password, 256);
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `usertags`
--

CREATE TABLE `usertags` (
  `userID` int(5) NOT NULL,
  `TagID` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usertags`
--

INSERT INTO `usertags` (`userID`, `TagID`) VALUES
(1, 5),
(2, 5),
(3, 1),
(35, 2),
(36, 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bulletinboard`
--
ALTER TABLE `bulletinboard`
  ADD PRIMARY KEY (`PostID`),
  ADD KEY `DigitalConnectionID` (`DigitalConnectionID`),
  ADD KEY `fk_tag` (`TagID`);

--
-- Indexes for table `digitalconnectionprofile`
--
ALTER TABLE `digitalconnectionprofile`
  ADD PRIMARY KEY (`DigitalConnectionID`),
  ADD KEY `userID` (`userID`),
  ADD KEY `TagID` (`TagID`);

--
-- Indexes for table `documents`
--
ALTER TABLE `documents`
  ADD PRIMARY KEY (`DocumentID`),
  ADD KEY `fk_userID_docs` (`userID`);

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`EventID`),
  ADD KEY `FK_Event_Tag` (`TagID`);

--
-- Indexes for table `eventattendance`
--
ALTER TABLE `eventattendance`
  ADD PRIMARY KEY (`EventID`,`UserID`),
  ADD KEY `fk_UserID` (`UserID`),
  ADD KEY `EventID` (`EventID`,`UserID`);

--
-- Indexes for table `membership`
--
ALTER TABLE `membership`
  ADD PRIMARY KEY (`UserID`,`MembershipTypeID`),
  ADD KEY `MembershipTypeID` (`MembershipTypeID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `membershiprequest`
--
ALTER TABLE `membershiprequest`
  ADD PRIMARY KEY (`UserID`,`MembershipTypeID`),
  ADD KEY `MembershipID` (`MembershipTypeID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `membershiptype`
--
ALTER TABLE `membershiptype`
  ADD PRIMARY KEY (`MembershipTypeID`);

--
-- Indexes for table `payment_details`
--
ALTER TABLE `payment_details`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `fk_userID_pay` (`UserID`);

--
-- Indexes for table `potential_member`
--
ALTER TABLE `potential_member`
  ADD PRIMARY KEY (`PotentialMemberID`);

--
-- Indexes for table `tag`
--
ALTER TABLE `tag`
  ADD PRIMARY KEY (`TagID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `usertags`
--
ALTER TABLE `usertags`
  ADD PRIMARY KEY (`userID`,`TagID`),
  ADD KEY `userID` (`userID`),
  ADD KEY `TagID` (`TagID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bulletinboard`
--
ALTER TABLE `bulletinboard`
  MODIFY `PostID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `digitalconnectionprofile`
--
ALTER TABLE `digitalconnectionprofile`
  MODIFY `DigitalConnectionID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=116;

--
-- AUTO_INCREMENT for table `documents`
--
ALTER TABLE `documents`
  MODIFY `DocumentID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `EventID` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2510;

--
-- AUTO_INCREMENT for table `membershiptype`
--
ALTER TABLE `membershiptype`
  MODIFY `MembershipTypeID` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `payment_details`
--
ALTER TABLE `payment_details`
  MODIFY `PaymentID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `potential_member`
--
ALTER TABLE `potential_member`
  MODIFY `PotentialMemberID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tag`
--
ALTER TABLE `tag`
  MODIFY `TagID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bulletinboard`
--
ALTER TABLE `bulletinboard`
  ADD CONSTRAINT `bulletinboard_ibfk_1` FOREIGN KEY (`DigitalConnectionID`) REFERENCES `digitalconnectionprofile` (`DigitalConnectionID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tag` FOREIGN KEY (`TagID`) REFERENCES `tag` (`TagID`);

--
-- Constraints for table `digitalconnectionprofile`
--
ALTER TABLE `digitalconnectionprofile`
  ADD CONSTRAINT `digitalconnectionprofile_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `users` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `digitalconnectionprofile_ibfk_2` FOREIGN KEY (`TagID`) REFERENCES `tag` (`TagID`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `documents`
--
ALTER TABLE `documents`
  ADD CONSTRAINT `fk_userID_docs` FOREIGN KEY (`userID`) REFERENCES `users` (`userID`) ON DELETE CASCADE;

--
-- Constraints for table `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `FK_Event_Tag` FOREIGN KEY (`TagID`) REFERENCES `tag` (`TagID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `eventattendance`
--
ALTER TABLE `eventattendance`
  ADD CONSTRAINT `fk_EventID` FOREIGN KEY (`EventID`) REFERENCES `event` (`EventID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_UserID` FOREIGN KEY (`UserID`) REFERENCES `users` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `membership`
--
ALTER TABLE `membership`
  ADD CONSTRAINT `membership_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `membership_ibfk_2` FOREIGN KEY (`MembershipTypeID`) REFERENCES `membershiptype` (`MembershipTypeID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `membershiprequest`
--
ALTER TABLE `membershiprequest`
  ADD CONSTRAINT `membershiprequest_ibfk_2` FOREIGN KEY (`MembershipTypeID`) REFERENCES `membershiptype` (`MembershipTypeID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `membershiprequest_ibfk_3` FOREIGN KEY (`UserID`) REFERENCES `users` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `payment_details`
--
ALTER TABLE `payment_details`
  ADD CONSTRAINT `fk_userID_pay` FOREIGN KEY (`UserID`) REFERENCES `users` (`userID`) ON DELETE CASCADE;

--
-- Constraints for table `usertags`
--
ALTER TABLE `usertags`
  ADD CONSTRAINT `usertags_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `users` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `usertags_ibfk_2` FOREIGN KEY (`TagID`) REFERENCES `tag` (`TagID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
