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
        Me.GerenciarPrestadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPrestadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarAgendamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panel_fatbee = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.GerenciarToolStripMenuItem, Me.CoToolStripMenuItem, Me.AgendarToolStripMenuItem})
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
        Me.GerenciarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarClientesToolStripMenuItem, Me.GerenciarPrestadoresToolStripMenuItem, Me.GerenciarContasToolStripMenuItem})
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
        Me.GerenciarClientesToolStripMenuItem.Size = New System.Drawing.Size(321, 32)
        Me.GerenciarClientesToolStripMenuItem.Text = "Gerenciar Clientes"
        '
        'GerenciarPrestadoresToolStripMenuItem
        '
        Me.GerenciarPrestadoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GerenciarPrestadoresToolStripMenuItem.Image = CType(resources.GetObject("GerenciarPrestadoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciarPrestadoresToolStripMenuItem.Name = "GerenciarPrestadoresToolStripMenuItem"
        Me.GerenciarPrestadoresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.GerenciarPrestadoresToolStripMenuItem.Size = New System.Drawing.Size(321, 32)
        Me.GerenciarPrestadoresToolStripMenuItem.Text = "Gerenciar Prestadores"
        '
        'GerenciarContasToolStripMenuItem
        '
        Me.GerenciarContasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GerenciarContasToolStripMenuItem.Image = CType(resources.GetObject("GerenciarContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciarContasToolStripMenuItem.Name = "GerenciarContasToolStripMenuItem"
        Me.GerenciarContasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.GerenciarContasToolStripMenuItem.Size = New System.Drawing.Size(321, 32)
        Me.GerenciarContasToolStripMenuItem.Text = "Gerenciar Contas"
        '
        'CoToolStripMenuItem
        '
        Me.CoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarClienteToolStripMenuItem, Me.ConsultarPrestadoresToolStripMenuItem, Me.ConsultarAgendamentosToolStripMenuItem})
        Me.CoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoToolStripMenuItem.Name = "CoToolStripMenuItem"
        Me.CoToolStripMenuItem.Size = New System.Drawing.Size(109, 36)
        Me.CoToolStripMenuItem.Text = "&Consultar"
        '
        'ConsultarClienteToolStripMenuItem
        '
        Me.ConsultarClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ConsultarClienteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarClienteToolStripMenuItem.Image = CType(resources.GetObject("ConsultarClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarClienteToolStripMenuItem.Name = "ConsultarClienteToolStripMenuItem"
        Me.ConsultarClienteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ConsultarClienteToolStripMenuItem.Size = New System.Drawing.Size(352, 32)
        Me.ConsultarClienteToolStripMenuItem.Text = "Consultar Clientes"
        '
        'ConsultarPrestadoresToolStripMenuItem
        '
        Me.ConsultarPrestadoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ConsultarPrestadoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarPrestadoresToolStripMenuItem.Image = CType(resources.GetObject("ConsultarPrestadoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarPrestadoresToolStripMenuItem.Name = "ConsultarPrestadoresToolStripMenuItem"
        Me.ConsultarPrestadoresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ConsultarPrestadoresToolStripMenuItem.Size = New System.Drawing.Size(352, 32)
        Me.ConsultarPrestadoresToolStripMenuItem.Text = "Consultar Prestadores"
        '
        'ConsultarAgendamentosToolStripMenuItem
        '
        Me.ConsultarAgendamentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ConsultarAgendamentosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarAgendamentosToolStripMenuItem.Image = CType(resources.GetObject("ConsultarAgendamentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarAgendamentosToolStripMenuItem.Name = "ConsultarAgendamentosToolStripMenuItem"
        Me.ConsultarAgendamentosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ConsultarAgendamentosToolStripMenuItem.Size = New System.Drawing.Size(352, 32)
        Me.ConsultarAgendamentosToolStripMenuItem.Text = "Consultar Agendamentos"
        '
        'AgendarToolStripMenuItem
        '
        Me.AgendarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendarToolStripMenuItem1})
        Me.AgendarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendarToolStripMenuItem.Name = "AgendarToolStripMenuItem"
        Me.AgendarToolStripMenuItem.Size = New System.Drawing.Size(101, 36)
        Me.AgendarToolStripMenuItem.Text = "Agendar"
        '
        'AgendarToolStripMenuItem1
        '
        Me.AgendarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AgendarToolStripMenuItem1.Name = "AgendarToolStripMenuItem1"
        Me.AgendarToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.AgendarToolStripMenuItem1.Size = New System.Drawing.Size(334, 32)
        Me.AgendarToolStripMenuItem1.Text = "Agendar Procedimento"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(568, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 93)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("JejuMyeongjo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Diretrizes do Sistema:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(63, 367)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(593, 355)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(968, 128)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 73)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'panel_fatbee
        '
        Me.panel_fatbee.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.panel_fatbee.Location = New System.Drawing.Point(752, 306)
        Me.panel_fatbee.Name = "panel_fatbee"
        Me.panel_fatbee.Size = New System.Drawing.Size(655, 416)
        Me.panel_fatbee.TabIndex = 8
        '
        'frm_menu_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.panel_fatbee)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu_inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Inicial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GerenciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents GerenciarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarPrestadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPrestadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarAgendamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents panel_fatbee As Panel
End Class
