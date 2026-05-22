-- 1 Busca o nome e ano dos filmes
 SELECT Nome, Ano FROM Filmes

-- 2 Busca o nome e ano dos filmes, ordenados por ordem crescente pelo ano 
SELECT Nome, Ano FROM Filmes ORDER BY Ano

-- 3 Busca pelo filme de volta para o futuro, trazendo o nome, ano e a duração
SELECT * FROM Filmes WHERE Nome = 'De Volta para o Futuro'

-- 4 Busca os filmes lançados em 1997
SELECT * FROM Filmes WHERE Ano = 1997

-- 5 Busca os filmes lançados APÓS o ano 2000
SELECT * FROM Filmes WHERE Ano > 2000

-- 6 Busca os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
SELECT * FROM Filmes WHERE Duracao > 100 AND Duracao < 150 ORDER BY Duracao

-- 7 Busca a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente
SELECT Ano, COUNT(*) AS Quantidade FROM Filmes GROUP BY Ano ORDER BY Quantidade DESC

-- 8 Busca os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
SELECT * FROM Atores WHERE Genero = 'M'

-- 9 Busca os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome
SELECT * FROM Atores WHERE Genero = 'F' ORDER BY PrimeiroNome


-- join filmes com filmes genero
SELECT * FROM Filmes INNER JOIN FilmesGenero ON Filmes.Id = FilmesGenero.IdFilme


-- 10 Busca o nome do filme e o gênero
SELECT Nome, Genero FROM Filmes INNER JOIN FilmesGenero ON Filmes.Id = FilmesGenero.IdFilme INNER JOIN Generos ON FilmesGenero.IdGenero = Generos.Id

-- 11 Busca o nome do filme e o gênero do tipo "Mistério"
SELECT Nome, Genero FROM Filmes INNER JOIN FilmesGenero ON Filmes.Id = FilmesGenero.IdFilme INNER JOIN Generos ON FilmesGenero.IdGenero = Generos.Id WHERE Genero = 'Mistério'

-- 12 Busca o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
SELECT Nome, PrimeiroNome, UltimoNome, Papel FROM Filmes INNER JOIN Atores ON Filmes.Id = Atores.Id INNER JOIN ElencoFilme ON ElencoFilme.IdAtor = Atores.Id
