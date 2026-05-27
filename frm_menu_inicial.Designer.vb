<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu_inicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_inicial))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.GerenciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClínicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.GerenciarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btn_gravar
        '
        Me.btn_gravar.AutoSize = False
        Me.btn_gravar.BackColor = System.Drawing.Color.Transparent
        Me.btn_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(30, 30)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'GerenciarToolStripMenuItem
        '
        Me.GerenciarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarClientesToolStripMenuItem, Me.ConsultarClínicasToolStripMenuItem, Me.GerenciarContasToolStripMenuItem})
        Me.GerenciarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GerenciarToolStripMenuItem.Name = "GerenciarToolStripMenuItem"
        Me.GerenciarToolStripMenuItem.Size = New System.Drawing.Size(109, 36)
        Me.GerenciarToolStripMenuItem.Text = "&Gerenciar"
        '
        'GerenciarClientesToolStripMenuItem
        '
        Me.GerenciarClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GerenciarClientesToolStripMenuItem.Image = CType(resources.GetObject("GerenciarClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciarClientesToolStripMenuItem.Name = "GerenciarClientesToolStripMenuItem"
        Me.GerenciarClientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.GerenciarClientesToolStripMenuItem.Size = New System.Drawing.Size(287, 32)
        Me.GerenciarClientesToolStripMenuItem.Text = "Gerenciar Clientes"
        '
        'ConsultarClínicasToolStripMenuItem
        '
        Me.ConsultarClínicasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ConsultarClínicasToolStripMenuItem.Image = CType(resources.GetObject("ConsultarClínicasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarClínicasToolStripMenuItem.Name = "ConsultarClínicasToolStripMenuItem"
        Me.ConsultarClínicasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ConsultarClínicasToolStripMenuItem.Size = New System.Drawing.Size(287, 32)
        Me.ConsultarClínicasToolStripMenuItem.Text = "Consultar Clínicas"
        '
        'GerenciarContasToolStripMenuItem
        '
        Me.GerenciarContasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GerenciarContasToolStripMenuItem.Image = CType(resources.GetObject("GerenciarContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciarContasToolStripMenuItem.Name = "GerenciarContasToolStripMenuItem"
        Me.GerenciarContasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.GerenciarContasToolStripMenuItem.Size = New System.Drawing.Size(287, 32)
        Me.GerenciarContasToolStripMenuItem.Text = "Gerenciar Contas"
        '
        'frm_menu_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu_inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Inicial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents GerenciarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btn_gravar As ToolStripButton
	Friend WithEvents GerenciarClientesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ConsultarClínicasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GerenciarContasToolStripMenuItem As ToolStripMenuItem
End Class
