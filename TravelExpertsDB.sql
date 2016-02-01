ALTER TABLE Agents
ADD AgentPassword varbinary(max) NOT NULL DEFAULT '123ABC'

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
WHERE AgtFirstName = 'Janet'
AND AgentPassword = '123ABC'