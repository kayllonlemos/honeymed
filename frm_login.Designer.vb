<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_rec_senha = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_visualizar_senha = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_rec_senha)
        Me.Panel1.Controls.Add(Me.btn_entrar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_login)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(210, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(832, 439)
        Me.Panel1.TabIndex = 0
        '
        'lbl_rec_senha
        '
        Me.lbl_rec_senha.AutoSize = True
        Me.lbl_rec_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rec_senha.Font = New System.Drawing.Font("Jaldi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rec_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_rec_senha.Location = New System.Drawing.Point(562, 301)
        Me.lbl_rec_senha.Name = "lbl_rec_senha"
        Me.lbl_rec_senha.Size = New System.Drawing.Size(157, 34)
        Me.lbl_rec_senha.TabIndex = 12
        Me.lbl_rec_senha.Text = "Recuperar senha"
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btn_entrar.Font = New System.Drawing.Font("Jaldi", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Location = New System.Drawing.Point(508, 344)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(279, 47)
        Me.btn_entrar.TabIndex = 11
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, -100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 47)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Bem vindo(a)..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("JejuMyeongjo", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 47)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Insira seus dados:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(448, 235)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Jaldi", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Senha:"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(518, 258)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(229, 22)
        Me.txt_senha.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btn_visualizar_senha)
        Me.Panel4.Location = New System.Drawing.Point(508, 250)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 43)
        Me.Panel4.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(448, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Jaldi", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuário ou E-mail:"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(518, 161)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(259, 22)
        Me.txt_login.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(21, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 360)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(508, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(279, 42)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(188, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(875, 478)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(514, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(272, 75)
        Me.Panel5.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("JejuMyeongjo", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 64)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "  Bem vindo(a)..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_visualizar_senha
        '
        Me.btn_visualizar_senha.BackColor = System.Drawing.SystemColors.Window
        Me.btn_visualizar_senha.BackgroundImage = CType(resources.GetObject("btn_visualizar_senha.BackgroundImage"), System.Drawing.Image)
        Me.btn_visualizar_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_visualizar_senha.Location = New System.Drawing.Point(245, 10)
        Me.btn_visualizar_senha.Name = "btn_visualizar_senha"
        Me.btn_visualizar_senha.Size = New System.Drawing.Size(25, 25)
        Me.btn_visualizar_senha.TabIndex = 15
        Me.btn_visualizar_senha.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txt_login As TextBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txt_senha As TextBox
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Label5 As Label
	Friend WithEvents btn_entrar As Button
	Friend WithEvents lbl_rec_senha As Label
    Friend WithEvents btn_visualizar_senha As Button
End Class
