<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_graf_media_prestador
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HoneymedDataSet = New HoneyMed.honeymedDataSet()
        Me.HoneymedDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoneymedDataSet1 = New HoneyMed.honeymedDataSet1()
        Me.TbprestadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_prestadoresTableAdapter = New HoneyMed.honeymedDataSet1TableAdapters.tb_prestadoresTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoneymedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoneymedDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoneymedDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbprestadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.TbprestadoresBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(256, 163)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(606, 373)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Prestadores mais procurados"
        '
        'HoneymedDataSet
        '
        Me.HoneymedDataSet.DataSetName = "honeymedDataSet"
        Me.HoneymedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoneymedDataSetBindingSource
        '
        Me.HoneymedDataSetBindingSource.DataSource = Me.HoneymedDataSet
        Me.HoneymedDataSetBindingSource.Position = 0
        '
        'HoneymedDataSet1
        '
        Me.HoneymedDataSet1.DataSetName = "honeymedDataSet1"
        Me.HoneymedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbprestadoresBindingSource
        '
        Me.TbprestadoresBindingSource.DataMember = "tb_prestadores"
        Me.TbprestadoresBindingSource.DataSource = Me.HoneymedDataSet1
        '
        'Tb_prestadoresTableAdapter
        '
        Me.Tb_prestadoresTableAdapter.ClearBeforeFill = True
        '
        'frm_graf_media_prestador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 636)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "frm_graf_media_prestador"
        Me.Text = "frm_graf_media_prestador"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoneymedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoneymedDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoneymedDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbprestadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents HoneymedDataSetBindingSource As BindingSource
    Friend WithEvents HoneymedDataSet As honeymedDataSet
    Friend WithEvents HoneymedDataSet1 As honeymedDataSet1
    Friend WithEvents TbprestadoresBindingSource As BindingSource
    Friend WithEvents Tb_prestadoresTableAdapter As honeymedDataSet1TableAdapters.tb_prestadoresTableAdapter
End Class
