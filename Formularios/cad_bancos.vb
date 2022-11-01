Imports MySql.Data.MySqlClient

Public Class cad_bancos

    Private Sub cad_bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            sql = "INSERT INTO bancos (cod, instituicao, cnpj, agencia, conta, operacao, tipo) VALUES ('" & tb_cod.Text & "', '" & tb_instituicao.Text & "', '" & tb_cnpj.Text & "', '" & tb_agencia.Text & "', '" & tb_conta.Text & "', '" & tb_operacao.Text & "', '" & cb_tipo.Text & "')"
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
            sql = "UPDATE  bancos SET cod =  '" & tb_cod.Text & "', instituicao =  '" & tb_instituicao.Text & "', cnpj =  '" & tb_cnpj.Text & "', agencia =  '" & tb_agencia.Text & "', conta =  '" & tb_conta.Text & "', operacao =  '" & tb_operacao.Text & "', tipo =  '" & cb_tipo.Text & "' WHERE id =  '" & tb_id.Text & "'"
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
                sql = "DELETE FROM bancos WHERE id = '" & tb_id.Text & "'"
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
        tb_cod.Text = ""
        tb_instituicao.Text = ""
        tb_cnpj.Text = ""
        tb_agencia.Text = ""
        tb_conta.Text = ""
        tb_operacao.Text = ""
        cb_tipo.Text = ""

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
        tb_cod.Enabled = True
        tb_instituicao.Enabled = True
        tb_cnpj.Enabled = True
        tb_agencia.Enabled = True
        tb_conta.Enabled = True
        tb_operacao.Enabled = True
        cb_tipo.Enabled = True

        'Cor do fundo
        tb_id.BackColor = Color.Salmon
        tb_cod.BackColor = Color.Salmon
        tb_instituicao.BackColor = Color.Salmon
        tb_cnpj.BackColor = Color.Salmon
        tb_agencia.BackColor = Color.Salmon
        tb_conta.BackColor = Color.Salmon
        tb_operacao.BackColor = Color.Salmon
        cb_tipo.BackColor = Color.Salmon

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
        tb_cod.Enabled = False
        tb_instituicao.Enabled = False
        tb_cnpj.Enabled = False
        tb_agencia.Enabled = False
        tb_conta.Enabled = False
        tb_operacao.Enabled = False
        cb_tipo.Enabled = False

        'Cor do fundo
        tb_id.BackColor = Color.LightGray
        tb_cod.BackColor = Color.LightGray
        tb_instituicao.BackColor = Color.LightGray
        tb_cnpj.BackColor = Color.LightGray
        tb_agencia.BackColor = Color.LightGray
        tb_conta.BackColor = Color.LightGray
        tb_operacao.BackColor = Color.LightGray
        cb_tipo.BackColor = Color.LightGray

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

            sql = "SELECT * FROM bancos ORDER BY instituicao ASC"

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
        FormGrid.Columns(1).HeaderText = "Código"
        FormGrid.Columns(2).HeaderText = "Instituição"
        FormGrid.Columns(3).HeaderText = "CNPJ"
        FormGrid.Columns(4).HeaderText = "Agência"
        FormGrid.Columns(5).HeaderText = "Conta"
        FormGrid.Columns(6).HeaderText = "Operação"
        FormGrid.Columns(7).HeaderText = "Tipo"

    End Sub

    Private Sub dt_grid_form_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_form.CellClick

        Habilitar()

        btn_menu_save.Enabled = False

        Dim FormGrid = dt_grid_form

        tb_id.Text = FormGrid.CurrentRow.Cells(0).Value
        tb_cod.Text = FormGrid.CurrentRow.Cells(1).Value
        tb_instituicao.Text = FormGrid.CurrentRow.Cells(2).Value
        tb_cnpj.Text = FormGrid.CurrentRow.Cells(3).Value
        tb_agencia.Text = FormGrid.CurrentRow.Cells(4).Value
        tb_conta.Text = FormGrid.CurrentRow.Cells(5).Value
        tb_operacao.Text = FormGrid.CurrentRow.Cells(6).Value
        cb_tipo.Text = FormGrid.CurrentRow.Cells(7).Value

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