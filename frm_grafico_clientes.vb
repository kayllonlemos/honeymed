Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_grafico_clientes

    Private Sub frm_grafico_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Últimos 5 Clientes Cadastrados"
        Me.Size = New Size(700, 500)
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim lbl As New Label()
        lbl.Text = "👤 Últimos 5 Clientes Cadastrados"
        lbl.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(180, 120, 0)
        lbl.AutoSize = True
        lbl.Location = New Point(20, 15)
        Me.Controls.Add(lbl)

        ' Tabela com os dados dos clientes
        Dim dgv As New DataGridView()
        dgv.Location = New Point(20, 55)
        dgv.Size = New Size(645, 180)
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
        dgv.Columns.Add("plano", "Plano")
        dgv.Columns.Add("email", "E-mail")
        Me.Controls.Add(dgv)

        ' Gráfico de pizza por plano dos últimos 5
        Dim lblChart As New Label()
        lblChart.Text = "Distribuição por Plano (últimos 5)"
        lblChart.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblChart.ForeColor = Color.FromArgb(150, 100, 0)
        lblChart.AutoSize = True
        lblChart.Location = New Point(20, 248)
        Me.Controls.Add(lblChart)

        Dim chart As New Chart()
        chart.Location = New Point(20, 275)
        chart.Size = New Size(645, 175)
        chart.BackColor = Color.White
        Me.Controls.Add(chart)

        Dim area As New ChartArea("area1")
        area.BackColor = Color.White
        chart.ChartAreas.Add(area)

        Dim serie As New Series("Planos")
        serie.ChartType = SeriesChartType.Pie
        serie.IsValueShownAsLabel = True
        serie.LabelFormat = "{0} cliente(s)"
        serie.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Dim legend As New Legend("leg")
        legend.Font = New Font("Segoe UI", 9)
        chart.Legends.Add(legend)

        Dim coresPizza() As Color = {
            Color.FromArgb(252, 194, 26),
            Color.FromArgb(255, 140, 0),
            Color.FromArgb(200, 100, 0)
        }

        Try
            Dim rs = db.Execute("SELECT TOP 5 id_cliente, nome, tipo_plano, email FROM tb_clientes ORDER BY id_cliente DESC")
            Dim planos As New Dictionary(Of String, Integer)

            Do While rs.EOF = False
                Dim id As String = rs.Fields(0).Value.ToString()
                Dim nome As String = rs.Fields(1).Value.ToString()
                Dim plano As String = rs.Fields(2).Value.ToString()
                Dim email As String = rs.Fields(3).Value.ToString()
                dgv.Rows.Add(id, nome, plano, email)

                If planos.ContainsKey(plano) Then
                    planos(plano) += 1
                Else
                    planos(plano) = 1
                End If
                rs.MoveNext()
            Loop

            Dim idx As Integer = 0
            For Each kvp As KeyValuePair(Of String, Integer) In planos
                Dim pt As New DataPoint()
                pt.SetValueXY(kvp.Key, kvp.Value)
                pt.Color = coresPizza(Math.Min(idx, coresPizza.Length - 1))
                serie.Points.Add(pt)
                idx += 1
            Next

            If serie.Points.Count = 0 Then serie.Points.AddXY("Sem dados", 1)

        Catch ex As Exception
            dgv.Rows.Add("--", "Erro: " & ex.Message, "--", "--")
        End Try

        chart.Series.Add(serie)
    End Sub

End Class
