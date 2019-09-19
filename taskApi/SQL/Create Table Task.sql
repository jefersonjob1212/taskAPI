USE SUPERO_INTELBRAS;

CREATE TABLE Task (
	Id Integer identity(1,1) not null primary key,
	Descript varchar(50) not null,
	Done bit not null default 0
);