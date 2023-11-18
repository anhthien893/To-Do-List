-- Create the database
USE master
GO
DROP DATABASE databasePrn
GO
CREATE DATABASE databasePrn;
GO
USE databasePrn;
GO

CREATE TABLE [dbo].[user] (
                              [id] NVARCHAR(50) PRIMARY KEY,
                              [username] NVARCHAR(50) NOT NULL,
                              [password] NVARCHAR(255) NOT NULL,
                              [email] NVARCHAR(100) UNIQUE,
							  [status] bit
);

CREATE TABLE Course (
                        Id nvarchar(50) NOT NULL,
                        Name nvarchar(50) NOT NULL,
                        Status bit NOT NULL,
                        CONSTRAINT PK_Course PRIMARY KEY CLUSTERED
                            (
                             Id ASC
                                )
);
-- Create the UserCourses table
CREATE TABLE UserCourses (
                             UserId NVARCHAR(50) NOT NULL,
                             CourseId nvarchar(50) NOT NULL,
                             Status bit NOT NULL,
                             CONSTRAINT PK_UserCourses PRIMARY KEY CLUSTERED
                                 (
                                  UserId ASC,
                                  CourseId ASC
                                     ),
                             CONSTRAINT FK_UserCourses_Course_CourseId FOREIGN KEY (CourseId) REFERENCES Course (Id) ON DELETE CASCADE,
                             CONSTRAINT FK_UserCourses_User_UserId FOREIGN KEY (UserId) REFERENCES [User] (Id) ON DELETE CASCADE
);

-- Create the Task table
CREATE TABLE Task (
                      Id nvarchar(50) NOT NULL,
                      UserId NVARCHAR(50) NOT NULL,
                      Title nvarchar(50) NOT NULL,
                      Description nvarchar(50) NOT NULL,
                      CreateDate Datetime2 NOT NULL,
                      ScheduleDate Datetime2 NOT NULL,
                      CompleteDate Datetime2 NULL,
                      Status bit NOT NULL,
                      CONSTRAINT PK_Task PRIMARY KEY CLUSTERED
                          (
                           Id ASC
                              ),
					CONSTRAINT FK_Task_User_UserId FOREIGN KEY (UserId) REFERENCES [User] (Id) ON DELETE CASCADE
);

-- Create the test table
CREATE TABLE [test] (
                        [test_id] nvarchar(50) NOT NULL,
                        [CreateDate] datetime NOT NULL,
                        [Status] bit NOT NULL,
                        [correct_answer] int NULL,
                        [course_id] nvarchar(50) NOT NULL, -- Foreign key column
                        CONSTRAINT PK_test PRIMARY KEY CLUSTERED
                            (
                             [test_id] ASC
                                ),
                        CONSTRAINT FK_test_course FOREIGN KEY ([course_id]) REFERENCES [course]([Id])
);

-- Create the Question table
CREATE TABLE Question (
                          QuestionId nvarchar(50) NOT NULL,
                          CourseId nvarchar(50) NOT NULL,
                          Title nvarchar(100) NOT NULL,
                          A nvarchar(50) NOT NULL,
                          B nvarchar(50) NOT NULL,
                          C nvarchar(50) NOT NULL,
                          D nvarchar(50) NOT NULL,
                          CorrectAnswer nchar(1) NOT NULL, -- Changed to nchar for single Unicode character
                          Status bit NOT NULL,
                          CONSTRAINT PK_Question PRIMARY KEY CLUSTERED
                              (
                               QuestionId ASC
                                  ),
                          CONSTRAINT FK_Question_Course FOREIGN KEY (CourseId) REFERENCES Course (Id)
);

-- Create the QuestionTest table
CREATE TABLE QuestionTest (
                              QuestionId nvarchar(50) NOT NULL,
                              TestId nvarchar(50) NOT NULL,
                              UserId NVARCHAR(50) NULL,
                              Status bit NOT NULL,
                              CONSTRAINT PK_QuestionTest PRIMARY KEY CLUSTERED
                                  (
                                   QuestionId ASC,
                                   TestId ASC
                                      ),
                              CONSTRAINT FK_QuestionTest_Question_QuestionId FOREIGN KEY (QuestionId) REFERENCES Question (QuestionId) ON DELETE CASCADE,
                              CONSTRAINT FK_QuestionTest_Test_TestId FOREIGN KEY (TestId) REFERENCES [test] (test_id) ON DELETE CASCADE, -- Using [test] table name
                              CONSTRAINT FK_QuestionTest_User_UserId FOREIGN KEY (UserId) REFERENCES [User] (Id) ON DELETE CASCADE
);

-- Insert data into Course table
INSERT INTO Course (Id, Name, Status) VALUES
                                          ('social101', 'Social Studies', 1),
                                          ('math101', 'Mathematics', 1),
                                          ('science101', 'Science', 1);

