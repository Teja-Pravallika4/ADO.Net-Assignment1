create database FootBall;

use FootBall;
create table FootBallLeague
(MatchID INTEGER NOT NULL PRIMARY KEY,
TeamName1 VARCHAR(100),
TeamName2 VARCHAR(100),
Status varchar(40),
WinningTeam varchar(50),
Points integer);

select * from FootBallLeague;

CREATE PROCEDURE sample2 (@MatchId int,
                               @TeamName1 nchar(20),
							   @TeamNmae2 nchar(20),
							   @Status nchar(20),
							   @WinningTeam nchar(20),
							   @Points int)
							   AS
							   BEGIN 
							   INSERT INTO FootBallLeague
							   (MatchID,TeamName1,TeamName2,Status,WinningTeam,Points)
							   VALUES (@MatchId,
                               @TeamName1 ,
							   @TeamNmae2 ,
							   @status ,
							   @Winningteam ,
							   @Points)
							   END

							   USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1001,
		@TeamName1 = N'Italy',
		@TeamNmae2 = N'France',
		@Status = N'Win',
		@WinningTeam = N'France',
		@Points = 4

SELECT	'Return Value' = @return_value

GO
USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1003,
		@TeamName1 = N'England',
		@TeamNmae2 = N'Japan',
		@Status = N'Win',
		@WinningTeam = N'England',
		@Points = 4

SELECT	'Return Value' = @return_value

GO
USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1004,
		@TeamName1 = N'USA',
		@TeamNmae2 = N'Russia',
		@Status = N'Win',
		@WinningTeam = N'Russia',
		@Points = 4

SELECT	'Return Value' = @return_value

GO
USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1005,
		@TeamName1 = N'Portugal',
		@TeamNmae2 = N'Italy',
		@Status = N'Draw',
		@WinningTeam = NULL,
		@Points = 2

SELECT	'Return Value' = @return_value

GO
USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1006,
		@TeamName1 = N'Brazil',
		@TeamNmae2 = N'France',
		@Status = N'Win',
		@WinningTeam = N'Brazil',
		@Points = 4

SELECT	'Return Value' = @return_value

GO
USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1007,
		@TeamName1 = N'England',
		@TeamNmae2 = N'Russia',
		@Status = N'Win',
		@WinningTeam = N'Russia',
		@Points = 4

SELECT	'Return Value' = @return_value

GO
USE [sample3]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sample2]
		@MatchId = 1008,
		@TeamName1 = N'Japan',
		@TeamNmae2 = N'USA',
		@Status = N'Draw',
		@WinningTeam = NULL,
		@Points = 2

SELECT	'Return Value' = @return_value

GO
/* Retrieve all the winning TeamNames */ 

select TeamName1,TeamName2 
from FootBallLeague
where Status='Win';

/*	Create View Match_View to display the teams whose status is Draw   */

CREATE VIEW MatchView  AS
SELECT TeamName1,TeamName2
FROM FootBallLeague
WHERE Status='Draw';

select * from [MatchView];  /* Display View */

/* Retrieve the details of all matches in which Japan played */

select * from FootBallLeague
where TeamName1='Japan' or TeamName2='Japan';
