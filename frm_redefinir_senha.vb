Public Class frm_redefinir_senha
    Private Sub btn_rec_senha_Click(sender As Object, e As EventArgs) Handles btn_rec_senha.Click
        If txt_cod_mestre.Text = "" Or
                txt_login.Text = "" Or
            txt_nova_senha.Text = "" Then
            MsgBox("Preencha os todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Else
            If txt_cod_mestre.Text = "admin" Then
                resp = MsgBox("Deseja Mesmo Redefinir a Senha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                If resp = vbYes Then
                    SQL = $"update tb_contas set senha='{txt_nova_senha.Text}'
											  where nome_funcionario='{txt_login.Text}' or email='{txt_login.Text}'"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Senha Redefinida com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                Else
                    Exit Sub
                End If
            Else
                MsgBox("O Código Mestre Está Incorreto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
            End If
        End If
    End Sub

    Private Sub frm_redefinir_senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub
End Class