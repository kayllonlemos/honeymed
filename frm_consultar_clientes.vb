Public Class frm_consultar_clientes
    Private Sub frm_consultar_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        AtualizarGrid()
    End Sub

    Private Sub AtualizarGrid()
        Dim selectBase As String = "select id_cliente, cpf, nome, tipo_plano, email from tb_clientes"

        Filtrar_Generico(dgv_info, selectBase,
                         "id_cliente", txt_id_cliente.Text,
                         "nome", txt_nome.Text,
                         "order by nome asc")
    End Sub

    Private Sub txt_id_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_id_cliente.TextChanged
        AtualizarGrid()
    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged
        AtualizarGrid()
    End Sub
End Class