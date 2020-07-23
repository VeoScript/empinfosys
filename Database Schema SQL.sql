create database EIS

use EIS

create table UserAccount(
	id int identity primary key not null,
	position varchar(255) not null,
	name varchar(255) unique not null,
	username varchar(255) unique not null,
	password varchar(255) not null
)

create table RegisteredEmployee(
	id int identity primary key not null,
	idnumber varchar(100) unique not null,
	lastname varchar(100) not null,
	firstname varchar(100) not null,
	middlename varchar(100) not null,
	gender varchar(100) not null,
	maritalstatus varchar(100) not null,
	birthdate varchar(100) not null,
	contact varchar(100) not null,
	dependents varchar(100) not null,
	email varchar(100) not null,
	address varchar(100) not null,
	philhealth varchar(255) not null,
	sss varchar(255) not null,
	pagibig varchar(255) not null,
	tin varchar(255) not null
)

create table Employee(
	id int identity primary key not null,
	idnumber varchar(100) unique not null,
	lastname varchar(100) not null,
	firstname varchar(100) not null,
	middlename varchar(100) not null,
	employementstatus varchar(100) not null,
	position varchar(100) not null,
	salarydetails varchar(100) not null,
	datehired varchar(100) not null
)

drop table Employee

select * from UserAccount
select * from RegisteredEmployee
select * from Employee
insert useraccount(position, name, username, password) VALUES('SYSTEM DEVELOPER', 'VEOSCRIPT', 'veo', 'veo123')

delete from RegisteredEmployee
delete from Employee

SELECT
Employee.idnumber AS 'IDNUMBER', 
Employee.lastname AS 'LASTNAME', 
Employee.firstname AS 'FIRSTNAME', 
Employee.middlename AS 'MIDDLENAME', 
Employee.Position AS 'POSITION', 
Employee.employementstatus AS 'EMPSTATUS', 
Employee.datehired AS 'DATEHIRED',
RegisteredEmployee.gender AS 'GENDER',
RegisteredEmployee.address AS 'ADDRESS',
RegisteredEmployee.contact AS 'CONTACT',
RegisteredEmployee.email AS 'EMAIL',
RegisteredEmployee.birthdate AS 'BIRTHDATE',
RegisteredEmployee.maritalstatus AS 'MARITAL',
RegisteredEmployee.dependents AS 'DEPENDENTS',
RegisteredEmployee.philhealth AS 'PHILHEALTH',
RegisteredEmployee.sss AS 'SSS',
RegisteredEmployee.pagibig AS 'PAGIBIG',
RegisteredEmployee.tin AS 'TIN'
FROM RegisteredEmployee INNER JOIN Employee ON RegisteredEmployee.idnumber = 'P-0002' AND Employee.idnumber = 'P-0002'


SELECT COUNT(employementstatus) AS 'REGULAREMPLOYEE' FROM Employee WHERE employementstatus='REGULAR/UNION' OR employementstatus='REGULAR/NON-UNION'
SELECT COUNT(employementstatus) AS 'REGULAREMPLOYEE' FROM Employee WHERE employementstatus='PROBATIONARY'
SELECT COUNT(employementstatus) AS 'REGULAREMPLOYEE' FROM Employee WHERE employementstatus='AGENCY'