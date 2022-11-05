<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_gasto_mes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_gasto_mes))
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
        Me.tb_valor = New System.Windows.Forms.TextBox()
        Me.lb_valor = New System.Windows.Forms.Label()
        Me.tb_ir = New System.Windows.Forms.TextBox()
        Me.lb_ir = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.lb_tipo = New System.Windows.Forms.Label()
        Me.cb_id_identificacao = New System.Windows.Forms.ComboBox()
        Me.lb_id_identificacao = New System.Windows.Forms.Label()
        Me.cb_id_pessoa = New System.Windows.Forms.ComboBox()
        Me.lb_id_pessoa = New System.Windows.Forms.Label()
        Me.dt_data = New System.Windows.Forms.DateTimePicker()
        Me.lb_data = New System.Windows.Forms.Label()
        Me.tb_liquido = New System.Windows.Forms.TextBox()
        Me.lb_liquido = New System.Windows.Forms.Label()
        Me.tb_inss = New System.Windows.Forms.TextBox()
        Me.lb_inss = New System.Windows.Forms.Label()
        Me.tb_descontos = New System.Windows.Forms.TextBox()
        Me.lb_descontos = New System.Windows.Forms.Label()
        Me.tb_multa = New System.Windows.Forms.TextBox()
        Me.lb_multa = New System.Windows.Forms.Label()
        Me.valor_id = New System.Windows.Forms.TextBox()
        Me.rb_fornecedores = New System.Windows.Forms.RadioButton()
        Me.rb_pagadores = New System.Windows.Forms.RadioButton()
        Me.rb_impostos = New System.Windows.Forms.RadioButton()
        Me.rb_aplicacoes = New System.Windows.Forms.RadioButton()
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
        Me.btn_menu_edit_pt.Location = New System.Drawing.Point(427, 33)
        Me.btn_menu_edit_pt.Name = "btn_menu_edit_pt"
        Me.btn_menu_edit_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_edit_pt.TabIndex = 111
        Me.btn_menu_edit_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_save_pt
        '
        Me.btn_menu_save_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_save_pt
        Me.btn_menu_save_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_save_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_save_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_save_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_save_pt.Location = New System.Drawing.Point(346, 33)
        Me.btn_menu_save_pt.Name = "btn_menu_save_pt"
        Me.btn_menu_save_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_save_pt.TabIndex = 110
        Me.btn_menu_save_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_relat_pt
        '
        Me.btn_menu_relat_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_print_pt
        Me.btn_menu_relat_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_relat_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_relat_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_relat_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_relat_pt.Location = New System.Drawing.Point(670, 33)
        Me.btn_menu_relat_pt.Name = "btn_menu_relat_pt"
        Me.btn_menu_relat_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_relat_pt.TabIndex = 109
        Me.btn_menu_relat_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_del_pt
        '
        Me.btn_menu_del_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_delet_pt
        Me.btn_menu_del_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_del_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_del_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_del_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_del_pt.Location = New System.Drawing.Point(589, 33)
        Me.btn_menu_del_pt.Name = "btn_menu_del_pt"
        Me.btn_menu_del_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_del_pt.TabIndex = 108
        Me.btn_menu_del_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_clean_pt
        '
        Me.btn_menu_clean_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_clean_pt
        Me.btn_menu_clean_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_clean_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_clean_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_clean_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_clean_pt.Location = New System.Drawing.Point(508, 33)
        Me.btn_menu_clean_pt.Name = "btn_menu_clean_pt"
        Me.btn_menu_clean_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_clean_pt.TabIndex = 107
        Me.btn_menu_clean_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_add_pt
        '
        Me.btn_menu_add_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_add_pt
        Me.btn_menu_add_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_add_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_add_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_add_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_add_pt.Location = New System.Drawing.Point(265, 33)
        Me.btn_menu_add_pt.Name = "btn_menu_add_pt"
        Me.btn_menu_add_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_add_pt.TabIndex = 106
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
        Me.btn_menu_edit_cz.Location = New System.Drawing.Point(427, 33)
        Me.btn_menu_edit_cz.Name = "btn_menu_edit_cz"
        Me.btn_menu_edit_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_edit_cz.TabIndex = 117
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
        Me.btn_menu_save_cz.Location = New System.Drawing.Point(346, 33)
        Me.btn_menu_save_cz.Name = "btn_menu_save_cz"
        Me.btn_menu_save_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_save_cz.TabIndex = 116
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
        Me.btn_menu_relat_cz.Location = New System.Drawing.Point(670, 33)
        Me.btn_menu_relat_cz.Name = "btn_menu_relat_cz"
        Me.btn_menu_relat_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_relat_cz.TabIndex = 115
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
        Me.btn_menu_del_cz.Location = New System.Drawing.Point(589, 33)
        Me.btn_menu_del_cz.Name = "btn_menu_del_cz"
        Me.btn_menu_del_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_del_cz.TabIndex = 114
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
        Me.btn_menu_clean_cz.Location = New System.Drawing.Point(508, 33)
        Me.btn_menu_clean_cz.Name = "btn_menu_clean_cz"
        Me.btn_menu_clean_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_clean_cz.TabIndex = 113
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
        Me.btn_menu_add_cz.Location = New System.Drawing.Point(265, 33)
        Me.btn_menu_add_cz.Name = "btn_menu_add_cz"
        Me.btn_menu_add_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_add_cz.TabIndex = 112
        Me.btn_menu_add_cz.UseVisualStyleBackColor = False
        '
        'form_menu
        '
        Me.form_menu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.form_menu.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.form_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menu_home, Me.btn_menu_close})
        Me.form_menu.Location = New System.Drawing.Point(0, 0)
        Me.form_menu.Name = "form_menu"
        Me.form_menu.Size = New System.Drawing.Size(984, 30)
        Me.form_menu.TabIndex = 105
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
        Me.tb_obs.Location = New System.Drawing.Point(481, 345)
        Me.tb_obs.MaxLength = 500
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_obs.Size = New System.Drawing.Size(433, 56)
        Me.tb_obs.TabIndex = 121
        '
        'lb_obs
        '
        Me.lb_obs.AutoSize = True
        Me.lb_obs.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_obs.Location = New System.Drawing.Point(477, 323)
        Me.lb_obs.Name = "lb_obs"
        Me.lb_obs.Size = New System.Drawing.Size(106, 19)
        Me.lb_obs.TabIndex = 120
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
        Me.tb_id.Location = New System.Drawing.Point(38, 382)
        Me.tb_id.MaxLength = 20
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(97, 19)
        Me.tb_id.TabIndex = 119
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
        Me.dt_grid_form.Location = New System.Drawing.Point(38, 407)
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
        Me.dt_grid_form.Size = New System.Drawing.Size(909, 142)
        Me.dt_grid_form.TabIndex = 118
        '
        'tb_valor
        '
        Me.tb_valor.BackColor = System.Drawing.Color.Salmon
        Me.tb_valor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_valor.Enabled = False
        Me.tb_valor.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_valor.ForeColor = System.Drawing.Color.Snow
        Me.tb_valor.Location = New System.Drawing.Point(760, 124)
        Me.tb_valor.MaxLength = 200
        Me.tb_valor.Name = "tb_valor"
        Me.tb_valor.Size = New System.Drawing.Size(137, 19)
        Me.tb_valor.TabIndex = 133
        Me.tb_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_valor
        '
        Me.lb_valor.AutoSize = True
        Me.lb_valor.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_valor.Location = New System.Drawing.Point(706, 124)
        Me.lb_valor.Name = "lb_valor"
        Me.lb_valor.Size = New System.Drawing.Size(49, 19)
        Me.lb_valor.TabIndex = 132
        Me.lb_valor.Text = "Valor"
        Me.lb_valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_ir
        '
        Me.tb_ir.BackColor = System.Drawing.Color.Salmon
        Me.tb_ir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_ir.Enabled = False
        Me.tb_ir.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ir.ForeColor = System.Drawing.Color.Snow
        Me.tb_ir.Location = New System.Drawing.Point(786, 155)
        Me.tb_ir.MaxLength = 200
        Me.tb_ir.Name = "tb_ir"
        Me.tb_ir.Size = New System.Drawing.Size(111, 19)
        Me.tb_ir.TabIndex = 131
        Me.tb_ir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_ir
        '
        Me.lb_ir.AutoSize = True
        Me.lb_ir.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ir.Location = New System.Drawing.Point(756, 155)
        Me.lb_ir.Name = "lb_ir"
        Me.lb_ir.Size = New System.Drawing.Size(24, 19)
        Me.lb_ir.TabIndex = 130
        Me.lb_ir.Text = "IR"
        Me.lb_ir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_tipo
        '
        Me.cb_tipo.BackColor = System.Drawing.Color.Salmon
        Me.cb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_tipo.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.cb_tipo.ForeColor = System.Drawing.Color.Snow
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.ItemHeight = 19
        Me.cb_tipo.Items.AddRange(New Object() {"Débito", "Crédito"})
        Me.cb_tipo.Location = New System.Drawing.Point(115, 124)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(114, 27)
        Me.cb_tipo.TabIndex = 129
        '
        'lb_tipo
        '
        Me.lb_tipo.AutoSize = True
        Me.lb_tipo.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tipo.Location = New System.Drawing.Point(70, 128)
        Me.lb_tipo.Name = "lb_tipo"
        Me.lb_tipo.Size = New System.Drawing.Size(42, 19)
        Me.lb_tipo.TabIndex = 128
        Me.lb_tipo.Text = "Tipo"
        Me.lb_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_id_identificacao
        '
        Me.cb_id_identificacao.BackColor = System.Drawing.Color.Salmon
        Me.cb_id_identificacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_id_identificacao.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.cb_id_identificacao.ForeColor = System.Drawing.Color.Snow
        Me.cb_id_identificacao.FormattingEnabled = True
        Me.cb_id_identificacao.ItemHeight = 19
        Me.cb_id_identificacao.Location = New System.Drawing.Point(74, 258)
        Me.cb_id_identificacao.Name = "cb_id_identificacao"
        Me.cb_id_identificacao.Size = New System.Drawing.Size(361, 27)
        Me.cb_id_identificacao.TabIndex = 127
        '
        'lb_id_identificacao
        '
        Me.lb_id_identificacao.AutoSize = True
        Me.lb_id_identificacao.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id_identificacao.Location = New System.Drawing.Point(70, 236)
        Me.lb_id_identificacao.Name = "lb_id_identificacao"
        Me.lb_id_identificacao.Size = New System.Drawing.Size(162, 19)
        Me.lb_id_identificacao.TabIndex = 126
        Me.lb_id_identificacao.Text = "Descrição/Descrição"
        Me.lb_id_identificacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_id_pessoa
        '
        Me.cb_id_pessoa.BackColor = System.Drawing.Color.Salmon
        Me.cb_id_pessoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_id_pessoa.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.cb_id_pessoa.ForeColor = System.Drawing.Color.Snow
        Me.cb_id_pessoa.FormattingEnabled = True
        Me.cb_id_pessoa.ItemHeight = 19
        Me.cb_id_pessoa.Location = New System.Drawing.Point(74, 193)
        Me.cb_id_pessoa.Name = "cb_id_pessoa"
        Me.cb_id_pessoa.Size = New System.Drawing.Size(361, 27)
        Me.cb_id_pessoa.TabIndex = 125
        '
        'lb_id_pessoa
        '
        Me.lb_id_pessoa.AutoSize = True
        Me.lb_id_pessoa.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id_pessoa.Location = New System.Drawing.Point(70, 171)
        Me.lb_id_pessoa.Name = "lb_id_pessoa"
        Me.lb_id_pessoa.Size = New System.Drawing.Size(60, 19)
        Me.lb_id_pessoa.TabIndex = 124
        Me.lb_id_pessoa.Text = "Pessoa"
        Me.lb_id_pessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_data
        '
        Me.dt_data.CalendarForeColor = System.Drawing.Color.Snow
        Me.dt_data.CalendarMonthBackground = System.Drawing.Color.Salmon
        Me.dt_data.CalendarTitleBackColor = System.Drawing.Color.Salmon
        Me.dt_data.CalendarTitleForeColor = System.Drawing.Color.Snow
        Me.dt_data.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dt_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dt_data.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.dt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_data.Location = New System.Drawing.Point(287, 124)
        Me.dt_data.Name = "dt_data"
        Me.dt_data.Size = New System.Drawing.Size(148, 26)
        Me.dt_data.TabIndex = 123
        Me.dt_data.Value = New Date(2022, 11, 1, 0, 0, 0, 0)
        '
        'lb_data
        '
        Me.lb_data.AutoSize = True
        Me.lb_data.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_data.Location = New System.Drawing.Point(238, 128)
        Me.lb_data.Name = "lb_data"
        Me.lb_data.Size = New System.Drawing.Size(45, 19)
        Me.lb_data.TabIndex = 122
        Me.lb_data.Text = "Data"
        Me.lb_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_liquido
        '
        Me.tb_liquido.BackColor = System.Drawing.Color.Salmon
        Me.tb_liquido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_liquido.Enabled = False
        Me.tb_liquido.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_liquido.ForeColor = System.Drawing.Color.Snow
        Me.tb_liquido.Location = New System.Drawing.Point(760, 279)
        Me.tb_liquido.MaxLength = 200
        Me.tb_liquido.Name = "tb_liquido"
        Me.tb_liquido.Size = New System.Drawing.Size(137, 19)
        Me.tb_liquido.TabIndex = 135
        Me.tb_liquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_liquido
        '
        Me.lb_liquido.AutoSize = True
        Me.lb_liquido.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_liquido.Location = New System.Drawing.Point(647, 279)
        Me.lb_liquido.Name = "lb_liquido"
        Me.lb_liquido.Size = New System.Drawing.Size(108, 19)
        Me.lb_liquido.TabIndex = 134
        Me.lb_liquido.Text = "Total Líquido"
        Me.lb_liquido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_inss
        '
        Me.tb_inss.BackColor = System.Drawing.Color.Salmon
        Me.tb_inss.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_inss.Enabled = False
        Me.tb_inss.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_inss.ForeColor = System.Drawing.Color.Snow
        Me.tb_inss.Location = New System.Drawing.Point(786, 186)
        Me.tb_inss.MaxLength = 200
        Me.tb_inss.Name = "tb_inss"
        Me.tb_inss.Size = New System.Drawing.Size(111, 19)
        Me.tb_inss.TabIndex = 137
        Me.tb_inss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_inss
        '
        Me.lb_inss.AutoSize = True
        Me.lb_inss.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_inss.Location = New System.Drawing.Point(737, 186)
        Me.lb_inss.Name = "lb_inss"
        Me.lb_inss.Size = New System.Drawing.Size(43, 19)
        Me.lb_inss.TabIndex = 136
        Me.lb_inss.Text = "INSS"
        Me.lb_inss.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_descontos
        '
        Me.tb_descontos.BackColor = System.Drawing.Color.Salmon
        Me.tb_descontos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_descontos.Enabled = False
        Me.tb_descontos.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_descontos.ForeColor = System.Drawing.Color.Snow
        Me.tb_descontos.Location = New System.Drawing.Point(786, 217)
        Me.tb_descontos.MaxLength = 200
        Me.tb_descontos.Name = "tb_descontos"
        Me.tb_descontos.Size = New System.Drawing.Size(111, 19)
        Me.tb_descontos.TabIndex = 139
        Me.tb_descontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_descontos
        '
        Me.lb_descontos.AutoSize = True
        Me.lb_descontos.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_descontos.Location = New System.Drawing.Point(638, 217)
        Me.lb_descontos.Name = "lb_descontos"
        Me.lb_descontos.Size = New System.Drawing.Size(142, 19)
        Me.lb_descontos.TabIndex = 138
        Me.lb_descontos.Text = "Outros descontos"
        Me.lb_descontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_multa
        '
        Me.tb_multa.BackColor = System.Drawing.Color.Salmon
        Me.tb_multa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_multa.Enabled = False
        Me.tb_multa.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_multa.ForeColor = System.Drawing.Color.Snow
        Me.tb_multa.Location = New System.Drawing.Point(786, 248)
        Me.tb_multa.MaxLength = 200
        Me.tb_multa.Name = "tb_multa"
        Me.tb_multa.Size = New System.Drawing.Size(111, 19)
        Me.tb_multa.TabIndex = 141
        Me.tb_multa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_multa
        '
        Me.lb_multa.AutoSize = True
        Me.lb_multa.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_multa.Location = New System.Drawing.Point(728, 248)
        Me.lb_multa.Name = "lb_multa"
        Me.lb_multa.Size = New System.Drawing.Size(52, 19)
        Me.lb_multa.TabIndex = 140
        Me.lb_multa.Text = "Multa"
        Me.lb_multa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'valor_id
        '
        Me.valor_id.BackColor = System.Drawing.Color.Salmon
        Me.valor_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valor_id.Enabled = False
        Me.valor_id.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_id.ForeColor = System.Drawing.Color.Snow
        Me.valor_id.Location = New System.Drawing.Point(141, 382)
        Me.valor_id.MaxLength = 20
        Me.valor_id.Name = "valor_id"
        Me.valor_id.Size = New System.Drawing.Size(97, 19)
        Me.valor_id.TabIndex = 146
        '
        'rb_fornecedores
        '
        Me.rb_fornecedores.AutoSize = True
        Me.rb_fornecedores.BackColor = System.Drawing.Color.Snow
        Me.rb_fornecedores.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb_fornecedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_fornecedores.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.rb_fornecedores.ForeColor = System.Drawing.Color.Salmon
        Me.rb_fornecedores.Location = New System.Drawing.Point(302, 291)
        Me.rb_fornecedores.Name = "rb_fornecedores"
        Me.rb_fornecedores.Size = New System.Drawing.Size(130, 23)
        Me.rb_fornecedores.TabIndex = 147
        Me.rb_fornecedores.TabStop = True
        Me.rb_fornecedores.Text = "Fornecedores"
        Me.rb_fornecedores.UseVisualStyleBackColor = False
        '
        'rb_pagadores
        '
        Me.rb_pagadores.AutoSize = True
        Me.rb_pagadores.BackColor = System.Drawing.Color.Snow
        Me.rb_pagadores.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb_pagadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_pagadores.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.rb_pagadores.ForeColor = System.Drawing.Color.Salmon
        Me.rb_pagadores.Location = New System.Drawing.Point(326, 318)
        Me.rb_pagadores.Name = "rb_pagadores"
        Me.rb_pagadores.Size = New System.Drawing.Size(106, 23)
        Me.rb_pagadores.TabIndex = 148
        Me.rb_pagadores.TabStop = True
        Me.rb_pagadores.Text = "Pagadores"
        Me.rb_pagadores.UseVisualStyleBackColor = False
        '
        'rb_impostos
        '
        Me.rb_impostos.AutoSize = True
        Me.rb_impostos.BackColor = System.Drawing.Color.Snow
        Me.rb_impostos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb_impostos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_impostos.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.rb_impostos.ForeColor = System.Drawing.Color.Salmon
        Me.rb_impostos.Location = New System.Drawing.Point(336, 345)
        Me.rb_impostos.Name = "rb_impostos"
        Me.rb_impostos.Size = New System.Drawing.Size(96, 23)
        Me.rb_impostos.TabIndex = 149
        Me.rb_impostos.TabStop = True
        Me.rb_impostos.Text = "Impostos"
        Me.rb_impostos.UseVisualStyleBackColor = False
        '
        'rb_aplicacoes
        '
        Me.rb_aplicacoes.AutoSize = True
        Me.rb_aplicacoes.BackColor = System.Drawing.Color.Snow
        Me.rb_aplicacoes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb_aplicacoes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_aplicacoes.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!)
        Me.rb_aplicacoes.ForeColor = System.Drawing.Color.Salmon
        Me.rb_aplicacoes.Location = New System.Drawing.Point(324, 372)
        Me.rb_aplicacoes.Name = "rb_aplicacoes"
        Me.rb_aplicacoes.Size = New System.Drawing.Size(108, 23)
        Me.rb_aplicacoes.TabIndex = 150
        Me.rb_aplicacoes.TabStop = True
        Me.rb_aplicacoes.Text = "Aplicações"
        Me.rb_aplicacoes.UseVisualStyleBackColor = False
        '
        'cad_gasto_mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.rb_aplicacoes)
        Me.Controls.Add(Me.rb_impostos)
        Me.Controls.Add(Me.rb_pagadores)
        Me.Controls.Add(Me.rb_fornecedores)
        Me.Controls.Add(Me.valor_id)
        Me.Controls.Add(Me.tb_multa)
        Me.Controls.Add(Me.lb_multa)
        Me.Controls.Add(Me.tb_descontos)
        Me.Controls.Add(Me.lb_descontos)
        Me.Controls.Add(Me.tb_inss)
        Me.Controls.Add(Me.lb_inss)
        Me.Controls.Add(Me.tb_liquido)
        Me.Controls.Add(Me.lb_liquido)
        Me.Controls.Add(Me.tb_valor)
        Me.Controls.Add(Me.lb_valor)
        Me.Controls.Add(Me.tb_ir)
        Me.Controls.Add(Me.lb_ir)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(Me.lb_tipo)
        Me.Controls.Add(Me.cb_id_identificacao)
        Me.Controls.Add(Me.lb_id_identificacao)
        Me.Controls.Add(Me.cb_id_pessoa)
        Me.Controls.Add(Me.lb_id_pessoa)
        Me.Controls.Add(Me.dt_data)
        Me.Controls.Add(Me.lb_data)
        Me.Controls.Add(Me.tb_obs)
        Me.Controls.Add(Me.lb_obs)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dt_grid_form)
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
        Me.Name = "cad_gasto_mes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cad_gasto_mes"
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
    Friend WithEvents tb_valor As TextBox
    Friend WithEvents lb_valor As Label
    Friend WithEvents tb_ir As TextBox
    Friend WithEvents lb_ir As Label
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents lb_tipo As Label
    Friend WithEvents cb_id_identificacao As ComboBox
    Friend WithEvents lb_id_identificacao As Label
    Friend WithEvents cb_id_pessoa As ComboBox
    Friend WithEvents lb_id_pessoa As Label
    Friend WithEvents dt_data As DateTimePicker
    Friend WithEvents lb_data As Label
    Friend WithEvents tb_liquido As TextBox
    Friend WithEvents lb_liquido As Label
    Friend WithEvents tb_inss As TextBox
    Friend WithEvents lb_inss As Label
    Friend WithEvents tb_descontos As TextBox
    Friend WithEvents lb_descontos As Label
    Friend WithEvents tb_multa As TextBox
    Friend WithEvents lb_multa As Label
    Friend WithEvents valor_id As TextBox
    Friend WithEvents rb_fornecedores As RadioButton
    Friend WithEvents rb_pagadores As RadioButton
    Friend WithEvents rb_impostos As RadioButton
    Friend WithEvents rb_aplicacoes As RadioButton
End Class
