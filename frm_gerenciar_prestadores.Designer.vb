<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciar_prestadores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciar_prestadores))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.lbl_fone = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_especialidades = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_especialidades = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_tipo_prestador = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmb_tipo_prestador = New System.Windows.Forms.ComboBox()
        Me.lbl_prestador = New System.Windows.Forms.Label()
        Me.txt_prestador = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(246, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(857, 654)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.lbl_fone)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl_especialidades)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.lbl_email)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.lbl_endereco)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_salvar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_tipo_prestador)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lbl_prestador)
        Me.Panel1.Controls.Add(Me.txt_prestador)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(842, 638)
        Me.Panel1.TabIndex = 1
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btn_editar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(657, 318)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(148, 43)
        Me.btn_editar.TabIndex = 31
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'lbl_fone
        '
        Me.lbl_fone.AutoSize = True
        Me.lbl_fone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fone.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fone.Location = New System.Drawing.Point(27, 357)
        Me.lbl_fone.Name = "lbl_fone"
        Me.lbl_fone.Size = New System.Drawing.Size(101, 28)
        Me.lbl_fone.TabIndex = 29
        Me.lbl_fone.Text = "Telefone:"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel12.Controls.Add(Me.txt_fone)
        Me.Panel12.Location = New System.Drawing.Point(32, 388)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(279, 39)
        Me.Panel12.TabIndex = 30
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(10, 8)
        Me.txt_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(259, 22)
        Me.txt_fone.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(230, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(403, 55)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Gerenciar Prestadores:"
        '
        'lbl_especialidades
        '
        Me.lbl_especialidades.AutoSize = True
        Me.lbl_especialidades.BackColor = System.Drawing.Color.Transparent
        Me.lbl_especialidades.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especialidades.Location = New System.Drawing.Point(343, 200)
        Me.lbl_especialidades.Name = "lbl_especialidades"
        Me.lbl_especialidades.Size = New System.Drawing.Size(154, 28)
        Me.lbl_especialidades.TabIndex = 19
        Me.lbl_especialidades.Text = "Especialidades:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txt_especialidades)
        Me.Panel7.Location = New System.Drawing.Point(348, 231)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(279, 196)
        Me.Panel7.TabIndex = 20
        '
        'txt_especialidades
        '
        Me.txt_especialidades.Location = New System.Drawing.Point(10, 9)
        Me.txt_especialidades.Multiline = True
        Me.txt_especialidades.Name = "txt_especialidades"
        Me.txt_especialidades.Size = New System.Drawing.Size(259, 178)
        Me.txt_especialidades.TabIndex = 32
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(343, 122)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(74, 28)
        Me.lbl_email.TabIndex = 16
        Me.lbl_email.Text = "E-mail:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel8.Controls.Add(Me.txt_email)
        Me.Panel8.Location = New System.Drawing.Point(348, 153)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(279, 39)
        Me.Panel8.TabIndex = 17
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(10, 8)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(259, 22)
        Me.txt_email.TabIndex = 2
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.BackColor = System.Drawing.Color.Transparent
        Me.lbl_endereco.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(27, 280)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(105, 28)
        Me.lbl_endereco.TabIndex = 13
        Me.lbl_endereco.Text = "Endereço:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txt_endereco)
        Me.Panel5.Location = New System.Drawing.Point(32, 311)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(279, 39)
        Me.Panel5.TabIndex = 14
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(10, 8)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(259, 22)
        Me.txt_endereco.TabIndex = 33
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btn_salvar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(657, 384)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(148, 43)
        Me.btn_salvar.TabIndex = 11
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
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
        'lbl_tipo_prestador
        '
        Me.lbl_tipo_prestador.AutoSize = True
        Me.lbl_tipo_prestador.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipo_prestador.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_prestador.Location = New System.Drawing.Point(27, 200)
        Me.lbl_tipo_prestador.Name = "lbl_tipo_prestador"
        Me.lbl_tipo_prestador.Size = New System.Drawing.Size(187, 28)
        Me.lbl_tipo_prestador.TabIndex = 6
        Me.lbl_tipo_prestador.Text = "Tipo de Prestador:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cmb_tipo_prestador)
        Me.Panel4.Location = New System.Drawing.Point(32, 231)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 39)
        Me.Panel4.TabIndex = 8
        '
        'cmb_tipo_prestador
        '
        Me.cmb_tipo_prestador.FormattingEnabled = True
        Me.cmb_tipo_prestador.Location = New System.Drawing.Point(10, 7)
        Me.cmb_tipo_prestador.Name = "cmb_tipo_prestador"
        Me.cmb_tipo_prestador.Size = New System.Drawing.Size(259, 24)
        Me.cmb_tipo_prestador.TabIndex = 1
        '
        'lbl_prestador
        '
        Me.lbl_prestador.AutoSize = True
        Me.lbl_prestador.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prestador.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prestador.Location = New System.Drawing.Point(27, 122)
        Me.lbl_prestador.Name = "lbl_prestador"
        Me.lbl_prestador.Size = New System.Drawing.Size(198, 28)
        Me.lbl_prestador.TabIndex = 2
        Me.lbl_prestador.Text = "Nome do Prestador:"
        '
        'txt_prestador
        '
        Me.txt_prestador.Location = New System.Drawing.Point(42, 161)
        Me.txt_prestador.Name = "txt_prestador"
        Me.txt_prestador.Size = New System.Drawing.Size(259, 22)
        Me.txt_prestador.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(32, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(279, 39)
        Me.Panel3.TabIndex = 4
        '
        'frm_gerenciar_prestadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerenciar_prestadores"
        Me.Text = "Gerenciar Prestadores"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_fone As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_especialidades As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_especialidades As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_tipo_prestador As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_prestador As Label
    Friend WithEvents txt_prestador As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents cmb_tipo_prestador As ComboBox
    Friend WithEvents btn_editar As Button
End Class
