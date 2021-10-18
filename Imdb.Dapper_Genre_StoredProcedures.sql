
alter procedure up_GetAllGenres
as
begin
	select Id,GenreName from Genre

end

create procedure up_InsertGenre
@name nvarchar(50)
as
begin
	insert into genre(GenreName) values(@name)
end

create procedure up_GetGenreById
@id int
as begin
	select * from genre where Id=@id
end

Create procedure up_UpdateGenre
@id int,
@name nvarchar(50)
as
begin
	update genre set genrename=@name where Id=@id
end

Create procedure up_DeleteGenre
@id int
as
begin
	delete from genre where Id=@id
end