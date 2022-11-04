Imports MySql.Data.MySqlClient

Public Class cad_gasto_mes

    Private Sub cad_gasto_mes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dicas()
        Limpar()
        BotoesEstiloInicio()
        Desabilitar()
        Listar()

    End Sub

    Private Sub cad_documentos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

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

            Dim dataRegistro = dt_data.Value.ToString("yyyy-MM-dd")

            'Inserir dados em uma planilha no banco de dados
            sql = "INSERT INTO gastos (id_pessoa, data, id_identificacao, valor, liquido, tipo, ir, inss, descontos, multa, obs) VALUES ('" & cb_id_pessoa.SelectedValue & "', '" & dataRegistro & "', '" & cb_id_identificacao.SelectedValue & "', '" & tb_valor.Text.Replace(",", ".") & "', '" & tb_liquido.Text.Replace(",", ".") & "', '" & cb_tipo.Text & "', '" & tb_ir.Text.Replace(",", ".") & "', '" & tb_inss.Text.Replace(",", ".") & "', '" & tb_descontos.Text.Replace(",", ".") & "', '" & tb_multa.Text.Replace(",", ".") & "', '" & tb_obs.Text & "')"

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

            Dim dataRegistro = dt_data.Value.ToString("yyyy-MM-dd")

            'Inserir dados em uma planilha no banco de dados
            sql = "UPDATE  gastos SET id_pessoa = '" & cb_id_pessoa.SelectedValue & "', data = '" & dt_data.Text & "', id_identificacao = '" & cb_id_identificacao.SelectedValue & "', valor = '" & tb_valor.Text.Replace(",", ".") & "', liquido = '" & tb_liquido.Text.Replace(",", ".") & "', tipo = '" & cb_tipo.SelectedValue & "', ir = '" & tb_ir.Text.Replace(",", ".") & "', inss = '" & tb_inss.Text.Replace(",", ".") & "', descontos = '" & tb_descontos.Text.Replace(",", ".") & "', multa = '" & tb_multa.Text.Replace(",", ".") & "', obs = '" & tb_obs.Text & "' WHERE id = '" & tb_id.Text & "'"

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
                sql = "DELETE FROM gastos WHERE id = '" & tb_id.Text & "'"

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
        cb_id_pessoa.Text = ""
        dt_data.Text = Now().ToShortDateString
        cb_id_identificacao.Text = ""
        tb_valor.Text = Format("0,00")
        tb_liquido.Text = Format("0,00")
        cb_tipo.Text = ""
        tb_ir.Text = Format("0,00")
        tb_inss.Text = Format("0,00")
        tb_descontos.Text = Format("0,00")
        tb_multa.Text = Format("0,00")
        tb_obs.Text = ""

    End Sub

#End Region

