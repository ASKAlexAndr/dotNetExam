CREATE VIEW [dbo].[ViewScore]
	AS SELECT TOP 10 [name], [surname], ISNULL(SUM(score), 0) AS [score]
	FROM [Users]
	LEFT JOIN [Games] ON [Games].user_id = [Users].Id
	GROUP BY [name], [surname]
	ORDER BY [score]