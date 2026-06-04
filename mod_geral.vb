Module mod_geral
	Public diretorio, SQL, resp, aux, aux2 As String
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

	Sub Autocarregar_dadosClientes()
		With frm_gerenciar_clientes
			Try
				If IsNumeric(aux) Then
					SQL = $"select * from tb_clientes where id_cliente='{aux}'"
				Else
					SQL = $"select * from tb_clientes where cpf='{aux}' or email='{aux}'"
				End If
				rs = db.Execute(SQL)
				If rs.EOF = False Then
					.txt_id.Text = rs.Fields(0).Value
					.txt_cpf.Text = rs.Fields(1).Value
					.cmb_sexo.Text = rs.Fields(2).Value
					.txt_fone.Text = rs.Fields(3).Value
					.txt_nome.Text = rs.Fields(4).Value
					.cmb_data_nasc.Text = rs.Fields(5).Value
					.cmb_tipo_plano.Text = rs.Fields(6).Value
					.txt_email.Text = rs.Fields(7).Value
					.img_foto.Load(rs.Fields(8).Value)
				End If
			Catch ex As Exception
				Exit Sub
			End Try
		End With
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
	Sub Dados_DataGridViewClientes()
		Try
			SQL = $"select * from tb_clientes order by id_cliente asc"
			rs = db.Execute(SQL)
			With frm_gerenciar_clientes.dgv_info
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
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

	Sub Alimentar_ComboBoxClientes()
		Try
			With DirectCast(frm_gerenciar_clientes.dgv_info.Columns(3), DataGridViewComboBoxColumn)
				.Items.Clear()
				.Items.Add("MELZINHO")
				.Items.Add("HONEYGOLD")
				.Items.Add("QUEENBEE")
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
				.cmb_tipo_conta.Text = ""
				.cmb_tipo_conta.Text = "Abelha Operária"
				.img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Limpar_cadastroClientes()
		Try
			With frm_gerenciar_clientes
				.txt_cpf.Text = ""
				.cmb_sexo.Text = ""
				.txt_fone.Text = ""
				.txt_nome.Text = ""
				.cmb_data_nasc.Text = ""
				.cmb_tipo_plano.Text = ""
				.txt_email.Text = ""
				.img_foto.Load(Application.StartupPath & "\Imagens\quem-e-esse-pokemon.png")
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

	Sub TipoPrestadoresAuto()
		With frm_gerenciar_prestadores.cmb_tipo_prestador.Items
			.Add("HOSPITAL")
			.Add("CLÍNICA")
			.Add("LABORATÓRIO")
			.Add("MÉDICO")
		End With
		frm_gerenciar_prestadores.cmb_tipo_prestador.SelectedIndex = 0
	End Sub

	Sub PrestadoresAutoPreenchimento()
		With frm_gerenciar_prestadores
			Try
				SQL = $"select * from tb_prestadores where nome='{aux}'"
				rs = db.Execute(SQL)
				If rs.EOF = False Then
					Dim idPrestador As Integer = rs.Fields(0).Value

					.txt_prestador.Text = rs.Fields(1).Value
					.cmb_tipo_prestador.Text = rs.Fields(3).Value
					.txt_endereco.Text = rs.Fields(4).Value
					.txt_fone.Text = rs.Fields(5).Value
					.txt_email.Text = rs.Fields(2).Value

					SQL = $"select especialidade from tb_especialidades where id_prestador={idPrestador}"
					Dim rsEsp = db.Execute(SQL)

					Dim linhas As New List(Of String)
					Do While rsEsp.EOF = False
						linhas.Add(rsEsp.Fields(0).Value.ToString())
						rsEsp.MoveNext()
					Loop

					.txt_especialidades.Text = String.Join(Environment.NewLine, linhas)
				End If
			Catch ex As Exception
				Exit Sub
			End Try
		End With
	End Sub
	Sub Limpar_cadastroPrestadores()
		Try
			With frm_gerenciar_prestadores
				.txt_prestador.Text = ""
				.txt_email.Text = ""
				.cmb_tipo_prestador.Text = ""
				.txt_especialidades.Text = ""
				.txt_endereco.Text = ""
				.txt_fone.Text = ""
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Carregar_especialidadesAgendamento()
		Try
			With frm_gerenciar_agendamentos.cmb_especialidade.Items
				.Clear()
				rs = db.Execute($"select id from tb_prestadores where nome='{aux}'")
				If rs.EOF Then Exit Sub
				Dim idPrestador As Integer = rs.Fields(0).Value

				SQL = $"select especialidade from tb_especialidades where id_prestador={idPrestador}"
				rs = db.Execute(SQL)
				Do While rs.EOF = False
					.Add(rs.Fields(0).Value.ToString())
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Carregar_prestadoresAgendamento()
		Try
			With frm_gerenciar_agendamentos.cmb_prestador.Items
				.Clear()
				SQL = $"select nome from tb_prestadores"
				rs = db.Execute(SQL)
				Do While rs.EOF = False
					.Add(rs.Fields(0).Value.ToString())
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub
	Sub horariosDisponiveis()
		Try
			With frm_gerenciar_agendamentos.cmb_horario.Items
				.Clear()
				Dim horarios As String() = {"08:00", "09:00", "10:00", "11:00"}
				Dim dataSelecionada As String = frm_gerenciar_agendamentos.cmb_data.Text

				rs = db.Execute($"select id from tb_prestadores where nome='{frm_gerenciar_agendamentos.cmb_prestador.Text}'")
				If rs.EOF Then Exit Sub
				Dim idPrestador As Integer = rs.Fields(0).Value

				Dim queryIgnorarAtual As String = ""
				If frm_gerenciar_agendamentos.txt_id_agendamento.Text <> "" Then
					queryIgnorarAtual = $" and id_agendamento <> {frm_gerenciar_agendamentos.txt_id_agendamento.Text}"
				End If

				For Each h As String In horarios
					SQL = $"select count(*) from tb_agendamentos where data_agendamento='{dataSelecionada}' and horario='{h}' and id_prestador={idPrestador}{queryIgnorarAtual}"
					rs = db.Execute(SQL)
					If rs.Fields(0).Value = 0 Then
						.Add(h)
					End If
				Next

				If .Count > 0 Then frm_gerenciar_agendamentos.cmb_horario.SelectedIndex = 0
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub datasDisponiveis()
		Try
			With frm_gerenciar_agendamentos.cmb_data.Items
				.Clear()
				Dim idPrestador As Integer = 0
				Dim rsPrest = db.Execute($"select id from tb_prestadores where nome='{frm_gerenciar_agendamentos.cmb_prestador.Text}'")
				If Not rsPrest.EOF Then idPrestador = rsPrest.Fields(0).Value

				Dim queryIgnorarAtual As String = ""
				If frm_gerenciar_agendamentos.txt_id_agendamento.Text <> "" Then
					queryIgnorarAtual = $" and id_agendamento <> {frm_gerenciar_agendamentos.txt_id_agendamento.Text}"
				End If

				For i As Integer = 0 To 30
					Dim data As String = DateTime.Now.AddDays(i).ToShortDateString()
					If idPrestador > 0 Then
						SQL = $"select count(*) from tb_agendamentos where data_agendamento='{data}' and id_prestador={idPrestador}{queryIgnorarAtual}"
					Else
						SQL = $"select count(*) from tb_agendamentos where data_agendamento='{data}'{queryIgnorarAtual}"
					End If
					rs = db.Execute(SQL)

					If rs.Fields(0).Value < 4 Then
						.Add(data)
					End If
				Next
				If .Count > 0 Then frm_gerenciar_agendamentos.cmb_data.SelectedIndex = 0
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub DataGridViewAgendamentos()
		Try
			With frm_gerenciar_agendamentos.dgv_info
				.Rows.Clear()
				SQL = $"select a.id_agendamento, c.nome, p.nome, e.especialidade, a.data_agendamento, a.horario
                    from tb_agendamentos a
                    inner join tb_clientes c on c.id_cliente = a.id_cliente
                    inner join tb_prestadores p on p.id = a.id_prestador
                    inner join tb_especialidades e on e.id = a.id_especialidade"
				rs = db.Execute(SQL)
				Do While rs.EOF = False
					.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Limpar_agendamento()
		Try
			With frm_gerenciar_agendamentos
				.txt_id_agendamento.Text = ""
				.txt_id_cliente.Text = ""
				.cmb_prestador.Text = ""
				.cmb_especialidade.Items.Clear()
				.cmb_especialidade.Text = ""
				.cmb_data.Text = ""
				.cmb_horario.Items.Clear()
				.cmb_horario.Text = ""
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Carregar_prestadoresConsulta()
		Try
			With frm_consultar_prestadores.cmb_prestador.Items
				SQL = $"select nome from tb_prestadores order by nome asc"
				rs = db.Execute(SQL)
				Do While rs.EOF = False
					.Add(rs.Fields(0).Value.ToString())
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Carregar_especialidadesConsulta()
		Try
			With frm_consultar_prestadores.cmb_especialidade.Items
				.Clear()
				SQL = "select DISTINCT especialidade from tb_especialidades order by especialidade asc"
				rs = db.Execute(SQL)
				Do While rs.EOF = False
					.Add(rs.Fields(0).Value.ToString())
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Dados_DataGridViewConsultaPrestadores()
		Try
			SQL = $"select * from tb_prestadores order by nome asc"
			rs = db.Execute(SQL)
			With frm_consultar_prestadores.dgv_info
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
					rs.MoveNext()
				Loop
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub

	Sub Filtrar_DataGridView_Dinamico()
		Try
			Dim filtroPrestador As String = frm_consultar_prestadores.cmb_prestador.Text
			Dim filtroEspecialidade As String = frm_consultar_prestadores.cmb_especialidade.Text

			If filtroPrestador = "" And filtroEspecialidade = "" Then
				Dados_DataGridViewConsultaPrestadores()
				Exit Sub
			End If

			SQL = "select distinct p.id, p.nome, p.email, p.tipo_prestador, p.endereco, p.fone " &
				  "from tb_prestadores p "

			If filtroEspecialidade <> "" Then
				SQL &= "inner join tb_especialidades e on e.id_prestador = p.id "
			End If

			SQL &= "where 1=1 "

			If filtroPrestador <> "" Then
				SQL &= $"and p.nome = '{filtroPrestador}' "
			End If

			If filtroEspecialidade <> "" Then
				SQL &= $"and e.especialidade = '{filtroEspecialidade}' "
			End If

			SQL &= "order by p.nome asc"

			rs = db.Execute(SQL)

			With frm_consultar_prestadores.dgv_info
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value,
							  rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
					rs.MoveNext()
				Loop
			End With

		Catch ex As Exception
			MsgBox("Erro ao filtrar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
		End Try
	End Sub
End Module
