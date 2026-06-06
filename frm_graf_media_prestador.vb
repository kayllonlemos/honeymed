Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_graf_media_prestador

    Private Sub frm_graf_media_prestador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Server=localhost;Database=honeymed;Trusted_Connection=True;TrustServerCertificate=True;"

        Dim coresPrestador As Color() = {
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
        Chart1.Titles.Add("Média de Agendamentos por Prestador")
        Chart1.Titles(0).Font = New Font("Segoe UI", 13, FontStyle.Bold)
        Chart1.Titles(0).ForeColor = Color.Black

        Chart1.Legends.Clear()
        Dim legenda As New Legend("Legenda")
        legenda.Docking = Docking.Bottom
        legenda.Alignment = StringAlignment.Center
        legenda.Font = New Font("Segoe UI", 9)
        Chart1.Legends.Add(legenda)

        Chart1.ChartAreas(0).AxisX.Title = "Agendamentos"
        Chart1.ChartAreas(0).AxisX.TitleFont = New Font("Segoe UI", 9)
        Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisY.Interval = 1
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "0"

        ' Série única com pontos coloridos individualmente
        Dim serie As New Series("Prestadores")
        serie.ChartType = SeriesChartType.Column
        serie.IsValueShownAsLabel = True
        serie.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        serie.LabelForeColor = Color.Black
        serie.CustomProperties = "PointWidth=0.6, GapWidth=0.8"

        Dim nomes As New List(Of String)
        Dim totais As New List(Of Integer)

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT p.nome, COUNT(*) AS total
                FROM tb_agendamentos a
                INNER JOIN tb_prestadores p ON a.id_prestador = p.id
                GROUP BY p.nome
                ORDER BY total DESC"

            Dim cmd As New SqlCommand(query, conn)
            conn.Open()

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    nomes.Add(reader("nome").ToString())
                    totais.Add(Convert.ToInt32(reader("total")))
                End While
            End Using
        End Using

        For i As Integer = 0 To nomes.Count - 1
            Dim pt As New DataPoint()
            pt.SetValueXY(nomes(i), totais(i))
            pt.Color = coresPrestador(i Mod coresPrestador.Length)
            pt.LegendText = nomes(i)
            pt.IsValueShownAsLabel = True
            serie.Points.Add(pt)
        Next

        Chart1.Series.Add(serie)

        ' Oculta a entrada genérica da série na legenda e mostra os pontos
        serie.IsVisibleInLegend = False

        ' Cria uma entrada de legenda por ponto
        Chart1.Legends("Legenda").CustomItems.Clear()
        For i As Integer = 0 To nomes.Count - 1
            Dim item As New LegendItem()
            item.Name = nomes(i)
            item.Color = coresPrestador(i Mod coresPrestador.Length)
            item.ImageStyle = LegendImageStyle.Rectangle
            Chart1.Legends("Legenda").CustomItems.Add(item)
        Next

    End Sub

End Class