﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tela_inicial
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
        Me.form_menu = New System.Windows.Forms.ToolStrip()
        Me.btn_menu_close = New System.Windows.Forms.ToolStripButton()
        Me.btn_menu_config = New System.Windows.Forms.ToolStripSplitButton()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_pessoa_fisica = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_pessoa_juridica = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_controle_caixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_bancos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_contas_mes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_aplicacoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_fornecedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_impostos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_pagadores = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_bens = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_inicio_banco = New System.Windows.Forms.Button()
        Me.btn_inicio_caixa = New System.Windows.Forms.Button()
        Me.btn_inicio_pessoa = New System.Windows.Forms.Button()
        Me.btn_inicio_gastos = New System.Windows.Forms.Button()
        Me.btn_inicio_bens = New System.Windows.Forms.Button()
        Me.btn_inicio_pagadores = New System.Windows.Forms.Button()
        Me.menu_documentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.form_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'form_menu
        '
        Me.form_menu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.form_menu.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.form_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menu_close, Me.btn_menu_config})
        Me.form_menu.Location = New System.Drawing.Point(0, 0)
        Me.form_menu.Name = "form_menu"
        Me.form_menu.Size = New System.Drawing.Size(750, 32)
        Me.form_menu.TabIndex = 32
        '
        'btn_menu_close
        '
        Me.btn_menu_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_menu_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_menu_close.Image = Global.AppTopMoney.My.Resources.Resources.icon_close_pt
        Me.btn_menu_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_menu_close.Name = "btn_menu_close"
        Me.btn_menu_close.Size = New System.Drawing.Size(29, 29)
        Me.btn_menu_close.Text = "Sair"
        '
        'btn_menu_config
        '
        Me.btn_menu_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_config.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_menu_config.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.FinanceiroToolStripMenuItem, Me.menu_bens, Me.menu_documentos})
        Me.btn_menu_config.Image = Global.AppTopMoney.My.Resources.Resources.icon_conf_pt
        Me.btn_menu_config.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_menu_config.Name = "btn_menu_config"
        Me.btn_menu_config.Size = New System.Drawing.Size(41, 29)
        Me.btn_menu_config.Text = "Formulários"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_pessoa_fisica, Me.menu_pessoa_juridica})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'menu_pessoa_fisica
        '
        Me.menu_pessoa_fisica.Name = "menu_pessoa_fisica"
        Me.menu_pessoa_fisica.Size = New System.Drawing.Size(180, 22)
        Me.menu_pessoa_fisica.Text = "Pessoa Física"
        '
        'menu_pessoa_juridica
        '
        Me.menu_pessoa_juridica.Name = "menu_pessoa_juridica"
        Me.menu_pessoa_juridica.Size = New System.Drawing.Size(180, 22)
        Me.menu_pessoa_juridica.Text = "Pessoa Jurídica"
        '
        'FinanceiroToolStripMenuItem
        '
        Me.FinanceiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_controle_caixa, Me.menu_bancos, Me.menu_contas_mes, Me.menu_aplicacoes, Me.menu_fornecedores, Me.menu_impostos, Me.menu_pagadores})
        Me.FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        Me.FinanceiroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FinanceiroToolStripMenuItem.Text = "Financeiro"
        '
        'menu_controle_caixa
        '
        Me.menu_controle_caixa.Name = "menu_controle_caixa"
        Me.menu_controle_caixa.Size = New System.Drawing.Size(180, 22)
        Me.menu_controle_caixa.Text = "Controle de Caixa"
        '
        'menu_bancos
        '
        Me.menu_bancos.Name = "menu_bancos"
        Me.menu_bancos.Size = New System.Drawing.Size(180, 22)
        Me.menu_bancos.Text = "Bancos"
        '
        'menu_contas_mes
        '
        Me.menu_contas_mes.Name = "menu_contas_mes"
        Me.menu_contas_mes.Size = New System.Drawing.Size(180, 22)
        Me.menu_contas_mes.Text = "Contas Mensais"
        '
        'menu_aplicacoes
        '
        Me.menu_aplicacoes.Name = "menu_aplicacoes"
        Me.menu_aplicacoes.Size = New System.Drawing.Size(180, 22)
        Me.menu_aplicacoes.Text = "Aplicações"
        '
        'menu_fornecedores
        '
        Me.menu_fornecedores.Name = "menu_fornecedores"
        Me.menu_fornecedores.Size = New System.Drawing.Size(180, 22)
        Me.menu_fornecedores.Text = "Fornecedores"
        '
        'menu_impostos
        '
        Me.menu_impostos.Name = "menu_impostos"
        Me.menu_impostos.Size = New System.Drawing.Size(180, 22)
        Me.menu_impostos.Text = "Impostos"
        '
        'menu_pagadores
        '
        Me.menu_pagadores.Name = "menu_pagadores"
        Me.menu_pagadores.Size = New System.Drawing.Size(180, 22)
        Me.menu_pagadores.Text = "Pagadores"
        '
        'menu_bens
        '
        Me.menu_bens.Name = "menu_bens"
        Me.menu_bens.Size = New System.Drawing.Size(180, 22)
        Me.menu_bens.Text = "Bens"
        '
        'btn_inicio_banco
        '
        Me.btn_inicio_banco.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.btn_banco
        Me.btn_inicio_banco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicio_banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio_banco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio_banco.ForeColor = System.Drawing.Color.Transparent
        Me.btn_inicio_banco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_inicio_banco.Location = New System.Drawing.Point(475, 72)
        Me.btn_inicio_banco.Name = "btn_inicio_banco"
        Me.btn_inicio_banco.Size = New System.Drawing.Size(150, 150)
        Me.btn_inicio_banco.TabIndex = 35
        Me.btn_inicio_banco.UseVisualStyleBackColor = False
        '
        'btn_inicio_caixa
        '
        Me.btn_inicio_caixa.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.btn_caixa
        Me.btn_inicio_caixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicio_caixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio_caixa.ForeColor = System.Drawing.Color.Transparent
        Me.btn_inicio_caixa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_inicio_caixa.Location = New System.Drawing.Point(300, 72)
        Me.btn_inicio_caixa.Name = "btn_inicio_caixa"
        Me.btn_inicio_caixa.Size = New System.Drawing.Size(150, 150)
        Me.btn_inicio_caixa.TabIndex = 34
        Me.btn_inicio_caixa.UseVisualStyleBackColor = False
        '
        'btn_inicio_pessoa
        '
        Me.btn_inicio_pessoa.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.btn_pessoa
        Me.btn_inicio_pessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicio_pessoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio_pessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio_pessoa.ForeColor = System.Drawing.Color.Transparent
        Me.btn_inicio_pessoa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_inicio_pessoa.Location = New System.Drawing.Point(125, 72)
        Me.btn_inicio_pessoa.Name = "btn_inicio_pessoa"
        Me.btn_inicio_pessoa.Size = New System.Drawing.Size(150, 150)
        Me.btn_inicio_pessoa.TabIndex = 33
        Me.btn_inicio_pessoa.UseVisualStyleBackColor = False
        '
        'btn_inicio_gastos
        '
        Me.btn_inicio_gastos.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.btn_gastos
        Me.btn_inicio_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicio_gastos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio_gastos.ForeColor = System.Drawing.Color.Transparent
        Me.btn_inicio_gastos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_inicio_gastos.Location = New System.Drawing.Point(475, 228)
        Me.btn_inicio_gastos.Name = "btn_inicio_gastos"
        Me.btn_inicio_gastos.Size = New System.Drawing.Size(150, 150)
        Me.btn_inicio_gastos.TabIndex = 38
        Me.btn_inicio_gastos.UseVisualStyleBackColor = False
        '
        'btn_inicio_bens
        '
        Me.btn_inicio_bens.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.btn_bens
        Me.btn_inicio_bens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicio_bens.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio_bens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio_bens.ForeColor = System.Drawing.Color.Transparent
        Me.btn_inicio_bens.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_inicio_bens.Location = New System.Drawing.Point(300, 228)
        Me.btn_inicio_bens.Name = "btn_inicio_bens"
        Me.btn_inicio_bens.Size = New System.Drawing.Size(150, 150)
        Me.btn_inicio_bens.TabIndex = 37
        Me.btn_inicio_bens.UseVisualStyleBackColor = False
        '
        'btn_inicio_pagadores
        '
        Me.btn_inicio_pagadores.BackgroundImage = Global.AppTopMoney.My.Resources.Resources.btn_pagadores
        Me.btn_inicio_pagadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicio_pagadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio_pagadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio_pagadores.ForeColor = System.Drawing.Color.Transparent
        Me.btn_inicio_pagadores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_inicio_pagadores.Location = New System.Drawing.Point(125, 228)
        Me.btn_inicio_pagadores.Name = "btn_inicio_pagadores"
        Me.btn_inicio_pagadores.Size = New System.Drawing.Size(150, 150)
        Me.btn_inicio_pagadores.TabIndex = 36
        Me.btn_inicio_pagadores.UseVisualStyleBackColor = False
        '
        'menu_documentos
        '
        Me.menu_documentos.Name = "menu_documentos"
        Me.menu_documentos.Size = New System.Drawing.Size(180, 22)
        Me.menu_documentos.Text = "Documentos"
        '
        'frm_tela_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.btn_inicio_gastos)
        Me.Controls.Add(Me.btn_inicio_bens)
        Me.Controls.Add(Me.btn_inicio_pagadores)
        Me.Controls.Add(Me.btn_inicio_banco)
        Me.Controls.Add(Me.btn_inicio_caixa)
        Me.Controls.Add(Me.btn_inicio_pessoa)
        Me.Controls.Add(Me.form_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frm_tela_inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_tela_inicial"
        Me.form_menu.ResumeLayout(False)
        Me.form_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents form_menu As ToolStrip
    Friend WithEvents btn_menu_close As ToolStripButton
    Friend WithEvents btn_menu_config As ToolStripSplitButton
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_pessoa_fisica As ToolStripMenuItem
    Friend WithEvents menu_pessoa_juridica As ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_controle_caixa As ToolStripMenuItem
    Friend WithEvents menu_bancos As ToolStripMenuItem
    Friend WithEvents menu_contas_mes As ToolStripMenuItem
    Friend WithEvents menu_fornecedores As ToolStripMenuItem
    Friend WithEvents menu_impostos As ToolStripMenuItem
    Friend WithEvents menu_pagadores As ToolStripMenuItem
    Friend WithEvents menu_bens As ToolStripMenuItem
    Friend WithEvents btn_inicio_pessoa As Button
    Friend WithEvents btn_inicio_caixa As Button
    Friend WithEvents btn_inicio_banco As Button
    Friend WithEvents btn_inicio_gastos As Button
    Friend WithEvents btn_inicio_bens As Button
    Friend WithEvents btn_inicio_pagadores As Button
    Friend WithEvents menu_aplicacoes As ToolStripMenuItem
    Friend WithEvents menu_documentos As ToolStripMenuItem
End Class
