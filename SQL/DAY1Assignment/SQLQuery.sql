--creating day1sqlassignment named database
create database DAY1SQLAssignment;
go
--using daysqlassignment database
use DAY1SQLAssignment;
go


--creating table
create table Employee(
 	EmployeeID INT,
 	FirstName VARCHAR(50),
 	LastName VARCHAR(50),
 	Email VARCHAR(100),
 	Department VARCHAR(50),
 	Salary DECIMAL(10,2),
 	DateOfJoining DATE
 )

 -- To insert all the sample data
 insert into
 Employee (EmployeeID,FirstName,LastName,Email,Department,Salary,DateOfJoining)
 values
 (1,'Niken','Patel','niken@example.com','FINANCE',50000,'2026-01-05'),
 (8,'Het','PaTEL','HET@example.com','FINANCE',35000,'2026-01-05'),
 (2,'Aayush','Panchasara','Aayush@example.com','IT',70000,'2026-01-10'),
 (3,'Vishw','Patel','Vishw@example.com','HR',20000,'2026-01-15'),
 (4,'Smit','Pipalva','Smit@example.com','HR',150000,'2026-01-20'),
 (5,'Om','Kotawala','Om@example.com','MARKETING',30000,'2026-01-25'),
 (6,'Mann','badreshiya','Om@example.com','IT',60000,'2026-01-30'),
 (9,'Rohan','Mehta','rohan.mehta@gmail.com','Sales',55000,'2022-12-01'),
(10,'Anjali','Kumar','anjali.kumar@gmail.com','IT',68000,'2020-08-14'),
(11,'Deepak','Yadav','deepak.y@gmail.com','Operations',50000,'2023-04-11'),
(12,'Pooja','Joshi','pooja.j@gmail.com','HR',47000,'2021-01-19'),
(13,'Kunal','Desai','kunal.desai@gmail.com','Sales',62000,'2019-10-09'),
(14,'Sneha','Shah','sneha.shah@gmail.com','Marketing',42000,'2022-03-27'),
(15,'Vikas','Gupta','vikas.gupta@gmail.com','Finance',78000,'2020-05-06'),
(16,'Raj','rana','raj@gmail.com','HR',78000,'2019-05-06');

 
 -- To see all the sample data
 select * from Employee;

 
 --QUERRY 1
 select Top 5 * 
 from Employee order By Salary desc;

 
 --QUERRY 2
 select distinct Department
 from Employee
 where Department Like 's%'
 
 --QUERRY 3
 select *
 from Employee
 where Department in ('HR','IT','FINANCE') AND Salary>50000
 
 --QUERRY 4
 --here at first we apply condition salary >75000
 --and then byb using or operator appling condition departmen is sales
 --so it select the employe who either have salary greater than 75000 or from sales department
 select *
 from Employee
 where Salary>75000 or Department = 'sales' 
 
 
 --QUERRY 5
 select EmployeeID,FirstName,Email
 from Employee 
 where Email like '%'+FirstName+'%';

 
 --QUERRY 6
 select *
 from Employee
 order by DateOfJoining
 OFFSET 5 rows
 fetch next  5 rows only


 --QUERRY 7
 select *
 from Employee
 where (Department = 'IT' and Salary > 60000)
        or
       (Department ='HR' and DateOfJoining < '2020-01-01')



