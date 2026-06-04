Public Class frm_consultar_prestadores
    Private Sub frm_consultar_prestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_prestadoresConsulta()
        Carregar_especialidadesConsulta()
        Dados_DataGridViewConsultaPrestadores()
    End Sub

    Private Sub cmb_prestador_TextChanged(sender As Object, e As EventArgs) Handles cmb_prestador.TextChanged
        If cmb_prestador.Text = "" Then
            Dados_DataGridViewConsultaPrestadores()
        Else
            aux = cmb_prestador.Text
            aux2 = cmb_especialidade.Text
            Filtrar_DataGridView_ConsultaPrestador()
        End If
    End Sub

    Private Sub cmb_especialidade_TextChanged(sender As Object, e As EventArgs) Handles cmb_especialidade.TextChanged
        If cmb_especialidade.Text = "" Then
            Dados_DataGridViewConsultaPrestadores()
        Else
            aux = cmb_prestador.Text
            aux2 = cmb_especialidade.Text
            Filtrar_DataGridView_ConsultaEspecialidade()
        End If
    End Sub
End Class