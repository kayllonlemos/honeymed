Public Class frm_consultar_prestadores
    Private Sub frm_consultar_prestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_prestadoresConsulta()
        Carregar_especialidadesConsulta()
        Dados_DataGridViewConsultaPrestadores()
    End Sub

    Private Sub cmb_prestador_LostFocus(sender As Object, e As EventArgs) Handles cmb_prestador.LostFocus
        aux = cmb_prestador.Text
        If cmb_prestador.Text = "" And cmb_especialidade.Text = "" Then
            Dados_DataGridViewConsultaPrestadores()
        ElseIf cmb_especialidade.Text = "" Then
            Filtrar_DataGridView_ConsultaPrestador()
        Else
            Filtrar_DataGridView_Consulta()
        End If
    End Sub

    Private Sub cmb_especialidade_LostFocus(sender As Object, e As EventArgs) Handles cmb_especialidade.LostFocus
        aux2 = cmb_especialidade.Text
        If cmb_especialidade.Text = "" And cmb_prestador.Text = "" Then
            Dados_DataGridViewConsultaPrestadores()
        ElseIf cmb_prestador.Text = "" Then
            Filtrar_DataGridView_ConsultaEspecialidade()
        Else
            Filtrar_DataGridView_Consulta()
        End If
    End Sub

End Class