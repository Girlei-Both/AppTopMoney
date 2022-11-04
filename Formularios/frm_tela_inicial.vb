Public Class frm_tela_inicial

#Region "BARRA DE MENU"

    Private Sub btn_menu_close_Click(sender As Object, e As EventArgs) Handles btn_menu_close.Click
        Application.Exit()
    End Sub

    Private Sub menu_pessoa_fisica_Click(sender As Object, e As EventArgs) Handles menu_pessoa_fisica.Click
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

    Private Sub menu_pessoa_juridica_Click(sender As Object, e As EventArgs) Handles menu_pessoa_juridica.Click
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

    Private Sub menu_controle_caixa_Click(sender As Object, e As EventArgs) Handles menu_controle_caixa.Click

    End Sub

    Private Sub menu_bancos_Click(sender As Object, e As EventArgs) Handles menu_bancos.Click
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

    Private Sub menu_contas_mes_Click(sender As Object, e As EventArgs) Handles menu_contas_mes.Click

    End Sub

    Private Sub menu_aplicacoes_Click(sender As Object, e As EventArgs) Handles menu_aplicacoes.Click
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

    Private Sub menu_fornecedores_Click(sender As Object, e As EventArgs) Handles menu_fornecedores.Click

    End Sub

    Private Sub menu_impostos_Click(sender As Object, e As EventArgs) Handles menu_impostos.Click

    End Sub

    Private Sub menu_pagadores_Click(sender As Object, e As EventArgs) Handles menu_pagadores.Click

    End Sub

    Private Sub menu_bens_Click(sender As Object, e As EventArgs) Handles menu_bens.Click
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

    Private Sub menu_documentos_Click(sender As Object, e As EventArgs) Handles menu_documentos.Click
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

#End Region

#Region "BOTÕES"

    Private Sub btn_inicio_pessoa_Click(sender As Object, e As EventArgs) Handles btn_inicio_pessoa.Click

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

    Private Sub btn_inicio_caixa_Click(sender As Object, e As EventArgs) Handles btn_inicio_caixa.Click

    End Sub

    Private Sub btn_inicio_banco_Click(sender As Object, e As EventArgs) Handles btn_inicio_banco.Click

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

    Private Sub btn_inicio_pagadores_Click(sender As Object, e As EventArgs) Handles btn_inicio_pagadores.Click

    End Sub

    Private Sub btn_inicio_bens_Click(sender As Object, e As EventArgs) Handles btn_inicio_bens.Click

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

    Private Sub btn_inicio_gastos_Click(sender As Object, e As EventArgs) Handles btn_inicio_gastos.Click

    End Sub

    Private Sub frm_tela_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





#End Region

End Class