#Region "HABILITAR"

    Private Sub Habilitar()

        CarregarNomes()

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

        'RadioButton
        rb_fornecedores.Enabled = True
        rb_pagadores.Enabled = True
        rb_impostos.Enabled = True
        rb_aplicacoes.Enabled = True

        'Caixas de texto
        'tb_id.Enabled = True
        cb_id_pessoa.Enabled = True
        dt_data.Enabled = True
        'cb_id_identificacao.Enabled = True
        tb_valor.Enabled = True
        'tb_liquido.Enabled = True
        cb_tipo.Enabled = True
        tb_ir.Enabled = True
        tb_inss.Enabled = True
        tb_descontos.Enabled = True
        tb_multa.Enabled = True
        tb_obs.Enabled = True

        'Cor do fundo
        cb_id_pessoa.BackColor = Color.Salmon
        dt_data.BackColor = Color.Salmon
        cb_id_identificacao.BackColor = Color.Salmon
        tb_valor.BackColor = Color.Salmon
        tb_liquido.BackColor = Color.Salmon
        cb_tipo.BackColor = Color.Salmon
        tb_ir.BackColor = Color.Salmon
        tb_inss.BackColor = Color.Salmon
        tb_descontos.BackColor = Color.Salmon
        tb_multa.BackColor = Color.Salmon
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

        'RadioButton
        rb_fornecedores.Enabled = False
        rb_pagadores.Enabled = False
        rb_impostos.Enabled = False
        rb_aplicacoes.Enabled = False
        'Checked
        rb_fornecedores.Checked = False
        rb_pagadores.Checked = False
        rb_impostos.Checked = False
        rb_aplicacoes.Checked = False

        'Caixas de texto
        'tb_id.Enabled = False
        cb_id_pessoa.Enabled = False
        dt_data.Enabled = False
        cb_id_identificacao.Enabled = False
        tb_valor.Enabled = False
        tb_liquido.Enabled = False
        cb_tipo.Enabled = False
        tb_ir.Enabled = False
        tb_inss.Enabled = False
        tb_descontos.Enabled = False
        tb_multa.Enabled = False
        tb_obs.Enabled = False

        'Cor do fundo
        tb_id.BackColor = Color.LightGray
        cb_id_pessoa.BackColor = Color.LightGray
        dt_data.BackColor = Color.LightGray
        cb_id_identificacao.BackColor = Color.LightGray
        tb_valor.BackColor = Color.LightGray
        tb_liquido.BackColor = Color.LightGray
        cb_tipo.BackColor = Color.LightGray
        tb_ir.BackColor = Color.LightGray
        tb_inss.BackColor = Color.LightGray
        tb_descontos.BackColor = Color.LightGray
        tb_multa.BackColor = Color.LightGray
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

            sql = "SELECT * FROM gastos ORDER BY data DESC"

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
        FormGrid.Columns(1).HeaderText = "Pessoa"
        FormGrid.Columns(2).HeaderText = "Data"
        FormGrid.Columns(3).HeaderText = "Descrição/Descrição"
        FormGrid.Columns(4).HeaderText = "Valor"
        FormGrid.Columns(5).HeaderText = "Total Líquido"
        FormGrid.Columns(6).HeaderText = "Tipo"
        FormGrid.Columns(7).HeaderText = "IR"
        FormGrid.Columns(8).HeaderText = "INSS"
        FormGrid.Columns(9).HeaderText = "Outros descontos"
        FormGrid.Columns(10).HeaderText = "Multa"
        FormGrid.Columns(11).HeaderText = "Observações"


        'Formatação da célula em MOEDA => R$
        FormGrid.Columns(4).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(5).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(7).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(8).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(9).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(10).DefaultCellStyle.Format = "C2"

    End Sub

    Private Sub dt_grid_form_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_form.CellClick

        Limpar()
        BotoesEstiloEditar()
        Habilitar()

        Dim FormGrid = dt_grid_form

        tb_id.Text = FormGrid.CurrentRow.Cells(0).Value
        cb_id_pessoa.SelectedValue = FormGrid.CurrentRow.Cells(1).Value
        dt_data.Text = FormGrid.CurrentRow.Cells(2).Value
        cb_id_identificacao.SelectedValue = FormGrid.CurrentRow.Cells(3).Value
        tb_valor.Text = FormGrid.CurrentRow.Cells(4).Value
        tb_liquido.Text = FormGrid.CurrentRow.Cells(5).Value
        cb_tipo.Text = FormGrid.CurrentRow.Cells(6).Value
        tb_ir.Text = FormGrid.CurrentRow.Cells(7).Value
        tb_inss.Text = FormGrid.CurrentRow.Cells(8).Value
        tb_descontos.Text = FormGrid.CurrentRow.Cells(9).Value
        tb_multa.Text = FormGrid.CurrentRow.Cells(10).Value
        tb_obs.Text = FormGrid.CurrentRow.Cells(11).Value

    End Sub

#End Region

#Region "RADIO BUTTON"

    Private Sub rb_fornecedores_CheckedChanged(sender As Object, e As EventArgs) Handles rb_fornecedores.CheckedChanged

        cb_id_identificacao.Enabled = True
        cb_id_identificacao.Text = ""

        CheckBoxIdentificacao()

    End Sub

    Private Sub rb_pagadores_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pagadores.CheckedChanged

        cb_id_identificacao.Enabled = True
        cb_id_identificacao.Text = ""

        CheckBoxIdentificacao()

    End Sub

    Private Sub rb_impostos_CheckedChanged(sender As Object, e As EventArgs) Handles rb_impostos.CheckedChanged

        cb_id_identificacao.Enabled = True
        cb_id_identificacao.Text = ""

        CheckBoxIdentificacao()

    End Sub

    Private Sub rb_aplicacoes_CheckedChanged(sender As Object, e As EventArgs) Handles rb_aplicacoes.CheckedChanged

        cb_id_identificacao.Enabled = True
        cb_id_identificacao.Text = ""

        CheckBoxIdentificacao()

    End Sub

#End Region

