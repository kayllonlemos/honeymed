Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_grafico_prestadores

    Private Sub frm_grafico_prestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Top 5 Prestadores com Mais Agendamentos"
        Me.Size = New Size(700, 500)
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim lbl As New Label()
        lbl.Text = "🏆 Top 5 Prestadores — Mais Agendamentos"
        lbl.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(180, 120, 0)
        lbl.AutoSize = True
        lbl.Location = New Point(20, 15)
        Me.Controls.Add(lbl)

        Dim chart As New Chart()
        chart.Location = New Point(20, 55)
        chart.Size = New Size(645, 390)
        chart.BackColor = Color.White
        Me.Controls.Add(chart)

        Dim area As New ChartArea("area1")
        area.BackColor = Color.White
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area.AxisX.LabelStyle.Font = New Font("Segoe UI", 9)
        area.AxisY.LabelStyle.Font = New Font("Segoe UI", 9)
        area.AxisX.LineColor = Color.Silver
        area.AxisY.LineColor = Color.Silver
        area.AxisY.Title = "Nº de Agendamentos"
        area.AxisY.TitleFont = New Font("Segoe UI", 9, FontStyle.Bold)
        chart.ChartAreas.Add(area)

        Dim serie As New Series("Prestadores")
        serie.ChartType = SeriesChartType.Column
        serie.IsValueShownAsLabel = True
        serie.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        serie.LabelForeColor = Color.FromArgb(100, 70, 0)

        Dim cores() As Color = {
            Color.FromArgb(252, 194, 26),
            Color.FromArgb(255, 165, 0),
            Color.FromArgb(255, 213, 80),
            Color.FromArgb(230, 145, 0),
            Color.FromArgb(200, 120, 0)
        }

        Try
            Dim SQL As String = "SELECT TOP 5 p.nome, COUNT(a.id_agendamento) AS total " &
                                "FROM tb_prestadores p " &
                                "INNER JOIN tb_agendamentos a ON a.id_prestador = p.id " &
                                "GROUP BY p.nome ORDER BY total DESC"
            Dim rs = db.Execute(SQL)

            Dim i As Integer = 0
            Do While rs.EOF = False
                Dim nome As String = rs.Fields(0).Value.ToString()
                Dim total As Integer = CInt(rs.Fields(1).Value)
                Dim pt As New DataPoint()
                pt.SetValueXY(nome, total)
                pt.Color = cores(Math.Min(i, cores.Length - 1))
                pt.BorderColor = Color.White
                pt.BorderWidth = 2
                serie.Points.Add(pt)
                rs.MoveNext()
                i += 1
            Loop

            If serie.Points.Count = 0 Then
                serie.Points.AddXY("Sem dados", 0)
            End If

        Catch ex As Exception
            serie.Points.AddXY("Erro: " & ex.Message, 0)
        End Try

        chart.Series.Add(serie)

        Dim legend As New Legend("leg")
        legend.Enabled = False
        chart.Legends.Add(legend)
    End Sub

End Class
