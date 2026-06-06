Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_graf_cliente_por_plano

    Private Sub frm_graf_cliente_por_plano_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Server=localhost;Database=honeymed;Trusted_Connection=True;TrustServerCertificate=True;"

        Dim coresPlano As New Dictionary(Of String, Color)(StringComparer.OrdinalIgnoreCase) From {
            {"Melzinho", Color.FromArgb(255, 215, 0)},
            {"HoneyGold", Color.FromArgb(255, 140, 0)},
            {"QueenBee", Color.FromArgb(20, 20, 20)}
        }
        Dim corPadrao As Color = Color.FromArgb(100, 100, 100)

        Chart1.Series.Clear()
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
        Chart1.ChartAreas(0).BackColor = Color.White
        Chart1.BackColor = Color.White
        Chart1.Titles.Clear()
        Chart1.Titles.Add("Média de Assinaturas por Plano")
        Chart1.Titles(0).Font = New Font("Jockey One", 32, FontStyle.Regular)
        Chart1.Titles(0).ForeColor = Color.Black

        Chart1.Legends.Clear()
        Dim legenda As New Legend("Legenda")
        legenda.Docking = Docking.Bottom
        legenda.Alignment = StringAlignment.Center
        legenda.Font = New Font("Bpmf Huninn", 12)
        Chart1.Legends.Add(legenda)

        Chart1.ChartAreas(0).AxisX.Title = "Assinaturas"
        Chart1.ChartAreas(0).AxisX.TitleFont = New Font("Jaldi", 12, FontStyle.Bold)
        Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisY.Interval = 1
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "0"

        Dim serie As New Series("Planos")
        serie.ChartType = SeriesChartType.Column
        serie.IsValueShownAsLabel = True
        serie.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        serie.LabelForeColor = Color.Black
        serie.CustomProperties = "PointWidth=0.6, GapWidth=0.8"

        Dim nomes As New List(Of String)
        Dim totais As New List(Of Integer)

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT tipo_plano, COUNT(*) AS total
                FROM tb_clientes
                GROUP BY tipo_plano
                ORDER BY total DESC"

            Dim cmd As New SqlCommand(query, conn)
            conn.Open()

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    nomes.Add(reader("tipo_plano").ToString())
                    totais.Add(Convert.ToInt32(reader("total")))
                End While
            End Using
        End Using

        For i As Integer = 0 To nomes.Count - 1
            Dim pt As New DataPoint()
            pt.SetValueXY(nomes(i), totais(i))
            Dim cor As Color = If(coresPlano.ContainsKey(nomes(i)), coresPlano(nomes(i)), corPadrao)
            pt.Color = cor
            pt.LegendText = nomes(i)
            pt.IsValueShownAsLabel = True
            serie.Points.Add(pt)
        Next

        Chart1.Series.Add(serie)

        serie.IsVisibleInLegend = False

        Chart1.Legends("Legenda").CustomItems.Clear()
        For i As Integer = 0 To nomes.Count - 1
            Dim item As New LegendItem()
            item.Name = nomes(i)
            Dim cor As Color = If(coresPlano.ContainsKey(nomes(i)), coresPlano(nomes(i)), corPadrao)
            item.Color = cor
            item.ImageStyle = LegendImageStyle.Rectangle
            Chart1.Legends("Legenda").CustomItems.Add(item)
        Next

    End Sub

End Class