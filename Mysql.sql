CREATE TABLE `equipment` (
  `EID` int NOT NULL AUTO_INCREMENT,
  `EquipName` varchar(250) NOT NULL,
  `EDescription` varchar(450) NOT NULL,
  `MUsed` varchar(250) NOT NULL,
  `DDate` varchar(150) NOT NULL,
  `Cost` bigint NOT NULL,
  PRIMARY KEY (`EID`)
);

CREATE TABLE `newmember` (
  `MID` int NOT NULL AUTO_INCREMENT,
  `Fname` varchar(20) NOT NULL,
  `Lname` varchar(20) NOT NULL,
  `Gender` varchar(5) NOT NULL,
  `DOB` varchar(20) NOT NULL,
  `Mobile` bigint NOT NULL,
  `Email` varchar(50) NOT NULL,
  `JoinDate` varchar(20) NOT NULL,
  `GymTime` varchar(20) NOT NULL,
  `Maddress` varchar(150) NOT NULL,
  `Membershiptime` varchar(20) NOT NULL,
  PRIMARY KEY (`MID`)
);

CREATE TABLE `newstaff` (
  `SID` int NOT NULL AUTO_INCREMENT,
  `Fname` varchar(150) NOT NULL,
  `Lname` varchar(150) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `DOB` varchar(100) NOT NULL,
  `Mobile` bigint NOT NULL,
  `Email` varchar(150) DEFAULT NULL,
  `JoinDate` varchar(100) NOT NULL,
  `Statee` varchar(100) NOT NULL,
  `City` varchar(100) NOT NULL,
  PRIMARY KEY (`SID`)
);

CREATE TABLE `review` (
  `reviewID` int NOT NULL AUTO_INCREMENT,
  `MID` int DEFAULT NULL,
  `feedback` text,
  PRIMARY KEY (`reviewID`),
  KEY `MID` (`MID`),
  CONSTRAINT `review_ibfk_1` FOREIGN KEY (`MID`) REFERENCES `newmember` (`MID`)
);

DELIMITER $$
CREATE TRIGGER before_newmember_insert
BEFORE INSERT ON NewMember
FOR EACH ROW
BEGIN
    -- Check if MID is invalid (example: negative or NULL)
    IF NEW.MID IS NULL OR NEW.MID <= 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Invalid MID: MID not found.';
    END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `GetMemberByID`(inputMID INT) RETURNS json
    DETERMINISTIC
BEGIN
    RETURN (
        SELECT JSON_OBJECT(
            'MID', MID,
            'Fname', Fname,
            'Lname', Lname,
            'Gender', Gender,
            'DOB', DOB,
            'Mobile', Mobile,
            'Email', Email,
            'JoinDate', JoinDate,
            'GymTime', GymTime,
            'Maddress', Maddress,
            'Membershiptime', Membershiptime
        )
        FROM NewMember
        WHERE MID = inputMID
    );
END$$
DELIMITER ;
