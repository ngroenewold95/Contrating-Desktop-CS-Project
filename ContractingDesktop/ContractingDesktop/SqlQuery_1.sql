create table CONTRACTS(
	ContractID char(6) not null,
	EmployeeID char(6) not null,
	ClientID char(6) not null,
	JobDescript varchar(50),
	JobPlace varchar(50),

	CurStart date not null,
	CurEnd date not null,
	CurHR numeric(3,2),
	CurCR numeric (3,2),


	R1Start date,
	R1End date,
	R1HR numeric(3,2),
	R1CR numeric(3,2),

	R2Start date,
	R2End date,
	R2HR numeric(3,2),
	R2CR numeric(3,2),

	foreign key (EmployeeID) references CONTRACTORS,
	foreign key (ClientID) references CLIENT,
	primary key (ContractID)
	)


create table CONTRACTOR(
	EmployeeID char(6) not null,
	FirstName varchar(30) not null,
	LastName varchar(30),
	City varchar(30),
	ZIP char(6),
	ADDRS varchar(30),
	IncorpName varchar(30),
	Email varchar(30),
	primary key (EmployeeID)
	
)


create table CLIENT(
	ClientID char(6) not null,
	ClientName varchar(30) not null
	primary key (ClientID)
)


create table HOURS_RECORDED(
	ContractID char(6) not null,
	Years int,
	Months int,
	Hourly numeric(3,2),
	primary key (ContractID, Years, Months),
)