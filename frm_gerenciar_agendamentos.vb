Public Class frm_gerenciar_agendamentos
    Private Sub frm_gerenciar_agendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_prestadoresAgendamento()
        datasDisponiveis()
        DataGridViewAgendamentos()
    End Sub

    Private Sub cmb_prestador_LostFocus(sender As Object, e As EventArgs) Handles cmb_prestador.LostFocus
        aux = cmb_prestador.Text
        Carregar_especialidadesAgendamento()
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
                    MsgBox("Esse Horário Esta Ocupado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                    horariosDisponiveis()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cmb_data_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_data.SelectedIndexChanged
        horariosDisponiveis()
    End Sub
End Class