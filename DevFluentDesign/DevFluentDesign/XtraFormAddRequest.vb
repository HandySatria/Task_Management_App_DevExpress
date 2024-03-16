﻿Imports MySql.Data.MySqlClient
Public Class XtraFormAddRequest
    Private id As String
    Public nilaiAkhir As String

    Dim tString, mode As String
    Dim cek_simpan As Integer
    Dim divisiDictionary As New Dictionary(Of Integer, String)()
    Dim prioritasDictionary As New Dictionary(Of Integer, String)()

    Sub New(Optional ByVal idRequest As String = "")
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = idRequest
        nilaiAkhir = "Ini nilai akhir"
    End Sub
    Public Function getNilaiAkhir() As String
        Return nilaiAkhir
    End Function

    Sub resetForm()
        TextBoxSubject.Text = ""
        TextBoxDeskripsi.Text = ""
        ComboBoxDivisi.SelectedValue = -1
        ComboBoxPrioritas.SelectedValue = -1
    End Sub
    Sub setComboBoxValue()
        divisiDictionary.Clear()
        ComboBoxDivisi.DataSource = Nothing
        Call Koneksi()
        Cmd = New MySqlCommand("select divisi_id, divisi_name from divisi", Conn)
        Rd = Cmd.ExecuteReader
        divisiDictionary.Add(-1, "Pilih Divisi")
        ComboBoxDivisi.Items.Add(divisiDictionary)
        Do While Rd.Read
            Dim divisiId As String
            divisiId = Rd.Item("divisi_id")
            If divisiId = activeUserData.getDivisionId Then
            Else
                divisiDictionary.Add(Rd.Item("divisi_id"), Rd.Item("divisi_name"))
                ComboBoxDivisi.Items.Add(divisiDictionary)
            End If
        Loop
        ComboBoxDivisi.DisplayMember = "Value"
        ComboBoxDivisi.ValueMember = "Key"
        ComboBoxDivisi.DataSource = New BindingSource(divisiDictionary, Nothing)

        prioritasDictionary.Clear()
        ComboBoxPrioritas.DataSource = Nothing
        Call Koneksi()
        Cmd = New MySqlCommand("select ref_prioritas_id, prioritas_name from ref_prioritas", Conn)
        Rd = Cmd.ExecuteReader
        prioritasDictionary.Add(-1, "Pilih Prioritas")
        ComboBoxPrioritas.Items.Add(prioritasDictionary)
        Do While Rd.Read
            prioritasDictionary.Add(Rd.Item("ref_prioritas_id"), Rd.Item("prioritas_name"))
            ComboBoxPrioritas.Items.Add(prioritasDictionary)
        Loop
        ComboBoxPrioritas.DisplayMember = "Value"
        ComboBoxPrioritas.ValueMember = "Key"
        ComboBoxPrioritas.DataSource = New BindingSource(prioritasDictionary, Nothing)
    End Sub


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        resetForm()
        Me.Close()
    End Sub

    Private Async Sub ButtonSimpan_ClickAsync(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            'ProgressPanelUtil.ShowProgressPanel(Me)
            ButtonSimpan.Enabled = False
            ButtonCancel.Enabled = False
            cek_simpan = 0
            tString = TextBoxSubject.Text
            For j = 0 To tString.Length - 1
                If tString.Chars(j) = "'" Then
                    MsgBox("Tidak Boleh Ada Tanda " & "( ' )" & " Pada Subjek", vbOKOnly, "MESSAGE")
                    TextBoxSubject.Focus()
                    cek_simpan = 1
                End If
            Next
            If cek_simpan = 0 Then
                tString = TextBoxDeskripsi.Text
                For j = 0 To tString.Length - 1
                    If tString.Chars(j) = "'" Then
                        MsgBox("Tidak Boleh Ada Tanda " & "( ' )" & " Pada Deskripsi", vbOKOnly, "MESSAGE")
                        TextBoxDeskripsi.Focus()
                        cek_simpan = 1
                    End If
                Next
            End If
            If cek_simpan = 0 Then
                If TextBoxSubject.Text = "" Then
                    MsgBox("Subject Tidak Boleh Kosong", vbOKOnly, "MESSAGE")
                    cek_simpan = 1
                End If
            End If
            If cek_simpan = 0 Then
                If TextBoxDeskripsi.Text = "" Then
                    MsgBox("Deskripsi Tidak Boleh Kosong", vbOKOnly, "MESSAGE")
                    cek_simpan = 1
                End If
            End If
            If cek_simpan = 0 Then
                If ComboBoxDivisi.SelectedValue = -1 Then
                    MsgBox("Harap Pilih Divisi", vbOKOnly, "MESSAGE")
                    cek_simpan = 1
                End If
            End If
            If cek_simpan = 0 Then
                If ComboBoxPrioritas.SelectedValue = -1 Then
                    MsgBox("Harap Pilih Prioritas", vbOKOnly, "MESSAGE")
                    cek_simpan = 1
                End If
            End If

            If cek_simpan = 0 Then

                If id = "" Then
                    Dim reqNo As String
                    reqNo = GenerteRequestNo()

                    ' add request
                    Call Koneksi()
                    Cmd = New MySqlCommand("INSERT INTO request(request_no, subject, from_divisi, to_divisi, description, status, prioritas, user_id, user_crt, user_upd, dtm_crt, dtm_upd) values(@request_no, @subject,  @from_divisi, @to_divisi, @description, @status, @prioritas, @user_id, @user_crt, @user_upd, @dtm_crt, @dtm_upd) ", Conn)
                    Cmd.Parameters.Add("@request_no", MySqlDbType.VarChar).Value = reqNo
                    Cmd.Parameters.Add("@subject", MySqlDbType.VarChar).Value = TextBoxSubject.Text
                    Cmd.Parameters.Add("@from_divisi", MySqlDbType.VarChar).Value = activeUserData.getDivisionId
                    Cmd.Parameters.Add("@to_divisi", MySqlDbType.VarChar).Value = ComboBoxDivisi.SelectedValue
                    Cmd.Parameters.Add("@prioritas", MySqlDbType.VarChar).Value = ComboBoxPrioritas.SelectedValue
                    Cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = TextBoxDeskripsi.Text
                    Cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = 1
                    Cmd.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = activeUserData.getUserId
                    Cmd.Parameters.Add("@user_crt", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_crt", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now

                    Cmd.ExecuteNonQuery()
                    Cmd = New MySqlCommand("SELECT LAST_INSERT_ID()", Conn)
                    Dim requestId As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

                    Call Koneksi()
                    Cmd = New MySqlCommand("INSERT INTO hist_request(request_id, ref_status_id, user_crt, user_upd, dtm_crt, dtm_upd) values( @request_id, @ref_status_id, @user_crt, @user_upd, @dtm_crt, @dtm_upd) ", Conn)
                    Cmd.Parameters.Add("@request_id", MySqlDbType.VarChar).Value = requestId
                    Cmd.Parameters.Add("@ref_status_id", MySqlDbType.VarChar).Value = "1"
                    Cmd.Parameters.Add("@user_crt", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_crt", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.ExecuteNonQuery()

                    Call Koneksi()
                    Cmd = New MySqlCommand("SELECT user_id, divisi_id, chat_id_telegram FROM user where divisi_id = '" & ComboBoxDivisi.SelectedValue & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    '  Rd.Read()
                    If Rd.HasRows Then
                        Do While Rd.Read
                            Dim chatIdTujuan As Long = Rd.Item("chat_id_telegram")
                            Dim pesan As String
                            pesan = "** TASK BARU DENGAN N0MOR " & reqNo & " **" & Environment.NewLine & Environment.NewLine & Environment.NewLine &
                                "- Dari Divisi : " & activeUserData.getDivisionName & Environment.NewLine & Environment.NewLine &
                                "- Subject : " & TextBoxSubject.Text & Environment.NewLine & Environment.NewLine &
                                "- Deskripsi : " & TextBoxDeskripsi.Text & Environment.NewLine & Environment.NewLine &
                                "- Prioritas : " & ComboBoxPrioritas.Text & Environment.NewLine & Environment.NewLine &
                                "- User : " & activeUserData.getFullName & Environment.NewLine & Environment.NewLine
                            Await KirimPesanKeOrangLainAsync(botClient, chatIdTujuan, pesan, cts.Token)
                        Loop
                    End If
                    MsgBox("Input Data Berhasil", vbOKOnly, "Success Message")

                Else
                    Call Koneksi()
                    Cmd = New MySqlCommand("SELECT user_id, divisi_id, chat_id_telegram FROM user where divisi_id = '" & ComboBoxDivisi.SelectedValue & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    '  Rd.Read()
                    If Rd.HasRows Then
                        Do While Rd.Read
                            Dim chatIdTujuan As Long = Rd.Item("chat_id_telegram")
                            Dim pesan As String
                            pesan = "** EDIT TASK DENGAN ID : " & id & "  **" & Environment.NewLine & Environment.NewLine & Environment.NewLine &
                                "- Dari Divisi : " & activeUserData.getDivisionName & Environment.NewLine & Environment.NewLine &
                                "- Subject : " & TextBoxSubject.Text & Environment.NewLine & Environment.NewLine &
                                "- Deskripsi : " & TextBoxDeskripsi.Text & Environment.NewLine & Environment.NewLine &
                                "- Prioritas : " & ComboBoxPrioritas.Text & Environment.NewLine & Environment.NewLine &
                                "- User : " & activeUserData.getFullName & Environment.NewLine & Environment.NewLine
                            Await KirimPesanKeOrangLainAsync(botClient, chatIdTujuan, pesan, cts.Token)
                        Loop
                    End If

                    Call Koneksi()
                    Cmd = New MySqlCommand("Update request set subject=@subject, to_divisi =@to_divisi, description =@description, prioritas =@prioritas, user_upd =@user_upd, dtm_upd =@dtm_upd where request_id = '" & id & "'", Conn)
                    Cmd.Parameters.Add("@subject", MySqlDbType.VarChar).Value = TextBoxSubject.Text
                    Cmd.Parameters.Add("@to_divisi", MySqlDbType.VarChar).Value = ComboBoxDivisi.SelectedValue
                    Cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = TextBoxDeskripsi.Text
                    Cmd.Parameters.Add("@divisi_id", MySqlDbType.VarChar).Value = ComboBoxDivisi.SelectedValue
                    Cmd.Parameters.Add("@prioritas", MySqlDbType.VarChar).Value = ComboBoxPrioritas.SelectedValue
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.ExecuteNonQuery()
                    MsgBox("Edit Data Berhasil", vbOKOnly, "Success Message")
                End If
                DialogResult = DialogResult.OK
                'resetForm()
                'FormRequest.resetForm()
                'Me.Close()
            End If
            ' ProgressPanelUtil.HideProgressPanel()
            ButtonSimpan.Enabled = True
            ButtonCancel.Enabled = True
        Catch ex As Exception
            'ProgressPanelUtil.HideProgressPanel()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'ProgressPanelUtil.ShowProgressPanel(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'ProgressPanelUtil.HideProgressPanel()
    End Sub

    Private Sub FormAddRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setComboBoxValue()
        If id = "" Then
            mode = "add"
            resetForm()
        Else
            mode = "edit"
            Call Koneksi()
            Cmd = New MySqlCommand("select request_id, request_date, subject, description, from_divisi, to_divisi, prioritas from request where request_id ='" & id & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.HasRows Then
                Do While Rd.Read
                    TextBoxDeskripsi.Text = Rd.Item("description")
                    TextBoxSubject.Text = Rd.Item("subject")
                    ComboBoxDivisi.SelectedValue = Rd.Item("to_divisi")
                    ComboBoxPrioritas.SelectedValue = Rd.Item("prioritas")
                Loop
            End If
        End If
    End Sub
End Class