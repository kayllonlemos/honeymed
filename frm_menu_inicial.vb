Public Class frm_menu_inicial
	Private Sub GerenciarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarContasToolStripMenuItem.Click
		Try
			frm_gerenciar_contas.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub GerenciarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarClientesToolStripMenuItem.Click
		Try
			frm_gerenciar_clientes.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub ConsultarClínicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarPrestadoresToolStripMenuItem.Click
		Try
			frm_gerenciar_prestadores.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub ConsultarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarClienteToolStripMenuItem.Click
		Try
			frm_consultar_clientes.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub ConsultarPrestadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPrestadoresToolStripMenuItem.Click
		Try
			frm_consultar_prestadores.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub ConsultarAgendamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarAgendamentosToolStripMenuItem.Click
		Try
			frm_consultar_agendamentos.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub AgendarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgendarToolStripMenuItem1.Click
		Try
			frm_gerenciar_agendamentos.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
		Try
			frm_about_us.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub frm_menu_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If acesso_admin = False Then
			With MenuStrip1
				GerenciarClientesToolStripMenuItem.Enabled = False
				GerenciarPrestadoresToolStripMenuItem.Enabled = False
				GerenciarContasToolStripMenuItem.Enabled = False
			End With
		End If
	End Sub
End Class