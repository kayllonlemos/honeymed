<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciar_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciar_clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.cmb_tipo_plano = New System.Windows.Forms.ComboBox()
        Me.lbl_data_nasc = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(246, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(857, 654)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_email)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.lbl_fone)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl_tipo_plano)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lbl_data_nasc)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.lbl_nome)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.lbl_sexo)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_salvar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_cpf)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lbl_id)
        Me.Panel1.Controls.Add(Me.txt_id)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(842, 638)
        Me.Panel1.TabIndex = 1
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(349, 308)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(74, 28)
        Me.lbl_email.TabIndex = 32
        Me.lbl_email.Text = "E-mail:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel11.Controls.Add(Me.txt_email)
        Me.Panel11.Location = New System.Drawing.Point(354, 339)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(279, 39)
        Me.Panel11.TabIndex = 33
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(10, 8)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(259, 22)
        Me.txt_email.TabIndex = 2
        '
        'lbl_fone
        '
        Me.lbl_fone.AutoSize = True
        Me.lbl_fone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fone.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fone.Location = New System.Drawing.Point(33, 308)
        Me.lbl_fone.Name = "lbl_fone"
        Me.lbl_fone.Size = New System.Drawing.Size(101, 28)
        Me.lbl_fone.TabIndex = 29
        Me.lbl_fone.Text = "Telefone:"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel12.Controls.Add(Me.txt_fone)
        Me.Panel12.Location = New System.Drawing.Point(38, 339)
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
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Controls.Add(Me.img_foto)
        Me.Panel10.Location = New System.Drawing.Point(650, 103)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(169, 176)
        Me.Panel10.TabIndex = 27
        '
        'img_foto
        '
        Me.img_foto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_foto.BackColor = System.Drawing.Color.White
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(10, 10)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(149, 156)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 3
        Me.img_foto.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(259, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 55)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Gerenciar Clientes:"
        '
        'lbl_tipo_plano
        '
        Me.lbl_tipo_plano.AutoSize = True
        Me.lbl_tipo_plano.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipo_plano.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_plano.Location = New System.Drawing.Point(349, 231)
        Me.lbl_tipo_plano.Name = "lbl_tipo_plano"
        Me.lbl_tipo_plano.Size = New System.Drawing.Size(141, 28)
        Me.lbl_tipo_plano.TabIndex = 22
        Me.lbl_tipo_plano.Text = "Tipo de Plano:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel6.Controls.Add(Me.cmb_tipo_plano)
        Me.Panel6.Location = New System.Drawing.Point(354, 262)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(279, 39)
        Me.Panel6.TabIndex = 23
        '
        'cmb_tipo_plano
        '
        Me.cmb_tipo_plano.FormattingEnabled = True
        Me.cmb_tipo_plano.Location = New System.Drawing.Point(10, 7)
        Me.cmb_tipo_plano.Name = "cmb_tipo_plano"
        Me.cmb_tipo_plano.Size = New System.Drawing.Size(259, 24)
        Me.cmb_tipo_plano.TabIndex = 0
        '
        'lbl_data_nasc
        '
        Me.lbl_data_nasc.AutoSize = True
        Me.lbl_data_nasc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data_nasc.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_nasc.Location = New System.Drawing.Point(349, 151)
        Me.lbl_data_nasc.Name = "lbl_data_nasc"
        Me.lbl_data_nasc.Size = New System.Drawing.Size(202, 28)
        Me.lbl_data_nasc.TabIndex = 19
        Me.lbl_data_nasc.Text = "Data de Nascimento:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel7.Controls.Add(Me.cmb_data_nasc)
        Me.Panel7.Location = New System.Drawing.Point(354, 182)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(279, 39)
        Me.Panel7.TabIndex = 20
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(10, 8)
        Me.cmb_data_nasc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(259, 22)
        Me.cmb_data_nasc.TabIndex = 9
        Me.cmb_data_nasc.Value = New Date(2026, 5, 4, 0, 0, 0, 0)
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(349, 73)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(169, 28)
        Me.lbl_nome.TabIndex = 16
        Me.lbl_nome.Text = "Nome do Cliente:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel8.Controls.Add(Me.txt_nome)
        Me.Panel8.Location = New System.Drawing.Point(354, 104)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(279, 39)
        Me.Panel8.TabIndex = 17
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(10, 8)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(259, 22)
        Me.txt_nome.TabIndex = 2
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sexo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.Location = New System.Drawing.Point(33, 231)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(66, 28)
        Me.lbl_sexo.TabIndex = 13
        Me.lbl_sexo.Text = "Sexo:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel5.Controls.Add(Me.cmb_sexo)
        Me.Panel5.Location = New System.Drawing.Point(38, 262)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(279, 39)
        Me.Panel5.TabIndex = 14
        '
        'cmb_sexo
        '
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Location = New System.Drawing.Point(10, 8)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(259, 24)
        Me.cmb_sexo.TabIndex = 1
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btn_salvar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(661, 300)
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
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(33, 151)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(52, 28)
        Me.lbl_cpf.TabIndex = 6
        Me.lbl_cpf.Text = "CPF:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txt_cpf)
        Me.Panel4.Location = New System.Drawing.Point(38, 182)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 39)
        Me.Panel4.TabIndex = 8
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(10, 8)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(259, 22)
        Me.txt_cpf.TabIndex = 35
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(33, 73)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(43, 28)
        Me.lbl_id.TabIndex = 2
        Me.lbl_id.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(48, 112)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(259, 22)
        Me.txt_id.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(38, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(279, 39)
        Me.Panel3.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel9.Controls.Add(Me.dgv_info)
        Me.Panel9.Location = New System.Drawing.Point(38, 417)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(767, 202)
        Me.Panel9.TabIndex = 26
        '
        'dgv_info
        '
        Me.dgv_info.AllowUserToAddRows = False
        Me.dgv_info.AllowUserToDeleteRows = False
        Me.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_info.BackgroundColor = System.Drawing.Color.White
        Me.dgv_info.ColumnHeadersHeight = 24
        Me.dgv_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_info.Location = New System.Drawing.Point(10, 11)
        Me.dgv_info.Name = "dgv_info"
        Me.dgv_info.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgv_info.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_info.RowTemplate.Height = 24
        Me.dgv_info.Size = New System.Drawing.Size(747, 180)
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
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column5
        '
        Me.Column5.HeaderText = "E-mail"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Editar"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Excluir"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'frm_gerenciar_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerenciar_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Clientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_tipo_plano As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_data_nasc As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_nome As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cmb_tipo_plano As ComboBox
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgv_info As DataGridView
    Friend WithEvents lbl_email As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lbl_fone As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents cmb_sexo As ComboBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
