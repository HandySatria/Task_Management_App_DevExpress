Imports MySql.Data.MySqlClient
Public Class FormAddDivisi
    Dim tString As String
    Dim cek_simpan As Integer

    Private id, namaDivisi As String

    Sub New(Optional ByVal idDivisi As String = "", Optional ByVal NamaDivisi As String = "")
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = idDivisi
        NamaDivisi = NamaDivisi
        TextBoxNamaDivisi.Text = NamaDivisi
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ProgressPanelUtil.ShowProgressPanel(Me)
        tString = TextBoxNamaDivisi.Text
        cek_simpan = 0
        For j = 0 To tString.Length - 1
            If tString.Chars(j) = "'" Then
                MessageBox.Show("Tidak Boleh Ada Tanda " & "( ' )" & " Pada Nama Divisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBoxNamaDivisi.Focus()
                cek_simpan = 1
            End If
        Next
        If cek_simpan = 0 And TextBoxNamaDivisi.Text = "" Then
            MessageBox.Show("Nama Divisi Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cek_simpan = 1
        End If
        If cek_simpan = 0 Then
            Try
                If id = "" Then
                    Call Koneksi()
                    Cmd = New MySqlCommand("INSERT INTO divisi(divisi_name, user_crt, user_upd, dtm_crt,dtm_upd) values(@divisi_name, @user_crt, @user_upd, @dtm_crt,@dtm_upd)  ", Conn)

                    Cmd.Parameters.Add("@divisi_name", MySqlDbType.VarChar).Value = TextBoxNamaDivisi.Text
                    Cmd.Parameters.Add("@user_crt", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_crt", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.ExecuteNonQuery()

                    MessageBox.Show("Input Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Call Koneksi()
                    'ImportData = "INSERT INTO tbl_pegawai VALUES('" & TextBoxNIK.Text & "','" & TextBoxNama.Text & "','" & TglLahir & "','" & status & "','" & ComboBoxStatus.Text & "','" & TglMK & "','" & TglMPT & "','" & ComboBoxGolKer.Text & "')"
                    Cmd = New MySqlCommand("Update divisi set divisi_name=@divisi_name, user_upd=@user_upd, dtm_upd=@dtm_upd where divisi_id = '" & id & "'", Conn)
                    Cmd.Parameters.Add("@divisi_name", MySqlDbType.VarChar).Value = TextBoxNamaDivisi.Text
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now

                    Cmd.ExecuteNonQuery()

                    MessageBox.Show("Edit Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                ' ProgressPanelUtil.HideProgressPanel()
                'FormMasterDivisi.resetForm()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '  ProgressPanelUtil.HideProgressPanel()
            End Try
        End If
        ' ProgressPanelUtil.HideProgressPanel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class