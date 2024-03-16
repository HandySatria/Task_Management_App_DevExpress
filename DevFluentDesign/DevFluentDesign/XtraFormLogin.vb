Imports MySql.Data.MySqlClient
Public Class XtraFormLogin

    'Sub KondisiTerbuka()
    '    FormMenu.RequestToolStripMenuItem.Visible = True
    '    FormMenu.TaskToolStripMenuItem.Visible = True
    '    FormMenu.DASHBOARDToolStripMenuItem.Visible = True
    '    If activeUserData.getIsAdmin Then
    '        FormMenu.SettingToolStripMenuItem.Visible = True
    '    End If
    '    FormMenu.ButtonLogin.Text = "LOGOUT"
    '    XtraForm1.DashboardViewer1.Dashboard.Parameters("FromDivisiId").Value = 5
    'End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        login()

    End Sub

    Sub login()
        If TextEditNama.Text = "" Or TextEditPassword.Text = "" Then
            MsgBox("Silahkan Isi Nama dan Password Terlebih Dahulu")
        Else
            Try
                Call Enkripsi(TextEditPassword.Text)
                Call Koneksi()
                Cmd = New MySqlCommand("SELECT u.user_id as user_id, u.fullname as fullname, u.username as username, u.password as password, d.divisi_name as divisi_name, d.divisi_id as divisi_id, u.is_admin as is_admin, mc.id as id_cabang, mc.nama as nama_cabang FROM user u left join divisi d on u.divisi_id = d.divisi_id left join mcabang mc on u.id_cabang = mc.id where u.username = @username and u.password = @password", Conn)
                Cmd.Parameters.AddWithValue("@username", TextEditNama.Text)
                Cmd.Parameters.AddWithValue("@password", HasilEnkripsi)

                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Not Rd.HasRows Then
                    MsgBox("Username atau Password Salah!")
                Else
                    'Divisi_Name = Rd.Item("divisi_name")
                    activeUserData = New UserData(CInt(Rd.Item("divisi_id")), Rd.Item("divisi_name"), CInt(Rd.Item("user_id")), Rd.Item("username"), Rd.Item("fullname"), Rd.Item("is_admin"), Rd.Item("nama_cabang"))
                    '   FormMenu.LabelHeader.Text = "Welcome, " & activeUserData.getFullName & " Dari Divisi " & activeUserData.getDivisionName
                    Me.Close()
                    ' Call KondisiTerbuka()
                    FluentDesignForm1.AccordionControl1.Visible = True
                    FormDashboard.DashboardViewer1.Dashboard.Parameters("FromDivisiId").Value = 5
                    Start_BotAsync()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextEditPassword.Properties.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            TextEditPassword.Properties.PasswordChar = "*"
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEditNama.Text = "admin01"
        TextEditPassword.Text = "admin01"
    End Sub


    Private Sub TextEditNamaKeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEditNama.KeyPress
        If e.KeyChar = Chr(13) Then
            login()
        End If
    End Sub

    Private Sub TextEditPasswordKeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEditPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            login()
        End If
    End Sub

    Private Sub TextEditNama_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEditPassword_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditPassword.EditValueChanged

    End Sub
End Class