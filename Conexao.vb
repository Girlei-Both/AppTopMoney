Imports MySql.Data.MySqlClient

Module Conexao

    'Tipo MÓDULO

#Region "Conexão ao SERVIDOR SQL"

    Dim servidor = "localhost"
    Dim user = "root"
    Dim database = "top_money"
    Dim password = "Dados.1gbm"

    Dim stringConexao = "server=" + servidor + "; userid= " + user + "; password= " + password + "; database= " + database + ";persistsecurityinfo=True; allowuservariables=True"


    Public conexaodados As New MySqlConnection(stringConexao)


    Sub Abrir()

        'se a conexão estiver fechada (0) então abra
        If conexaodados.State = 0 Then
            conexaodados.Open()
        End If

    End Sub

    Sub Fechar()

        'se a conexão estiver aberta (1) então feche
        If conexaodados.State = 0 Then
            conexaodados.Close()
        End If

    End Sub

#End Region



#Region "Variáveis GLOBAIS"

    'DECLARAÇÃO DE VARIÁVEIS GLOBAIS



#End Region






End Module
