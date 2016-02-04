ALTER TABLE Packages
ADD PkgImage varchar(20) NULL DEFAULT NULL

ALTER TABLE Agents
ADD AgentPassword varchar(20) NOT NULL DEFAULT '123ABC'

UPDATE Agents
SET AgentPassword = '123ABC'

SELECT * FROM Agents

SELECT * FROM PACKAGES 

SELECT * FROM PACKAGES

SELECT * FROM Packages
WHERE PackageId = 1
AND (PkgImage = 1 OR PkgImage IS NULL)

UPDATE Packages SET PkgImage = NULL

SELECT * FROM Packages_Products_Suppliers

SELECt * FROM Agents

SELECT * FROM Products

SELECT * FROM [dbo].[Products_Suppliers]

SELECT AgtFirstName, AgentPassword
FROM Agents 
WHERE AgtFirstName='Janet'
AND AgentPassword='123ABC'

ALTER TABLE customers
ADD Username varchar(20)

ALTER TABLE customers
ADD Password varchar(20)

UPDATE Customers
SET Username='User', Password='P@ssw0rd'
WHERE CustomerId = 143