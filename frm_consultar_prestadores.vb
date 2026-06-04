Public Class frm_consultar_prestadores
    Private Sub frm_consultar_prestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_prestadoresConsulta()
        Carregar_especialidadesConsulta()
        AtualizarGrid()
    End Sub

    Private Sub AtualizarGrid()
        Dim selectBase As String = "select distinct p.id, p.nome, p.email, p.tipo_prestador, p.endereco, p.fone " &
                                   "from tb_prestadores p " &
                                   "left join tb_especialidades e on e.id_prestador = p.id"

        Filtrar_Generico(dgv_info, selectBase,
                         "p.nome", cmb_prestador.Text,
                         "e.especialidade", cmb_especialidade.Text,
                         "order BY p.nome asc")
    End Sub

    Private Sub cmb_prestador_TextChanged(sender As Object, e As EventArgs) Handles cmb_prestador.TextChanged
        AtualizarGrid()
    End Sub

    Private Sub cmb_especialidade_TextChanged(sender As Object, e As EventArgs) Handles cmb_especialidade.TextChanged
        AtualizarGrid()
    End Sub
End Class