Imports MySql.Data.MySqlClient

Public Class cad_aplicacoes

    Private Sub cad_aplicacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dicas()
        Limpar()
        BotoesEstiloInicio()
        Desabilitar()
        Listar()

    End Sub

    Private Sub cad_aplicacoes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Dicas()
        Limpar()
        BotoesEstiloInicio()
        Desabilitar()
        Listar()

    End Sub

#Region "BOTÕES"

    'Ações dos botões primários
    Private Sub btn_menu_add_Click(sender As Object, e As EventArgs) Handles btn_menu_add_pt.Click
        Limpar()
        BotoesEstiloNovo()
        Habilitar()
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
    Sub BotoesEstiloInicio()
        btn_menu_add_pt.Visible = True
        btn_menu_save_pt.Visible = False
        btn_menu_edit_pt.Visible = False
        btn_menu_clean_pt.Visible = False
        btn_menu_del_pt.Visible = False
        btn_menu_relat_pt.Visible = False
    End Sub

    Sub BotoesEstiloNovo()
        btn_menu_add_pt.Visible = False
        btn_menu_save_pt.Visible = True
        btn_menu_edit_pt.Visible = False
        btn_menu_clean_pt.Visible = True
        btn_menu_del_pt.Visible = False
        btn_menu_relat_pt.Visible = False
    End Sub

    Sub BotoesEstiloEditar()
        btn_menu_add_pt.Visible = False
        btn_menu_save_pt.Visible = False
        btn_menu_edit_pt.Visible = True
        btn_menu_clean_pt.Visible = True
        btn_menu_del_pt.Visible = True
        btn_menu_relat_pt.Visible = False
    End Sub

#End Region

#Region "SALVAR"

    Sub Salvar()
        'Tratamento de erros durante o desenvolvimento do sistema
        Try
            'Abrindo a conexão
            Abrir()

            'Programando edição de registro no banco de dados
            Dim command As MySqlCommand
            Dim sql As String

            Dim dataRegistro = dt_data.Value.ToString("yyyy-MM-dd")

            'Inserir dados em uma planilha no banco de dados
            'sql = "INSERT INTO aplicacoes () VALUES ()"

            sql = "INSERT INTO aplicacoes (id_pessoa, id_instituicao, data, tipo, cod, acao, nome, quantidade, preco, total_avista, total_despesas, total_base, total_liquido, irrf_percent, irrf_taxa, darf, valor_darf, obs) VALUES ('" & cb_id_pessoa.SelectedValue & "', '" & cb_id_instituicao.SelectedValue & "', '" & dataRegistro & "', '" & cb_tipo.SelectedValue & "', '" & tb_cod.Text & "', '" & tb_acao.Text & "', '" & tb_nome.Text & "', '" & tb_quantidade.Text & "', '" & tb_preco.Text & "', '" & tb_total_avista.Text & "', '" & tb_total_despesas.Text & "', '" & tb_total_base.Text & "', '" & tb_total_liquido.Text & "', '" & tb_irrf_percent.Text & "', '" & tb_irrf_taxa.Text & "', '" & cb_darf.SelectedValue & "', '" & tb_valor_darf.Text & "', '" & tb_obs.Text & "')"

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

    Sub Editar()
        'Tratamento de erros durante o desenvolvimento do sistema
        Try
            'Abrindo a conexão
            Abrir()

            'Programando edição de registro no banco de dados
            Dim command As MySqlCommand
            Dim sql As String

            Dim dataRegistro = dt_data.Value.ToString("yyyy-MM-dd")

            'Inserir dados em uma planilha no banco de dados
            sql = "UPDATE  aplicacoes SET id_pessoa	=	'" & cb_id_pessoa.SelectedValue & "', id_instituicao	=	'" & cb_id_instituicao.SelectedValue & "', data	=	'" & dataRegistro & "', tipo	=	'" & cb_tipo.SelectedValue & "', cod	=	'" & tb_cod.Text & "', acao	=	'" & tb_acao.Text & "', nome	=	'" & tb_nome.Text & "', quantidade	=	'" & tb_quantidade.Text & "', preco	=	'" & tb_preco.Text.Replace(",", ".") & "', total_avista	=	'" & tb_total_avista.Text.Replace(",", ".") & "', total_despesas	=	'" & tb_total_despesas.Text.Replace(",", ".") & "', total_base	=	'" & tb_total_base.Text.Replace(",", ".") & "', total_liquido	=	'" & tb_total_liquido.Text.Replace(",", ".") & "', irrf_percent	=	'" & tb_irrf_percent.Text & "', irrf_taxa	=	'" & tb_irrf_taxa.Text.Replace(",", ".") & "', darf	=	'" & cb_darf.SelectedValue & "', valor_darf	=	'" & tb_valor_darf.Text.Replace(",", ".") & "', obs	=	'" & tb_obs.Text & "' WHERE id =  '" & tb_id.Text & "'"

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

    Sub Excluir()
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
                sql = "DELETE FROM aplicacoes WHERE id = '" & tb_id.Text & "'"
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

    Sub Limpar()

        tb_id.Text = ""
        cb_id_pessoa.SelectedValue = ""
        cb_id_instituicao.SelectedValue = ""
        dt_data.Text = Now().ToShortDateString
        cb_tipo.SelectedValue = ""
        tb_cod.Text = ""
        tb_acao.Text = ""
        tb_nome.Text = ""
        tb_quantidade.Text = "0"
        tb_preco.Text = Format("0,00")
        tb_total_avista.Text = Format("0,00")
        tb_total_despesas.Text = Format("0,00")
        tb_total_base.Text = Format("0,00")
        tb_total_liquido.Text = Format("0,00")
        tb_irrf_percent.Text = "20"
        tb_irrf_taxa.Text = Format("0,00")
        cb_darf.SelectedValue = ""
        tb_valor_darf.Text = Format("0,00")
        tb_obs.Text = ""

    End Sub

