CREATE PROCEDURE [dbo].[spPeople_Insert]
  @FirstName NVARCHAR(50),
  @LastName NVARCHAR(50)
AS
BEGIN
  INSERT INTO dbo.People (FirstName, LastName)
  VALUES (@FirstName, @LastName)
END