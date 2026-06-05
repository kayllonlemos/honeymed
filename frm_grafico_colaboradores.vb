Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_grafico_colaboradores

    Private Sub frm_grafico_colaboradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Últimos 5 Colaboradores Cadastrados"
        Me.Size = New Size(700, 500)
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim lbl As New Label()
        lbl.Text = "🐝 Últimos 5 Colaboradores Cadastrados"
        lbl.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(180, 120, 0)
        lbl.AutoSize = True
        lbl.Location = New Point(20, 15)
        Me.Controls.Add(lbl)

        ' Tabela dos colaboradores
        Dim dgv As New DataGridView()
        dgv.Location = New Point(20, 55)
        dgv.Size = New Size(645, 190)
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.RowHeadersVisible = False
        dgv.AllowUserToAddRows = False
        dgv.ReadOnly = True
        dgv.Font = New Font("Segoe UI", 9)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 194, 26)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 70, 0)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.EnableHeadersVisualStyles = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.Columns.Add("id", "ID")
        dgv.Columns.Add("nome", "Nome")
        dgv.Columns.Add("tipo", "Tipo de Conta")
        dgv.Columns.Add("status", "Status")
        Me.Controls.Add(dgv)

        ' Gráfico de barras: distribuição por tipo de conta
        Dim lblChart As New Label()
        lblChart.Text = "Distribuição por Tipo de Conta (todos os colaboradores)"
        lblChart.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblChart.ForeColor = Color.FromArgb(150, 100, 0)
        lblChart.AutoSize = True
        lblChart.Location = New Point(20, 258)
        Me.Controls.Add(lblChart)

        Dim chart As New Chart()
        chart.Location = New Point(20, 285)
        chart.Size = New Size(645, 165)
        chart.BackColor = Color.White
        Me.Controls.Add(chart)

        Dim area As New ChartArea("area1")
        area.BackColor = Color.White
        area.AxisX.LabelStyle.Font = New Font("Segoe UI", 9)
        area.AxisY.LabelStyle.Font = New Font("Segoe UI", 9)
        area.AxisX.LineColor = Color.Silver
        area.AxisY.LineColor = Color.Silver
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area.AxisX.MajorGrid.Enabled = False
        chart.ChartAreas.Add(area)

        Dim serie As New Series("Tipos")
        serie.ChartType = SeriesChartType.Bar
        serie.IsValueShownAsLabel = True
        serie.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        serie.LabelForeColor = Color.FromArgb(100, 70, 0)

        Dim legend As New Legend("leg")
        legend.Enabled = False
        chart.Legends.Add(legend)

        Try
            ' Carrega tabela dos últimos 5
            Dim rs = db.Execute("SELECT TOP 5 id_conta, nome_funcionario, tipo_conta, status_conta FROM tb_contas ORDER BY id_conta DESC")
            Do While rs.EOF = False
                dgv.Rows.Add(
                    rs.Fields(0).Value.ToString(),
                    rs.Fields(1).Value.ToString(),
                    rs.Fields(2).Value.ToString(),
                    rs.Fields(3).Value.ToString()
                )
                rs.MoveNext()
            Loop

            ' Gráfico de tipos de conta (geral)
            Dim rs2 = db.Execute("SELECT tipo_conta, COUNT(*) FROM tb_contas GROUP BY tipo_conta")
            Dim i As Integer = 0
            Dim cores() As Color = {Color.FromArgb(252, 194, 26), Color.FromArgb(255, 140, 0)}
            Do While rs2.EOF = False
                Dim pt As New DataPoint()
                pt.SetValueXY(rs2.Fields(0).Value.ToString(), CInt(rs2.Fields(1).Value))
                pt.Color = cores(Math.Min(i, cores.Length - 1))
                serie.Points.Add(pt)
                rs2.MoveNext()
                i += 1
            Loop

            If serie.Points.Count = 0 Then serie.Points.AddXY("Sem dados", 0)

        Catch ex As Exception
            dgv.Rows.Add("--", "Erro: " & ex.Message, "--", "--")
        End Try

        chart.Series.Add(serie)
    End Sub

End Class
