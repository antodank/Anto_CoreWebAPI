CREATE DATABASE BookStore 
 
GO 
 
USE BookStore 
 
GO 
 
CREATE TABLE Author 
  ( 
     Id   BIGINT IDENTITY(1, 1) NOT NULL, 
     NAME NVARCHAR(50) NOT NULL, 
     PRIMARY KEY (Id) 
  ) 
 
GO 
 
CREATE TABLE AuthorContact 
  ( 
     AuthorId      BIGINT NOT NULL, 
     ContactNumber NVARCHAR(15) NULL, 
     Address       NVARCHAR(100) NULL, 
     PRIMARY KEY (AuthorId), 
     FOREIGN KEY (AuthorId) REFERENCES Author(Id) 
  ) 
 
GO 
 
CREATE TABLE BookCategory 
  ( 
     Id   BIGINT IDENTITY(1, 1) NOT NULL, 
     NAME NVARCHAR(50) NOT NULL, 
     PRIMARY KEY (Id) 
  ) 
 
GO 
 
CREATE TABLE Publisher 
  ( 
     Id   BIGINT IDENTITY(1, 1) NOT NULL, 
     NAME NVARCHAR(100) NOT NULL, 
     PRIMARY KEY (Id) 
  ) 
 
GO 
 
CREATE TABLE Book 
  ( 
     Id          BIGINT IDENTITY(1, 1) NOT NULL, 
     Title       NVARCHAR(100) NOT NULL, 
     CategoryId  BIGINT NOT NULL, 
     PublisherId BIGINT NOT NULL, 
     PRIMARY KEY (Id), 
     FOREIGN KEY (CategoryId) REFERENCES BookCategory(Id), 
     FOREIGN KEY (PublisherId) REFERENCES Publisher(Id) 
  ) 
 
GO 
 
CREATE TABLE BookAuthors 
  ( 
     BookId   BIGINT NOT NULL, 
     AuthorId BIGINT NOT NULL 
     PRIMARY KEY (BookId, AuthorId), 
     FOREIGN KEY (BookId) REFERENCES Book(Id), 
     FOREIGN KEY (AuthorId) REFERENCES Author(Id) 
  )