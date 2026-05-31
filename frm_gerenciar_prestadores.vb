Imports System.Security.Policy

Public Class frm_gerenciar_prestadores
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_prestador.Text = "" Or
            txt_email.Text = "" Or
            cmb_tipo_prestador.Text = "" Or
            txt_especialidades.Text = "" Or
            txt_endereco.Text = "" Or
            txt_fone.Text = "" Then
            MsgBox("Preencha os campos vazios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Else
            Try
                SQL = $"select * from tb_prestadores where nome='{txt_prestador.Text}'"
                rs = db.Execute(SQL)
                If rs.EOF = True Then
                    SQL = $"insert into tb_prestadores (nome, email, tipo_prestador, endereco, fone)
                        values ('{txt_prestador.Text}', '{txt_email.Text}',
                        '{cmb_tipo_prestador.Text}', '{txt_endereco.Text}',
                        '{txt_fone.Text}')"
                    rs = db.Execute(UCase(SQL))

                    SQL = "select @@IDENTITY"
                    rs = db.Execute(SQL)
                    Dim idPrestador As Integer = rs.Fields(0).Value

                    Dim especialidades As String() = txt_especialidades.Text.Split(
                        New String() {Environment.NewLine, vbCrLf, vbLf},
                        StringSplitOptions.RemoveEmptyEntries)

                    For Each esp As String In especialidades
                        Dim nomeEsp As String = esp.Trim()
                        If nomeEsp <> "" Then
                            SQL = $"insert into tb_especialidades (id_prestador, especialidade)
                                values ({idPrestador}, '{nomeEsp}')"
                            db.Execute(UCase(SQL))
                        End If
                    Next
                    MsgBox("Prestador Registrado com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Limpar_cadastroPrestadores()
                Else
                    MsgBox("Esse Prestador Já Existe!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub frm_gerenciar_prestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        TipoPrestadoresAuto()
    End Sub



    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            rs = db.Execute($"select id from tb_prestadores where nome='{txt_prestador.Text}'")
            Dim idPrestador As Integer = rs.Fields(0).Value
            SQL = $"update tb_prestadores set nome='{txt_prestador.Text}',
                                                         email='{txt_email.Text}',
											             tipo_prestador='{cmb_tipo_prestador.Text}',
											             endereco='{txt_endereco.Text}',
                                                         fone='{txt_fone.Text}'
											             where id={idPrestador}"
            db.Execute(UCase(SQL))
            db.Execute($"delete from tb_especialidades where id_prestador={idPrestador}")
            Dim especialidades As String() = txt_especialidades.Text.Split(
            New String() {Environment.NewLine, vbCrLf, vbLf},
            StringSplitOptions.RemoveEmptyEntries)

            For Each esp As String In especialidades
                Dim nomeEsp As String = esp.Trim()
                If nomeEsp <> "" Then
                    db.Execute(UCase($"insert into tb_especialidades (id_prestador, especialidade)
                             values ({idPrestador}, '{nomeEsp}')"))
                    PrestadoresAutoPreenchimento()
                End If
            Next
            MsgBox("Dados do Prestador Alterados com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Catch ex As Exception
            MsgBox("Erro ao Alterar Dados do Prestador!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_prestador_LostFocus(sender As Object, e As EventArgs) Handles txt_prestador.LostFocus
        aux = txt_prestador.Text
        PrestadoresAutoPreenchimento()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lbl_fone_Click(sender As Object, e As EventArgs) Handles lbl_fone.Click

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub txt_fone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_fone.MaskInputRejected

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub lbl_especialidades_Click(sender As Object, e As EventArgs) Handles lbl_especialidades.Click

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub txt_especialidades_TextChanged(sender As Object, e As EventArgs) Handles txt_especialidades.TextChanged

    End Sub

    Private Sub lbl_email_Click(sender As Object, e As EventArgs) Handles lbl_email.Click

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub lbl_endereco_Click(sender As Object, e As EventArgs) Handles lbl_endereco.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub txt_endereco_TextChanged(sender As Object, e As EventArgs) Handles txt_endereco.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lbl_tipo_prestador_Click(sender As Object, e As EventArgs) Handles lbl_tipo_prestador.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub cmb_tipo_prestador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_prestador.SelectedIndexChanged

    End Sub

    Private Sub lbl_prestador_Click(sender As Object, e As EventArgs) Handles lbl_prestador.Click

    End Sub

    Private Sub txt_prestador_TextChanged(sender As Object, e As EventArgs) Handles txt_prestador.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class