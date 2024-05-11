CREATE PROCEDURE [dbo].[spPeople_GetById]
    @Id INT
AS
BEGIN
    SELECT * FROM People WHERE Id = @Id
END