Public Class frm_tela_inicial

#Region "BARRA DE MENU"

    Private Sub btn_menu_config_ButtonClick(sender As Object, e As EventArgs) Handles btn_menu_config.ButtonClick
        menu_cadastros.Select()
    End Sub

    Private Sub btn_menu_close_Click(sender As Object, e As EventArgs) Handles btn_menu_close.Click
        Application.Exit()
    End Sub

    Private Sub menu_pessoa_fisica_Click(sender As Object, e As EventArgs) Handles menu_pessoa_fisica.Click
        cadPessoaFisica()
    End Sub

    Private Sub menu_pessoa_juridica_Click(sender As Object, e As EventArgs) Handles menu_pessoa_juridica.Click
        cadPessoaJuridica()
    End Sub

    Private Sub menu_bens_Click(sender As Object, e As EventArgs) Handles menu_bens.Click
        cadBens()
    End Sub

    Private Sub menu_documentos_Click(sender As Object, e As EventArgs) Handles menu_documentos.Click
        cadDocumentos()
    End Sub

    Private Sub menu_gastos_mes_Click(sender As Object, e As EventArgs) Handles menu_gastos_mes.Click
        cadGastosCaixa()
    End Sub

    Private Sub menu_controle_caixa_Click(sender As Object, e As EventArgs) Handles menu_controle_caixa.Click
        cadControleCaixa()
    End Sub

    Private Sub menu_bancos_Click(sender As Object, e As EventArgs) Handles menu_bancos.Click
        cadBancos()
    End Sub

    Private Sub menu_aplicacoes_Click(sender As Object, e As EventArgs) Handles menu_aplicacoes.Click
        cadAplicacoes()
    End Sub

    Private Sub menu_fornecedores_Click(sender As Object, e As EventArgs) Handles menu_fornecedores.Click
        cadFornecedores()
    End Sub

    Private Sub menu_pagadores_Click(sender As Object, e As EventArgs) Handles menu_pagadores.Click
        cadPagadores()
    End Sub

#End Region

#Region "BOTÕES"

    Private Sub btn_inicio_pessoa_Click(sender As Object, e As EventArgs) Handles btn_inicio_pessoa.Click
        cadPessoaFisica()
    End Sub

    Private Sub btn_inicio_gastos_Click(sender As Object, e As EventArgs) Handles btn_inicio_gastos.Click
        cadGastosCaixa()
    End Sub

    Private Sub btn_inicio_banco_Click(sender As Object, e As EventArgs) Handles btn_inicio_banco.Click
        cadBancos()
    End Sub

    Private Sub btn_inicio_pagadores_Click(sender As Object, e As EventArgs) Handles btn_inicio_pagadores.Click
        cadPagadores()
    End Sub

    Private Sub btn_inicio_bens_Click(sender As Object, e As EventArgs) Handles btn_inicio_bens.Click
        cadBens()
    End Sub

    Private Sub btn_inicio_caixa_Click(sender As Object, e As EventArgs) Handles btn_inicio_caixa.Click
        cadControleCaixa()
    End Sub

#End Region

#Region "AÇÕES"

    Sub cadPessoaFisica()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_pessoa" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_pessoa
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadPessoaJuridica()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_pess_juridica" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_pess_juridica
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadBens()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_bens" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_bens
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadDocumentos()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_documentos" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_documentos
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadGastosCaixa()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_gasto_mes" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_gasto_mes
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadControleCaixa()
        'Relatório
    End Sub

    Sub cadBancos()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_bancos" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_bancos
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadAplicacoes()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_aplicacoes" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_aplicacoes
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadFornecedores()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_fornecedores" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_fornecedores
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Sub cadPagadores()
        Try
            Dim formsAbertos = Application.OpenForms
            Dim ativo = False
            Dim formularioAtivo = New Object

            For Each formulario As Form In formsAbertos
                If formulario.Name Is "cad_pagadores" Then
                    ativo = True
                    formularioAtivo = formulario
                End If
            Next

            If ativo = True Then
                formularioAtivo.Activate()
            Else
                Dim formAbrirNovo = New cad_pagadores
                Me.Visible = False
                formAbrirNovo.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro!! " + ex.Message, MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

#End Region


End Class