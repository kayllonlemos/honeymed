Public Class frm_menu_inicial
    Private Sub GerenciarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarContasToolStripMenuItem.Click
		Try
			frm_gerenciar_contas.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	'Private Sub frm_menu_inicial_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
	'Application.Restart()
	'End Sub

	Private Sub GerenciarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarClientesToolStripMenuItem.Click
		Try
			frm_gerenciar_clientes.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub CoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoToolStripMenuItem.Click

	End Sub
End Class