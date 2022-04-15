CREATE DATABASE CourseManagemntSystem_DB
use CourseManagemntSystem_DB
CREATE TABLE Course
(
course_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
course_CODE VARCHAR(100),
course_TITLE VARCHAR(100),
course_TYPE VARCHAR(50),
course_PREREQUISITE VARCHAR(100),
course_PICTURE VARBINARY(MAX) ,
course_CREDITHOURS INT,
course_TIMEDURATION DATE
);

INSERT INTO Course VALUES ('CS-314', 'HTML','CS', 'PF', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/HTML.png', SINGLE_BLOB) AS T), 2, '2008-11-11');
INSERT INTO Course VALUES ('CS-789', 'JS','CS', 'OOP', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/JS.jpg', SINGLE_BLOB) AS T), 2, '2008-11-11');
INSERT INTO Course VALUES ('CS-314', 'OOP','CS', 'PF', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/OOP.jpg', SINGLE_BLOB) AS T), 2, '2008-11-11');
INSERT INTO Course VALUES ('CS-789', 'PF','CS', 'OOP', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/PF.jpg', SINGLE_BLOB) AS T), 2, '2008-11-11');
INSERT INTO Course VALUES ('CS-314', 'AI','CS', 'PF', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/AI.jpg', SINGLE_BLOB) AS T), 2, '2008-11-11');
Drop table Course;
Select*From Course;

CREATE TABLE Student
(
student_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
student_ROLLNO VARCHAR(100),
student_NAME VARCHAR(100),
student_EMAIL VARCHAR(100),
student_ADDRESS VARCHAR(100),
student_GENDER VARCHAR(50),
student_PHONENUMBER VARCHAR(100),
student_PICTURE VARBINARY(MAX),
student_DOB DATE ,
);

INSERT INTO Student VALUES ('19011519-006', 'Faiqa', 'faiqa@email', 'Mandi', 'Female', '1111111111', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/student1.png', SINGLE_BLOB) AS T), '2008-11-11');
INSERT INTO Student VALUES ('19011519-158', 'Zainab', 'zainab@email', 'JPJ', 'Female', '1110001111', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/student2.jpg', SINGLE_BLOB) AS T), '2008-11-11');
INSERT INTO Student VALUES ('19011519-078', 'Shifa', 'shifa@email', 'Gujrat', 'Female', '1110001111', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/student3.png', SINGLE_BLOB) AS T), '2008-11-11');
INSERT INTO Student VALUES ('19011519-014', 'Marwa', 'marwa@email', 'Gujranwala', 'Female', '1110001111', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/student4.png', SINGLE_BLOB) AS T), '2008-11-11');
INSERT INTO Student VALUES ('19011519-039', 'Hafsa', 'hafsa@email', 'lahore', 'Female', '1110001111', (SELECT * FROM OPENROWSET(BULK N'C:/Users/faiqa/Desktop/CourseManagementSystem/Images/student5.jpg', SINGLE_BLOB) AS T), '2008-11-11');
Select*From Student;
Drop table Student;
CREATE TABLE Registration
(
registration_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
registration_CODE VARCHAR(100),
registration_DATE DATE,
course_ID INT,
CONSTRAINT fk_1 FOREIGN KEY (course_ID) REFERENCES Course (COURSE_ID),
student_ID INT,
CONSTRAINT fk_2 FOREIGN KEY (student_ID) REFERENCES Student (student_ID),
);

INSERT INTO Registration VALUES ('ST-1235', '2008-11-11', 5, 1005);
INSERT INTO Registration VALUES ('ST-5678', '2007-11-11', 6, 1006);
INSERT INTO Registration VALUES ('ST-1235', '2008-11-11', 7, 1007);
INSERT INTO Registration VALUES ('ST-5678', '2007-11-11', 8, 1008);
INSERT INTO Registration VALUES ('ST-1235', '2008-11-11', 9, 1009);

Select*From Registration;

Drop table Registration;