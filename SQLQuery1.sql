USE [C:\USERS\MATHEUS.DLAGARES\SOURCE\REPOS\MATHISTUBER\PROJETOAGENCIATI11T\PROJETOAGENCIATI11T\BANCO\BDAGENCIAVIAGENS.MDF]
GO

DECLARE	@return_value Int,
		@codigoCli int

EXEC	@return_value = [dbo].[pCadastrarCliente]
		@nomeCli = N'matheus',
		@emailCli = N'bsbeyeyeyeyey@gmail.com',
		@senhaCli = N'matheus',
		@imagemCli = NULL,
		@codigoCli = @codigoCli OUTPUT

SELECT	@codigoCli as N'@codigoCli'

SELECT	@return_value as 'Return Value'

GO
