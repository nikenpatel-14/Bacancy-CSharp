
--employeedata table created with sample data
create table EmployeeData(
 	EmployeeID INT,
 	FirstName VARCHAR(50),
 	LastName VARCHAR(50),
 	Email VARCHAR(100),
 	DepartmentID INT,
 	Salary DECIMAL(10,2),
 	DateOfJoining DATE
 )
 insert into
 EmployeeData(EmployeeID,FirstName,LastName,Email,DepartmentID,Salary,DateOfJoining)
 values
 (1,'Niken','Patel','niken@example.com',2,50000,'2026-01-05'),
 (8,'Het','PaTEL','HET@example.com',2,35000,'2026-01-05'),
 (2,'Aayush','Panchasara','Aayush@example.com',1,70000,'2026-01-10'),
 (3,'Vishw','Patel','Vishw@example.com',3,20000,'2026-01-15'),
 (4,'Smit','Pipalva','Smit@example.com',3,150000,'2026-01-20'),
 (5,'Om','Kotawala','Om@example.com',4,30000,'2026-01-25'),
 (6,'Mann','badreshiya','Mann@example.com',1,60000,'2026-01-30'),
 (9,'Rohan','Mehta','rohan.mehta@gmail.com',5,55000,'2022-12-01'),
(10,'Anjali','Kumar','anjali.kumar@gmail.com',1,68000,'2020-08-14'),
(11,'Deepak','Yadav','deepak.y@gmail.com',6,50000,'2023-04-11'),
(12,'Pooja','Joshi','pooja.j@gmail.com',2,47000,'2021-01-19'),
(13,'Kunal','Desai','kunal.desai@gmail.com',4,62000,'2019-10-09'),
(14,'Sneha','Shah','sneha.shah@gmail.com',3,42000,'2022-03-27'),
(15,'Vikas','Gupta','vikas.gupta@gmail.com',2,78000,'2020-05-06'),
(16,'Raj','rana','raj@gmail.com',3,78000,'2019-05-06');

--department table created with sample data
create table Department
(
  Id int ,
  DepartmentName varchar(50)
  )

insert into Department(Id,DepartmentName)
values
(1,'IT'),
(2,'HR'),
(3,'FINANCE'),
(4,'MARKETING'),
(5,'SALES'),
(6,'OPERATIONS')


select * from EmployeeData;
 

--QUERY1

-- view does not store the result it store the query which execute at run time
create view vw_EmployeeBasicInfo as
select EmployeeID,FirstName,DepartmentID
from EmployeeData;


--QUERY 2

--implementing CTE
with CTE_FinanaceEmp as (
select *
from Employee
where Department = 'finance')
select FirstName,Email,Salary  from CTE_FinanaceEmp



--QUERY 3

--selecting hr employee and assign into local temporary table with #
select * 
into #temp_HREmp
from Employee
where Department = 'HR'

select * from #temp_HREmp


--QUERY 5

--DEFINE PRIMARY KEY
--at first making the feild not null
alter table EmployeeData
alter column EmployeeId int not null
--then altering it to primary key
alter table EmployeeData
add constraint PK_EmployeeData_EmployeeId primary key (EmployeeID)

--DEFINE FOREIGN KEY
--at first making id from department id not null
alter table Department
alter column Id int not null
--then making it primary key
alter table Department
add constraint PK_Department_Id primary key (Id);
--then making dep id from employeedata foreign key whoich referece to id in department
alter table EmployeeData
add constraint FK_Department_DepId
Foreign key (DepartmentID) references Department(Id);

--DEFINE UNIQUE FEILD
alter table EmployeeData
add constraint UQ_EmployeeData_Email unique (Email)


--QUERY 4

--creating skill table containing feild id and skillname where id is primary key
create table skill(
    id int,
    SkillName varchar(50),
    constraint PK_skill primary key (id))
--inserting sample data
insert into skill(id,SkillName)
values
(1,'.NET')
,(2,'ANGULAR')
,(3,'C#')
,(4,'OOP')
,(5,'LINQ')

--Creating table employee skil where feilds are empid and skill id
--empid refrences to employeeid from employeedata
--skillid references to id from skill
create table EmployeeSkill(
    EmpID int ,
    SkillID int,

      CONSTRAINT PK_EmployeeSkill 
        PRIMARY KEY (EmpID, SkillID),

    constraint FK_EmployeeData_EmployeeSkill
    foreign key (EmpID) references EmployeeData(EmployeeeID) ,

    constraint FK_EmployeeData_skill
    foreign key (SkillID) references skill(id)
    );
 -- inserting sample data
INSERT INTO EmployeeSkill (EmpID, SkillID)
VALUES
(1,1), 
(1,2), 
(1,3), 
(2,2), 
(3,1), 
(3,4),
(4,5),
(4,2),
(5,1),
(6,2),
(8,3); 

--fetching employee who has more then one skill
select * from EmployeeData where EmployeeID in 
( select EmpID from EmployeeSkill es group by es.EmpID having COUNT(es.SkillID)>1)