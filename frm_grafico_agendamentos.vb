Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_grafico_agendamentos

    Private Sub frm_grafico_agendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Agendamentos — Marcados vs Desmarcados"
        Me.Size = New Size(750, 520)
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim lbl As New Label()
        lbl.Text = "📅 Agendamentos: Marcados vs Cancelados por Mês"
        lbl.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(180, 120, 0)
        lbl.AutoSize = True
        lbl.Location = New Point(20, 15)
        Me.Controls.Add(lbl)

        ' Cards de resumo
        Dim pnlTotal As New Panel()
        pnlTotal.Location = New Point(20, 55)
        pnlTotal.Size = New Size(200, 70)
        pnlTotal.BackColor = Color.FromArgb(252, 194, 26)
        Me.Controls.Add(pnlTotal)

        Dim lblTotalTitulo As New Label()
        lblTotalTitulo.Text = "Total Agendamentos"
        lblTotalTitulo.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblTotalTitulo.ForeColor = Color.FromArgb(100, 70, 0)
        lblTotalTitulo.AutoSize = True
        lblTotalTitulo.Location = New Point(10, 8)
        pnlTotal.Controls.Add(lblTotalTitulo)

        Dim lblTotalValor As New Label()
        lblTotalValor.Name = "lblTotalValor"
        lblTotalValor.Text = "..."
        lblTotalValor.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblTotalValor.ForeColor = Color.FromArgb(80, 50, 0)
        lblTotalValor.AutoSize = True
        lblTotalValor.Location = New Point(10, 30)
        pnlTotal.Controls.Add(lblTotalValor)

        Dim pnlMedia As New Panel()
        pnlMedia.Location = New Point(235, 55)
        pnlMedia.Size = New Size(200, 70)
        pnlMedia.BackColor = Color.FromArgb(255, 220, 100)
        Me.Controls.Add(pnlMedia)

        Dim lblMediaTitulo As New Label()
        lblMediaTitulo.Text = "Média por Mês"
        lblMediaTitulo.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblMediaTitulo.ForeColor = Color.FromArgb(100, 70, 0)
        lblMediaTitulo.AutoSize = True
        lblMediaTitulo.Location = New Point(10, 8)
        pnlMedia.Controls.Add(lblMediaTitulo)

        Dim lblMediaValor As New Label()
        lblMediaValor.Name = "lblMediaValor"
        lblMediaValor.Text = "..."
        lblMediaValor.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblMediaValor.ForeColor = Color.FromArgb(80, 50, 0)
        lblMediaValor.AutoSize = True
        lblMediaValor.Location = New Point(10, 30)
        pnlMedia.Controls.Add(lblMediaValor)

        ' Gráfico de rosca: marcados vs cancelados
        Dim chart As New Chart()
        chart.Location = New Point(20, 140)
        chart.Size = New Size(350, 330)
        chart.BackColor = Color.White
        Me.Controls.Add(chart)

        Dim area As New ChartArea("area1")
        area.BackColor = Color.White
        chart.ChartAreas.Add(area)

        Dim serie As New Series("Status")
        serie.ChartType = SeriesChartType.Doughnut
        serie("DoughnutRadius") = "55"
        serie.IsValueShownAsLabel = True
        serie.LabelFormat = "{0} ({P0})"
        serie.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Dim legend As New Legend("leg")
        legend.Font = New Font("Segoe UI", 9)
        chart.Legends.Add(legend)

        ' Gráfico de barras: agendamentos por mês
        Dim chart2 As New Chart()
        chart2.Location = New Point(385, 140)
        chart2.Size = New Size(340, 330)
        chart2.BackColor = Color.White
        Me.Controls.Add(chart2)

        Dim area2 As New ChartArea("area2")
        area2.BackColor = Color.White
        area2.AxisX.LabelStyle.Font = New Font("Segoe UI", 8)
        area2.AxisX.LabelStyle.Angle = -35
        area2.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area2.AxisX.MajorGrid.Enabled = False
        area2.AxisX.LineColor = Color.Silver
        area2.AxisY.LineColor = Color.Silver
        area2.AxisY.Title = "Agendamentos"
        area2.AxisY.TitleFont = New Font("Segoe UI", 8, FontStyle.Bold)
        chart2.ChartAreas.Add(area2)

        Dim serieMes As New Series("Por Mês")
        serieMes.ChartType = SeriesChartType.Column
        serieMes.IsValueShownAsLabel = True
        serieMes.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        serieMes.Color = Color.FromArgb(252, 194, 26)
        serieMes.LabelForeColor = Color.FromArgb(100, 70, 0)
        serieMes.BorderColor = Color.White
        serieMes.BorderWidth = 2

        Dim legend2 As New Legend("leg2")
        legend2.Enabled = False
        chart2.Legends.Add(legend2)

        Dim lblChart2 As New Label()
        lblChart2.Text = "Agendamentos por Mês (últimos 6 meses)"
        lblChart2.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblChart2.ForeColor = Color.FromArgb(150, 100, 0)
        lblChart2.AutoSize = True
        lblChart2.Location = New Point(385, 125)
        Me.Controls.Add(lblChart2)

        Try
            ' Total geral
            Dim rsTotal = db.Execute("SELECT COUNT(*) FROM tb_agendamentos")
            Dim total As Integer = CInt(rsTotal.Fields(0).Value)
            CType(pnlTotal.Controls("lblTotalValor"), Label).Text = total.ToString()

            ' Agendamentos por mês (últimos 6 meses) — usando SUBSTRING no SQL Server
            Dim rsMes = db.Execute(
                "SELECT TOP 6 " &
                "  SUBSTRING(data_agendamento, 4, 7) AS mes, " &
                "  COUNT(*) AS total " &
                "FROM tb_agendamentos " &
                "GROUP BY SUBSTRING(data_agendamento, 4, 7) " &
                "ORDER BY mes DESC")

            Dim totalMeses As Integer = 0
            Dim qtdMeses As Integer = 0
            Dim listaMeses As New List(Of (mes As String, total As Integer))

            Do While rsMes.EOF = False
                listaMeses.Add((rsMes.Fields(0).Value.ToString(), CInt(rsMes.Fields(1).Value)))
                totalMeses += CInt(rsMes.Fields(1).Value)
                qtdMeses += 1
                rsMes.MoveNext()
            Loop

            ' Plota do mais antigo ao mais recente
            listaMeses.Reverse()
            For Each item In listaMeses
                Dim pt As New DataPoint()
                pt.SetValueXY(item.mes, item.total)
                serieMes.Points.Add(pt)
            Next

            Dim media As Double = If(qtdMeses > 0, Math.Round(totalMeses / qtdMeses, 1), 0)
            CType(pnlMedia.Controls("lblMediaValor"), Label).Text = media.ToString("0.0")

            If serieMes.Points.Count = 0 Then serieMes.Points.AddXY("Sem dados", 0)

            ' Rosca: comparação marcados x "cancelados" (simulado: total vs sem agendamento no mês atual)
            Dim mesAtual As String = DateTime.Now.ToString("MM/yyyy")
            Dim rsMarcados = db.Execute("SELECT COUNT(*) FROM tb_agendamentos")
            Dim marcados As Integer = CInt(rsMarcados.Fields(0).Value)

            ' Simulação de cancelados: registros sem agendamento (clientes sem tb_agendamentos)
            Dim rsCancelados = db.Execute(
                "SELECT COUNT(*) FROM tb_clientes c " &
                "WHERE NOT EXISTS (SELECT 1 FROM tb_agendamentos a WHERE a.id_cliente = c.id_cliente)")
            Dim semAgendamento As Integer = CInt(rsCancelados.Fields(0).Value)

            Dim ptMarcado As New DataPoint()
            ptMarcado.SetValueXY("Com Agendamento", marcados)
            ptMarcado.Color = Color.FromArgb(252, 194, 26)
            serie.Points.Add(ptMarcado)

            Dim ptCancel As New DataPoint()
            ptCancel.SetValueXY("Sem Agendamento", semAgendamento)
            ptCancel.Color = Color.FromArgb(200, 200, 200)
            serie.Points.Add(ptCancel)

        Catch ex As Exception
            serie.Points.AddXY("Erro", 1)
        End Try

        chart.Series.Add(serie)
        chart2.Series.Add(serieMes)
    End Sub

End Class
