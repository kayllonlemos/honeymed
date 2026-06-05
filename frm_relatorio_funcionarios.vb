Imports System.Diagnostics.Eventing.Reader

Public Class frm_relatorio_funcionarios
    Private Sub frm_relatorio_formularios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
        CarregarUltimosFuncionarios()
    End Sub

    Private Sub CarregarUltimosFuncionarios()
        Try
            SQL = "SELECT TOP 5 * FROM tb_contas ORDER BY nome_funcionario DESC"
            rs = db.Execute(UCase(SQL))
            With DirectCast(dgv_info.Columns(3), DataGridViewComboBoxColumn)
                .Items.Clear()
                .Items.Add("ABELHA OPERÁRIA")
                .Items.Add("ABELHA RAINHA")
            End With
            With dgv_info
                While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value,
                              rs.Fields(2).Value)
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

                    SQL = $"SELECT * FROM tb_contas WHERE nome_funcionario = '{aux}'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        txt_usuario.Text = rs.Fields(1).Value
                        txt_tipo_conta.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                        img_foto.Load(rs.Fields(6).Value)
                        txt_fone.Text = rs.Fields(7).Value
                        If Not IsDBNull(rs.Fields(6).Value) AndAlso rs.Fields(6).Value.ToString() <> "" Then
                            img_foto.Load(rs.Fields(6).Value.ToString())
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