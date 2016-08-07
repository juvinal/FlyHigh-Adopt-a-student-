create database DbSystem

use DbSystem

create table tblUser
(
	BankID varchar (50) primary key,
	Username varchar (30) unique,
	PAssword varchar (30),
	LastName varchar (25),
	Firstname varchar (25),
	Gender varchar (10),
	Address varchar (50),
	Contact varchar (25),
	Usertype varchar (10),
)
drop table tblUser

create table StudentReference
(
	BankID varchar (50) foreign key (BankID) references tblUser(BankID),
	ReferenceLastname varchar (25),
	ReferenceFirstname varchar (25),
	ReferenceContact varchar (30),
	Form137 image,
	Endorsement image,
	Others image
)
drop table StudentReference

create procedure sp_SignUp
@BankID varchar (50),
@Username varchar (30),
@Password varchar (30),
@Lastname varchar (25),
@Firstname varchar (25),
@Gender varchar (10),
@Address varchar (50),
@Contact varchar (25),
@Usertype varchar (10) as insert into tblUser values (@BankID, @Username, @Password, @Lastname, @Firstname, @Gender, @Address, @Contact, @Usertype)

drop procedure sp_SignUp

create table myStudents
(
	StudBankID varchar (50),
	Lastname varchar (25),
	Firstname varchar (25),
	Gender varchar (10),
	Address varchar (50),
	Contact varchar (25)
)
drop table myStudents
select * from myStudents
truncate 

create procedure sp_SignUpStudent
@BankID varchar (50),
@Username varchar (30),
@Password varchar (30),
@Lastname varchar (25),
@Firstname varchar (25),
@Gender varchar (10),
@Address varchar (50),
@Contact varchar (25),
@Usertype varchar (10),
@RefLastname varchar (25),
@RefFirstname varchar (25),
@RefContact varchar (25),
@Form137 image,
@Endorsement image,
@Others image as insert into tblUser values (@BankID, @Username, @Password, @Lastname, @Firstname, @Gender, @Address, @Contact, @Usertype)
				insert into StudentReference values (@BankID, @RefLastname, @RefFirstname, @RefContact, @Form137, @Endorsement, @Others)

create procedure sp_Accounts as select * from tblUSer

create procedure sp_Students as select BankID,Lastname, Firstname, Gender, Address, Contact  from tblUser where Usertype = 'Student'
drop procedure sp_Students

create procedure sp_References as select * from StudentReference

create procedure sp_MyStudents
@Usertype varchar (50) as select BankID, Lastname, Firstname, Gender, Address, Contact from tblUser where Usertype = @Usertype
drop procedure sp_MyStudents

create procedure sp_AddStudent
@StudBankID varchar (50),
@Lastname varchar (25),
@Firstname varchar (25),
@Gender varchar (10),
@Address varchar (50),
@Contact varchar (25) as insert into myStudents values (@StudBankID, @Lastname, @Firstname, @Gender, @Address, @Contact)
drop procedure sp_AddStudent

create procedure sp_DeleteStud
@BankID varchar (50) as delete from StudentReference where BankID = '000112'
						delete from tblUser where BankID = '000112'
drop procedure sp_DeleteStud

 insert into tblUser values ('000113', 'juvinal', 'alvarado', 'Alvarado', 'Juvinal', 'Female', 'Haha', '09123456789', 'Student')
				insert into StudentReference values ('000113', 'Mader', 'Mama', '09123123123', '', '', '')

 insert into tblUser values ('000112', 'jovan', 'reyes', '0Reyes', 'Jovan', 'Male', 'Mandaue City, Cebu', '09123456789', 'Donor')
				insert into StudentReference values ('000112', 'Mader', 'Mama', '09123123123', '', '', '')

	select *from tblUser
	select * from StudentReference
	select * from myStudents

	delete from tblUser where BankID = 000117
	delete from StudentReference where BankID = 000117

	truncate table tblUser
	truncate table StudentReference

create procedure UpdateStudent
@BankID varchar (50),
@Usertype varchar (10) as Update tblUser set Usertype = @Usertype where BankID = @BankID
							Update tblUser set Usertype = 'Donor' where BankID = '000112'

