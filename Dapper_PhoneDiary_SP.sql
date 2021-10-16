use DapperCrudDb

create table Contact(
ContactId int primary key identity(1,1) not null,
FullName nvarchar(50) not null,
PhoneNumber nvarchar(11) not null,
)

--procedure for if id is not recognized add else edit
go
create procedure up_ContactAddOrEdit
@contactid as int,
@name as nvarchar(50),
@number as nvarchar(11)
as
begin
if(@contactid=0)
begin
	insert into Contact(FullName,PhoneNumber) values(@name,@number)
end
else
begin
	update Contact
	set
	FullName=@name,
	PhoneNumber=@number
	where ContactId=@contactid
end
end
go

--get all contacts sp
go
create procedure up_GetAllContact
as
begin
	select * from Contact
end
go

--sp for delete contact
go
create procedure up_DeleteContact
@id int
as
begin
	delete from Contact
	where ContactId=@id
end
go