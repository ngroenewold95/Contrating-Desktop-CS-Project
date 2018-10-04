create table CONTRACTS(
	ContractID char(6) not null,
	EmployeeID char(6) not null,
	StartDate date not null,
	EndDate date not null,
	Rate numeric(3,2),
	TotalHours numeric(3,2),
	JobDescript varchar(50),
	JobPlace varchar(50),
	primary key (ContractID)
)


create table PERSON(
	EmployeeID char(6) not null,
	EmployeeName varchar(30) not null,
	CompanyID char(6) not null,
	Email varchar(30),
	primary key (EmployeeID)
)


create table COMPANY(
	CompanyID char(6) not null,
	CompanyName varchar(30) not null
	primary key (CompanyID)
)