Imports MySql.Data.MySqlClient

Public Class cad_pessoa

    Private Sub cad_pessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dicas()
        Desabilitar()
        Listar()

    End Sub

    Private Sub cad_pessoa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

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
            sql = "INSERT INTO pessoa (nome, endereco, cidade, estado, cep, email, telefone, usuario, senha) VALUES ('" & tb_nome.Text & "', '" & tb_endereco.Text & "', '" & tb_cidade.Text & "', '" & tb_estado.Text & "', '" & tb_cep.Text & "', '" & tb_email.Text & "', '" & tb_fone.Text & "', '" & tb_usuario.Text & "', '" & tb_senha.Text & "')"
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
            sql = "UPDATE  pessoa SET nome =  '" & tb_nome.Text & "', endereco =  '" & tb_endereco.Text & "', cidade =  '" & tb_cidade.Text & "', estado =  '" & tb_estado.Text & "', cep =  '" & tb_cep.Text & "', email =  '" & tb_email.Text & "', telefone =  '" & tb_fone.Text & "', usuario =  '" & tb_usuario.Text & "', senha = '" & tb_senha.Text & "'   WHERE id =  '" & tb_id.Text & "'"
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
                sql = "DELETE FROM pessoa WHERE id = '" & tb_id.Text & "'"
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
        tb_nome.Text = ""
        tb_endereco.Text = ""
        tb_cidade.Text = ""
        tb_id.Text = ""
        tb_nome.Text = ""
        tb_endereco.Text = ""
        tb_cidade.Text = ""
        tb_estado.Text = ""
        tb_cep.Text = ""
        tb_email.Text = ""
        tb_fone.Text = ""
        tb_usuario.Text = ""
        tb_senha.Text = ""

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
        tb_nome.Enabled = True
        tb_endereco.Enabled = True
        tb_cidade.Enabled = True
        tb_id.Enabled = True
        tb_nome.Enabled = True
        tb_endereco.Enabled = True
        tb_cidade.Enabled = True
        tb_estado.Enabled = True
        tb_cep.Enabled = True
        tb_email.Enabled = True
        tb_fone.Enabled = True
        tb_usuario.Enabled = True
        tb_senha.Enabled = True

        'Cor do fundo
        tb_id.BackColor = Color.Salmon
        tb_nome.BackColor = Color.Salmon
        tb_endereco.BackColor = Color.Salmon
        tb_cidade.BackColor = Color.Salmon
        tb_id.BackColor = Color.Salmon
        tb_nome.BackColor = Color.Salmon
        tb_endereco.BackColor = Color.Salmon
        tb_cidade.BackColor = Color.Salmon
        tb_estado.BackColor = Color.Salmon
        tb_cep.BackColor = Color.Salmon
        tb_email.BackColor = Color.Salmon
        tb_fone.BackColor = Color.Salmon
        tb_usuario.BackColor = Color.Salmon
        tb_senha.BackColor = Color.Salmon

        'Imagens dos botões
        'btn_menu_add.Image = My.Resources.icon_add_pt
        'btn_menu_save.Image = My.Resources.icon_save_pt
        'btn_menu_edit.Image = My.Resources.icon_edit_pt
        'btn_menu_clean.Image = My.Resources.icon_clean_pt
        'btn_menu_del.Image = My.Resources.icon_delet_pt
        'btn_menu_relat.Image = My.Resources.icon_print_cz

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
        tb_nome.Enabled = False
        tb_endereco.Enabled = False
        tb_cidade.Enabled = False
        tb_id.Enabled = False
        tb_nome.Enabled = False
        tb_endereco.Enabled = False
        tb_cidade.Enabled = False
        tb_estado.Enabled = False
        tb_cep.Enabled = False
        tb_email.Enabled = False
        tb_fone.Enabled = False
        tb_usuario.Enabled = False
        tb_senha.Enabled = False

        'Cor do fundo
        tb_id.BackColor = Color.LightGray
        tb_nome.BackColor = Color.LightGray
        tb_endereco.BackColor = Color.LightGray
        tb_cidade.BackColor = Color.LightGray
        tb_id.BackColor = Color.LightGray
        tb_nome.BackColor = Color.LightGray
        tb_endereco.BackColor = Color.LightGray
        tb_cidade.BackColor = Color.LightGray
        tb_estado.BackColor = Color.LightGray
        tb_cep.BackColor = Color.LightGray
        tb_email.BackColor = Color.LightGray
        tb_fone.BackColor = Color.LightGray
        tb_usuario.BackColor = Color.LightGray
        tb_senha.BackColor = Color.LightGray

        'Imagens dos botões
        'btn_menu_add.Image = My.Resources.icon_add_pt
        ''btn_menu_add.Image = My.Resources.icon_add_cz
        'btn_menu_save.Image = My.Resources.icon_save_cz
        'btn_menu_edit.Image = My.Resources.icon_edit_cz
        'btn_menu_clean.Image = My.Resources.icon_clean_cz
        'btn_menu_del.Image = My.Resources.icon_delet_cz
        'btn_menu_relat.Image = My.Resources.icon_print_cz

        'btn_menu_add.BackgroundImageLayout = ImageLayout.Zoom
        'btn_menu_save.BackgroundImageLayout = ImageLayout.Zoom
        'btn_menu_save.AutoSize = PictureBoxSizeMode.Zoom

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

            sql = "SELECT * FROM pessoa ORDER BY nome ASC"

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
        FormGrid.Columns(1).HeaderText = "Nome"
        FormGrid.Columns(2).HeaderText = "Endereço"
        FormGrid.Columns(3).HeaderText = "Cidade"
        FormGrid.Columns(4).HeaderText = "Estado"
        FormGrid.Columns(5).HeaderText = "CEP"
        FormGrid.Columns(6).HeaderText = "E-mail"
        FormGrid.Columns(7).HeaderText = "Telefone"
        FormGrid.Columns(8).HeaderText = "Usuário"
        FormGrid.Columns(9).HeaderText = "Senha"

    End Sub

    Private Sub dt_grid_form_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_form.CellClick

        Habilitar()

        btn_menu_save.Enabled = False

        Dim FormGrid = dt_grid_form

        tb_id.Text = FormGrid.CurrentRow.Cells(0).Value
        tb_nome.Text = FormGrid.CurrentRow.Cells(1).Value
        tb_endereco.Text = FormGrid.CurrentRow.Cells(2).Value
        tb_cidade.Text = FormGrid.CurrentRow.Cells(3).Value
        tb_estado.Text = FormGrid.CurrentRow.Cells(4).Value
        tb_cep.Text = FormGrid.CurrentRow.Cells(5).Value
        tb_email.Text = FormGrid.CurrentRow.Cells(6).Value
        tb_fone.Text = FormGrid.CurrentRow.Cells(7).Value
        tb_usuario.Text = FormGrid.CurrentRow.Cells(8).Value
        tb_senha.Text = FormGrid.CurrentRow.Cells(9).Value

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
