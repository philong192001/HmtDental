CREATE TABLE Users (
	Id int identity primary key,
	UserName nvarchar(MAX) not null,
	Password nvarchar(250) NOT NULL,
	Phone int
)

CREATE TABLE Category (
	Id int identity primary key,
	Name nvarchar(250) ,
	Parent_Id int
)

CREATE TABLE Product(
	Id int identity primary key,
	Name nvarchar(MAX),
	Price float,
	Category_Id int,
	Description nvarchar(MAX),
	Image varchar(MAX),
	Quantity int,
	Code_Product int,
	Sub_Description nvarchar(MAX)
)

CREATE TABLE New(
	Id int identity primary key,
	Title nvarchar(MAX),
	Content nvarchar(MAX),
	DateTimeCreate datetime,
	Image varchar(MAX)
)

CREATE TABLE Background(
	Id int identity primary key,
	Hotline int,
	Landline int,
	Slogan nvarchar(MAX),
	Address nvarchar(MAX),
	Email nvarchar(MAX)
)

CREATE TABLE SupportUser(
	Id int identity primary key,
	Name nvarchar(MAX),
	Phone int
)