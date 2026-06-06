<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relatorio_funcionarios))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.lbl_frm_contas = New System.Windows.Forms.Label()
        Me.lbl_fone = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipo_conta = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_tipo_conta = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgv_info = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Controls.Add(Me.img_foto)
        Me.Panel10.Location = New System.Drawing.Point(487, 102)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(112, 121)
        Me.Panel10.TabIndex = 47
        '
        'img_foto
        '
        Me.img_foto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_foto.BackColor = System.Drawing.Color.White
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(7, 7)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(98, 104)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 3
        Me.img_foto.TabStop = False
        '
        'lbl_frm_contas
        '
        Me.lbl_frm_contas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_frm_contas.Font = New System.Drawing.Font("Jockey One", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_frm_contas.Location = New System.Drawing.Point(101, 28)
        Me.lbl_frm_contas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_frm_contas.Name = "lbl_frm_contas"
        Me.lbl_frm_contas.Size = New System.Drawing.Size(443, 45)
        Me.lbl_frm_contas.TabIndex = 46
        Me.lbl_frm_contas.Text = "Relatório: Últimos Abelhudos da Colmeia"
        Me.lbl_frm_contas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_fone
        '
        Me.lbl_fone.AutoSize = True
        Me.lbl_fone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fone.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fone.Location = New System.Drawing.Point(246, 170)
        Me.lbl_fone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fone.Name = "lbl_fone"
        Me.lbl_fone.Size = New System.Drawing.Size(83, 16)
        Me.lbl_fone.TabIndex = 41
        Me.lbl_fone.Text = "Telefone:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txt_fone)
        Me.Panel7.Location = New System.Drawing.Point(250, 188)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(209, 32)
        Me.Panel7.TabIndex = 42
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(8, 6)
        Me.txt_fone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(195, 20)
        Me.txt_fone.TabIndex = 35
        '
        'lbl_tipo_conta
        '
        Me.lbl_tipo_conta.AutoSize = True
        Me.lbl_tipo_conta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipo_conta.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_conta.Location = New System.Drawing.Point(246, 102)
        Me.lbl_tipo_conta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tipo_conta.Name = "lbl_tipo_conta"
        Me.lbl_tipo_conta.Size = New System.Drawing.Size(131, 16)
        Me.lbl_tipo_conta.TabIndex = 38
        Me.lbl_tipo_conta.Text = "Tipo de Abelha:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel8.Controls.Add(Me.txt_tipo_conta)
        Me.Panel8.Location = New System.Drawing.Point(250, 120)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(209, 32)
        Me.Panel8.TabIndex = 39
        '
        'txt_tipo_conta
        '
        Me.txt_tipo_conta.Location = New System.Drawing.Point(7, 6)
        Me.txt_tipo_conta.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tipo_conta.Name = "txt_tipo_conta"
        Me.txt_tipo_conta.Size = New System.Drawing.Size(195, 20)
        Me.txt_tipo_conta.TabIndex = 29
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(22, 170)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(70, 16)
        Me.lbl_email.TabIndex = 32
        Me.lbl_email.Text = "E-mail:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(33, 194)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(195, 20)
        Me.txt_email.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(25, 188)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(209, 32)
        Me.Panel4.TabIndex = 33
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(22, 102)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(193, 16)
        Me.lbl_usuario.TabIndex = 29
        Me.lbl_usuario.Text = "Usuário do Funcionário:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(33, 127)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(195, 20)
        Me.txt_usuario.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(25, 120)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 32)
        Me.Panel3.TabIndex = 30
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel9.Controls.Add(Me.dgv_info)
        Me.Panel9.Location = New System.Drawing.Point(25, 248)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(574, 216)
        Me.Panel9.TabIndex = 48
        '
        'dgv_info
        '
        Me.dgv_info.AllowUserToAddRows = False
        Me.dgv_info.AllowUserToDeleteRows = False
        Me.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_info.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_info.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_info.Location = New System.Drawing.Point(8, 9)
        Me.dgv_info.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_info.Name = "dgv_info"
        Me.dgv_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_info.RowTemplate.Height = 24
        Me.dgv_info.Size = New System.Drawing.Size(559, 195)
        Me.dgv_info.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "Usuário"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "E-mail"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Senha"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status Conta"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frm_relatorio_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 506)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.lbl_frm_contas)
        Me.Controls.Add(Me.lbl_fone)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.lbl_tipo_conta)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relatorio_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Funcionários"
        Me.Panel10.ResumeLayout(False)
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel10 As Panel
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents lbl_frm_contas As Label
    Friend WithEvents lbl_fone As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_tipo_conta As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_tipo_conta As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgv_info As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txt_fone As MaskedTextBox
End Class
