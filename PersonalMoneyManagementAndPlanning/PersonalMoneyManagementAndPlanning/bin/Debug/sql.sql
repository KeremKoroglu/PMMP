
-- TABLO DEÐERLERÝ SIRALAMALARINI YAP

-- DATABASE
CREATE DATABASE PMMP
USE PMMP

-- LOGIN
CREATE TABLE Users(
Id int identity(1, 1),
Name nvarchar(50) NOT NULL,
Surname nvarchar(50) NOT NULL,
Email nvarchar(50) NOT NULL,
Password nvarchar(50) NOT NULL,
PhoneNumber nvarchar(10) NOT NULL,
DateOfBirth date NOT NULL,
Registration date NOT NULL,
Lang nvarchar(50),
PRIMARY KEY(Id)
)

-- INCOMES
CREATE TABLE Incomes(
Id int identity(1, 1),
UserId int NOT NULL,
Description nvarchar(50) NOT NULL,
Amount decimal(18, 3) NOT NULL,
Category nvarchar(50) NOT NULL,
Account nvarchar(50),
Scenario nvarchar(50),
Date datetime NOT NULL,
PRIMARY KEY(Id),
FOREIGN KEY(UserId) REFERENCES Users(Id) ON DELETE CASCADE
)

-- EXPENSES
CREATE TABLE Expenses(
Id int identity(1, 1),
UserId int NOT NULL,
Description nvarchar(50) NOT NULL,
Amount decimal(18, 3) NOT NULL,
Category nvarchar(50) NOT NULL,
Account nvarchar(50),
Scenario nvarchar(50),
Date datetime NOT NULL,
PRIMARY KEY(Id),
FOREIGN KEY(UserId) REFERENCES Users(Id) ON DELETE CASCADE
)

-- SCENARIOS
CREATE TABLE Scenarios(
Id int identity(1, 1),
UserId int NOT NULL,
Name nvarchar(50) NOT NULL,
Description nvarchar(50),
Category nvarchar(50) NOT NULL,
Target nvarchar(50),
TargetValue decimal(18, 3),
Currency nvarchar(50) NOT NULL,

CreatedDate datetime NOT NULL,
PRIMARY KEY(Id),
FOREIGN KEY(UserId) REFERENCES Users(Id) ON DELETE CASCADE
)

-- ACCOUNTS
CREATE TABLE Accounts(
Id int identity(1, 1),
UserId int NOT NULL,
No nvarchar(50),
Name nvarchar(50) NOT NULL,
Description nvarchar(50),
Category nvarchar(50) NOT NULL,
Currency nvarchar(50) NOT NULL,
CreatedDate datetime NOT NULL,
PRIMARY KEY(Id, No),
FOREIGN KEY(UserId) REFERENCES Users(Id) ON DELETE CASCADE
)

-- INCOME AND EXPENSE CATEGORIES
CREATE TABLE IncomeAndExpenseCategories(
Id int identity(1, 1),
Name nvarchar(50) NOT NULL,
Description nvarchar(50),
PRIMARY KEY(Id)
)

-- SCENARIO CATEGORIES
CREATE TABLE ScenarioCategories(
Id int identity(1, 1),
Name nvarchar(50) NOT NULL,
Description nvarchar(50),
PRIMARY KEY(Id)
)

-- ACCOUNT CATEGORIES
CREATE TABLE AccountCategories(
Id int identity(1, 1),
Name nvarchar(50) NOT NULL,
Description nvarchar(50),
PRIMARY KEY(Id)
)

-- CURRENCY CATEGORIES
CREATE TABLE CurrencyCategories(
Id int identity(1, 1),
Name nvarchar(50) NOT NULL,
Description nvarchar(50),
PRIMARY KEY(Id)
)

-- LOGIN DEFAULT INSERT
INSERT INTO Users VALUES ('Kerem', 'Köroðlu', '@', '1234', '3367', '2024-01-01', '2024-01-01')

-- CATEGORIES DEFAULT INSERT
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Food')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Entertainment')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Transport')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Hobby')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Clothing')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Health')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Education')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Bill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('ElectricityBill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('HeatingBill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('WaterBill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('InternetBill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('TelevisionBill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('PhoneBill')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Charity')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('CreditCard')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Home')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Kid')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('PersonalCare')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Pet')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Rent')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Salary')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Sale')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Subscription')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Travel')
INSERT INTO IncomeAndExpenseCategories (Name) VALUES ('Other')

INSERT INTO ScenarioCategories (Name) VALUES ('Planning')
INSERT INTO ScenarioCategories (Name) VALUES ('DebtPayment')
INSERT INTO ScenarioCategories (Name) VALUES ('BuyPlan')

INSERT INTO AccountCategories (Name) VALUES ('Cash')
INSERT INTO AccountCategories (Name) VALUES ('BankAccount')
INSERT INTO AccountCategories (Name) VALUES ('CreditCard')
INSERT INTO AccountCategories (Name) VALUES ('BankCard')
INSERT INTO AccountCategories (Name) VALUES ('Saving')
INSERT INTO AccountCategories (Name) VALUES ('Investment')
INSERT INTO AccountCategories (Name) VALUES ('Credit')
INSERT INTO AccountCategories (Name) VALUES ('Other')

INSERT INTO CurrencyCategories VALUES ('TRY', 'TurkhisLira')
INSERT INTO CurrencyCategories VALUES ('USD', 'UnitedStatesDollar')
INSERT INTO CurrencyCategories VALUES ('EUR', 'Euro')
INSERT INTO CurrencyCategories VALUES ('GBP', 'BritishPoundSterling')
INSERT INTO CurrencyCategories VALUES ('JPY', 'JapaneseYen')
INSERT INTO CurrencyCategories VALUES ('CHF', 'SwissFranc')
INSERT INTO CurrencyCategories VALUES ('CNY', 'ChineseYuanRenminbi')
INSERT INTO CurrencyCategories VALUES ('RUB', 'RussianRuble')
INSERT INTO CurrencyCategories VALUES ('XAU', 'Gold')

-- TRIGGERS
CREATE TRIGGER AutoAccount
ON Users
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Accounts (UserId, No, Name, Description, Category, Currency) 
	SELECT Id, '000000', 'Nakit', null, 'Cash', 'TRY'
	FROM inserted
END;