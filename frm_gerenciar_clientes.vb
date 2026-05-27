Public Class frm_gerenciar_clientes
    Private Sub frm_gerenciar_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_comboBoxClientes()
        img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
    End Sub
End Class