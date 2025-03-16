CREATE DATABASE FacultyManagementDB
USE FacultyManagementDB

CREATE TABLE Teachers
(
ID INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Salary DECIMAL NOT NULL,
HireDate DATETIME NOT NULL
)

CREATE TABLE Subjects
(
ID INT PRIMARY KEY IDENTITY,
SubjectName VARCHAR(50) NOT NULL,
NumberSemesters INT NOT NULL
)

CREATE TABLE TeachSubject
(
ID INT PRIMARY KEY IDENTITY, 
TeacherID INT,
SubjectID INT,
CONSTRAINT FK_TeachSubject_Teachers
FOREIGN KEY (TeacherID)
REFERENCES Teachers(ID),
CONSTRAINT FK_TeachSubject_Subjects
FOREIGN KEY (SubjectID)
REFERENCES Subjects(ID)
)

INSERT INTO Subjects VALUES
('Algebra', 3),
('Calculus', 6),
('History of the computer', 1),
('Mathematical programming', 2),
('Database architecture', 1),
('Statistics', 3),
('Introduction to C#',1),
('Web programming', 4),
('Trigonometry', 2),
('Mathematical probabilities', 3)

INSERT INTO Teachers VALUES
('Nikolai', 'Lantsov', 2000, '2010/02/02'),
('Rin', 'Nesha', 2500, '1995/03/18'),
('Leigh', 'Bardugo', 1400, '2021/06/27'),
('Tahereh', 'Mafi', 1900, '2005/06/29'),
('Carswell', 'Thorne', 2800, '2000/05/01'),
('Kenji', 'Kishimoto', 1400, '2022/08/21'),
('Lemony', 'Snicket', 2200, '2003/12/04'),
('Aaron', 'Warner', 1500,'2021/10/28'),
('Alina', 'Starkova', 2000, '2018/01/19'),
('Kaz', 'Brekker', 1800, '2017/08/18')

INSERT INTO TeachSubject VALUES
(1,4), (1,8), (2,1), (2,9), (2,6), (3,3),(3,7),
(4,2), (4,5), (5,10), (6,8), (6,4), (6,6), (6,3),
(7,1), (7,10), (7,2),(8,6), (9,7), (9,2), (10,3), (10,5)