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

	Dim WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
	Private Sub frm_menu_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If acesso_admin = False Then
			With MenuStrip1
				GerenciarClientesToolStripMenuItem.Enabled = False
				GerenciarPrestadoresToolStripMenuItem.Enabled = False
				GerenciarContasToolStripMenuItem.Enabled = False
				RelatórioDeClientesToolStripMenuItem.Enabled = False
				RelatórioDeFuncionáriosToolStripMenuItem.Enabled = False
				RelatórioAgendamentosPrestadorToolStripMenuItem.Enabled = False
				RelatórioToolStripMenuItem.Enabled = False
				RelatórioToolStripMenuItem1.Enabled = False
			End With
		End If
		wmp = New AxWMPLib.AxWindowsMediaPlayer()

		panel_fatbee.SuspendLayout()
		panel_fatbee.Controls.Add(wmp)

		wmp.CreateControl()

		wmp.Dock = DockStyle.Fill
		wmp.uiMode = "none"

		AddHandler wmp.PlayStateChange, AddressOf Wmp_PlayStateChange
		wmp.settings.setMode("loop", True)
		wmp.URL = Application.StartupPath & "\Videos\Fat bee playing violin original.mp4"

		panel_fatbee.ResumeLayout()
	End Sub

	Private Sub Wmp_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
		If e.newState = 8 Then
			wmp.settings.mute = True
		End If
	End Sub

	Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
		resp = MsgBox("Deseja Encerrar Sessão?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO!")
		If resp = vbYes Then
			acesso_admin = False
			Application.Restart()
		End If
	End Sub

	Private Sub RelatórioDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDeClientesToolStripMenuItem.Click
		Try
			frm_relatorio_clientes.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub RelatórioDeFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDeFuncionáriosToolStripMenuItem.Click
		Try
			frm_relatorio_funcionarios.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub RelatórioAgendamentosPrestadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioAgendamentosPrestadorToolStripMenuItem.Click
		Try
			frm_graf_media_prestador.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem.Click
		Try
			frm_graf_cliente_por_plano.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub RelatórioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem1.Click
		Try
			Gráfico.ShowDialog()
		Catch ex As Exception
			MsgBox("Erro ao chamar o formulário.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub
End Class