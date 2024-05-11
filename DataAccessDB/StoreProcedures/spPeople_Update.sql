CREATE PROCEDURE [dbo].[spPeople_Update]
  @ID INT,
  @FirstName NVARCHAR(50),
  @LastName NVARCHAR(50)
AS
BEGIN
  UPDATE dbo.People
  SET FirstName = @FirstName, LastName = @LastName
  WHERE ID = @ID
END