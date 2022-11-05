Imports MySql.Data.MySqlClient

Public Class cad_pagadores

    Private Sub cad_pagadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dicas()
        Limpar()
        BotoesEstiloInicio()
        Desabilitar()
        Listar()

    End Sub

    Private Sub cad_pagadores_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Dicas()
        Limpar()
        BotoesEstiloInicio()
        Desabilitar()
        Listar()

    End Sub

#Region "BOTÕES"

    'Ações dos botões primários
    Private Sub btn_menu_add_Click(sender As Object, e As EventArgs) Handles btn_menu_add_pt.Click
        BotoesEstiloNovo()
        Habilitar()
        Limpar()
    End Sub

    Private Sub btn_menu_clean_Click(sender As Object, e As EventArgs) Handles btn_menu_clean_pt.Click
        Limpar()
        BotoesEstiloInicio()
        Desabilitar()
    End Sub

    Private Sub btn_menu_save_Click(sender As Object, e As EventArgs) Handles btn_menu_save_pt.Click
        Salvar()
    End Sub

    Private Sub btn_menu_edit_Click(sender As Object, e As EventArgs) Handles btn_menu_edit_pt.Click
        Editar()
    End Sub

    Private Sub btn_menu_del_Click(sender As Object, e As EventArgs) Handles btn_menu_del_pt.Click
        Excluir()
    End Sub

    Private Sub btn_menu_relat_pt_Click(sender As Object, e As EventArgs) Handles btn_menu_relat_pt.Click

    End Sub

    'Funcionalidade dos botões
    Private Sub BotoesEstiloInicio()
        btn_menu_add_pt.Visible = True
        btn_menu_save_pt.Visible = False
        btn_menu_edit_pt.Visible = False
        btn_menu_clean_pt.Visible = False
        btn_menu_del_pt.Visible = False
        btn_menu_relat_pt.Visible = False
    End Sub

    Private Sub BotoesEstiloNovo()
        btn_menu_add_pt.Visible = False
        btn_menu_save_pt.Visible = True
        btn_menu_edit_pt.Visible = False
        btn_menu_clean_pt.Visible = True
        btn_menu_del_pt.Visible = False
        btn_menu_relat_pt.Visible = False
    End Sub

    Private Sub BotoesEstiloEditar()
        btn_menu_add_pt.Visible = False
        btn_menu_save_pt.Visible = False
        btn_menu_edit_pt.Visible = True
        btn_menu_clean_pt.Visible = True
        btn_menu_del_pt.Visible = True
        btn_menu_relat_pt.Visible = False
    End Sub

#End Region

#Region "SALVAR"

    Private Sub Salvar()
        'Tratamento de erros durante o desenvolvimento do sistema
        Try
            'Abrindo a conexão
            Abrir()

            'Programando edição de registro no banco de dados
            Dim command As MySqlCommand
            Dim sql As String

            'Inserir dados em uma planilha no banco de dados
            sql = "INSERT INTO pagadores (cnpj, rasaosocial, endereco, cidade, estado, cep, email, telefone, site, obs) VALUES ('" & tb_cnpj.Text & "', '" & tb_rasaosocial.Text & "', '" & tb_endereco.Text & "', '" & tb_cidade.Text & "', '" & cb_estado.Text & "', '" & tb_cep.Text & "', '" & tb_email.Text & "', '" & tb_telefone.Text & "', '" & tb_site.Text & "', '" & tb_obs.Text & "')"

            command = New MySqlCommand(sql, conexaodados)
            command.ExecuteNonQuery()

            MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvos")

            Limpar()
            BotoesEstiloInicio()
            Desabilitar()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! ERRO: " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try
    End Sub

#End Region

