CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
  SELECT ID, FirstName, LastName
  FROM dbo.People
END