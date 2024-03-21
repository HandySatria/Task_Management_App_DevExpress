Imports MySql.Data.MySqlClient
Public Class FormAddUser
    Dim tString, mode As String
    Dim cek_simpan As Integer
    Dim divisiDictionary, cabangDictionary As New Dictionary(Of Integer, String)()

    Private id As String

    Sub New(Optional ByVal idUser As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        id = idUser
    End Sub
    Sub resetForm()
        TextBoxNama.Text = ""
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxIdTelegram.Text = ""
        CheckBox1.Checked = False
        ComboBoxDivisi.SelectedValue = -1
        ComboBoxCabang.SelectedValue = -1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cek_simpan = 0
        tString = TextBoxNama.Text
        For j = 0 To tString.Length - 1
            If tString.Chars(j) = "'" Then
                MessageBox.Show("Tidak Boleh Ada Tanda " & "( ' )" & " Pada Nama Lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBoxNama.Focus()
                cek_simpan = 1
            End If
        Next
        If cek_simpan = 0 Then
            tString = TextBoxUsername.Text
            For j = 0 To tString.Length - 1
                If tString.Chars(j) = "'" Then
                    MessageBox.Show("Tidak Boleh Ada Tanda " & "( ' )" & " Pada Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBoxUsername.Focus()
                    cek_simpan = 1
                End If
            Next
        End If
        If cek_simpan = 0 Then
            tString = TextBoxPassword.Text
            For j = 0 To tString.Length - 1
                If tString.Chars(j) = "'" Then
                    MessageBox.Show("Tidak Boleh Ada Tanda " & "( ' )" & " Pada Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBoxPassword.Focus()
                    cek_simpan = 1
                End If
            Next
        End If

        If cek_simpan = 0 Then
            tString = TextBoxIdTelegram.Text
            For j = 0 To tString.Length - 1
                If tString.Chars(j) = "'" Then
                    MessageBox.Show("Tidak Boleh Ada Tanda " & "( ' )" & " Pada ID Telegram", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBoxNama.Focus()
                    cek_simpan = 1
                End If
            Next
        End If

        If cek_simpan = 0 Then
            If TextBoxIdTelegram.Text <> "" Then
                If IsNumeric(TextBoxIdTelegram.Text) = False Then
                    MessageBox.Show("ID Telegram Harus Angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBoxIdTelegram.Focus()
                    cek_simpan = 1
                End If
            Else
                If TextBoxIdTelegram.Text = "" Then
                    MessageBox.Show("ID Telegram Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cek_simpan = 1
                End If
            End If
        End If

        If cek_simpan = 0 Then
            If TextBoxNama.Text = "" Then
                MessageBox.Show("Nama Lengkap Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cek_simpan = 1
            End If
        End If
        If cek_simpan = 0 Then
            If TextBoxUsername.Text = "" Then
                MessageBox.Show("Username Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cek_simpan = 1
            End If
        End If
        If cek_simpan = 0 Then
            If TextBoxPassword.Text = "" Then
                MessageBox.Show("Password Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cek_simpan = 1
            End If
        End If
        If cek_simpan = 0 Then
            If ComboBoxDivisi.SelectedValue = -1 Then
                MessageBox.Show("Harap Pilih Divisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cek_simpan = 1
            End If
        End If
        If cek_simpan = 0 Then
            If ComboBoxCabang.SelectedValue = -1 Then
                MessageBox.Show("Harap Pilih Cabang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cek_simpan = 1
            End If
        End If

        If cek_simpan = 0 Then
            Try
                Call Enkripsi(TextBoxPassword.Text)
                If id = "" Then
                    Call Koneksi()
                    Cmd = New MySqlCommand("INSERT INTO user(username,  password, fullname, divisi_id, chat_id_telegram, is_admin, id_cabang, user_crt, user_upd, dtm_crt,dtm_upd) values(@username,  @password, @fullname, @divisi_id, @chat_id_telegram, @is_admin, @id_cabang, @user_crt, @user_upd, @dtm_crt, @dtm_upd) ", Conn)
                    Cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBoxUsername.Text
                    Cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = HasilEnkripsi
                    Cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = TextBoxNama.Text
                    Cmd.Parameters.Add("@divisi_id", MySqlDbType.VarChar).Value = ComboBoxDivisi.SelectedValue
                    Cmd.Parameters.Add("@chat_id_telegram", MySqlDbType.VarChar).Value = TextBoxIdTelegram.Text
                    Cmd.Parameters.Add("@is_admin", MySqlDbType.Bit).Value = If(CheckBox1.Checked, 1, 0)
                    Cmd.Parameters.Add("@id_cabang", MySqlDbType.VarChar).Value = ComboBoxCabang.SelectedValue
                    Cmd.Parameters.Add("@user_crt", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_crt", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Input Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Call Koneksi()
                    Cmd = New MySqlCommand("Update user set username=@username, password=@password, fullname=@fullname, divisi_id=@divisi_id, chat_id_telegram=@chat_id_telegram, is_admin=@is_admin, id_cabang=@id_cabang, user_upd=@user_upd, dtm_upd=@dtm_upd where user_id = '" & id & "'", Conn)
                    Cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBoxUsername.Text
                    Cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = HasilEnkripsi
                    Cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = TextBoxNama.Text
                    Cmd.Parameters.Add("@divisi_id", MySqlDbType.VarChar).Value = ComboBoxDivisi.SelectedValue
                    Cmd.Parameters.Add("@chat_id_telegram", MySqlDbType.VarChar).Value = TextBoxIdTelegram.Text
                    Cmd.Parameters.Add("@is_admin", MySqlDbType.Bit).Value = If(CheckBox1.Checked, 1, 0)
                    Cmd.Parameters.Add("@id_cabang", MySqlDbType.VarChar).Value = ComboBoxCabang.SelectedValue
                    Cmd.Parameters.Add("@user_upd", MySqlDbType.VarChar).Value = activeUserData.getUserName
                    Cmd.Parameters.Add("@dtm_upd", MySqlDbType.DateTime).Value = DateTime.Now
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Edit Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                resetForm()
                'FormMasterUser.resetForm()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub FormAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setComboBoxValue()
        If id = "" Then
            mode = "add"
            resetForm()
        Else
            mode = "edit"
            Call Koneksi()
            Cmd = New MySqlCommand("SELECT u.user_id as user_id, u.fullname as fullname, u.username as username, u.password as password, d.divisi_name as divisi_name, d.divisi_id as divisi_id, u.chat_id_telegram as chat_id_telegram, u.is_admin as is_admin, u.id_cabang as id_cabang FROM user u left join divisi d on u.divisi_id = d.divisi_id where u.user_id ='" & id & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.HasRows Then
                Do While Rd.Read
                    TextBoxNama.Text = Rd.Item("fullname")
                    TextBoxUsername.Text = Rd.Item("username")
                    TextBoxPassword.Text = ""
                    TextBoxIdTelegram.Text = Rd.Item("chat_id_telegram")
                    ComboBoxCabang.SelectedValue = Rd.Item("id_cabang")
                    ComboBoxDivisi.SelectedValue = Rd.Item("divisi_id")
                    If Rd.Item("is_admin") Then
                        CheckBox1.Checked = True
                    Else
                        CheckBox1.Checked = False
                    End If
                Loop
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetForm()
        Me.Close()
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
            divisiDictionary.Add(Rd.Item("divisi_id"), Rd.Item("divisi_name"))
            ComboBoxDivisi.Items.Add(divisiDictionary)
        Loop
        ComboBoxDivisi.DisplayMember = "Value"
        ComboBoxDivisi.ValueMember = "Key"
        ComboBoxDivisi.DataSource = New BindingSource(divisiDictionary, Nothing)

        cabangDictionary.Clear()
        ComboBoxCabang.DataSource = Nothing
        Call Koneksi()
        Cmd = New MySqlCommand("select id, nama from mcabang", Conn)
        Rd = Cmd.ExecuteReader
        cabangDictionary.Add(-1, "Pilih Cabang")
        ComboBoxCabang.Items.Add(cabangDictionary)
        Do While Rd.Read
            cabangDictionary.Add(Rd.Item("id"), Rd.Item("nama"))
            ComboBoxCabang.Items.Add(cabangDictionary)
        Loop
        ComboBoxCabang.DisplayMember = "Value"
        ComboBoxCabang.ValueMember = "Key"
        ComboBoxCabang.DataSource = New BindingSource(cabangDictionary, Nothing)
    End Sub

End Class