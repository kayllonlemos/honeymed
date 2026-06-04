Public Class frm_consultar_prestadores
    Private Sub frm_consultar_prestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_prestadoresConsulta()
        Carregar_especialidadesConsulta()
        Dados_DataGridViewConsultaPrestadores()
    End Sub

    Private Sub cmb_prestador_TextChanged(sender As Object, e As EventArgs) Handles cmb_prestador.TextChanged
        Filtrar_DataGridView_Dinamico()
    End Sub

    Private Sub cmb_especialidade_TextChanged(sender As Object, e As EventArgs) Handles cmb_especialidade.TextChanged
        Filtrar_DataGridView_Dinamico()
    End Sub
End Class