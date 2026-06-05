<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerenciar_agendamentos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciar_agendamentos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_id_agendamento = New System.Windows.Forms.Label()
        Me.txt_id_agendamento = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_frm_ger_agendamentos = New System.Windows.Forms.Label()
        Me.lbl_horario = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmb_horario = New System.Windows.Forms.ComboBox()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmb_data = New System.Windows.Forms.ComboBox()
        Me.lbl_especialidade = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmb_especialidade = New System.Windows.Forms.ComboBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_prestador = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmb_prestador = New System.Windows.Forms.ComboBox()
        Me.lbl_id_cliente = New System.Windows.Forms.Label()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgv_info = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(0, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(857, 591)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_id_agendamento)
        Me.Panel1.Controls.Add(Me.txt_id_agendamento)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lbl_frm_ger_agendamentos)
        Me.Panel1.Controls.Add(Me.lbl_horario)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.lbl_data)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.lbl_especialidade)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_salvar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_prestador)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lbl_id_cliente)
        Me.Panel1.Controls.Add(Me.txt_id_cliente)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Location = New System.Drawing.Point(7, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(843, 571)
        Me.Panel1.TabIndex = 1
        '
        'lbl_id_agendamento
        '
        Me.lbl_id_agendamento.AutoSize = True
        Me.lbl_id_agendamento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id_agendamento.Font = New System.Drawing.Font("Bpmf Huninn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_id_agendamento.Location = New System.Drawing.Point(350, 82)
        Me.lbl_id_agendamento.Name = "lbl_id_agendamento"
        Me.lbl_id_agendamento.Size = New System.Drawing.Size(207, 26)
        Me.lbl_id_agendamento.TabIndex = 28
        Me.lbl_id_agendamento.Text = "ID do Agendamento:"
        '
        'txt_id_agendamento
        '
        Me.txt_id_agendamento.Location = New System.Drawing.Point(365, 121)
        Me.txt_id_agendamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_id_agendamento.Name = "txt_id_agendamento"
        Me.txt_id_agendamento.Size = New System.Drawing.Size(259, 22)
        Me.txt_id_agendamento.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(354, 112)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(279, 39)
        Me.Panel6.TabIndex = 29
        '
        'lbl_frm_ger_agendamentos
        '
        Me.lbl_frm_ger_agendamentos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_frm_ger_agendamentos.Font = New System.Drawing.Font("Jockey One", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_frm_ger_agendamentos.Location = New System.Drawing.Point(181, 9)
        Me.lbl_frm_ger_agendamentos.Name = "lbl_frm_ger_agendamentos"
        Me.lbl_frm_ger_agendamentos.Size = New System.Drawing.Size(500, 55)
        Me.lbl_frm_ger_agendamentos.TabIndex = 24
        Me.lbl_frm_ger_agendamentos.Text = "Gerenciar Agendamentos:"
        Me.lbl_frm_ger_agendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_horario
        '
        Me.lbl_horario.AutoSize = True
        Me.lbl_horario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_horario.Font = New System.Drawing.Font("Bpmf Huninn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_horario.Location = New System.Drawing.Point(349, 254)
        Me.lbl_horario.Name = "lbl_horario"
        Me.lbl_horario.Size = New System.Drawing.Size(86, 26)
        Me.lbl_horario.TabIndex = 19
        Me.lbl_horario.Text = "Horário:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel7.Controls.Add(Me.cmb_horario)
        Me.Panel7.Location = New System.Drawing.Point(355, 284)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(279, 39)
        Me.Panel7.TabIndex = 20
        '
        'cmb_horario
        '
        Me.cmb_horario.FormattingEnabled = True
        Me.cmb_horario.Location = New System.Drawing.Point(10, 7)
        Me.cmb_horario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_horario.Name = "cmb_horario"
        Me.cmb_horario.Size = New System.Drawing.Size(259, 24)
        Me.cmb_horario.TabIndex = 2
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data.Font = New System.Drawing.Font("Bpmf Huninn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_data.Location = New System.Drawing.Point(349, 166)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(61, 26)
        Me.lbl_data.TabIndex = 16
        Me.lbl_data.Text = "Data:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel8.Controls.Add(Me.cmb_data)
        Me.Panel8.Location = New System.Drawing.Point(355, 196)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(279, 39)
        Me.Panel8.TabIndex = 17
        '
        'cmb_data
        '
        Me.cmb_data.FormattingEnabled = True
        Me.cmb_data.Location = New System.Drawing.Point(10, 7)
        Me.cmb_data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(259, 24)
        Me.cmb_data.TabIndex = 2
        '
        'lbl_especialidade
        '
        Me.lbl_especialidade.AutoSize = True
        Me.lbl_especialidade.BackColor = System.Drawing.Color.Transparent
        Me.lbl_especialidade.Font = New System.Drawing.Font("Bpmf Huninn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_especialidade.Location = New System.Drawing.Point(33, 254)
        Me.lbl_especialidade.Name = "lbl_especialidade"
        Me.lbl_especialidade.Size = New System.Drawing.Size(143, 26)
        Me.lbl_especialidade.TabIndex = 13
        Me.lbl_especialidade.Text = "Especialidade:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel5.Controls.Add(Me.cmb_especialidade)
        Me.Panel5.Location = New System.Drawing.Point(37, 283)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(279, 39)
        Me.Panel5.TabIndex = 14
        '
        'cmb_especialidade
        '
        Me.cmb_especialidade.FormattingEnabled = True
        Me.cmb_especialidade.Location = New System.Drawing.Point(10, 7)
        Me.cmb_especialidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_especialidade.Name = "cmb_especialidade"
        Me.cmb_especialidade.Size = New System.Drawing.Size(259, 24)
        Me.cmb_especialidade.TabIndex = 2
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btn_salvar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(661, 279)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        'lbl_prestador
        '
        Me.lbl_prestador.AutoSize = True
        Me.lbl_prestador.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prestador.Font = New System.Drawing.Font("Bpmf Huninn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_prestador.Location = New System.Drawing.Point(33, 166)
        Me.lbl_prestador.Name = "lbl_prestador"
        Me.lbl_prestador.Size = New System.Drawing.Size(106, 26)
        Me.lbl_prestador.TabIndex = 6
        Me.lbl_prestador.Text = "Prestador:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cmb_prestador)
        Me.Panel4.Location = New System.Drawing.Point(37, 196)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 39)
        Me.Panel4.TabIndex = 8
        '
        'cmb_prestador
        '
        Me.cmb_prestador.FormattingEnabled = True
        Me.cmb_prestador.Location = New System.Drawing.Point(10, 7)
        Me.cmb_prestador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_prestador.Name = "cmb_prestador"
        Me.cmb_prestador.Size = New System.Drawing.Size(259, 24)
        Me.cmb_prestador.TabIndex = 1
        '
        'lbl_id_cliente
        '
        Me.lbl_id_cliente.AutoSize = True
        Me.lbl_id_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id_cliente.Font = New System.Drawing.Font("Bpmf Huninn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_id_cliente.Location = New System.Drawing.Point(33, 82)
        Me.lbl_id_cliente.Name = "lbl_id_cliente"
        Me.lbl_id_cliente.Size = New System.Drawing.Size(139, 26)
        Me.lbl_id_cliente.TabIndex = 2
        Me.lbl_id_cliente.Text = "ID do Cliente:"
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(48, 121)
        Me.txt_id_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(259, 22)
        Me.txt_id_cliente.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(37, 112)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(279, 39)
        Me.Panel3.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel9.Controls.Add(Me.dgv_info)
        Me.Panel9.Location = New System.Drawing.Point(37, 352)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_info.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgv_info.Location = New System.Drawing.Point(11, 11)
        Me.dgv_info.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_info.Name = "dgv_info"
        Me.dgv_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
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
        Me.Column2.HeaderText = "Cliente"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prestador"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Especialidade"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Data"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Horário"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Editar"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column8
        '
        Me.Column8.HeaderText = "Cancelar"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frm_gerenciar_agendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 587)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerenciar_agendamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Agendamentos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_frm_ger_agendamentos As Label
    Friend WithEvents lbl_horario As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_data As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_especialidade As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_prestador As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_id_cliente As Label
    Friend WithEvents txt_id_cliente As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgv_info As DataGridView
    Friend WithEvents cmb_prestador As ComboBox
    Friend WithEvents cmb_especialidade As ComboBox
    Friend WithEvents cmb_horario As ComboBox
    Friend WithEvents cmb_data As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents lbl_id_agendamento As Label
    Friend WithEvents txt_id_agendamento As TextBox
    Friend WithEvents Panel6 As Panel
End Class
