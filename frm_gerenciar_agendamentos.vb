Public Class frm_gerenciar_agendamentos
    Private carregando As Boolean = False

    Private Sub frm_gerenciar_agendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_prestadoresAgendamento()
        datasDisponiveis()
        DataGridViewAgendamentos()
    End Sub
    Private Sub cmb_prestador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prestador.SelectedIndexChanged
        aux = cmb_prestador.Text
        Carregar_especialidadesAgendamento()
        datasDisponiveis()
    End Sub

    Private Sub cmb_data_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_data.SelectedIndexChanged
        If carregando Then Exit Sub
        horariosDisponiveis()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_id_cliente.Text = "" Or
            cmb_prestador.Text = "" Or
            cmb_especialidade.Text = "" Or
            cmb_data.Text = "" Or
            cmb_horario.Text = "" Then
            MsgBox("Preencha os campos vazios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Else
            Try
                rs = db.Execute($"select id_cliente from tb_clientes where id_cliente='{txt_id_cliente.Text}'")
                If rs.EOF Then MsgBox("Cliente Não Encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!") : Exit Sub
                Dim idCliente As Integer = rs.Fields(0).Value

                rs = db.Execute($"select id from tb_prestadores where nome='{cmb_prestador.Text}'")
                Dim idPrestador As Integer = rs.Fields(0).Value

                rs = db.Execute($"select id from tb_especialidades where especialidade='{cmb_especialidade.Text}' and id_prestador={idPrestador}")
                Dim idEspecialidade As Integer = rs.Fields(0).Value

                rs = db.Execute($"select id_agendamento from tb_agendamentos where data_agendamento='{cmb_data.Text}' and horario='{cmb_horario.Text}' and id_prestador={idPrestador}")
                If rs.EOF = True Then
                    SQL = $"insert into tb_agendamentos (id_cliente, id_prestador, id_especialidade, data_agendamento, horario)
                            values ({idCliente}, {idPrestador}, {idEspecialidade}, '{cmb_data.Text}', '{cmb_horario.Text}')"
                    db.Execute(UCase(SQL))
                    MsgBox("Agendamento Registrado com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Limpar_agendamento()
                    DataGridViewAgendamentos()
                Else
                    MsgBox("Esse Horário Está Ocupado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                    horariosDisponiveis()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub dgv_info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_info.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            With dgv_info
                If e.ColumnIndex >= 0 And e.ColumnIndex <= 5 Then
                    aux = .Rows(e.RowIndex).Cells(0).Value

                    rs = db.Execute($"select a.id_agendamento, a.id_cliente, p.nome, e.especialidade, a.data_agendamento, a.horario
                                      from tb_agendamentos a
                                      inner join tb_prestadores p on p.id = a.id_prestador
                                      inner join tb_especialidades e on e.id = a.id_especialidade
                                      where a.id_agendamento={aux}")

                    If rs.EOF = False Then
                        carregando = True

                        Dim vIdAgendamento As String = rs.Fields(0).Value.ToString()
                        Dim vIdCliente As String = rs.Fields(1).Value.ToString()
                        Dim vPrestador As String = rs.Fields(2).Value.ToString()
                        Dim vEspecialidade As String = rs.Fields(3).Value.ToString()
                        Dim vData As String = rs.Fields(4).Value.ToString()
                        Dim vHorario As String = rs.Fields(5).Value.ToString()

                        txt_id_agendamento.Text = vIdAgendamento
                        txt_id_cliente.Text = vIdCliente
                        cmb_prestador.Text = vPrestador
                        aux = cmb_prestador.Text

                        Carregar_especialidadesAgendamento()
                        cmb_especialidade.Text = vEspecialidade

                        datasDisponiveis()
                        cmb_data.Text = vData

                        horariosDisponiveis()
                        cmb_horario.Text = vHorario

                        carregando = False
                    End If

                ElseIf e.ColumnIndex = 6 Then
                    If txt_id_agendamento.Text = "" Then
                        MsgBox("Selecione um agendamento na tabela para editar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                        Exit Sub
                    End If

                    resp = MsgBox("Confirmar a edição deste agendamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                    If resp = MsgBoxResult.Yes Then
                        Try
                            rs = db.Execute($"select id_cliente from tb_clientes where id_cliente='{txt_id_cliente.Text}'")
                            If rs.EOF Then MsgBox("Cliente Não Encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!") : Exit Sub
                            Dim idCliente As Integer = rs.Fields(0).Value

                            rs = db.Execute($"select id from tb_prestadores where nome='{cmb_prestador.Text}'")
                            Dim idPrestador As Integer = rs.Fields(0).Value

                            rs = db.Execute($"select id from tb_especialidades where especialidade='{cmb_especialidade.Text}' and id_prestador={idPrestador}")
                            Dim idEspecialidade As Integer = rs.Fields(0).Value

                            rs = db.Execute($"select id_agendamento from tb_agendamentos where data_agendamento='{cmb_data.Text}' and horario='{cmb_horario.Text}' and id_prestador={idPrestador} and id_agendamento <> {txt_id_agendamento.Text}")
                            If rs.EOF = True Then
                                SQL = $"update tb_agendamentos set id_cliente={idCliente}, id_prestador={idPrestador}, id_especialidade={idEspecialidade}, data_agendamento='{cmb_data.Text}', horario='{cmb_horario.Text}' where id_agendamento={txt_id_agendamento.Text}"
                                db.Execute(UCase(SQL))
                                MsgBox("Agendamento Alterado com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                                Limpar_agendamento()
                                DataGridViewAgendamentos()
                            Else
                                MsgBox("Esse Horário Está Ocupado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                                horariosDisponiveis()
                            End If
                        Catch ex As Exception
                            MsgBox("Erro ao editar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                        End Try
                    End If

                ElseIf e.ColumnIndex = 7 Then
                    aux = .Rows(e.RowIndex).Cells(0).Value
                    resp = MsgBox("Deseja Cancelar o Agendamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        db.Execute($"delete from tb_agendamentos where id_agendamento={aux}")
                        MsgBox("Agendamento Cancelado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Limpar_agendamento()
                        DataGridViewAgendamentos()
                    End If
                End If
            End With

        Catch ex As Exception
            MsgBox("Erro na operação: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class