#End Region

#Region "HABILITAR"

    Sub Habilitar()

        CarregarNomes()
        CarregarInstituicoes()

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
        cb_id_pessoa.Enabled = True
        cb_id_instituicao.Enabled = True
        dt_data.Enabled = True
        cb_tipo.Enabled = True
        tb_cod.Enabled = True
        tb_acao.Enabled = True
        tb_nome.Enabled = True
        tb_quantidade.Enabled = True
        tb_preco.Enabled = True
        tb_total_avista.Enabled = True
        tb_total_despesas.Enabled = True
        tb_total_base.Enabled = True
        tb_total_liquido.Enabled = True
        tb_irrf_percent.Enabled = True
        tb_irrf_taxa.Enabled = True
        cb_darf.Enabled = True
        tb_valor_darf.Enabled = True
        tb_obs.Enabled = True

        'Cor do fundo
        tb_id.BackColor = Color.Salmon
        cb_id_pessoa.BackColor = Color.Salmon
        cb_id_instituicao.BackColor = Color.Salmon
        dt_data.BackColor = Color.Salmon
        cb_tipo.BackColor = Color.Salmon
        tb_cod.BackColor = Color.Salmon
        tb_acao.BackColor = Color.Salmon
        tb_nome.BackColor = Color.Salmon
        tb_quantidade.BackColor = Color.Salmon
        tb_preco.BackColor = Color.Salmon
        tb_total_avista.BackColor = Color.Salmon
        tb_total_despesas.BackColor = Color.Salmon
        tb_total_base.BackColor = Color.Salmon
        tb_total_liquido.BackColor = Color.Salmon
        tb_irrf_percent.BackColor = Color.Salmon
        tb_irrf_taxa.BackColor = Color.Salmon
        cb_darf.BackColor = Color.Salmon
        tb_valor_darf.BackColor = Color.Salmon
        tb_obs.BackColor = Color.Salmon

    End Sub

#End Region