-- Insert data into test table
-- Insert data into test table
INSERT INTO [test] (test_id, CreateDate, Status, correct_answer, course_id) VALUES
                                                                                ('social_test', '2023-10-24 10:00:00', 1, NULL, 'social101'), -- Replace NULL with the appropriate value for correct_answer
                                                                                ('math_test', '2023-10-25 10:00:00', 1, NULL, 'math101'), -- Replace NULL with the appropriate value for correct_answer
                                                                                ('science_test', '2023-10-26 10:00:00', 1, NULL, 'science101'); -- Replace NULL with the appropriate value for correct_answer


-- Insert data into Question table for Social Test
INSERT INTO Question (QuestionId, CourseId, Title, A, B, C, D, CorrectAnswer, Status) VALUES
                                                                                          ('social_q1', 'social101', 'What is the capital of France?', 'Berlin', 'Rome', 'Madrid', 'Paris', 'D', 1),
                                                                                          ('social_q2', 'social101', 'Which ocean is the largest?', 'Indian Ocean', 'Atlantic Ocean', 'Arctic Ocean', 'Pacific Ocean', 'D', 1),
                                                                                          ('social_q3', 'social101', 'What is the currency of Japan?', 'Yen', 'Dollar', 'Euro', 'Pound', 'A', 1),
                                                                                          ('social_q4', 'social101', 'Who wrote the play "Romeo and Juliet"?', 'Charles Dickens', 'William Shakespeare', 'F. Scott Fitzgerald', 'Jane Austen', 'B', 1),
                                                                                          ('social_q5', 'social101', 'Which planet is known as the "Red Planet"?', 'Mars', 'Jupiter', 'Venus', 'Saturn', 'A', 1),
                                                                                          ('social_q6', 'social101', 'What is the largest mammal in the world?', 'African Elephant', 'Blue Whale', 'Giraffe', 'Hippopotamus', 'B', 1),
                                                                                          ('social_q7', 'social101', 'Who painted the Mona Lisa?', 'Pablo Picasso', 'Vincent van Gogh', 'Claude Monet', 'Leonardo da Vinci', 'D', 1),
                                                                                          ('social_q8', 'social101', 'Which country is known as the Land of the Rising Sun?', 'China', 'South Korea', 'Japan', 'Thailand', 'C', 1),
                                                                                          ('social_q9', 'social101', 'What is the largest desert in the world?', 'Gobi Desert', 'Sahara Desert', 'Atacama Desert', 'Arabian Desert', 'B', 1),
                                                                                          ('social_q10', 'social101', 'Which language is spoken in Brazil?', 'Spanish', 'Portuguese', 'French', 'Italian', 'B', 1);

-- Insert data into Question table for Math Test
INSERT INTO Question (QuestionId, CourseId, Title, A, B, C, D, CorrectAnswer, Status) VALUES
                                                                                          ('math_q1', 'math101', 'What is 2 + 2?', '3', '4', '5', '6', 'B', 1),
                                                                                          ('math_q2', 'math101', 'What is the square root of 16?', '2', '4', '8', '16', 'A', 1),
                                                                                          ('math_q3', 'math101', 'What is the value of π (pi)?', '2', '3', '3.14159', '4', 'C', 1),
                                                                                          ('math_q4', 'math101', 'What is the area of a square with a side length of 5 units?', '15', '20', '25', '30', 'C', 1),
                                                                                          ('math_q5', 'math101', 'Solve for x: 2x + 5 = 15', 'x = 5', 'x = 10', 'x = 15', 'x = 20', 'B', 1),
                                                                                          ('math_q6', 'math101', 'What is the perimeter of a rectangle with length 8 units and width 6 units?', '14', '24', '32', '48', 'C', 1),
                                                                                          ('math_q7', 'math101', 'Which is the smallest prime number?', '1', '2', '3', '4', 'B', 1),
                                                                                          ('math_q8', 'math101', 'What is the value of 7 squared?', '7', '14', '49', '21', 'C', 1),
                                                                                          ('math_q9', 'math101', 'If a train travels at a constant speed of 60 miles per hour, how far will it travel in 3 hours?', '120 miles', '180 miles', '240 miles', '300 miles', 'C', 1),
                                                                                          ('math_q10', 'math101', 'What is the next number in the sequence: 2, 4, 8, 16, ...?', '32', '24', '12', '64', 'D', 1);

