--Query 1
--function to calculate experience in year
use DAY1SQLAssignment
go
create function TotalExperience(
	@dateofjoining date )
returns decimal(10,1)
as
begin
	return DATEDIFF(Year,@dateofjoining,getdate())
end
go


select EmployeeID,FirstName,dbo.TotalExperience(DateOfJoining) as experience from Employee




--QUERY 2
go
--function to fetch senior employee
create function seniorEmployee3(
	@DepartmentId int )
returns table
as 
return (
    select e.*, case 
					WHEN dbo.TotalExperience(e.DateOfJoining) > 5
				    THEN 'Yes'
					ELSE 'No' 
				end as ISseniorEmp
	from EmployeeData e
	where DepartmentID = @DepartmentId)
go

select * from dbo.seniorEmployee3(4)


--QUERY 3
--creating sp for add employee it validate email
go
create procedure AddEmployee(
	@EmployeeID int,
	@FirstName varchar(50),
	@LastName varchar(50),
	@Email varchar(50),
	@Department varchar(50),
	@Salary varchar(50),
	@DateOfJoining date )
as
begin
  if @Email not in (select email from Employee)
	insert into Employee(
	EmployeeID ,
	FirstName ,
	LastName ,
	Email ,
	Department ,
	Salary ,
	DateOfJoining )
	values
	(@EmployeeID ,
	@FirstName ,
	@LastName ,
	@Email ,
	@Department ,
	@Salary ,
	@DateOfJoining )
  else
   print 'email already exist'
end;
go

exec AddEmployee 20,'hhh','ppp','hetpatelbhai@gmailcom','net',5000,'2026-01-01';

select * from Employee

--QUERY 4
--procedure which calculate total salary department wise for time gap
go
create procedure TotalSalaryBydepartment(
   @startdate date,
   @enddate date )
as
begin 
   select Department,
   sum( Salary * DATEDIFF(
   day,
   --logic to take days just after the date of joining
   case 
	when @startdate > DateOfJoining  then  @startdate else DateOfJoining
   end
   ,@enddate )
   /30.0) as totalSalary
   from Employee
   where DateOfJoining < @enddate
   group by department
   
 end;
go
exec TotalSalaryBydepartment '2025-12-20','2026-01-01'

--QUERY 5

create table OrderItem(
	orderID INT,
	orderDescription varchar(50),
	orderPrice int,
	createdBy varchar(50) 
	)
insert into OrderItem(orderID,orderDescription,orderPrice,createdBy)
values
(1,'smartphone',5000,'Het'),
(2,'Headphone',10000,'raj'),
(3,'laptop',15000,'om')

create table OrderAudit(
	OrderId INT,
    InsertedDate DATETIME,
    InsertedBy VARCHAR(100)
	)


--creaate trigger after insert for orderitem 
go
create trigger trg_OrderItem
on OrderItem
after insert
as
begin
	Insert into OrderAudit
	(
		 OrderId ,
		 InsertedDate ,
		 InsertedBy )
	select orderID,GETDATE(),createdBy
	from inserted
end;
go

insert into OrderItem(orderID,orderDescription,orderPrice,createdBy)
values 
(5,'tablet',2000,'Niken')
select * from OrderAudit


--QUERY 6


create table Products(
	productId int,
	productName varchar(50),
	productPrice int,
	productStatus varchar(50)
)
insert into Products(productId,productName,productPrice,productStatus)
values
(1,'mobile',5000,'active'),
(2,'Tablet',10000,'inactive'),
(3,'Headphone',2000,'inactive'),
(4,'Laptop',50000,'active')

--creating trigger to prevent active product delation
--using instead of delete
go
create trigger trg_ProductDelationPrevent
on Products
instead of delete
AS
begin
	if exists ( select * from deleted where productStatus = 'active')
	begin
	   print 'can not delete product which active with order'
	   return;
	end

	delete from Products where productId IN (
        select ProductID from deleted
    );

end
go
delete from Products where productId = 1
select * from Products

