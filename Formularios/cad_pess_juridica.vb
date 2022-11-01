﻿Imports MySql.Data.MySqlClient

Public Class cad_pess_juridica

    Private Sub cad_pess_juridica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dicas()
        Desabilitar()
        Listar()

    End Sub

    Private Sub cad_bancos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Dicas()
        Desabilitar()
        Listar()

    End Sub

#Region "NOVO"

    Private Sub btn_menu_add_Click(sender As Object, e As EventArgs) Handles btn_menu_add.Click

        Limpar()
        Habilitar()

    End Sub

#End Region

#Region "SALVAR"

    Private Sub btn_menu_save_Click(sender As Object, e As EventArgs) Handles btn_menu_save.Click

        'Tratamento de erros durante o desenvolvimento do sistema
        Try
            'Abrindo a conexão
            Abrir()

            'Programando edição de registro no banco de dados
            Dim command As MySqlCommand
            Dim sql As String

            'Inserir dados em uma planilha no banco de dados
            sql = "INSERT INTO juridica (id_pessoa, cnpj, rasaosocial, endereco, cidade, estado, cep, email, site, obs) VALUES ('" & cb_id_pessoa.Text & "', '" & tb_cnpj.Text & "', '" & lb_rasaosocial.Text & "', '" & tb_endereco.Text & "', '" & tb_cidade.Text & "', '" & cb_estado.Text & "', '" & tb_cep.Text & "', '" & tb_email.Text & "', '" & tb_site.Text & "', '" & tb_obs.Text & "')"
            command = New MySqlCommand(sql, conexaodados)
            command.ExecuteNonQuery()

            MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvos")

            Limpar()
            Desabilitar()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! ERRO: " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try

    End Sub

#End Region

