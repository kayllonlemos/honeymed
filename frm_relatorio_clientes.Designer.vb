<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relatorio_clientes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_fone = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_tipo_plano = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_tipo_plano = New System.Windows.Forms.TextBox()
        Me.lbl_data_nasc = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_sexo = New System.Windows.Forms.TextBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgv_info = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(266, 277)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(70, 16)
        Me.lbl_email.TabIndex = 53
        Me.lbl_email.Text = "E-mail:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel11.Controls.Add(Me.txt_email)
        Me.Panel11.Location = New System.Drawing.Point(270, 294)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(209, 32)
        Me.Panel11.TabIndex = 54
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(8, 6)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(195, 20)
        Me.txt_email.TabIndex = 2
        '
        'lbl_fone
        '
        Me.lbl_fone.AutoSize = True
        Me.lbl_fone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fone.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fone.Location = New System.Drawing.Point(29, 277)
        Me.lbl_fone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fone.Name = "lbl_fone"
        Me.lbl_fone.Size = New System.Drawing.Size(83, 16)
        Me.lbl_fone.TabIndex = 51
        Me.lbl_fone.Text = "Telefone:"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel12.Controls.Add(Me.txt_fone)
        Me.Panel12.Location = New System.Drawing.Point(32, 294)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(209, 32)
        Me.Panel12.TabIndex = 52
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(8, 6)
        Me.txt_fone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(195, 20)
        Me.txt_fone.TabIndex = 34
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Controls.Add(Me.img_foto)
        Me.Panel10.Location = New System.Drawing.Point(516, 103)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(127, 143)
        Me.Panel10.TabIndex = 50
        '
        'img_foto
        '
        Me.img_foto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_foto.BackColor = System.Drawing.Color.White
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(8, 8)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(112, 127)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 3
        Me.img_foto.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Jockey One", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(273, 45)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Relatório Clientes:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_tipo_plano
        '
        Me.lbl_tipo_plano.AutoSize = True
        Me.lbl_tipo_plano.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipo_plano.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_plano.Location = New System.Drawing.Point(266, 215)
        Me.lbl_tipo_plano.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tipo_plano.Name = "lbl_tipo_plano"
        Me.lbl_tipo_plano.Size = New System.Drawing.Size(121, 16)
        Me.lbl_tipo_plano.TabIndex = 46
        Me.lbl_tipo_plano.Text = "Tipo de Plano:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txt_tipo_plano)
        Me.Panel6.Location = New System.Drawing.Point(270, 232)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(209, 32)
        Me.Panel6.TabIndex = 47
        '
        'txt_tipo_plano
        '
        Me.txt_tipo_plano.Location = New System.Drawing.Point(7, 6)
        Me.txt_tipo_plano.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tipo_plano.Name = "txt_tipo_plano"
        Me.txt_tipo_plano.Size = New System.Drawing.Size(195, 20)
        Me.txt_tipo_plano.TabIndex = 35
        '
        'lbl_data_nasc
        '
        Me.lbl_data_nasc.AutoSize = True
        Me.lbl_data_nasc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data_nasc.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_nasc.Location = New System.Drawing.Point(266, 150)
        Me.lbl_data_nasc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_data_nasc.Name = "lbl_data_nasc"
        Me.lbl_data_nasc.Size = New System.Drawing.Size(170, 16)
        Me.lbl_data_nasc.TabIndex = 44
        Me.lbl_data_nasc.Text = "Data de Nascimento:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel7.Controls.Add(Me.cmb_data_nasc)
        Me.Panel7.Location = New System.Drawing.Point(270, 167)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(209, 32)
        Me.Panel7.TabIndex = 45
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(8, 6)
        Me.cmb_data_nasc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(195, 20)
        Me.cmb_data_nasc.TabIndex = 9
        Me.cmb_data_nasc.Value = New Date(2026, 5, 4, 0, 0, 0, 0)
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(266, 86)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(142, 16)
        Me.lbl_nome.TabIndex = 42
        Me.lbl_nome.Text = "Nome do Cliente:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel8.Controls.Add(Me.txt_nome)
        Me.Panel8.Location = New System.Drawing.Point(270, 103)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(209, 32)
        Me.Panel8.TabIndex = 43
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(8, 6)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(195, 20)
        Me.txt_nome.TabIndex = 2
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sexo.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.Location = New System.Drawing.Point(29, 215)
        Me.lbl_sexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(53, 16)
        Me.lbl_sexo.TabIndex = 40
        Me.lbl_sexo.Text = "Sexo:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txt_sexo)
        Me.Panel5.Location = New System.Drawing.Point(32, 232)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(209, 32)
        Me.Panel5.TabIndex = 41
        '
        'txt_sexo
        '
        Me.txt_sexo.Location = New System.Drawing.Point(7, 6)
        Me.txt_sexo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(195, 20)
        Me.txt_sexo.TabIndex = 35
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(29, 150)
        Me.lbl_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(48, 16)
        Me.lbl_cpf.TabIndex = 37
        Me.lbl_cpf.Text = "CPF:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txt_cpf)
        Me.Panel4.Location = New System.Drawing.Point(32, 167)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(209, 32)
        Me.Panel4.TabIndex = 38
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(8, 6)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(195, 20)
        Me.txt_cpf.TabIndex = 35
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("JejuMyeongjo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(29, 86)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(33, 16)
        Me.lbl_id.TabIndex = 35
        Me.lbl_id.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(40, 110)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(195, 20)
        Me.txt_id.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(32, 103)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 32)
        Me.Panel3.TabIndex = 36
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel9.Controls.Add(Me.dgv_info)
        Me.Panel9.Location = New System.Drawing.Point(32, 348)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(611, 199)
        Me.Panel9.TabIndex = 49
        '
        'dgv_info
        '
        Me.dgv_info.AllowUserToAddRows = False
        Me.dgv_info.AllowUserToDeleteRows = False
        Me.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_info.BackgroundColor = System.Drawing.Color.White
        Me.dgv_info.ColumnHeadersHeight = 24
        Me.dgv_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_info.Location = New System.Drawing.Point(8, 9)
        Me.dgv_info.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_info.Name = "dgv_info"
        Me.dgv_info.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgv_info.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_info.RowTemplate.Height = 24
        Me.dgv_info.Size = New System.Drawing.Size(596, 178)
        Me.dgv_info.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nome Cliente"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo Plano"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column5
        '
        Me.Column5.HeaderText = "E-mail"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(527, 255)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 87)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'frm_relatorio_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 571)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.lbl_fone)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_tipo_plano)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.lbl_data_nasc)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relatorio_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Clientes"
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_email As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_fone As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_tipo_plano As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_data_nasc As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents lbl_nome As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgv_info As DataGridView
    Friend WithEvents txt_tipo_plano As TextBox
    Friend WithEvents txt_sexo As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
