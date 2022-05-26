USE [C:\USERS\MATHEUS.DLAGARES\SOURCE\REPOS\MATHISTUBER\PROJETOAGENCIATI11T\PROJETOAGENCIATI11T\BANCO\BDAGENCIAVIAGENS.MDF]
GO

DECLARE	@return_value Int,
		@codigoFun int

EXEC	@return_value = [dbo].[pCadastrarFuncionario]
		@nomeFun = N'cdrgfggg',
		@emailFun = N'gggggg',
		@senhaFun = N'gggggg',
		@codigoFun = @codigoFun OUTPUT

SELECT	@codigoFun as N'@codigoFun'

SELECT	@return_value as 'Return Value'

GO
