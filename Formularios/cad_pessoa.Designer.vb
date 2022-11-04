<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cad_pessoa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_pessoa))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lb_nome = New System.Windows.Forms.Label()
        Me.tb_nome = New System.Windows.Forms.TextBox()
        Me.tb_endereco = New System.Windows.Forms.TextBox()
        Me.lb_endereco = New System.Windows.Forms.Label()
        Me.tb_cidade = New System.Windows.Forms.TextBox()
        Me.lb_cidade = New System.Windows.Forms.Label()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.lb_email = New System.Windows.Forms.Label()
        Me.tb_cep = New System.Windows.Forms.TextBox()
        Me.lb_cep = New System.Windows.Forms.Label()
        Me.tb_estado = New System.Windows.Forms.TextBox()
        Me.lb_estado = New System.Windows.Forms.Label()
        Me.tb_fone = New System.Windows.Forms.TextBox()
        Me.lb_fone = New System.Windows.Forms.Label()
        Me.dt_grid_form = New System.Windows.Forms.DataGridView()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.tb_usuario = New System.Windows.Forms.TextBox()
        Me.lb_usuario = New System.Windows.Forms.Label()
        Me.tb_senha = New System.Windows.Forms.TextBox()
        Me.lb_senha = New System.Windows.Forms.Label()
        Me.form_menu = New System.Windows.Forms.ToolStrip()
        Me.btn_menu_home = New System.Windows.Forms.ToolStripButton()
        Me.btn_menu_close = New System.Windows.Forms.ToolStripButton()
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
        'lb_nome
        '
        resources.ApplyResources(Me.lb_nome, "lb_nome")
        Me.lb_nome.Name = "lb_nome"
        '
        'tb_nome
        '
        Me.tb_nome.BackColor = System.Drawing.Color.Salmon
        Me.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_nome, "tb_nome")
        Me.tb_nome.ForeColor = System.Drawing.Color.Snow
        Me.tb_nome.Name = "tb_nome"
        '
        'tb_endereco
        '
        Me.tb_endereco.BackColor = System.Drawing.Color.Salmon
        Me.tb_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_endereco, "tb_endereco")
        Me.tb_endereco.ForeColor = System.Drawing.Color.Snow
        Me.tb_endereco.Name = "tb_endereco"
        '
        'lb_endereco
        '
        resources.ApplyResources(Me.lb_endereco, "lb_endereco")
        Me.lb_endereco.Name = "lb_endereco"
        '
        'tb_cidade
        '
        Me.tb_cidade.BackColor = System.Drawing.Color.Salmon
        Me.tb_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_cidade, "tb_cidade")
        Me.tb_cidade.ForeColor = System.Drawing.Color.Snow
        Me.tb_cidade.Name = "tb_cidade"
        '
        'lb_cidade
        '
        resources.ApplyResources(Me.lb_cidade, "lb_cidade")
        Me.lb_cidade.Name = "lb_cidade"
        '
        'tb_email
        '
        Me.tb_email.BackColor = System.Drawing.Color.Salmon
        Me.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_email, "tb_email")
        Me.tb_email.ForeColor = System.Drawing.Color.Snow
        Me.tb_email.Name = "tb_email"
        '
        'lb_email
        '
        resources.ApplyResources(Me.lb_email, "lb_email")
        Me.lb_email.Name = "lb_email"
        '
        'tb_cep
        '
        Me.tb_cep.BackColor = System.Drawing.Color.Salmon
        Me.tb_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_cep, "tb_cep")
        Me.tb_cep.ForeColor = System.Drawing.Color.Snow
        Me.tb_cep.Name = "tb_cep"
        '
        'lb_cep
        '
        resources.ApplyResources(Me.lb_cep, "lb_cep")
        Me.lb_cep.Name = "lb_cep"
        '
        'tb_estado
        '
        Me.tb_estado.BackColor = System.Drawing.Color.Salmon
        Me.tb_estado.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_estado, "tb_estado")
        Me.tb_estado.ForeColor = System.Drawing.Color.Snow
        Me.tb_estado.Name = "tb_estado"
        '
        'lb_estado
        '
        resources.ApplyResources(Me.lb_estado, "lb_estado")
        Me.lb_estado.Name = "lb_estado"
        '
        'tb_fone
        '
        Me.tb_fone.BackColor = System.Drawing.Color.Salmon
        Me.tb_fone.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_fone, "tb_fone")
        Me.tb_fone.ForeColor = System.Drawing.Color.Snow
        Me.tb_fone.Name = "tb_fone"
        '
        'lb_fone
        '
        resources.ApplyResources(Me.lb_fone, "lb_fone")
        Me.lb_fone.Name = "lb_fone"
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_grid_form.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_grid_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid_form.EnableHeadersVisualStyles = False
        Me.dt_grid_form.GridColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.dt_grid_form, "dt_grid_form")
        Me.dt_grid_form.MultiSelect = False
        Me.dt_grid_form.Name = "dt_grid_form"
        Me.dt_grid_form.ReadOnly = True
        Me.dt_grid_form.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Salmon
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed
        Me.dt_grid_form.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dt_grid_form.RowTemplate.Height = 20
        Me.dt_grid_form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'tb_id
        '
        Me.tb_id.BackColor = System.Drawing.Color.Salmon
        Me.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_id, "tb_id")
        Me.tb_id.ForeColor = System.Drawing.Color.Snow
        Me.tb_id.Name = "tb_id"
        '
        'tb_usuario
        '
        Me.tb_usuario.BackColor = System.Drawing.Color.Salmon
        Me.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_usuario, "tb_usuario")
        Me.tb_usuario.ForeColor = System.Drawing.Color.Snow
        Me.tb_usuario.Name = "tb_usuario"
        '
        'lb_usuario
        '
        resources.ApplyResources(Me.lb_usuario, "lb_usuario")
        Me.lb_usuario.Name = "lb_usuario"
        '
        'tb_senha
        '
        Me.tb_senha.BackColor = System.Drawing.Color.Salmon
        Me.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tb_senha, "tb_senha")
        Me.tb_senha.ForeColor = System.Drawing.Color.Snow
        Me.tb_senha.Name = "tb_senha"
        '
        'lb_senha
        '
        resources.ApplyResources(Me.lb_senha, "lb_senha")
        Me.lb_senha.Name = "lb_senha"
        '
        'form_menu
        '
        Me.form_menu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.form_menu.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.form_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menu_home, Me.btn_menu_close})
        resources.ApplyResources(Me.form_menu, "form_menu")
        Me.form_menu.Name = "form_menu"
        '
        'btn_menu_home
        '
        resources.ApplyResources(Me.btn_menu_home, "btn_menu_home")
        Me.btn_menu_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_menu_home.Image = Global.AppTopMoney.My.Resources.Resources.icon_home_pt
        Me.btn_menu_home.Name = "btn_menu_home"
        '
        'btn_menu_close
        '
        Me.btn_menu_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        resources.ApplyResources(Me.btn_menu_close, "btn_menu_close")
        Me.btn_menu_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_menu_close.Image = Global.AppTopMoney.My.Resources.Resources.icon_close_pt
        Me.btn_menu_close.Name = "btn_menu_close"
        '
        'btn_menu_edit_pt
        '
        Me.btn_menu_edit_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_edit_pt
        resources.ApplyResources(Me.btn_menu_edit_pt, "btn_menu_edit_pt")
        Me.btn_menu_edit_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_edit_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_edit_pt.Name = "btn_menu_edit_pt"
        Me.btn_menu_edit_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_save_pt
        '
        Me.btn_menu_save_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_save_pt
        resources.ApplyResources(Me.btn_menu_save_pt, "btn_menu_save_pt")
        Me.btn_menu_save_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_save_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_save_pt.Name = "btn_menu_save_pt"
        Me.btn_menu_save_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_relat_pt
        '
        Me.btn_menu_relat_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_print_pt
        resources.ApplyResources(Me.btn_menu_relat_pt, "btn_menu_relat_pt")
        Me.btn_menu_relat_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_relat_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_relat_pt.Name = "btn_menu_relat_pt"
        Me.btn_menu_relat_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_del_pt
        '
        Me.btn_menu_del_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_delet_pt
        resources.ApplyResources(Me.btn_menu_del_pt, "btn_menu_del_pt")
        Me.btn_menu_del_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_del_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_del_pt.Name = "btn_menu_del_pt"
        Me.btn_menu_del_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_clean_pt
        '
        Me.btn_menu_clean_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_clean_pt
        resources.ApplyResources(Me.btn_menu_clean_pt, "btn_menu_clean_pt")
        Me.btn_menu_clean_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_clean_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_clean_pt.Name = "btn_menu_clean_pt"
        Me.btn_menu_clean_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_add_pt
        '
        Me.btn_menu_add_pt.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_add_pt
        resources.ApplyResources(Me.btn_menu_add_pt, "btn_menu_add_pt")
        Me.btn_menu_add_pt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_add_pt.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_add_pt.Name = "btn_menu_add_pt"
        Me.btn_menu_add_pt.UseVisualStyleBackColor = False
        '
        'btn_menu_edit_cz
        '
        Me.btn_menu_edit_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_edit_cz
        resources.ApplyResources(Me.btn_menu_edit_cz, "btn_menu_edit_cz")
        Me.btn_menu_edit_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_edit_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_edit_cz.Name = "btn_menu_edit_cz"
        Me.btn_menu_edit_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_save_cz
        '
        Me.btn_menu_save_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_save_cz
        resources.ApplyResources(Me.btn_menu_save_cz, "btn_menu_save_cz")
        Me.btn_menu_save_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_save_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_save_cz.Name = "btn_menu_save_cz"
        Me.btn_menu_save_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_relat_cz
        '
        Me.btn_menu_relat_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_print_cz
        resources.ApplyResources(Me.btn_menu_relat_cz, "btn_menu_relat_cz")
        Me.btn_menu_relat_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_relat_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_relat_cz.Name = "btn_menu_relat_cz"
        Me.btn_menu_relat_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_del_cz
        '
        Me.btn_menu_del_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_delet_cz
        resources.ApplyResources(Me.btn_menu_del_cz, "btn_menu_del_cz")
        Me.btn_menu_del_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_del_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_del_cz.Name = "btn_menu_del_cz"
        Me.btn_menu_del_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_clean_cz
        '
        Me.btn_menu_clean_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_clean_cz
        resources.ApplyResources(Me.btn_menu_clean_cz, "btn_menu_clean_cz")
        Me.btn_menu_clean_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_clean_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_clean_cz.Name = "btn_menu_clean_cz"
        Me.btn_menu_clean_cz.UseVisualStyleBackColor = False
        '
        'btn_menu_add_cz
        '
        Me.btn_menu_add_cz.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.icon_add_cz
        resources.ApplyResources(Me.btn_menu_add_cz, "btn_menu_add_cz")
        Me.btn_menu_add_cz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_add_cz.ForeColor = System.Drawing.Color.Transparent
        Me.btn_menu_add_cz.Name = "btn_menu_add_cz"
        Me.btn_menu_add_cz.UseVisualStyleBackColor = False
        '
        'cad_pessoa
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
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
        Me.Controls.Add(Me.tb_senha)
        Me.Controls.Add(Me.lb_senha)
        Me.Controls.Add(Me.tb_usuario)
        Me.Controls.Add(Me.lb_usuario)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dt_grid_form)
        Me.Controls.Add(Me.tb_fone)
        Me.Controls.Add(Me.lb_fone)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.lb_email)
        Me.Controls.Add(Me.tb_cep)
        Me.Controls.Add(Me.lb_cep)
        Me.Controls.Add(Me.tb_estado)
        Me.Controls.Add(Me.lb_estado)
        Me.Controls.Add(Me.tb_cidade)
        Me.Controls.Add(Me.lb_cidade)
        Me.Controls.Add(Me.tb_endereco)
        Me.Controls.Add(Me.lb_endereco)
        Me.Controls.Add(Me.tb_nome)
        Me.Controls.Add(Me.lb_nome)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "cad_pessoa"
        CType(Me.dt_grid_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_menu.ResumeLayout(False)
        Me.form_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_nome As Label
    Friend WithEvents tb_nome As TextBox
    Friend WithEvents tb_endereco As TextBox
    Friend WithEvents lb_endereco As Label
    Friend WithEvents tb_cidade As TextBox
    Friend WithEvents lb_cidade As Label
    Friend WithEvents tb_email As TextBox
    Friend WithEvents lb_email As Label
    Friend WithEvents tb_cep As TextBox
    Friend WithEvents lb_cep As Label
    Friend WithEvents tb_estado As TextBox
    Friend WithEvents lb_estado As Label
    Friend WithEvents tb_fone As TextBox
    Friend WithEvents lb_fone As Label
    Friend WithEvents dt_grid_form As DataGridView
    Friend WithEvents tb_id As TextBox
    Friend WithEvents tb_usuario As TextBox
    Friend WithEvents lb_usuario As Label
    Friend WithEvents tb_senha As TextBox
    Friend WithEvents lb_senha As Label
    Friend WithEvents form_menu As ToolStrip
    Friend WithEvents btn_menu_home As ToolStripButton
    Friend WithEvents btn_menu_close As ToolStripButton
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