-- Insert data into Question table for Science Test
INSERT INTO Question (QuestionId, CourseId, Title, A, B, C, D, CorrectAnswer, Status) VALUES
                                                                                          ('science_q1', 'science101', 'What is the chemical symbol for water?', 'H2O2', 'CO2', 'O2', 'H2O', 'D', 1),
                                                                                          ('science_q2', 'science101', 'What is the boiling point of water in Celsius?', '100°C', '0°C', '50°C', '212°F', 'A', 1),
                                                                                          ('science_q3', 'science101', 'Which gas do plants absorb from the atmosphere?', 'Carbon dioxide', 'Oxygen', 'Nitrogen', 'Methane', 'A', 1),
                                                                                          ('science_q4', 'science101', 'What is the chemical symbol for gold?', 'Ag', 'Ge', 'Au', 'Pt', 'C', 1),
                                                                                          ('science_q5', 'science101', 'What is the primary function of the heart?', 'Pumping blood', 'Digesting food', 'Filtering the blood', 'Storing oxygen', 'A', 1),
                                                                                          ('science_q6', 'science101', 'What is the chemical symbol for oxygen?', 'H2O', 'O2', 'CO2', 'N2', 'B', 1),
                                                                                          ('science_q7', 'science101', 'Which planet is known as the "Red Planet"?', 'Mars', 'Jupiter', 'Venus', 'Saturn', 'A', 1),
                                                                                          ('science_q8', 'science101', 'What is the largest organ of the human body?', 'Heart', 'Brain', 'Liver', 'Skin', 'D', 1),
                                                                                          ('science_q9', 'science101', 'What is the process of plants making their own food using sunlight called?', 'Respiration', 'Photosynthesis', 'Fermentation', 'Digestion', 'B', 1),
                                                                                          ('science_q10', 'science101', 'What is the chemical formula for table salt?', 'NaCl', 'H2O', 'O2', 'C6H12O6', 'A', 1);

-- Insert data into QuestionTest for the Social Test
INSERT INTO QuestionTest (QuestionId, TestId, UserId, Status) VALUES
                                                                  ('social_q1', 'social_test', NULL, 1),
                                                                  ('social_q2', 'social_test', NULL, 1),
                                                                  ('social_q3', 'social_test', NULL, 1),
                                                                  ('social_q4', 'social_test', NULL, 1),
                                                                  ('social_q5', 'social_test', NULL, 1),
                                                                  ('social_q6', 'social_test', NULL, 1),
                                                                  ('social_q7', 'social_test', NULL, 1),
                                                                  ('social_q8', 'social_test', NULL, 1),
                                                                  ('social_q9', 'social_test', NULL, 1),
                                                                  ('social_q10', 'social_test', NULL, 1);
-- You may specify the UserId accordingly

-- Insert data into QuestionTest for the Math Test
INSERT INTO QuestionTest (QuestionId, TestId, UserId, Status) VALUES
                                                                  ('math_q1', 'math_test', NULL, 1),
                                                                  ('math_q2', 'math_test', NULL, 1),
                                                                  ('math_q3', 'math_test', NULL, 1),
                                                                  ('math_q4', 'math_test', NULL, 1),
                                                                  ('math_q5', 'math_test', NULL, 1),
                                                                  ('math_q6', 'math_test', NULL, 1),
                                                                  ('math_q7', 'math_test', NULL, 1),
                                                                  ('math_q8', 'math_test', NULL, 1),
                                                                  ('math_q9', 'math_test', NULL, 1),
                                                                  ('math_q10', 'math_test', NULL, 1);
-- You may specify the UserId accordingly

-- Insert data into QuestionTest for the Science Test
INSERT INTO QuestionTest (QuestionId, TestId, UserId, Status) VALUES
                                                                  ('science_q1', 'science_test', NULL, 1),
                                                                  ('science_q2', 'science_test', NULL, 1),
                                                                  ('science_q3', 'science_test', NULL, 1),
                                                                  ('science_q4', 'science_test', NULL, 1),
                                                                  ('science_q5', 'science_test', NULL, 1),
                                                                  ('science_q6', 'science_test', NULL, 1),
                                                                  ('science_q7', 'science_test', NULL, 1),
                                                                  ('science_q8', 'science_test', NULL, 1),
                                                                  ('science_q9', 'science_test', NULL, 1),
                                                                  ('science_q10', 'science_test', NULL, 1);
-- You may specify the UserId accordingly

-- Insert sample user data
INSERT INTO [user] (id, username, password, email, status) VALUES
                                                   ('U001', 'user1', 'password123', 'user1@example.com', 1),
                                                   ('U002', 'user2', 'secret456', 'user2@example.com', 1),
                                                   ('U003', 'user3', 'mysecurepass', 'user3@example.com', 1);
-- Insert data into Task table
INSERT INTO Task (Id, UserId, Title, Description, CreateDate, ScheduleDate, CompleteDate, Status) VALUES
                                                                                                      ('task1', 'U001', 'Complete Math Homework', 'Finish the math homework exercises', '2023-10-24 14:00:00', '2023-10-24 16:00:00', '2023-10-24 16:30:00', 1),
                                                                                                      ('task2', 'U002', 'Physics Quiz', 'Take the physics quiz', '2023-10-25 10:00:00', '2023-10-25 12:00:00', '2023-10-25 12:30:00', 1);










