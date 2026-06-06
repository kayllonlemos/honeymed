Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Gráfico
    Private Sub frm_graf_servicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Server=localhost;Database=honeymed;Trusted_Connection=True;TrustServerCertificate=True;"

        Dim coresServico As Color() = {
            Color.FromArgb(31, 119, 180),
            Color.FromArgb(255, 165, 0),
            Color.FromArgb(255, 140, 0),
            Color.FromArgb(20, 20, 20),
            Color.FromArgb(148, 103, 189),
            Color.FromArgb(44, 160, 44),
            Color.FromArgb(214, 39, 40),
            Color.FromArgb(140, 86, 75)
        }

        Chart1.Series.Clear()
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
        Chart1.ChartAreas(0).BackColor = Color.White
        Chart1.BackColor = Color.White
        Chart1.Titles.Clear()
        Chart1.Titles.Add("Procedimentos mais Procurados")
        Chart1.Titles(0).Font = New Font("Jockey One", 32, FontStyle.Regular)
        Chart1.Titles(0).ForeColor = Color.Black

        Chart1.Legends.Clear()
        Dim legenda As New Legend("Legenda")
        legenda.Docking = Docking.Bottom
        legenda.Alignment = StringAlignment.Center
        legenda.Font = New Font("Bpmf Huninn", 12)
        Chart1.Legends.Add(legenda)

        Chart1.ChartAreas(0).AxisX.Title = "Procedimentos"
        Chart1.ChartAreas(0).AxisX.TitleFont = New Font("Jaldi", 12, FontStyle.Bold)
        Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisY.Interval = 1
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "0"

        Dim serie As New Series("Servicos")
        serie.ChartType = SeriesChartType.Column
        serie.IsValueShownAsLabel = True
        serie.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        serie.LabelForeColor = Color.Black
        serie.CustomProperties = "PointWidth=0.6, GapWidth=0.8"

        Dim nomes As New List(Of String)
        Dim totais As New List(Of Integer)

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT e.especialidade, COUNT(*) AS total
                FROM tb_agendamentos a
                INNER JOIN tb_especialidades e ON a.id_especialidade = e.id
                GROUP BY e.especialidade
                ORDER BY total DESC"

            Dim cmd As New SqlCommand(query, conn)
            conn.Open()

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    nomes.Add(reader("especialidade").ToString())
                    totais.Add(Convert.ToInt32(reader("total")))
                End While
            End Using
        End Using

        For i As Integer = 0 To nomes.Count - 1
            Dim pt As New DataPoint()
            pt.SetValueXY(nomes(i), totais(i))
            pt.Color = coresServico(i Mod coresServico.Length)
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
            item.Color = coresServico(i Mod coresServico.Length)
            item.ImageStyle = LegendImageStyle.Rectangle
            Chart1.Legends("Legenda").CustomItems.Add(item)
        Next

    End Sub
End Class