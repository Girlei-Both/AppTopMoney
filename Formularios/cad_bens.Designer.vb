<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_bens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_bens))
        Me.form_menu = New System.Windows.Forms.ToolStrip()
        Me.tb_descricao = New System.Windows.Forms.TextBox()
        Me.lb_descricao = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.dt_grid_form = New System.Windows.Forms.DataGridView()
        Me.lb_data = New System.Windows.Forms.Label()
        Me.tb_valor = New System.Windows.Forms.TextBox()
        Me.lb_valor = New System.Windows.Forms.Label()
        Me.tb_obs = New System.Windows.Forms.TextBox()
        Me.lb_obs = New System.Windows.Forms.Label()
        Me.dt_data = New System.Windows.Forms.DateTimePicker()
        Me.cb_id_pessoa = New System.Windows.Forms.ComboBox()
        Me.lb_id_pessoa = New System.Windows.Forms.Label()
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
        Me.btn_menu_home = New System.Windows.Forms.ToolStripButton()
        Me.btn_menu_close = New System.Windows.Forms.ToolStripButton()
        Me.form_menu.SuspendLayout()
        CType(Me.dt_grid_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'form_menu
        '
        Me.form_menu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.form_menu.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.form_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menu_home, Me.btn_menu_close})
        Me.form_menu.Location = New System.Drawing.Point(0, 0)
        Me.form_menu.Name = "form_menu"
        Me.form_menu.Size = New System.Drawing.Size(700, 30)
        Me.form_menu.TabIndex = 39
        '
        'tb_descricao
        '
        Me.tb_descricao.BackColor = System.Drawing.Color.Salmon
        Me.tb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_descricao.Enabled = False
        Me.tb_descricao.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_descricao.ForeColor = System.Drawing.Color.Snow
        Me.tb_descricao.Location = New System.Drawing.Point(246, 173)
        Me.tb_descricao.MaxLength = 100
        Me.tb_descricao.Name = "tb_descricao"
        Me.tb_descricao.Size = New System.Drawing.Size(321, 19)
        Me.tb_descricao.TabIndex = 47
        '
        'lb_descricao
        '
        Me.lb_descricao.AutoSize = True
        Me.lb_descricao.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_descricao.Location = New System.Drawing.Point(157, 173)
        Me.lb_descricao.Name = "lb_descricao"
        Me.lb_descricao.Size = New System.Drawing.Size(82, 19)
        Me.lb_descricao.TabIndex = 46
        Me.lb_descricao.Text = "Descrição"
        Me.lb_descricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_id
        '
        Me.tb_id.BackColor = System.Drawing.Color.Salmon
        Me.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_id.Enabled = False
        Me.tb_id.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.Snow
        Me.tb_id.Location = New System.Drawing.Point(42, 359)
        Me.tb_id.MaxLength = 20
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(97, 19)
        Me.tb_id.TabIndex = 49
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
        Me.dt_grid_form.Location = New System.Drawing.Point(42, 384)
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
        Me.dt_grid_form.Size = New System.Drawing.Size(616, 142)
        Me.dt_grid_form.TabIndex = 48
        '
        'lb_data
        '
        Me.lb_data.AutoSize = True
        Me.lb_data.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_data.Location = New System.Drawing.Point(194, 141)
        Me.lb_data.Name = "lb_data"
        Me.lb_data.Size = New System.Drawing.Size(45, 19)
        Me.lb_data.TabIndex = 50
        Me.lb_data.Text = "Data"
        Me.lb_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_valor
        '
        Me.tb_valor.BackColor = System.Drawing.Color.Salmon
        Me.tb_valor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_valor.Enabled = False
        Me.tb_valor.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_valor.ForeColor = System.Drawing.Color.Snow
        Me.tb_valor.Location = New System.Drawing.Point(246, 205)
        Me.tb_valor.MaxLength = 15
        Me.tb_valor.Name = "tb_valor"
        Me.tb_valor.Size = New System.Drawing.Size(140, 19)
        Me.tb_valor.TabIndex = 52
        '
        'lb_valor
        '
        Me.lb_valor.AutoSize = True
        Me.lb_valor.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_valor.Location = New System.Drawing.Point(190, 205)
        Me.lb_valor.Name = "lb_valor"
        Me.lb_valor.Size = New System.Drawing.Size(49, 19)
        Me.lb_valor.TabIndex = 51
        Me.lb_valor.Text = "Valor"
        Me.lb_valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_obs
        '
        Me.tb_obs.BackColor = System.Drawing.Color.Salmon
        Me.tb_obs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_obs.Enabled = False
        Me.tb_obs.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obs.ForeColor = System.Drawing.Color.Snow
        Me.tb_obs.Location = New System.Drawing.Point(134, 260)
        Me.tb_obs.MaxLength = 500
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_obs.Size = New System.Drawing.Size(433, 97)
        Me.tb_obs.TabIndex = 54
        '
        'lb_obs
        '
        Me.lb_obs.AutoSize = True
        Me.lb_obs.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_obs.Location = New System.Drawing.Point(134, 237)
        Me.lb_obs.Name = "lb_obs"
        Me.lb_obs.Size = New System.Drawing.Size(106, 19)
        Me.lb_obs.TabIndex = 53
        Me.lb_obs.Text = "Observações"
        Me.lb_obs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.dt_data.Location = New System.Drawing.Point(246, 137)
        Me.dt_data.Name = "dt_data"
        Me.dt_data.Size = New System.Drawing.Size(140, 26)
        Me.dt_data.TabIndex = 55
        Me.dt_data.Value = New Date(2022, 11, 1, 0, 0, 0, 0)
        '
        'cb_id_pessoa
        '
        Me.cb_id_pessoa.BackColor = System.Drawing.Color.Salmon
        Me.cb_id_pessoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_id_pessoa.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.cb_id_pessoa.ForeColor = System.Drawing.Color.Snow
        Me.cb_id_pessoa.FormattingEnabled = True
        Me.cb_id_pessoa.ItemHeight = 19
        Me.cb_id_pessoa.Location = New System.Drawing.Point(246, 105)
        Me.cb_id_pessoa.Name = "cb_id_pessoa"
        Me.cb_id_pessoa.Size = New System.Drawing.Size(307, 27)
        Me.cb_id_pessoa.TabIndex = 78
        '
        'lb_id_pessoa
        '
        Me.lb_id_pessoa.AutoSize = True
        Me.lb_id_pessoa.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id_pessoa.Location = New System.Drawing.Point(179, 109)
        Me.lb_id_pessoa.Name = "lb_id_pessoa"
        Me.lb_id_pessoa.Size = New System.Drawing.Size(60, 19)
        Me.lb_id_pessoa.TabIndex = 77
        Me.lb_id_pessoa.Text = "Pessoa"
        Me.lb_id_pessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_menu_edit_pt
        '
        Me.btn_menu_edit_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_edit_pt
        Me.btn_menu_edit_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_edit_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_edit_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_edit_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_edit_pt.Location = New System.Drawing.Point(285, 33)
        Me.btn_menu_edit_pt.Name = "btn_menu_edit_pt"
        Me.btn_menu_edit_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_edit_pt.TabIndex = 45
        Me.btn_menu_edit_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_save_pt
        '
        Me.btn_menu_save_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_save_pt
        Me.btn_menu_save_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_save_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_save_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_save_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_save_pt.Location = New System.Drawing.Point(204, 33)
        Me.btn_menu_save_pt.Name = "btn_menu_save_pt"
        Me.btn_menu_save_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_save_pt.TabIndex = 44
        Me.btn_menu_save_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_relat_pt
        '
        Me.btn_menu_relat_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_print_pt
        Me.btn_menu_relat_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_relat_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_relat_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_relat_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_relat_pt.Location = New System.Drawing.Point(528, 33)
        Me.btn_menu_relat_pt.Name = "btn_menu_relat_pt"
        Me.btn_menu_relat_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_relat_pt.TabIndex = 43
        Me.btn_menu_relat_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_del_pt
        '
        Me.btn_menu_del_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_delet_pt
        Me.btn_menu_del_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_del_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_del_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_del_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_del_pt.Location = New System.Drawing.Point(447, 33)
        Me.btn_menu_del_pt.Name = "btn_menu_del_pt"
        Me.btn_menu_del_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_del_pt.TabIndex = 42
        Me.btn_menu_del_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_clean_pt
        '
        Me.btn_menu_clean_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_clean_pt
        Me.btn_menu_clean_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_clean_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_clean_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_clean_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_clean_pt.Location = New System.Drawing.Point(366, 33)
        Me.btn_menu_clean_pt.Name = "btn_menu_clean_pt"
        Me.btn_menu_clean_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_clean_pt.TabIndex = 41
        Me.btn_menu_clean_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_add_pt
        '
        Me.btn_menu_add_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_add_pt
        Me.btn_menu_add_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_add_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_add_pt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_add_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_add_pt.Location = New System.Drawing.Point(123, 33)
        Me.btn_menu_add_pt.Name = "btn_menu_add_pt"
        Me.btn_menu_add_pt.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_add_pt.TabIndex = 40
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
        Me.btn_menu_edit_cz.Location = New System.Drawing.Point(285, 33)
        Me.btn_menu_edit_cz.Name = "btn_menu_edit_cz"
        Me.btn_menu_edit_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_edit_cz.TabIndex = 61
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
        Me.btn_menu_save_cz.Location = New System.Drawing.Point(204, 33)
        Me.btn_menu_save_cz.Name = "btn_menu_save_cz"
        Me.btn_menu_save_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_save_cz.TabIndex = 60
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
        Me.btn_menu_relat_cz.Location = New System.Drawing.Point(528, 33)
        Me.btn_menu_relat_cz.Name = "btn_menu_relat_cz"
        Me.btn_menu_relat_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_relat_cz.TabIndex = 59
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
        Me.btn_menu_del_cz.Location = New System.Drawing.Point(447, 33)
        Me.btn_menu_del_cz.Name = "btn_menu_del_cz"
        Me.btn_menu_del_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_del_cz.TabIndex = 58
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
        Me.btn_menu_clean_cz.Location = New System.Drawing.Point(366, 33)
        Me.btn_menu_clean_cz.Name = "btn_menu_clean_cz"
        Me.btn_menu_clean_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_clean_cz.TabIndex = 57
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
        Me.btn_menu_add_cz.Location = New System.Drawing.Point(123, 33)
        Me.btn_menu_add_cz.Name = "btn_menu_add_cz"
        Me.btn_menu_add_cz.Size = New System.Drawing.Size(50, 50)
        Me.btn_menu_add_cz.TabIndex = 56
        Me.btn_menu_add_cz.UseVisualStyleBackColor = False
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
        'cad_bens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(700, 550)
        Me.Controls.Add(Me.cb_id_pessoa)
        Me.Controls.Add(Me.lb_id_pessoa)
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
        Me.Controls.Add(Me.dt_data)
        Me.Controls.Add(Me.tb_obs)
        Me.Controls.Add(Me.lb_obs)
        Me.Controls.Add(Me.tb_valor)
        Me.Controls.Add(Me.lb_valor)
        Me.Controls.Add(Me.lb_data)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dt_grid_form)
        Me.Controls.Add(Me.tb_descricao)
        Me.Controls.Add(Me.lb_descricao)
        Me.Controls.Add(Me.form_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "cad_bens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cad_bens"
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
    Friend WithEvents form_menu As ToolStrip
    Friend WithEvents btn_menu_home As ToolStripButton
    Friend WithEvents btn_menu_close As ToolStripButton
    Friend WithEvents tb_descricao As TextBox
    Friend WithEvents lb_descricao As Label
    Friend WithEvents tb_id As TextBox
    Friend WithEvents dt_grid_form As DataGridView
    Friend WithEvents lb_data As Label
    Friend WithEvents tb_valor As TextBox
    Friend WithEvents lb_valor As Label
    Friend WithEvents tb_obs As TextBox
    Friend WithEvents lb_obs As Label
    Friend WithEvents dt_data As DateTimePicker
    Friend WithEvents btn_menu_edit_cz As Button
    Friend WithEvents btn_menu_save_cz As Button
    Friend WithEvents btn_menu_relat_cz As Button
    Friend WithEvents btn_menu_del_cz As Button
    Friend WithEvents btn_menu_clean_cz As Button
    Friend WithEvents btn_menu_add_cz As Button
    Friend WithEvents cb_id_pessoa As ComboBox
    Friend WithEvents lb_id_pessoa As Label
End Class
