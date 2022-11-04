<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_bancos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_bancos))
        Me.tb_cod = New System.Windows.Forms.TextBox()
        Me.lb_codigo = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.dt_grid_form = New System.Windows.Forms.DataGridView()
        Me.tb_instituicao = New System.Windows.Forms.TextBox()
        Me.lb_instituicao = New System.Windows.Forms.Label()
        Me.tb_cnpj = New System.Windows.Forms.TextBox()
        Me.lb_cnpj = New System.Windows.Forms.Label()
        Me.tb_agencia = New System.Windows.Forms.TextBox()
        Me.lb_agencia = New System.Windows.Forms.Label()
        Me.tb_conta = New System.Windows.Forms.TextBox()
        Me.lb_operacao = New System.Windows.Forms.Label()
        Me.tb_operacao = New System.Windows.Forms.TextBox()
        Me.lb_conta = New System.Windows.Forms.Label()
        Me.lb_tipo = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.btn_menu_home = New System.Windows.Forms.ToolStripButton()
        Me.btn_menu_close = New System.Windows.Forms.ToolStripButton()
        Me.form_menu = New System.Windows.Forms.ToolStrip()
        Me.btn_menu_edit_pt = New System.Windows.Forms.Button()
        Me.btn_menu_save_pt = New System.Windows.Forms.Button()
        Me.btn_menu_relat_pt = New System.Windows.Forms.Button()
        Me.btn_menu_del_pt = New System.Windows.Forms.Button()
        Me.btn_menu_clean_pt = New System.Windows.Forms.Button()
        Me.btn_menu_add_pt = New System.Windows.Forms.Button()
        Me.btn_menu_edit_cz = New System.Windows.Forms.Button()
        Me.btn_menu_save_cz = New System.Windows.Forms.Button()
        Me.btn_menu_relat_cz = New System.Windows.Forms.Button()
        Me.btn_menu_del_cz = New System.Windows.Forms.Button()
        Me.btn_menu_clean_cz = New System.Windows.Forms.Button()
        Me.btn_menu_add_cz = New System.Windows.Forms.Button()
        CType(Me.dt_grid_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.form_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_cod
        '
        Me.tb_cod.BackColor = System.Drawing.Color.Salmon
        Me.tb_cod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cod.Enabled = False
        Me.tb_cod.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cod.ForeColor = System.Drawing.Color.Snow
        Me.tb_cod.Location = New System.Drawing.Point(513, 196)
        Me.tb_cod.MaxLength = 45
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(81, 19)
        Me.tb_cod.TabIndex = 37
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(444, 196)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(63, 19)
        Me.lb_codigo.TabIndex = 36
        Me.lb_codigo.Text = "Código"
        Me.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_id
        '
        Me.tb_id.BackColor = System.Drawing.Color.Salmon
        Me.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_id.Enabled = False
        Me.tb_id.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.Snow
        Me.tb_id.Location = New System.Drawing.Point(32, 302)
        Me.tb_id.MaxLength = 20
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(97, 19)
        Me.tb_id.TabIndex = 40
        '
        'dt_grid_form
        '
        Me.dt_grid_form.AllowUserToAddRows = False
        Me.dt_grid_form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_grid_form.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_grid_form.BackgroundColor = System.Drawing.Color.Snow
        Me.dt_grid_form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dt_grid_form.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dt_grid_form.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dt_grid_form.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_grid_form.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dt_grid_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid_form.EnableHeadersVisualStyles = False
        Me.dt_grid_form.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dt_grid_form.Location = New System.Drawing.Point(32, 327)
        Me.dt_grid_form.MultiSelect = False
        Me.dt_grid_form.Name = "dt_grid_form"
        Me.dt_grid_form.ReadOnly = True
        Me.dt_grid_form.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dt_grid_form.RowHeadersWidth = 40
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Salmon
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dt_grid_form.RowTemplate.Height = 20
        Me.dt_grid_form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_grid_form.Size = New System.Drawing.Size(686, 142)
        Me.dt_grid_form.TabIndex = 39
        '
        'tb_instituicao
        '
        Me.tb_instituicao.BackColor = System.Drawing.Color.Salmon
        Me.tb_instituicao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_instituicao.Enabled = False
        Me.tb_instituicao.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_instituicao.ForeColor = System.Drawing.Color.Snow
        Me.tb_instituicao.Location = New System.Drawing.Point(251, 164)
        Me.tb_instituicao.MaxLength = 100
        Me.tb_instituicao.Name = "tb_instituicao"
        Me.tb_instituicao.Size = New System.Drawing.Size(343, 19)
        Me.tb_instituicao.TabIndex = 42
        '
        'lb_instituicao
        '
        Me.lb_instituicao.AutoSize = True
        Me.lb_instituicao.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_instituicao.Location = New System.Drawing.Point(157, 164)
        Me.lb_instituicao.Name = "lb_instituicao"
        Me.lb_instituicao.Size = New System.Drawing.Size(88, 19)
        Me.lb_instituicao.TabIndex = 41
        Me.lb_instituicao.Text = "Instituição"
        Me.lb_instituicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_cnpj
        '
        Me.tb_cnpj.BackColor = System.Drawing.Color.Salmon
        Me.tb_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cnpj.Enabled = False
        Me.tb_cnpj.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cnpj.ForeColor = System.Drawing.Color.Snow
        Me.tb_cnpj.Location = New System.Drawing.Point(251, 196)
        Me.tb_cnpj.MaxLength = 45
        Me.tb_cnpj.Name = "tb_cnpj"
        Me.tb_cnpj.Size = New System.Drawing.Size(171, 19)
        Me.tb_cnpj.TabIndex = 44
        '
        'lb_cnpj
        '
        Me.lb_cnpj.AutoSize = True
        Me.lb_cnpj.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cnpj.Location = New System.Drawing.Point(197, 196)
        Me.lb_cnpj.Name = "lb_cnpj"
        Me.lb_cnpj.Size = New System.Drawing.Size(48, 19)
        Me.lb_cnpj.TabIndex = 43
        Me.lb_cnpj.Text = "CNPJ"
        Me.lb_cnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_agencia
        '
        Me.tb_agencia.BackColor = System.Drawing.Color.Salmon
        Me.tb_agencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_agencia.Enabled = False
        Me.tb_agencia.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_agencia.ForeColor = System.Drawing.Color.Snow
        Me.tb_agencia.Location = New System.Drawing.Point(251, 228)
        Me.tb_agencia.MaxLength = 45
        Me.tb_agencia.Name = "tb_agencia"
        Me.tb_agencia.Size = New System.Drawing.Size(145, 19)
        Me.tb_agencia.TabIndex = 46
        '
        'lb_agencia
        '
        Me.lb_agencia.AutoSize = True
        Me.lb_agencia.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_agencia.Location = New System.Drawing.Point(174, 228)
        Me.lb_agencia.Name = "lb_agencia"
        Me.lb_agencia.Size = New System.Drawing.Size(71, 19)
        Me.lb_agencia.TabIndex = 45
        Me.lb_agencia.Text = "Agência"
        Me.lb_agencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_conta
        '
        Me.tb_conta.BackColor = System.Drawing.Color.Salmon
        Me.tb_conta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_conta.Enabled = False
        Me.tb_conta.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_conta.ForeColor = System.Drawing.Color.Snow
        Me.tb_conta.Location = New System.Drawing.Point(251, 260)
        Me.tb_conta.MaxLength = 45
        Me.tb_conta.Name = "tb_conta"
        Me.tb_conta.Size = New System.Drawing.Size(145, 19)
        Me.tb_conta.TabIndex = 48
        '
        'lb_operacao
        '
        Me.lb_operacao.AutoSize = True
        Me.lb_operacao.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_operacao.Location = New System.Drawing.Point(424, 260)
        Me.lb_operacao.Name = "lb_operacao"
        Me.lb_operacao.Size = New System.Drawing.Size(83, 19)
        Me.lb_operacao.TabIndex = 47
        Me.lb_operacao.Text = "Operação"
        Me.lb_operacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_operacao
        '
        Me.tb_operacao.BackColor = System.Drawing.Color.Salmon
        Me.tb_operacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_operacao.Enabled = False
        Me.tb_operacao.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_operacao.ForeColor = System.Drawing.Color.Snow
        Me.tb_operacao.Location = New System.Drawing.Point(513, 260)
        Me.tb_operacao.MaxLength = 45
        Me.tb_operacao.Name = "tb_operacao"
        Me.tb_operacao.Size = New System.Drawing.Size(81, 19)
        Me.tb_operacao.TabIndex = 50
        '
        'lb_conta
        '
        Me.lb_conta.AutoSize = True
        Me.lb_conta.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_conta.Location = New System.Drawing.Point(191, 260)
        Me.lb_conta.Name = "lb_conta"
        Me.lb_conta.Size = New System.Drawing.Size(54, 19)
        Me.lb_conta.TabIndex = 49
        Me.lb_conta.Text = "Conta"
        Me.lb_conta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_tipo
        '
        Me.lb_tipo.AutoSize = True
        Me.lb_tipo.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tipo.Location = New System.Drawing.Point(203, 128)
        Me.lb_tipo.Name = "lb_tipo"
        Me.lb_tipo.Size = New System.Drawing.Size(42, 19)
        Me.lb_tipo.TabIndex = 51
        Me.lb_tipo.Text = "Tipo"
        Me.lb_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_tipo
        '
        Me.cb_tipo.BackColor = System.Drawing.Color.Salmon
        Me.cb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_tipo.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.cb_tipo.ForeColor = System.Drawing.Color.Snow
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.ItemHeight = 19
        Me.cb_tipo.Items.AddRange(New Object() {"Corrente", "Poupança", "Investimento"})
        Me.cb_tipo.Location = New System.Drawing.Point(251, 124)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(162, 27)
        Me.cb_tipo.TabIndex = 52
        '
        'btn_menu_home
        '
        Me.btn_menu_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_menu_home.Image = Global.AppTopMoney.My.Resources.Resources.icon_home_pt
        Me.btn_menu_home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_menu_home.Name = "btn_menu_home"
        Me.btn_menu_home.Size = New System.Drawing.Size(27, 27)
        Me.btn_menu_home.Text = "Menu Principal"
        '
        'btn_menu_close
        '
        Me.btn_menu_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_menu_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_menu_close.Image = Global.AppTopMoney.My.Resources.Resources.icon_close_pt
        Me.btn_menu_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_menu_close.Name = "btn_menu_close"
        Me.btn_menu_close.Size = New System.Drawing.Size(27, 27)
        Me.btn_menu_close.Text = "Sair"
        '
        'form_menu
        '
        Me.form_menu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.form_menu.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.form_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menu_home, Me.btn_menu_close})
        Me.form_menu.Location = New System.Drawing.Point(0, 0)
        Me.form_menu.Name = "form_menu"
        Me.form_menu.Size = New System.Drawing.Size(750, 30)
        Me.form_menu.TabIndex = 30
        '
        'btn_menu_edit_pt
        '
        Me.btn_menu_edit_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_edit_pt
        Me.btn_menu_edit_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_edit_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_edit_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_edit_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_edit_pt.Location = New System.Drawing.Point(310, 33)
        Me.btn_menu_edit_pt.Name = "btn_menu_edit_pt"
        Me.btn_menu_edit_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_edit_pt.TabIndex = 67
        Me.btn_menu_edit_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_save_pt
        '
        Me.btn_menu_save_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_save_pt
        Me.btn_menu_save_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_save_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_save_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_save_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_save_pt.Location = New System.Drawing.Point(229, 33)
        Me.btn_menu_save_pt.Name = "btn_menu_save_pt"
        Me.btn_menu_save_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_save_pt.TabIndex = 66
        Me.btn_menu_save_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_relat_pt
        '
        Me.btn_menu_relat_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_print_pt
        Me.btn_menu_relat_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_relat_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_relat_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_relat_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_relat_pt.Location = New System.Drawing.Point(553, 33)
        Me.btn_menu_relat_pt.Name = "btn_menu_relat_pt"
        Me.btn_menu_relat_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_relat_pt.TabIndex = 65
        Me.btn_menu_relat_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_del_pt
        '
        Me.btn_menu_del_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_delet_pt
        Me.btn_menu_del_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_del_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_del_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_del_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_del_pt.Location = New System.Drawing.Point(472, 33)
        Me.btn_menu_del_pt.Name = "btn_menu_del_pt"
        Me.btn_menu_del_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_del_pt.TabIndex = 64
        Me.btn_menu_del_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_clean_pt
        '
        Me.btn_menu_clean_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_clean_pt
        Me.btn_menu_clean_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_clean_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_clean_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_clean_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_clean_pt.Location = New System.Drawing.Point(391, 33)
        Me.btn_menu_clean_pt.Name = "btn_menu_clean_pt"
        Me.btn_menu_clean_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_clean_pt.TabIndex = 63
        Me.btn_menu_clean_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_add_pt
        '
        Me.btn_menu_add_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_add_pt
        Me.btn_menu_add_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_add_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_add_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_add_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_add_pt.Location = New System.Drawing.Point(148, 33)
        Me.btn_menu_add_pt.Name = "btn_menu_add_pt"
        Me.btn_menu_add_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_add_pt.TabIndex = 62
        Me.btn_menu_add_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_edit_cz
        '
        Me.btn_menu_edit_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_edit_cz
        Me.btn_menu_edit_cz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_edit_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_edit_cz.Enabled = False
        Me.btn_menu_edit_cz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_edit_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_edit_cz.Location = New System.Drawing.Point(310, 33)
        Me.btn_menu_edit_cz.Name = "btn_menu_edit_cz"
        Me.btn_menu_edit_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_edit_cz.TabIndex = 73
        Me.btn_menu_edit_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_save_cz
        '
        Me.btn_menu_save_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_save_cz
        Me.btn_menu_save_cz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_save_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_save_cz.Enabled = False
        Me.btn_menu_save_cz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_save_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_save_cz.Location = New System.Drawing.Point(229, 33)
        Me.btn_menu_save_cz.Name = "btn_menu_save_cz"
        Me.btn_menu_save_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_save_cz.TabIndex = 72
        Me.btn_menu_save_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_relat_cz
        '
        Me.btn_menu_relat_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_print_cz
        Me.btn_menu_relat_cz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_relat_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_relat_cz.Enabled = False
        Me.btn_menu_relat_cz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_relat_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_relat_cz.Location = New System.Drawing.Point(553, 33)
        Me.btn_menu_relat_cz.Name = "btn_menu_relat_cz"
        Me.btn_menu_relat_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_relat_cz.TabIndex = 71
        Me.btn_menu_relat_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_del_cz
        '
        Me.btn_menu_del_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_delet_cz
        Me.btn_menu_del_cz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_del_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_del_cz.Enabled = False
        Me.btn_menu_del_cz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_del_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_del_cz.Location = New System.Drawing.Point(472, 33)
        Me.btn_menu_del_cz.Name = "btn_menu_del_cz"
        Me.btn_menu_del_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_del_cz.TabIndex = 70
        Me.btn_menu_del_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_clean_cz
        '
        Me.btn_menu_clean_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_clean_cz
        Me.btn_menu_clean_cz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_clean_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_clean_cz.Enabled = False
        Me.btn_menu_clean_cz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_clean_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_clean_cz.Location = New System.Drawing.Point(391, 33)
        Me.btn_menu_clean_cz.Name = "btn_menu_clean_cz"
        Me.btn_menu_clean_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_clean_cz.TabIndex = 69
        Me.btn_menu_clean_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_add_cz
        '
        Me.btn_menu_add_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_add_cz
        Me.btn_menu_add_cz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_add_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_add_cz.Enabled = False
        Me.btn_menu_add_cz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_add_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_add_cz.Location = New System.Drawing.Point(148, 33)
        Me.btn_menu_add_cz.Name = "btn_menu_add_cz"
        Me.btn_menu_add_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_add_cz.TabIndex = 68
        Me.btn_menu_add_cz.UseVisualStyleBackColor = False
        '
        'cad_bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.btn_menu_edit_pt)
        Me.Controls.Add(Me.btn_menu_save_pt)
        Me.Controls.Add(Me.btn_menu_relat_pt)
        Me.Controls.Add(Me.btn_menu_del_pt)
        Me.Controls.Add(Me.btn_menu_clean_pt)
        Me.Controls.Add(Me.btn_menu_add_pt)
        Me.Controls.Add(Me.btn_menu_edit_cz)
        Me.Controls.Add(Me.btn_menu_save_cz)
        Me.Controls.Add(Me.btn_menu_relat_cz)
        Me.Controls.Add(Me.btn_menu_del_cz)
        Me.Controls.Add(Me.btn_menu_clean_cz)
        Me.Controls.Add(Me.btn_menu_add_cz)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(Me.lb_tipo)
        Me.Controls.Add(Me.tb_operacao)
        Me.Controls.Add(Me.lb_conta)
        Me.Controls.Add(Me.tb_conta)
        Me.Controls.Add(Me.lb_operacao)
        Me.Controls.Add(Me.tb_agencia)
        Me.Controls.Add(Me.lb_agencia)
        Me.Controls.Add(Me.tb_cnpj)
        Me.Controls.Add(Me.lb_cnpj)
        Me.Controls.Add(Me.tb_instituicao)
        Me.Controls.Add(Me.lb_instituicao)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dt_grid_form)
        Me.Controls.Add(Me.tb_cod)
        Me.Controls.Add(Me.lb_codigo)
        Me.Controls.Add(Me.form_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "cad_bancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cad_bancos"
        CType(Me.dt_grid_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_menu.ResumeLayout(False)
        Me.form_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_cod As TextBox
    Friend WithEvents lb_codigo As Label
    Friend WithEvents tb_id As TextBox
    Friend WithEvents dt_grid_form As DataGridView
    Friend WithEvents tb_instituicao As TextBox
    Friend WithEvents lb_instituicao As Label
    Friend WithEvents tb_cnpj As TextBox
    Friend WithEvents lb_cnpj As Label
    Friend WithEvents tb_agencia As TextBox
    Friend WithEvents lb_agencia As Label
    Friend WithEvents tb_conta As TextBox
    Friend WithEvents lb_operacao As Label
    Friend WithEvents tb_operacao As TextBox
    Friend WithEvents lb_conta As Label
    Friend WithEvents lb_tipo As Label
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents btn_menu_home As ToolStripButton
    Friend WithEvents btn_menu_close As ToolStripButton
    Friend WithEvents form_menu As ToolStrip
    Friend WithEvents btn_menu_edit_pt As Button
    Friend WithEvents btn_menu_save_pt As Button
    Friend WithEvents btn_menu_relat_pt As Button
    Friend WithEvents btn_menu_del_pt As Button
    Friend WithEvents btn_menu_clean_pt As Button
    Friend WithEvents btn_menu_add_pt As Button
    Friend WithEvents btn_menu_edit_cz As Button
    Friend WithEvents btn_menu_save_cz As Button
    Friend WithEvents btn_menu_relat_cz As Button
    Friend WithEvents btn_menu_del_cz As Button
    Friend WithEvents btn_menu_clean_cz As Button
    Friend WithEvents btn_menu_add_cz As Button
End Class