#Region "DESABILITAR"

    Sub Desabilitar()

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
        cb_id_pessoa.Enabled = False
        cb_id_instituicao.Enabled = False
        dt_data.Enabled = False
        cb_tipo.Enabled = False
        tb_cod.Enabled = False
        tb_acao.Enabled = False
        tb_nome.Enabled = False
        tb_quantidade.Enabled = False
        tb_preco.Enabled = False
        tb_total_avista.Enabled = False
        tb_total_despesas.Enabled = False
        tb_total_base.Enabled = False
        tb_total_liquido.Enabled = False
        tb_irrf_percent.Enabled = False
        tb_irrf_taxa.Enabled = False
        cb_darf.Enabled = False
        tb_valor_darf.Enabled = False
        tb_obs.Enabled = False


        'Cor do fundo
        tb_id.BackColor = Color.LightGray
        cb_id_pessoa.BackColor = Color.LightGray
        cb_id_instituicao.BackColor = Color.LightGray
        dt_data.BackColor = Color.LightGray
        cb_tipo.BackColor = Color.LightGray
        tb_cod.BackColor = Color.LightGray
        tb_acao.BackColor = Color.LightGray
        tb_nome.BackColor = Color.LightGray
        tb_quantidade.BackColor = Color.LightGray
        tb_preco.BackColor = Color.LightGray
        tb_total_avista.BackColor = Color.LightGray
        tb_total_despesas.BackColor = Color.LightGray
        tb_total_base.BackColor = Color.LightGray
        tb_total_liquido.BackColor = Color.LightGray
        tb_irrf_percent.BackColor = Color.LightGray
        tb_irrf_taxa.BackColor = Color.LightGray
        cb_darf.BackColor = Color.LightGray
        tb_valor_darf.BackColor = Color.LightGray
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

            sql = "SELECT * FROM aplicacoes ORDER BY data DESC"

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
        FormGrid.Columns(2).HeaderText = "Instituição"
        FormGrid.Columns(3).HeaderText = "Data"
        FormGrid.Columns(4).HeaderText = "Tipo"
        FormGrid.Columns(5).HeaderText = "Codigo"
        FormGrid.Columns(6).HeaderText = "Ação"
        FormGrid.Columns(7).HeaderText = "Nome"
        FormGrid.Columns(8).HeaderText = "Quant."
        FormGrid.Columns(9).HeaderText = "Preço"
        FormGrid.Columns(10).HeaderText = "Total a Vista"
        FormGrid.Columns(11).HeaderText = "Total Despesas"
        FormGrid.Columns(12).HeaderText = "Total Base"
        FormGrid.Columns(13).HeaderText = "Total Líquido"
        FormGrid.Columns(14).HeaderText = "% IRRF"
        FormGrid.Columns(15).HeaderText = "Taxa IRRF"
        FormGrid.Columns(16).HeaderText = "DARF"
        FormGrid.Columns(17).HeaderText = "Valor DARF"
        FormGrid.Columns(18).HeaderText = "Obs"

        'Formatação da célula em MOEDA => R$
        FormGrid.Columns(9).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(10).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(11).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(12).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(13).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(15).DefaultCellStyle.Format = "C2"
        FormGrid.Columns(17).DefaultCellStyle.Format = "C2"

    End Sub

    Private Sub dt_grid_form_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_form.CellClick

        Limpar()
        BotoesEstiloEditar()
        Habilitar()

        Dim FormGrid = dt_grid_form

        tb_id.Text = FormGrid.CurrentRow.Cells(0).Value
        cb_id_pessoa.SelectedValue = FormGrid.CurrentRow.Cells(1).Value
        cb_id_instituicao.SelectedValue = FormGrid.CurrentRow.Cells(2).Value
        dt_data.Text = FormGrid.CurrentRow.Cells(3).Value
        cb_tipo.SelectedValue = FormGrid.CurrentRow.Cells(4).Value
        tb_cod.Text = FormGrid.CurrentRow.Cells(5).Value
        tb_acao.Text = FormGrid.CurrentRow.Cells(6).Value
        tb_nome.Text = FormGrid.CurrentRow.Cells(7).Value
        tb_quantidade.Text = FormGrid.CurrentRow.Cells(8).Value
        tb_preco.Text = FormGrid.CurrentRow.Cells(9).Value
        tb_total_avista.Text = FormGrid.CurrentRow.Cells(10).Value
        tb_total_despesas.Text = FormGrid.CurrentRow.Cells(11).Value
        tb_total_base.Text = FormGrid.CurrentRow.Cells(12).Value
        tb_total_liquido.Text = FormGrid.CurrentRow.Cells(13).Value
        tb_irrf_percent.Text = FormGrid.CurrentRow.Cells(14).Value
        tb_irrf_taxa.Text = FormGrid.CurrentRow.Cells(15).Value
        cb_darf.SelectedValue = FormGrid.CurrentRow.Cells(16).Value
        tb_valor_darf.Text = FormGrid.CurrentRow.Cells(17).Value
        tb_obs.Text = FormGrid.CurrentRow.Cells(18).Value

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



    Private Sub CarregarNomes()
        'Buscar informações da tabela no banco de dados e mostrar no ComboBox
        Try
            'Abrir conexão
            Abrir()

            'Dim caixaTexto = cb_id_pessoa

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT nome FROM pessoa ORDER BY nome ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            If dattable.Rows.Count > 0 Then
                cb_id_pessoa.ValueMember = "id"
                cb_id_pessoa.DisplayMember = "nome"
                cb_id_pessoa.DataSource = dattable
            Else
                cb_id_pessoa.Text = "Insira um nome no cadastro de 'Pessoa Física'."
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try

    End Sub

    Private Sub CarregarInstituicoes()
        'Buscar informações da tabela no banco de dados e mostrar no ComboBox
        Try
            'Abrir conexão
            Abrir()

            'Dim caixaTexto = cb_id_instituicao

            Dim sql As String
            Dim dattable As New DataTable
            Dim datadapter As MySqlDataAdapter

            sql = "SELECT instituicao FROM bancos ORDER BY instituicao ASC"

            datadapter = New MySqlDataAdapter(sql, conexaodados)
            datadapter.Fill(dattable)

            If dattable.Rows.Count > 0 Then
                cb_id_instituicao.ValueMember = "id"
                cb_id_instituicao.DisplayMember = "instituicao"
                cb_id_instituicao.DataSource = dattable
            Else
                cb_id_instituicao.Text = "Insira uma instituicao no cadastro de 'Bancos'."
            End If

        Catch ex As Exception
            MsgBox("Erro ao mostrar dados no grid!! ERRO! " + ex.Message, MsgBoxStyle.Information, "Erro de processamento!")
        End Try

    End Sub




End Class