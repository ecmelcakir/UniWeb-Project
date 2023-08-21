insert into "Lecturers" ("LecName","Salary","EntryDate","Job") values
('Bora',32500,'2010-09-12','Professor'),
('Oğuzhan',12560,'2019-10-10','Research Assistant'),
('Engin',28640,'2013-11-04','Doc'),
('Alparslan',45000,'2016-10-08','Professor')

insert into "Lecturers" ("LecName","Salary","EntryDate","Job") values
('Fethullah',16500,'2013-09-12','Research Assistant')

select*from Lecturers


insert into "Students"("StuName","Department","Entrydate","LecturerId")values
('Sude','EEE','2021-08-09',5),
('Bedirhan','CSE','2019-09-08',2),
('Mustafa Erdem','SE','2019-09-30',6)

select*from Students

select*from Courses

select*from StudentCourses

insert into "Courses"("CourseName") values
('Digital Design'),
('Circuits'),
('Electronics 2'),
('Object Orianted Programming'),
('Linear Algebra')

