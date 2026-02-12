use DAY1SQLAssignment;
go


--creating departments table 
--id is primary key
--department  name unique and not null

create table Departments(
	departmentId int  primary key,
	DepartmentName varchar(50) unique NOT null
)
--creating employees table
--id is primary key
--name is not null
--salary has check condition salary > 15000
--foreign key departmentid refrences to department table id

create table Employees (
    EmployeeId int primary key,              
    Name varchar(100) not null,              
    Salary int check (Salary > 15000),              
    HireDate date,                           
    DepartmentId int,                     
    constraint  FK_Employees_Department
    foreign key (DepartmentId)
    references Departments(departmentId)      
);

--adding new feild email unique
alter table Employees
add Email varchar (50) unique

--adding new feild isactive set default value 1
alter table Employees
add isActive bit  default 1

--modifing salary to decimal
--first drop current check constraint
alter table Employees
drop constraint CK__Employees__Salar__2DE6D218
--then altering column to decimal type
alter table Employees
alter column Salary Decimal(10,1)
--then reapplying check condition
alter table Employees
add check (Salary > 15000)

--appling constraint to check hiredate can not be future date
alter table Employees
add check (HireDate <= getdate())

INSERT INTO Departments
(departmentId, DepartmentName)
VALUES
(101, 'Human Resources'),
(102, 'IT'),
(103, 'Finance'),
(104, 'Marketing'),
(105, 'Operations');


INSERT INTO Employees
(EmployeeId, Name, Salary, HireDate, DepartmentId, Email, IsActive)
VALUES
(1, 'Aayush Patel',   28000.50, '2022-05-10', 101, 'amit@gmail.com',   1),
(2, 'Om Shah',   35000.00, '2021-03-15', 102, 'rahul@gmail.com',  1),
(3, 'Smit Mehta',   42000.75, '2020-07-20', 103, 'neha@gmail.com',   1),
(4, 'Pooja Desai',  30000.00, '2023-01-05', 101, 'pooja@gmail.com',  1),
(5, 'Mann Bhadreshiya',  50000.25, '2019-11-12', 104, 'karan@gmail.com',  1),
(6, 'Riya Verma',   26000.00, '2022-09-18', 102, 'riya@gmail.com',   1),
(7, 'Niken Patel', 38000.90, '2021-06-25', 103, 'suresh@gmail.com', 1),
(8, 'Raj Rana',  45000.00, '2020-02-14', 104, 'anjali@gmail.com', 1);

-- increase employee salary of department id 101 to 5% 
update Employees
set Salary =Salary *1.05
where DepartmentId = 101

--make employe hire date before specific date inactive
update Employees
set isActive = 0
where HireDate < '2022-01-01'

--delete inactive employees
delete Employees
where isActive = 0

--changing department of employees having id 1 and 4
update Employees
set DepartmentId = 103
where EmployeeId in (1,4)


--JOIN OPERATIONS
--selecting employees and department table common data
--it means it results the employee who associated with any department
select *
from Employees  e
join Departments d
on e.DepartmentId = d.departmentId

--performing left join operations
--it fetches the department for which there's no employee
select *
from Departments d
left join Employees e
on d.departmentId = e.DepartmentId


--counting salary department wise for all departments
--it gives null for department where no employee associated
select d.DepartmentName,max(Salary) as TotalSalary
from Departments d
left join Employees e
on d.departmentId = e.DepartmentId
group by DepartmentName
