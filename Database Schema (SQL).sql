create database EIS

use EIS

create table UserAccount(
	id int identity primary key not null,
	position varchar(255) not null,
	name varchar(255) unique not null,
	username varchar(255) unique not null,
	password varchar(255) not null
)

select * from useraccount
insert useraccount(position, name, username, password) VALUES('SYSTEM DEVELOPER', 'VEOSCRIPT', 'veo', 'veo123')

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
	employementstatus varchar(100) not null,
	position varchar(100) not null,
	salarydetails varchar(100) not null,
	datehired varchar(100) not null
)