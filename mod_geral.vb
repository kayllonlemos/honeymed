Module mod_geral
	Public diretorio, SQL, resp, aux As String
	Public db As New ADODB.Connection
	Public rs As New ADODB.Recordset

	Sub Conectar_banco()
		Try
			db = CreateObject("ADODB.Connection")
			db.Open("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=honeymed;trusted_connection=yes;")
			MsgBox("Conexão Estabelecida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
		Catch ex As Exception
			MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
		End Try
	End Sub

	Sub Carregar_contas()
		Try
			With frm_gerenciar_contas.cmb_tipo_conta.Items
				.Add("Abelha Rainha")
				.Add("Abelha Operária")
			End With
			frm_gerenciar_contas.cmb_tipo_conta.SelectedIndex = 1
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Autocarregar_dados()
		With frm_gerenciar_contas
			Try
				SQL = $"select * from tb_contas where nome_funcionario='{aux}' or email='{aux}'"
				rs = db.Execute(SQL)
				If rs.EOF = False Then
					.txt_usuario.Text = rs.Fields(1).Value
					.cmb_tipo_conta.Text = rs.Fields(2).Value
					.txt_email.Text = rs.Fields(3).Value
					.txt_senha.Text = rs.Fields(4).Value
					.txt_csenha.Text = rs.Fields(4).Value
					.img_foto.Load(rs.Fields(6).Value)
					.txt_fone.Text = rs.Fields(7).Value
				End If
			Catch ex As Exception
				Exit Sub
			End Try
		End With
	End Sub

	Sub Dados_DataGridView()
		Try
			SQL = $"select * from tb_contas order by nome_funcionario asc"
			rs = db.Execute(SQL)
			With frm_gerenciar_contas.dgv_info
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Alimentar_ComboBox()
		Try
			With DirectCast(frm_gerenciar_contas.dgv_info.Columns(3), DataGridViewComboBoxColumn)
				.Items.Clear()
				.Items.Add("ATIVA")
				.Items.Add("INATIVA")
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Limpar_cadastro()
		Try
			With frm_gerenciar_contas
				.txt_usuario.Text = ""
				.txt_email.Text = ""
				.txt_fone.Text = ""
				.txt_senha.Text = ""
				.txt_csenha.Text = ""
				.cmb_tipo_conta.Text = "Abelha Operária"
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Carregar_comboBoxClientes()
		Try
			With frm_gerenciar_clientes.cmb_sexo.Items
				.Add("Masculino")
				.Add("Feminino")
				.Add("Outro")
			End With
			frm_gerenciar_clientes.cmb_sexo.SelectedIndex = 0
			With frm_gerenciar_clientes.cmb_tipo_plano.Items
				.Add("Melzinho")
				.Add("HoneyGold")
				.Add("QueenBee")
			End With
			frm_gerenciar_clientes.cmb_tipo_plano.SelectedIndex = 0
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub
End Module
