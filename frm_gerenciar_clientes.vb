Imports System.Diagnostics.Eventing.Reader

Public Class frm_gerenciar_clientes
    Private Sub frm_gerenciar_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_comboBoxClientes()
        Alimentar_ComboBoxClientes()
        img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
        Dados_DataGridViewClientes()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_cpf.Text = "" Or
            cmb_sexo.Text = "" Or
            txt_fone.Text = "" Or
            txt_nome.Text = "" Or
            cmb_data_nasc.Text = "" Or
            cmb_tipo_plano.Text = "" Or
            txt_email.Text = "" Then
            MsgBox("Preencha os campos vazios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Else
            Try
                SQL = $"select * from tb_clientes where cpf='{txt_cpf.Text}'"
                rs = db.Execute(SQL)
                If rs.EOF = True Then
                    SQL = $"insert into tb_clientes (cpf,sexo,fone,nome,data_nasc,tipo_plano,email,foto)
						values ('{txt_cpf.Text}', '{cmb_sexo.Text}',
						'{txt_fone.Text}', '{txt_nome.Text}',
						'{cmb_data_nasc.Value.ToShortDateString}',
                        '{cmb_tipo_plano.Text}', '{txt_email.Text}', '{diretorio}')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Cliente Registrado com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Limpar_cadastroClientes()
                    Dados_DataGridViewClientes()
                Else
                    MsgBox("Esse Cliente Já Existe!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With New OpenFileDialog()
                .Title = "SELECIONE A FOTO DO CLIENTE"
                .InitialDirectory = (Application.StartupPath & "\Imagens\")
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub txt_id_LostFocus(sender As Object, e As EventArgs) Handles txt_id.LostFocus
        aux = txt_id.Text
        Autocarregar_dadosClientes()
    End Sub
    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        aux = txt_cpf.Text
        Autocarregar_dadosClientes()
    End Sub
    Private Sub txt_email_LostFocus(sender As Object, e As EventArgs) Handles txt_email.LostFocus
        aux = txt_email.Text
        Autocarregar_dadosClientes()
    End Sub

    Private Sub dgv_info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_info.CellContentClick
        Try
            With dgv_info
                If .CurrentRow.Cells(0).Selected = True Or .CurrentRow.Cells(1).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    SQL = $"select * from tb_clientes where id_cliente='{aux}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_id.Text = rs.Fields(0).Value
                        txt_cpf.Text = rs.Fields(1).Value
                        cmb_sexo.Text = rs.Fields(2).Value
                        txt_fone.Text = rs.Fields(3).Value
                        txt_nome.Text = rs.Fields(4).Value
                        cmb_data_nasc.Text = rs.Fields(5).Value
                        cmb_tipo_plano.Text = rs.Fields(6).Value
                        txt_email.Text = rs.Fields(7).Value
                        img_foto.Load(rs.Fields(8).Value)
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux = .CurrentRow.Cells(2).Value
                    SQL = $"select * from tb_clientes where nome='{aux}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja Excluir o Cliente: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            SQL = $"delete from tb_clientes where nome='{aux}'"
                            rs = db.Execute(SQL)
                            Limpar_cadastroClientes()
                            Dados_DataGridViewClientes()
                        End If
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    rs = db.Execute($"select * from tb_clientes where id_cliente='{aux}'")
                    If rs.EOF = False Then
                        Dim cpf = If(txt_cpf.Text <> "", txt_cpf.Text, rs.Fields(1).Value)
                        Dim sexo = If(cmb_sexo.Text <> "", cmb_sexo.Text, rs.Fields(2).Value)
                        Dim fone = If(txt_fone.Text <> "", txt_fone.Text, rs.Fields(3).Value)
                        Dim nome = If(txt_nome.Text <> "", txt_nome.Text, rs.Fields(4).Value)
                        Dim data_nasc = If(cmb_data_nasc.Text <> "", cmb_data_nasc.Text, rs.Fields(5).Value)
                        Dim tipo_plano = If(cmb_tipo_plano.Text <> "", cmb_tipo_plano.Text, rs.Fields(6).Value)
                        Dim email = If(txt_email.Text <> "", txt_email.Text, rs.Fields(7).Value)
                        Dim status = dgv_info.CurrentRow.Cells(3).Value
                        If diretorio = "" Then
                            diretorio = rs.Fields(8).Value
                        End If
                        SQL = $"update tb_clientes set cpf='{cpf}',
											             sexo='{sexo}',
											             fone='{fone}',
											             nome='{nome}',
                                                         data_nasc='{data_nasc}',
											             tipo_plano='{tipo_plano}',
                                                         email='{email}',
                                                         foto='{diretorio}'
											             where id_cliente='{aux}'"
                        rs = db.Execute(UCase(SQL))
                        MsgBox("Dados do Cliente Alterados com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Limpar_cadastroClientes()
                        Dados_DataGridViewClientes()
                        diretorio = ""
                    End If
                End If
                Autocarregar_dadosClientes()
            End With
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class