<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_graf_cliente_por_plano
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
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_graf_cliente_por_plano))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TbclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoneymedDataSet2 = New HoneyMed.honeymedDataSet2()
        Me.Tb_clientesTableAdapter = New HoneyMed.honeymedDataSet2TableAdapters.tb_clientesTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoneymedDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.TbclientesBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-7, -2)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1081, 557)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Média de Clientes por Plano"
        Me.Chart1.Titles.Add(Title1)
        '
        'TbclientesBindingSource
        '
        Me.TbclientesBindingSource.DataMember = "tb_clientes"
        Me.TbclientesBindingSource.DataSource = Me.HoneymedDataSet2
        '
        'HoneymedDataSet2
        '
        Me.HoneymedDataSet2.DataSetName = "honeymedDataSet2"
        Me.HoneymedDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_clientesTableAdapter
        '
        Me.Tb_clientesTableAdapter.ClearBeforeFill = True
        '
        'frm_graf_cliente_por_plano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_graf_cliente_por_plano"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assinaturas Por Plano"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoneymedDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents HoneymedDataSet2 As honeymedDataSet2
    Friend WithEvents TbclientesBindingSource As BindingSource
    Friend WithEvents Tb_clientesTableAdapter As honeymedDataSet2TableAdapters.tb_clientesTableAdapter
End Class
