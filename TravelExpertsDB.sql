ALTER TABLE Agents
ADD AgentPassword varbinary(max) NOT NULL DEFAULT '123ABC'

UPDATE Agents
SET AgentPassword = '123ABC'

SELECT * FROM Agents

SELECT * FROM PACKAGES WHERE PkgImage is NULL

SELECT * FROM PACKAGES

SELECT * FROM Packages
WHERE PackageId = 1
AND (PkgImage = 1 OR PkgImage IS NULL)5

UPDATE Packages SET PkgImage = NULL