#Region "COMBOBOX"

    Private Sub CarregarNomes()
        'Buscar informações da tabela no banco de dados e mostrar no ComboBox
        Try
            'Abrir conexão
            Abrir()

            Dim caixaTexto = cb_id_pessoa

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT * FROM pessoa ORDER BY nome ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            If dattable.Rows.Count > 0 Then
                caixaTexto.ValueMember = "id"           'O que aparece no SelectedValue
                caixaTexto.DisplayMember = "nome"       'O que aparece no display do Combobox
                caixaTexto.DataSource = dattable        'A lista da base de dados
            Else
                caixaTexto.Text = "Insira um nome no cadastro de 'Pessoa Física'."
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try
    End Sub

    Private Sub CheckBoxIdentificacao()

        If rb_fornecedores.Checked Then
            CarregarFornecedores()
        Else
            If rb_pagadores.Checked Then
                CarregarPagadores()
            Else
                If rb_impostos.Checked Then
                    CarregarImpostos()
                Else
                    If rb_aplicacoes.Checked Then
                        CarregarAplicacoes()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub CarregarFornecedores()
        'Buscar informações da tabela no banco de dados e mostrar no ComboBox
        Try
            'Abrir conexão
            Abrir()

            Dim caixaTexto = cb_id_identificacao

            'Limpa a lista anterior 
            caixaTexto.DataSource = Nothing

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT * FROM fornecedores ORDER BY nome ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            If dattable.Rows.Count > 0 Then
                caixaTexto.ValueMember = "id"           'O que aparece no SelectedValue
                caixaTexto.DisplayMember = "nome"       'O que aparece no display do Combobox
                caixaTexto.DataSource = dattable        'A lista da base de dados
            Else
                caixaTexto.Text = "Insira um nome no cadastro de 'Fornecedores'."
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try
    End Sub

    Private Sub CarregarPagadores()
        'Buscar informações da tabela no banco de dados e mostrar no ComboBox
        Try
            'Abrir conexão
            Abrir()

            Dim caixaTexto = cb_id_identificacao

            'Limpa a lista anterior 
            caixaTexto.DataSource = Nothing

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT * FROM pagadores ORDER BY rasaosocial ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            If dattable.Rows.Count > 0 Then
                caixaTexto.ValueMember = "id"           'O que aparece no SelectedValue
                caixaTexto.DisplayMember = "rasaosocial"       'O que aparece no display do Combobox
                caixaTexto.DataSource = dattable        'A lista da base de dados
            Else
                caixaTexto.Text = "Insira um nome no cadastro de 'Pagadores'."
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try
    End Sub

    Private Sub CarregarImpostos()

    End Sub

    Private Sub CarregarAplicacoes()
        'Buscar informações da tabela no banco de dados e mostrar no ComboBox
        Try
            'Abrir conexão
            Abrir()

            Dim caixaTexto = cb_id_identificacao

            'Limpa a lista anterior 
            caixaTexto.DataSource = Nothing

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT * FROM bancos ORDER BY instituicao ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            If dattable.Rows.Count > 0 Then
                caixaTexto.ValueMember = "id"           'O que aparece no SelectedValue
                caixaTexto.DisplayMember = "instituicao"       'O que aparece no display do Combobox
                caixaTexto.DataSource = dattable        'A lista da base de dados
            Else
                caixaTexto.Text = "Insira um nome no cadastro de 'Banco'."
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try
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

#Region "CÁLCULOS"

    Private Sub calculosTotal()

        Dim valor As Decimal
        Dim ir As Decimal
        Dim inss As Decimal
        Dim desconto As Decimal
        Dim total As Decimal

        valor = tb_valor.Text
        ir = tb_ir.Text
        inss = tb_inss.Text
        desconto = tb_descontos.Text

        total = (valor - (ir + inss + desconto))
        tb_liquido.Text = Format(total, "#,##")

    End Sub

    Private Sub tb_valor_Leave(sender As Object, e As EventArgs) Handles tb_valor.Leave
        calculosTotal()
    End Sub

    Private Sub tb_ir_Leave(sender As Object, e As EventArgs) Handles tb_ir.Leave
        calculosTotal()
    End Sub

    Private Sub tb_inss_Leave(sender As Object, e As EventArgs) Handles tb_inss.Leave
        calculosTotal()
    End Sub

    Private Sub tb_descontos_Leave(sender As Object, e As EventArgs) Handles tb_descontos.Leave
        calculosTotal()
    End Sub

    Private Sub tb_multa_Leave(sender As Object, e As EventArgs) Handles tb_multa.Leave
        calculosTotal()
    End Sub

#End Region




End Class