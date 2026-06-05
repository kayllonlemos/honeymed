Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_grafico_servicos

    Private Sub frm_grafico_servicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Serviços Mais Procurados e Planos de Clientes"
        Me.Size = New Size(850, 540)
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen

        ' --- TÍTULO ---
        Dim lbl As New Label()
        lbl.Text = "⭐ Top 5 Serviços Mais Procurados"
        lbl.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(180, 120, 0)
        lbl.AutoSize = True
        lbl.Location = New Point(20, 15)
        Me.Controls.Add(lbl)

        ' --- GRÁFICO 1: Top 5 especialidades (barra horizontal) ---
        Dim chart1 As New Chart()
        chart1.Location = New Point(20, 50)
        chart1.Size = New Size(490, 440)
        chart1.BackColor = Color.White
        Me.Controls.Add(chart1)

        Dim area1 As New ChartArea("area1")
        area1.BackColor = Color.White
        area1.AxisX.LabelStyle.Font = New Font("Segoe UI", 9)
        area1.AxisY.LabelStyle.Font = New Font("Segoe UI", 9)
        area1.AxisX.LineColor = Color.Silver
        area1.AxisY.LineColor = Color.Silver
        area1.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area1.AxisX.MajorGrid.Enabled = False
        area1.AxisY.Title = "Nº de Agendamentos"
        area1.AxisY.TitleFont = New Font("Segoe UI", 9, FontStyle.Bold)
        chart1.ChartAreas.Add(area1)

        Dim serie1 As New Series("Especialidades")
        serie1.ChartType = SeriesChartType.Bar
        serie1.IsValueShownAsLabel = True
        serie1.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        serie1.LabelForeColor = Color.FromArgb(100, 70, 0)

        Dim cores() As Color = {
            Color.FromArgb(252, 194, 26),
            Color.FromArgb(255, 165, 0),
            Color.FromArgb(255, 213, 80),
            Color.FromArgb(230, 145, 0),
            Color.FromArgb(200, 120, 0)
        }

        Dim leg1 As New Legend("leg1")
        leg1.Enabled = False
        chart1.Legends.Add(leg1)

        ' --- TÍTULO GRÁFICO 2 ---
        Dim lbl2 As New Label()
        lbl2.Text = "Clientes por Plano"
        lbl2.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lbl2.ForeColor = Color.FromArgb(180, 120, 0)
        lbl2.AutoSize = True
        lbl2.Location = New Point(525, 15)
        Me.Controls.Add(lbl2)

        ' --- GRÁFICO 2: Clientes por plano (pizza) ---
        Dim chart2 As New Chart()
        chart2.Location = New Point(525, 50)
        chart2.Size = New Size(300, 280)
        chart2.BackColor = Color.White
        Me.Controls.Add(chart2)

        Dim area2 As New ChartArea("area2")
        area2.BackColor = Color.White
        chart2.ChartAreas.Add(area2)

        Dim serie2 As New Series("Planos")
        serie2.ChartType = SeriesChartType.Pie
        serie2.IsValueShownAsLabel = True
        serie2.LabelFormat = "{0}\n({P0})"
        serie2.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        serie2("PieLabelStyle") = "Outside"

        Dim leg2 As New Legend("leg2")
        leg2.Font = New Font("Segoe UI", 9)
        leg2.Docking = Docking.Bottom
        chart2.Legends.Add(leg2)

        Dim coresPlano() As Color = {
            Color.FromArgb(252, 194, 26),
            Color.FromArgb(255, 140, 0),
            Color.FromArgb(180, 90, 0)
        }

        ' --- TABELA DE CONTAGEM POR PLANO ---
        Dim lblTab As New Label()
        lblTab.Text = "Detalhes por Plano"
        lblTab.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblTab.ForeColor = Color.FromArgb(150, 100, 0)
        lblTab.AutoSize = True
        lblTab.Location = New Point(525, 340)
        Me.Controls.Add(lblTab)

        Dim dgv As New DataGridView()
        dgv.Location = New Point(525, 365)
        dgv.Size = New Size(300, 125)
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
        dgv.Columns.Add("plano", "Plano")
        dgv.Columns.Add("qtd", "Clientes")
        Me.Controls.Add(dgv)

        Try
            
            Dim rs1 = db.Execute(
                "SELECT TOP 5 e.especialidade, COUNT(a.id_agendamento) AS total " &
                "FROM tb_especialidades e " &
                "INNER JOIN tb_agendamentos a ON a.id_especialidade = e.id " &
                "GROUP BY e.especialidade " &
                "ORDER BY total DESC")

            Dim i As Integer = 0
            Do While rs1.EOF = False
                Dim pt As New DataPoint()
                pt.SetValueXY(rs1.Fields(0).Value.ToString(), CInt(rs1.Fields(1).Value))
                pt.Color = cores(Math.Min(i, cores.Length - 1))
                serie1.Points.Add(pt)
                rs1.MoveNext()
                i += 1
            Loop

            If serie1.Points.Count = 0 Then serie1.Points.AddXY("Sem dados", 0)

            ' Clientes por plano
            Dim rs2 = db.Execute("SELECT tipo_plano, COUNT(*) FROM tb_clientes GROUP BY tipo_plano ORDER BY COUNT(*) DESC")
            Dim j As Integer = 0
            Do While rs2.EOF = False
                Dim plano As String = rs2.Fields(0).Value.ToString()
                Dim qtd As Integer = CInt(rs2.Fields(1).Value)

                Dim pt2 As New DataPoint()
                pt2.SetValueXY(plano, qtd)
                pt2.Color = coresPlano(Math.Min(j, coresPlano.Length - 1))
                serie2.Points.Add(pt2)

                dgv.Rows.Add(plano, qtd)
                rs2.MoveNext()
                j += 1
            Next

            If serie2.Points.Count = 0 Then serie2.Points.AddXY("Sem dados", 1)

        Catch ex As Exception
            serie1.Points.AddXY("Erro: " & ex.Message, 0)
            serie2.Points.AddXY("Erro", 1)
        End Try

        chart1.Series.Add(serie1)
        chart2.Series.Add(serie2)
    End Sub

End Class