#Region "EDITAR"

    Private Sub btn_menu_edit_Click(sender As Object, e As EventArgs) Handles btn_menu_edit.Click

        'Tratamento de erros durante o desenvolvimento do sistema
        Try
            'Abrindo a conexão
            Abrir()

            'Programando edição de registro no banco de dados
            Dim command As MySqlCommand
            Dim sql As String

            'Inserir dados em uma planilha no banco de dados
            sql = "UPDATE  juridica SET id_pessoa =  '" & cb_id_pessoa.Text & "', cnpj =  '" & tb_cnpj.Text & "', rasaosocial =  '" & tb_rasaosocial.Text & "', endereco =  '" & tb_endereco.Text & "', cidade =  '" & tb_cidade.Text & "', estado =  '" & cb_estado.Text & "', cep =  '" & tb_cep.Text & "', email =  '" & tb_email.Text & "', site =  '" & tb_site.Text & "', obs =  '" & tb_obs.Text & "' WHERE id =  '" & tb_id.Text & "'"
            command = New MySqlCommand(sql, conexaodados)
            command.ExecuteNonQuery()

            MsgBox("Editado com Sucesso!!", MsgBoxStyle.Information, "Dados Editados")

            Limpar()
            Desabilitar()

        Catch ex As Exception
            MsgBox("Erro ao Editar!! ERRO: " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub btn_menu_del_Click(sender As Object, e As EventArgs) Handles btn_menu_del.Click

        'Teste de condição para o botão excluir
        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a opção") = vbYes Then

            'Tratamento de erros durante o desenvolvimento do sistema
            Try

                'Abrindo a conexão
                Abrir()

                'Programando exclusão de registro no banco de dados
                Dim command As MySqlCommand
                Dim sql As String
                'Excluindo dados em uma planilha no banco de dados
                sql = "DELETE FROM juridica WHERE id = '" & tb_id.Text & "'"
                command = New MySqlCommand(sql, conexaodados)
                command.ExecuteNonQuery()

                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Excluidos")

                Limpar()
                Desabilitar()

            Catch ex As Exception
                MsgBox("Erro ao Excluir!! ERRO: " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
            End Try

        End If

    End Sub

#End Region

#Region "LIMPAR"

    Private Sub btn_menu_clean_Click(sender As Object, e As EventArgs) Handles btn_menu_clean.Click

        Limpar()

    End Sub

    Sub Limpar()

        tb_id.Text = ""
        cb_id_pessoa.Text = ""
        tb_cnpj.Text = ""
        tb_rasaosocial.Text = ""
        tb_endereco.Text = ""
        tb_cidade.Text = ""
        cb_estado.Text = ""
        tb_cep.Text = ""
        tb_email.Text = ""
        tb_site.Text = ""
        tb_obs.Text = ""

        Desabilitar()

    End Sub

#End Region

#Region "HABILITAR"

    Sub Habilitar()

        'Botões
        btn_menu_add.Enabled = True
        btn_menu_save.Enabled = True
        btn_menu_edit.Enabled = True
        btn_menu_clean.Enabled = True
        btn_menu_del.Enabled = True
        'btn_menu_relat.Enabled = True

        'Caixas de texto
        'tb_id.Enabled = True
        cb_id_pessoa.Enabled = True
        tb_cnpj.Enabled = True
        tb_rasaosocial.Enabled = True
        tb_endereco.Enabled = True
        tb_cidade.Enabled = True
        cb_estado.Enabled = True
        tb_cep.Enabled = True
        tb_email.Enabled = True
        tb_site.Enabled = True
        tb_obs.Enabled = True

        'Cor do fundo
        tb_id.BackColor = Color.Salmon
        cb_id_pessoa.BackColor = Color.Salmon
        tb_cnpj.BackColor = Color.Salmon
        tb_rasaosocial.BackColor = Color.Salmon
        tb_endereco.BackColor = Color.Salmon
        tb_cidade.BackColor = Color.Salmon
        cb_estado.BackColor = Color.Salmon
        tb_cep.BackColor = Color.Salmon
        tb_email.BackColor = Color.Salmon
        tb_site.BackColor = Color.Salmon
        tb_obs.BackColor = Color.Salmon

    End Sub

#End Region

#Region "DESABILITAR"

    Sub Desabilitar()

        'Botões
        'btn_menu_add.Enabled = False
        btn_menu_save.Enabled = False
        btn_menu_edit.Enabled = False
        btn_menu_clean.Enabled = False
        btn_menu_del.Enabled = False
        'btn_menu_relat.Enabled = False

        'Caixas de texto
        'tb_id.Enabled = False
        cb_id_pessoa.Enabled = False
        tb_cnpj.Enabled = False
        tb_rasaosocial.Enabled = False
        tb_endereco.Enabled = False
        tb_cidade.Enabled = False
        cb_estado.Enabled = False
        tb_cep.Enabled = False
        tb_email.Enabled = False
        tb_site.Enabled = False
        tb_obs.Enabled = False

        'Cor do fundo
        tb_id.BackColor = Color.LightGray
        cb_id_pessoa.BackColor = Color.LightGray
        tb_cnpj.BackColor = Color.LightGray
        tb_rasaosocial.BackColor = Color.LightGray
        tb_endereco.BackColor = Color.LightGray
        tb_cidade.BackColor = Color.LightGray
        cb_estado.BackColor = Color.LightGray
        tb_cep.BackColor = Color.LightGray
        tb_email.BackColor = Color.LightGray
        tb_site.BackColor = Color.LightGray
        tb_obs.BackColor = Color.LightGray

    End Sub

#End Region

#Region "DATA GRID"

    Sub Listar()

        Try

            'Buscar informações da tabela no banco de dados e mostrar no datagrid

            'Abrir conexão
            Abrir()

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT * FROM juridica ORDER BY rasaosocial ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            'Atribui ao DataGrid
            dt_grid_form.DataSource = dattable

            'Formatar Grid apenas após a inserção de linhas e não antes
            If dt_grid_form.Rows.Count > 0 Then
                FormatarGrid()
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try

    End Sub

    Sub FormatarGrid()

        Dim FormGrid = dt_grid_form

        'Ajustar os títulos das colunas
        FormGrid.Columns(0).HeaderText = "Id"
        FormGrid.Columns(1).HeaderText = "Pessoa"
        FormGrid.Columns(2).HeaderText = "CNPJ"
        FormGrid.Columns(3).HeaderText = "Rasão Social"
        FormGrid.Columns(4).HeaderText = "Endereço"
        FormGrid.Columns(5).HeaderText = "Cidade"
        FormGrid.Columns(6).HeaderText = "Estado"
        FormGrid.Columns(7).HeaderText = "CEP"
        FormGrid.Columns(8).HeaderText = "E-mail"
        FormGrid.Columns(9).HeaderText = "Site"
        FormGrid.Columns(10).HeaderText = "Observações"

    End Sub

    Private Sub dt_grid_form_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_form.CellClick

        Habilitar()

        btn_menu_save.Enabled = False

        Dim FormGrid = dt_grid_form

        tb_id.Text = FormGrid.CurrentRow.Cells(0).Value
        cb_id_pessoa.Text = FormGrid.CurrentRow.Cells(1).Value
        tb_cnpj.Text = FormGrid.CurrentRow.Cells(2).Value
        tb_rasaosocial.Text = FormGrid.CurrentRow.Cells(3).Value
        tb_endereco.Text = FormGrid.CurrentRow.Cells(4).Value
        tb_cidade.Text = FormGrid.CurrentRow.Cells(5).Value
        cb_estado.Text = FormGrid.CurrentRow.Cells(6).Value
        tb_cep.Text = FormGrid.CurrentRow.Cells(7).Value
        tb_email.Text = FormGrid.CurrentRow.Cells(8).Value
        tb_site.Text = FormGrid.CurrentRow.Cells(9).Value
        tb_obs.Text = FormGrid.CurrentRow.Cells(10).Value

    End Sub

#End Region

#Region "DICAS"

    Sub Dicas()

        'Exibe janelas de ajuda
        Dim toolTip As New ToolTip With {
            .AutoPopDelay = 5000,   ' Define o delay para a ToolTip.
            .InitialDelay = 100,
            .ReshowDelay = 100,
            .ShowAlways = True      ' Força a o texto da ToolTip a ser exibido mesmo que o form não esta ativo
        }

        ' Define o texto da ToolTip para o Button, TextBox, Checkbox e Label
        toolTip.SetToolTip(Me.btn_menu_add, "Botão para habilitar os campos.")
        toolTip.SetToolTip(Me.btn_menu_save, "Botão para Salvar um novo registro.")
        toolTip.SetToolTip(Me.btn_menu_edit, "Botão para Editar um registro existente.")
        toolTip.SetToolTip(Me.btn_menu_clean, "Botão para Limpar todos os campos.")
        toolTip.SetToolTip(Me.btn_menu_del, "Botão para Deletar um registro.")
        toolTip.SetToolTip(Me.btn_menu_relat, "Botão para emitir um relatório.")

    End Sub

#End Region

#Region "BARRA DE MENU"

    Private Sub btn_menu_home_Click(sender As Object, e As EventArgs) Handles btn_menu_home.Click

        Limpar()
        Me.Close()
        frm_tela_inicial.Show()

    End Sub

    Private Sub btn_menu_close_Click(sender As Object, e As EventArgs) Handles btn_menu_close.Click

        Limpar()
        Me.Close()
        frm_tela_inicial.Show()

    End Sub

#End Region

End Class