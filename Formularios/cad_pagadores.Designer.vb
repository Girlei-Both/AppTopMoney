<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_pagadores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_pagadores))
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
        Me.form_menu = New System.Windows.Forms.ToolStrip()
        Me.btn_menu_home = New System.Windows.Forms.ToolStripButton()
        Me.btn_menu_close = New System.Windows.Forms.ToolStripButton()
        Me.tb_obs = New System.Windows.Forms.TextBox()
        Me.lb_obs = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.dt_grid_form = New System.Windows.Forms.DataGridView()
        Me.tb_cnpj = New System.Windows.Forms.TextBox()
        Me.lb_cnpj = New System.Windows.Forms.Label()
        Me.tb_telefone = New System.Windows.Forms.TextBox()
        Me.lb_telefone = New System.Windows.Forms.Label()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.lb_email = New System.Windows.Forms.Label()
        Me.tb_cep = New System.Windows.Forms.TextBox()
        Me.lb_cep = New System.Windows.Forms.Label()
        Me.lb_estado = New System.Windows.Forms.Label()
        Me.tb_cidade = New System.Windows.Forms.TextBox()
        Me.lb_cidade = New System.Windows.Forms.Label()
        Me.tb_endereco = New System.Windows.Forms.TextBox()
        Me.lb_endereco = New System.Windows.Forms.Label()
        Me.tb_rasaosocial = New System.Windows.Forms.TextBox()
        Me.lb_rasaosocial = New System.Windows.Forms.Label()
        Me.tb_site = New System.Windows.Forms.TextBox()
        Me.lb_site = New System.Windows.Forms.Label()
        Me.cb_estado = New System.Windows.Forms.ComboBox()
        Me.form_menu.SuspendLayout()
        CType(Me.dt_grid_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_menu_edit_pt.TabIndex = 98
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
        Me.btn_menu_save_pt.TabIndex = 97
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
        Me.btn_menu_relat_pt.TabIndex = 96
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
        Me.btn_menu_del_pt.TabIndex = 95
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
        Me.btn_menu_clean_pt.TabIndex = 94
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
        Me.btn_menu_add_pt.TabIndex = 93
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
        Me.btn_menu_edit_cz.TabIndex = 104
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
        Me.btn_menu_save_cz.TabIndex = 103
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
        Me.btn_menu_relat_cz.TabIndex = 102
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
        Me.btn_menu_del_cz.TabIndex = 101
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
        Me.btn_menu_clean_cz.TabIndex = 100
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
        Me.btn_menu_add_cz.TabIndex = 99
        Me.btn_menu_add_cz.UseVisualStyleBackColor = False
        '
        'form_menu
        '
        Me.form_menu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.form_menu.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.form_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menu_home, Me.btn_menu_close})
        Me.form_menu.Location = New System.Drawing.Point(0, 0)
        Me.form_menu.Name = "form_menu"
        Me.form_menu.Size = New System.Drawing.Size(750, 30)
        Me.form_menu.TabIndex = 92
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
        'tb_obs
        '
        Me.tb_obs.BackColor = System.Drawing.Color.Salmon
        Me.tb_obs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_obs.Enabled = False
        Me.tb_obs.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obs.ForeColor = System.Drawing.Color.Snow
        Me.tb_obs.Location = New System.Drawing.Point(159, 384)
        Me.tb_obs.MaxLength = 500
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_obs.Size = New System.Drawing.Size(433, 56)
        Me.tb_obs.TabIndex = 113
        '
        'lb_obs
        '
        Me.lb_obs.AutoSize = True
        Me.lb_obs.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_obs.Location = New System.Drawing.Point(155, 362)
        Me.lb_obs.Name = "lb_obs"
        Me.lb_obs.Size = New System.Drawing.Size(106, 19)
        Me.lb_obs.TabIndex = 112
        Me.lb_obs.Text = "Observações"
        Me.lb_obs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_id
        '
        Me.tb_id.BackColor = System.Drawing.Color.Salmon
        Me.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_id.Enabled = False
        Me.tb_id.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.Snow
        Me.tb_id.Location = New System.Drawing.Point(49, 421)
        Me.tb_id.MaxLength = 20
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(97, 19)
        Me.tb_id.TabIndex = 111
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_grid_form.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_grid_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid_form.EnableHeadersVisualStyles = False
        Me.dt_grid_form.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dt_grid_form.Location = New System.Drawing.Point(49, 446)
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
        Me.dt_grid_form.Size = New System.Drawing.Size(653, 142)
        Me.dt_grid_form.TabIndex = 110
        '
        'tb_cnpj
        '
        Me.tb_cnpj.BackColor = System.Drawing.Color.Salmon
        Me.tb_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cnpj.Enabled = False
        Me.tb_cnpj.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cnpj.ForeColor = System.Drawing.Color.Snow
        Me.tb_cnpj.Location = New System.Drawing.Point(270, 108)
        Me.tb_cnpj.MaxLength = 100
        Me.tb_cnpj.Name = "tb_cnpj"
        Me.tb_cnpj.Size = New System.Drawing.Size(166, 19)
        Me.tb_cnpj.TabIndex = 109
        '
        'lb_cnpj
        '
        Me.lb_cnpj.AutoSize = True
        Me.lb_cnpj.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cnpj.Location = New System.Drawing.Point(216, 108)
        Me.lb_cnpj.Name = "lb_cnpj"
        Me.lb_cnpj.Size = New System.Drawing.Size(48, 19)
        Me.lb_cnpj.TabIndex = 108
        Me.lb_cnpj.Text = "CNPJ"
        Me.lb_cnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_telefone
        '
        Me.tb_telefone.BackColor = System.Drawing.Color.Salmon
        Me.tb_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_telefone.Enabled = False
        Me.tb_telefone.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_telefone.ForeColor = System.Drawing.Color.Snow
        Me.tb_telefone.Location = New System.Drawing.Point(270, 332)
        Me.tb_telefone.MaxLength = 45
        Me.tb_telefone.Name = "tb_telefone"
        Me.tb_telefone.Size = New System.Drawing.Size(166, 19)
        Me.tb_telefone.TabIndex = 127
        '
        'lb_telefone
        '
        Me.lb_telefone.AutoSize = True
        Me.lb_telefone.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_telefone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_telefone.Location = New System.Drawing.Point(189, 332)
        Me.lb_telefone.Name = "lb_telefone"
        Me.lb_telefone.Size = New System.Drawing.Size(75, 19)
        Me.lb_telefone.TabIndex = 126
        Me.lb_telefone.Text = "Telefone"
        Me.lb_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_email
        '
        Me.tb_email.BackColor = System.Drawing.Color.Salmon
        Me.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_email.Enabled = False
        Me.tb_email.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_email.ForeColor = System.Drawing.Color.Snow
        Me.tb_email.Location = New System.Drawing.Point(270, 268)
        Me.tb_email.MaxLength = 100
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(318, 19)
        Me.tb_email.TabIndex = 125
        '
        'lb_email
        '
        Me.lb_email.AutoSize = True
        Me.lb_email.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_email.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_email.Location = New System.Drawing.Point(210, 268)
        Me.lb_email.Name = "lb_email"
        Me.lb_email.Size = New System.Drawing.Size(54, 19)
        Me.lb_email.TabIndex = 124
        Me.lb_email.Text = "E-mail"
        Me.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_cep
        '
        Me.tb_cep.BackColor = System.Drawing.Color.Salmon
        Me.tb_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cep.Enabled = False
        Me.tb_cep.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_cep.ForeColor = System.Drawing.Color.Snow
        Me.tb_cep.Location = New System.Drawing.Point(442, 236)
        Me.tb_cep.MaxLength = 20
        Me.tb_cep.Name = "tb_cep"
        Me.tb_cep.Size = New System.Drawing.Size(146, 19)
        Me.tb_cep.TabIndex = 123
        '
        'lb_cep
        '
        Me.lb_cep.AutoSize = True
        Me.lb_cep.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_cep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_cep.Location = New System.Drawing.Point(398, 236)
        Me.lb_cep.Name = "lb_cep"
        Me.lb_cep.Size = New System.Drawing.Size(38, 19)
        Me.lb_cep.TabIndex = 122
        Me.lb_cep.Text = "CEP"
        Me.lb_cep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_estado
        '
        Me.lb_estado.AutoSize = True
        Me.lb_estado.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_estado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_estado.Location = New System.Drawing.Point(203, 236)
        Me.lb_estado.Name = "lb_estado"
        Me.lb_estado.Size = New System.Drawing.Size(61, 19)
        Me.lb_estado.TabIndex = 120
        Me.lb_estado.Text = "Estado"
        Me.lb_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_cidade
        '
        Me.tb_cidade.BackColor = System.Drawing.Color.Salmon
        Me.tb_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cidade.Enabled = False
        Me.tb_cidade.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_cidade.ForeColor = System.Drawing.Color.Snow
        Me.tb_cidade.Location = New System.Drawing.Point(270, 204)
        Me.tb_cidade.MaxLength = 50
        Me.tb_cidade.Name = "tb_cidade"
        Me.tb_cidade.Size = New System.Drawing.Size(166, 19)
        Me.tb_cidade.TabIndex = 119
        '
        'lb_cidade
        '
        Me.lb_cidade.AutoSize = True
        Me.lb_cidade.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_cidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_cidade.Location = New System.Drawing.Point(203, 204)
        Me.lb_cidade.Name = "lb_cidade"
        Me.lb_cidade.Size = New System.Drawing.Size(61, 19)
        Me.lb_cidade.TabIndex = 118
        Me.lb_cidade.Text = "Cidade"
        Me.lb_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_endereco
        '
        Me.tb_endereco.BackColor = System.Drawing.Color.Salmon
        Me.tb_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_endereco.Enabled = False
        Me.tb_endereco.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_endereco.ForeColor = System.Drawing.Color.Snow
        Me.tb_endereco.Location = New System.Drawing.Point(270, 172)
        Me.tb_endereco.MaxLength = 100
        Me.tb_endereco.Name = "tb_endereco"
        Me.tb_endereco.Size = New System.Drawing.Size(318, 19)
        Me.tb_endereco.TabIndex = 117
        '
        'lb_endereco
        '
        Me.lb_endereco.AutoSize = True
        Me.lb_endereco.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_endereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_endereco.Location = New System.Drawing.Point(183, 172)
        Me.lb_endereco.Name = "lb_endereco"
        Me.lb_endereco.Size = New System.Drawing.Size(81, 19)
        Me.lb_endereco.TabIndex = 116
        Me.lb_endereco.Text = "Endereço"
        Me.lb_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_rasaosocial
        '
        Me.tb_rasaosocial.BackColor = System.Drawing.Color.Salmon
        Me.tb_rasaosocial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_rasaosocial.Enabled = False
        Me.tb_rasaosocial.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_rasaosocial.ForeColor = System.Drawing.Color.Snow
        Me.tb_rasaosocial.Location = New System.Drawing.Point(270, 140)
        Me.tb_rasaosocial.MaxLength = 100
        Me.tb_rasaosocial.Name = "tb_rasaosocial"
        Me.tb_rasaosocial.Size = New System.Drawing.Size(318, 19)
        Me.tb_rasaosocial.TabIndex = 115
        '
        'lb_rasaosocial
        '
        Me.lb_rasaosocial.AutoSize = True
        Me.lb_rasaosocial.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_rasaosocial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_rasaosocial.Location = New System.Drawing.Point(163, 140)
        Me.lb_rasaosocial.Name = "lb_rasaosocial"
        Me.lb_rasaosocial.Size = New System.Drawing.Size(101, 19)
        Me.lb_rasaosocial.TabIndex = 114
        Me.lb_rasaosocial.Text = "Rasão Social"
        Me.lb_rasaosocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_site
        '
        Me.tb_site.BackColor = System.Drawing.Color.Salmon
        Me.tb_site.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_site.Enabled = False
        Me.tb_site.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.tb_site.ForeColor = System.Drawing.Color.Snow
        Me.tb_site.Location = New System.Drawing.Point(270, 300)
        Me.tb_site.MaxLength = 100
        Me.tb_site.Name = "tb_site"
        Me.tb_site.Size = New System.Drawing.Size(318, 19)
        Me.tb_site.TabIndex = 129
        '
        'lb_site
        '
        Me.lb_site.AutoSize = True
        Me.lb_site.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.lb_site.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_site.Location = New System.Drawing.Point(228, 300)
        Me.lb_site.Name = "lb_site"
        Me.lb_site.Size = New System.Drawing.Size(36, 19)
        Me.lb_site.TabIndex = 128
        Me.lb_site.Text = "Site"
        Me.lb_site.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_estado
        '
        Me.cb_estado.BackColor = System.Drawing.Color.Salmon
        Me.cb_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_estado.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.cb_estado.ForeColor = System.Drawing.Color.Snow
        Me.cb_estado.FormattingEnabled = True
        Me.cb_estado.ItemHeight = 19
        Me.cb_estado.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cb_estado.Location = New System.Drawing.Point(270, 232)
        Me.cb_estado.Name = "cb_estado"
        Me.cb_estado.Size = New System.Drawing.Size(75, 27)
        Me.cb_estado.TabIndex = 130
        '
        'cad_pagadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(750, 600)
        Me.Controls.Add(Me.cb_estado)
        Me.Controls.Add(Me.tb_site)
        Me.Controls.Add(Me.lb_site)
        Me.Controls.Add(Me.tb_telefone)
        Me.Controls.Add(Me.lb_telefone)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.lb_email)
        Me.Controls.Add(Me.tb_cep)
        Me.Controls.Add(Me.lb_cep)
        Me.Controls.Add(Me.lb_estado)
        Me.Controls.Add(Me.tb_cidade)
        Me.Controls.Add(Me.lb_cidade)
        Me.Controls.Add(Me.tb_endereco)
        Me.Controls.Add(Me.lb_endereco)
        Me.Controls.Add(Me.tb_rasaosocial)
        Me.Controls.Add(Me.lb_rasaosocial)
        Me.Controls.Add(Me.tb_obs)
        Me.Controls.Add(Me.lb_obs)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dt_grid_form)
        Me.Controls.Add(Me.tb_cnpj)
        Me.Controls.Add(Me.lb_cnpj)
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
        Me.Controls.Add(Me.form_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "cad_pagadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cad_pagadores"
        Me.form_menu.ResumeLayout(False)
        Me.form_menu.PerformLayout()
        CType(Me.dt_grid_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents form_menu As ToolStrip
    Friend WithEvents btn_menu_home As ToolStripButton
    Friend WithEvents btn_menu_close As ToolStripButton
    Friend WithEvents tb_obs As TextBox
    Friend WithEvents lb_obs As Label
    Friend WithEvents tb_id As TextBox
    Friend WithEvents dt_grid_form As DataGridView
    Friend WithEvents tb_cnpj As TextBox
    Friend WithEvents lb_cnpj As Label
    Friend WithEvents tb_telefone As TextBox
    Friend WithEvents lb_telefone As Label
    Friend WithEvents tb_email As TextBox
    Friend WithEvents lb_email As Label
    Friend WithEvents tb_cep As TextBox
    Friend WithEvents lb_cep As Label
    Friend WithEvents lb_estado As Label
    Friend WithEvents tb_cidade As TextBox
    Friend WithEvents lb_cidade As Label
    Friend WithEvents tb_endereco As TextBox
    Friend WithEvents lb_endereco As Label
    Friend WithEvents tb_rasaosocial As TextBox
    Friend WithEvents lb_rasaosocial As Label
    Friend WithEvents tb_site As TextBox
    Friend WithEvents lb_site As Label
    Friend WithEvents cb_estado As ComboBox
End Class