#Region "EDITAR"

    Private Sub Editar()
        'Tratamento de erros durante o desenvolvimento do sistema
        Try
            'Abrindo a conexão
            Abrir()

            'Programando edição de registro no banco de dados
            Dim command As MySqlCommand
            Dim sql As String

            'Inserir dados em uma planilha no banco de dados
            sql = "UPDATE  pagadores SET cnpj = '" & tb_cnpj.Text & "', rasaosocial = '" & tb_rasaosocial.Text & "', endereco = '" & tb_endereco.Text & "', cidade = '" & tb_cidade.Text & "', estado = '" & cb_estado.SelectedValue & "', cep = '" & tb_cep.Text & "', email = '" & tb_email.Text & "', telefone = '" & tb_telefone.Text & "', site = '" & tb_site.Text & "', obs = '" & tb_obs.Text & "' WHERE id = '" & tb_id.Text & "'"

            command = New MySqlCommand(sql, conexaodados)
            command.ExecuteNonQuery()

            MsgBox("Editado com Sucesso!!", MsgBoxStyle.Information, "Dados Editados")

            Limpar()
            BotoesEstiloInicio()
            Desabilitar()

        Catch ex As Exception
            MsgBox("Erro ao Editar!! ERRO: " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try

    End Sub

#End Region

#Region "EXCLUIR"

    Private Sub Excluir()
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
                sql = "DELETE FROM pagadores WHERE id = '" & tb_id.Text & "'"

                command = New MySqlCommand(sql, conexaodados)
                command.ExecuteNonQuery()

                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Excluidos")

                Limpar()
                BotoesEstiloInicio()
                Desabilitar()

            Catch ex As Exception
                MsgBox("Erro ao Excluir!! ERRO: " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
            End Try

        End If

    End Sub

#End Region

#Region "LIMPAR"

    Private Sub Limpar()

        tb_id.Text = ""
        tb_cnpj.Text = ""
        tb_rasaosocial.Text = ""
        tb_endereco.Text = ""
        tb_cidade.Text = ""
        cb_estado.Text = ""
        tb_cep.Text = ""
        tb_email.Text = ""
        tb_telefone.Text = ""
        tb_site.Text = ""
        tb_obs.Text = ""

    End Sub

#End Region

#Region "HABILITAR"

    Private Sub Habilitar()

        'Botões
        If btn_menu_add_pt.Visible = True Then
            btn_menu_add_cz.Visible = False
        Else
            btn_menu_add_cz.Visible = True
        End If

        If btn_menu_save_pt.Visible = True Then
            btn_menu_save_cz.Visible = False
        Else
            btn_menu_save_cz.Visible = True
        End If

        If btn_menu_edit_pt.Visible = True Then
            btn_menu_edit_cz.Visible = False
        Else
            btn_menu_edit_cz.Visible = True
        End If

        If btn_menu_clean_pt.Visible = True Then
            btn_menu_clean_cz.Visible = False
        Else
            btn_menu_clean_cz.Visible = True
        End If

        If btn_menu_del_pt.Visible = True Then
            btn_menu_del_cz.Visible = False
        Else
            btn_menu_del_cz.Visible = True
        End If

        If btn_menu_relat_pt.Visible = True Then
            btn_menu_relat_cz.Visible = False
        Else
            btn_menu_relat_cz.Visible = True
        End If

        'Caixas de texto
        'tb_id.Enabled = True
        tb_cnpj.Enabled = True
        tb_rasaosocial.Enabled = True
        tb_endereco.Enabled = True
        tb_cidade.Enabled = True
        cb_estado.Enabled = True
        tb_cep.Enabled = True
        tb_email.Enabled = True
        tb_telefone.Enabled = True
        tb_site.Enabled = True
        tb_obs.Enabled = True

        'Cor do fundo
        tb_id.BackColor = Color.Salmon
        tb_cnpj.BackColor = Color.Salmon
        tb_rasaosocial.BackColor = Color.Salmon
        tb_endereco.BackColor = Color.Salmon
        tb_cidade.BackColor = Color.Salmon
        cb_estado.BackColor = Color.Salmon
        tb_cep.BackColor = Color.Salmon
        tb_email.BackColor = Color.Salmon
        tb_telefone.BackColor = Color.Salmon
        tb_site.BackColor = Color.Salmon
        tb_obs.BackColor = Color.Salmon

    End Sub

#End Region

#Region "DESABILITAR"

    Private Sub Desabilitar()

        'Botões
        If btn_menu_add_pt.Visible = True Then
            btn_menu_add_cz.Visible = False
        Else
            btn_menu_add_cz.Visible = True
        End If

        If btn_menu_save_pt.Visible = True Then
            btn_menu_save_cz.Visible = False
        Else
            btn_menu_save_cz.Visible = True
        End If

        If btn_menu_edit_pt.Visible = True Then
            btn_menu_edit_cz.Visible = False
        Else
            btn_menu_edit_cz.Visible = True
        End If

        If btn_menu_clean_pt.Visible = True Then
            btn_menu_clean_cz.Visible = False
        Else
            btn_menu_clean_cz.Visible = True
        End If

        If btn_menu_del_pt.Visible = True Then
            btn_menu_del_cz.Visible = False
        Else
            btn_menu_del_cz.Visible = True
        End If

        If btn_menu_relat_pt.Visible = True Then
            btn_menu_relat_cz.Visible = False
        Else
            btn_menu_relat_cz.Visible = True
        End If

        'Caixas de texto
        'tb_id.Enabled = False
        tb_cnpj.Enabled = False
        tb_rasaosocial.Enabled = False
        tb_endereco.Enabled = False
        tb_cidade.Enabled = False
        cb_estado.Enabled = False
        tb_cep.Enabled = False
        tb_email.Enabled = False
        tb_telefone.Enabled = False
        tb_site.Enabled = False
        tb_obs.Enabled = False

        'Cor do fundo
        tb_id.BackColor = Color.LightGray
        tb_cnpj.BackColor = Color.LightGray
        tb_rasaosocial.BackColor = Color.LightGray
        tb_endereco.BackColor = Color.LightGray
        tb_cidade.BackColor = Color.LightGray
        cb_estado.BackColor = Color.LightGray
        tb_cep.BackColor = Color.LightGray
        tb_email.BackColor = Color.LightGray
        tb_telefone.BackColor = Color.LightGray
        tb_site.BackColor = Color.LightGray
        tb_obs.BackColor = Color.LightGray

    End Sub

#End Region

#Region "DATA GRID"

    Private Sub Listar()

        Try

            'Buscar informações da tabela no banco de dados e mostrar no datagrid

            'Abrir conexão
            Abrir()

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT * FROM pagadores ORDER BY rasaosocial ASC"

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

    Private Sub FormatarGrid()

        Dim FormGrid = dt_grid_form

        'Ajustar os títulos das colunas
        FormGrid.Columns(0).HeaderText = "ID"
        FormGrid.Columns(1).HeaderText = "CNPJ"
        FormGrid.Columns(2).HeaderText = "Rasão Social"
        FormGrid.Columns(3).HeaderText = "Endereço"
        FormGrid.Columns(4).HeaderText = "Cidade"
        FormGrid.Columns(5).HeaderText = "Estado"
        FormGrid.Columns(6).HeaderText = "CEP"
        FormGrid.Columns(7).HeaderText = "E-mail"
        FormGrid.Columns(8).HeaderText = "Telefone"
        FormGrid.Columns(9).HeaderText = "Site"
        FormGrid.Columns(10).HeaderText = "Observações"

    End Sub

    Private Sub dt_grid_form_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_form.CellClick

        Limpar()
        BotoesEstiloEditar()
        Habilitar()

        Dim FormGrid = dt_grid_form

        tb_id.Text = FormGrid.CurrentRow.Cells(0).Value
        tb_cnpj.Text = FormGrid.CurrentRow.Cells(1).Value
        tb_rasaosocial.Text = FormGrid.CurrentRow.Cells(2).Value
        tb_endereco.Text = FormGrid.CurrentRow.Cells(3).Value
        tb_cidade.Text = FormGrid.CurrentRow.Cells(4).Value
        cb_estado.Text = FormGrid.CurrentRow.Cells(5).Value
        tb_cep.Text = FormGrid.CurrentRow.Cells(6).Value
        tb_email.Text = FormGrid.CurrentRow.Cells(7).Value
        tb_telefone.Text = FormGrid.CurrentRow.Cells(8).Value
        tb_site.Text = FormGrid.CurrentRow.Cells(9).Value
        tb_obs.Text = FormGrid.CurrentRow.Cells(10).Value

    End Sub

#End Region

#Region "DICAS"

    Private Sub Dicas()

        'Exibe janelas de ajuda
        Dim toolTip As New ToolTip With {
            .AutoPopDelay = 5000,   ' Define o delay para a ToolTip.
            .InitialDelay = 100,
            .ReshowDelay = 100,
            .ShowAlways = True      ' Força a o texto da ToolTip a ser exibido mesmo que o form não esta ativo
        }

        ' Define o texto da ToolTip para o Button, TextBox, Checkbox e Label
        toolTip.SetToolTip(Me.btn_menu_add_pt, "Botão para habilitar os campos.")
        toolTip.SetToolTip(Me.btn_menu_save_pt, "Botão para Salvar um novo registro.")
        toolTip.SetToolTip(Me.btn_menu_edit_pt, "Botão para Editar um registro existente.")
        toolTip.SetToolTip(Me.btn_menu_clean_pt, "Botão para Limpar todos os campos.")
        toolTip.SetToolTip(Me.btn_menu_del_pt, "Botão para Deletar um registro.")
        toolTip.SetToolTip(Me.btn_menu_relat_pt, "Botão para emitir um relatório.")

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