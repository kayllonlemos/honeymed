Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_login.Text = "" Or
            txt_senha.Text = "" Then
            MsgBox("Preencha os todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Else
            Try
                SQL = $"select * from tb_contas where nome_funcionario='{txt_login.Text}' or email='{txt_login.Text}'"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    If UCase(txt_senha.Text) = rs.Fields(4).Value Then
                        If rs.Fields(5).Value = "INATIVA" Then
                            MsgBox("Sua Conta Está INATIVA!" & vbCrLf & "Entre em Contato com o Administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            Exit Sub
                        ElseIf rs.Fields(5).Value = "SUSPENSA" Then
                            MsgBox("Sua Conta Está SUSPENSA!" & vbCrLf & "Entre em Contato com o Administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            Exit Sub
                        End If
                        If rs.Fields(2).Value = "ABELHA RAINHA" Then
                                acesso_admin = True
                            Else
                                acesso_admin = False
                            End If
                            MsgBox("LOGIN EFETUADO COM SUCESSO!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                            Try
                                Me.Hide()
                                frm_menu_inicial.ShowDialog()
                                Me.Close()
                            Catch ex As Exception
                            MsgBox("Erro ao Chamar o Formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        End Try
                        Else
                            MsgBox("SENHA INCORRETA!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                    End If
                Else
                    MsgBox("Usuário ou E-mail Não Existem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
End Class
