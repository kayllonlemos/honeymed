Imports System.Diagnostics.Eventing.Reader

Public Class frm_gerenciar_contas
    Private Sub frm_gerenciar_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_contas()
        Alimentar_ComboBox()
        img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
        Dados_DataGridView()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_usuario.Text = "" Or
           cmb_tipo_conta.Text = "" Or
           txt_email.Text = "" Or
           txt_fone.Text = "" Or
           txt_senha.Text = "" Or
           txt_csenha.Text = "" Then
            MsgBox("Preencha os campos vazios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        ElseIf txt_senha.Text <> txt_csenha.Text Then
            MsgBox("As duas senhas devem ser idênticas!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Else
            Try
                SQL = $"select * from tb_contas where nome_funcionario='{txt_usuario.Text}' or email='{txt_email.Text}'"
                rs = db.Execute(SQL)
                If rs.EOF = True Then
                    SQL = $"insert into tb_contas (nome_funcionario,tipo_conta,email,senha,status_conta,foto, fone)
						values ('{txt_usuario.Text}', '{cmb_tipo_conta.Text}',
						'{txt_email.Text}', '{txt_senha.Text}',
						'{"ATIVA"}', '{diretorio}',
                        '{txt_fone.Text}')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Conta Criada com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Limpar_cadastro()
                    Dados_DataGridView()
                Else
                    MsgBox("Essa Conta Já Existe!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With New OpenFileDialog()
                .Title = "SELECIONE A FOTO DA CONTA"
                .InitialDirectory = (Application.StartupPath & "\Imagens\")
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        aux = txt_usuario.Text
        Autocarregar_dados()
    End Sub

    Private Sub txt_email_LostFocus(sender As Object, e As EventArgs) Handles txt_email.LostFocus
        aux = txt_email.Text
        Autocarregar_dados()
    End Sub

    Private Sub dgv_info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_info.CellContentClick
        Try
            With dgv_info
                If .CurrentRow.Cells(0).Selected = True Or .CurrentRow.Cells(1).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    SQL = $"select * from tb_contas where nome_funcionario='{txt_usuario.Text}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_usuario.Text = rs.Fields(1).Value
                        cmb_tipo_conta.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                        txt_senha.Text = rs.Fields(4).Value
                        txt_csenha.Text = rs.Fields(4).Value
                        img_foto.Load(rs.Fields(6).Value)
                        txt_fone.Text = rs.Fields(7).Value
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    SQL = $"select * from tb_contas where nome_funcionario='{aux}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja Excluir o Usuário: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            SQL = $"delete from tb_contas where nome_funcionario='{aux}'"
                            rs = db.Execute(SQL)
                            Limpar_cadastro()
                            Dados_DataGridView()
                        End If
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    rs = db.Execute($"select * from tb_contas where nome_funcionario='{aux}'")
                    If rs.EOF = False Then
                        Dim usuario = If(txt_usuario.Text <> "", txt_usuario.Text, rs.Fields(1).Value)
                        Dim tipo = If(cmb_tipo_conta.Text <> "", cmb_tipo_conta.Text, rs.Fields(2).Value)
                        Dim email = If(txt_email.Text <> "", txt_email.Text, rs.Fields(3).Value)
                        Dim senha = If(txt_senha.Text <> "", txt_senha.Text, rs.Fields(4).Value)
                        Dim status = dgv_info.CurrentRow.Cells(3).Value
                        Dim fone = If(txt_fone.Text <> "", txt_fone.Text, rs.Fields(7).Value)
                        If diretorio = "" Then
                            rs = db.Execute($"select foto from tb_contas where nome_funcionario='{aux}'")
                            If rs.EOF = False Then
                                diretorio = rs.Fields(0).Value
                            End If
                        End If
                        SQL = $"update tb_contas set nome_funcionario='{usuario}',
											             tipo_conta='{tipo}',
											             email='{email}',
											             senha='{senha}',
                                                         status_conta='{status}',
											             foto='{diretorio}',
                                                         fone='{fone}'
											             where nome_funcionario='{aux}'"
                        rs = db.Execute(UCase(SQL))
                        MsgBox("Dados Alterados com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Limpar_cadastro()
                        Dados_DataGridView()
                        diretorio = ""
                    End If
                End If
                Autocarregar_dados()
            End With
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class