Imports System.Diagnostics.Eventing.Reader

Public Class frm_relatorio_clientes
    Private Sub frm_relatorio_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
        CarregarUltimosClientes()
    End Sub

    Private Sub CarregarUltimosClientes()
        Try
            SQL = "SELECT TOP 5 * FROM tb_clientes ORDER BY id_cliente DESC"
            rs = db.Execute(UCase(SQL))

            With dgv_info
                While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value,
                              rs.Fields(6).Value, rs.Fields(7).Value)
                    rs.MoveNext()
                End While


            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os últimos clientes: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub dgv_info_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_info.CellClick
        If e.RowIndex >= 0 Then
            Try
                With dgv_info
                    Dim aux As String = .Rows(e.RowIndex).Cells(0).Value.ToString()

                    SQL = $"SELECT * FROM tb_clientes WHERE id_cliente = '{aux}'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        txt_id.Text = rs.Fields(0).Value.ToString()
                        txt_cpf.Text = rs.Fields(1).Value.ToString()
                        txt_sexo.Text = rs.Fields(2).Value.ToString()
                        txt_fone.Text = rs.Fields(3).Value.ToString()
                        txt_nome.Text = rs.Fields(4).Value.ToString()
                        cmb_data_nasc.Text = rs.Fields(5).Value.ToString()
                        txt_tipo_plano.Text = rs.Fields(6).Value.ToString()
                        txt_email.Text = rs.Fields(7).Value.ToString()

                        If Not IsDBNull(rs.Fields(8).Value) AndAlso rs.Fields(8).Value.ToString() <> "" Then
                            img_foto.Load(rs.Fields(8).Value.ToString())
                        Else
                            img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
                        End If
                    End If
                End With
            Catch ex As Exception
                MsgBox("Erro ao carregar dados do cliente: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
End Class
