Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_graf_cliente_por_plano
    Private Sub frm_graf_cliente_por_plano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series("Series1").Points.Clear()
        Chart1.Series("Series1").ChartType = SeriesChartType.Column

        Dim connectionString As String = "Server=localhost;Database=honeymed;Trusted_Connection=True;TrustServerCertificate=True;"

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
                    Chart1.Series("Series1").Points.AddXY(
                    reader("tipo_plano").ToString(),
                    Convert.ToInt32(reader("total")))
                End While
            End Using
        End Using

        Chart1.Series("Series1").IsValueShownAsLabel = True
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -45
    End Sub
End Class