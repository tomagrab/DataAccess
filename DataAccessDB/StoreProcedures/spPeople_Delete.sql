CREATE PROCEDURE [dbo].[spPeople_Delete]
  @ID INT
AS
BEGIN
  DELETE FROM dbo.People
  WHERE ID = @ID
END