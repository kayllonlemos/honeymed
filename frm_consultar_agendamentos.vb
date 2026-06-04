Public Class frm_consultar_agendamentos
    Private Sub frm_consultar_agendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        AtualizarGrid()
    End Sub

    Private Sub AtualizarGrid()
        Dim selectBase As String = "select a.id_agendamento, c.nome, p.nome, e.especialidade, a.data_agendamento, a.horario " &
                                   "from tb_agendamentos a " &
                                   "inner join tb_clientes c on c.id_cliente = a.id_cliente " &
                                   "inner join tb_prestadores p on p.id = a.id_prestador " &
                                   "inner join tb_especialidades e on e.id = a.id_especialidade"

        Filtrar_Generico(dgv_info, selectBase,
                         "a.id_agendamento", txt_id_agendamento.Text,
                         "a.id_cliente", txt_id_cliente.Text,
                         "order by a.data_agendamento asc, a.horario asc")
    End Sub

    Private Sub txt_id_agendamento_TextChanged(sender As Object, e As EventArgs) Handles txt_id_agendamento.TextChanged
        AtualizarGrid()
    End Sub

    Private Sub txt_id_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_id_cliente.TextChanged
        AtualizarGrid()
    End Sub
End Class