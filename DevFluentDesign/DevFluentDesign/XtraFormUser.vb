Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Partial Public Class XtraFormUser
    Dim divisiDictionary As New Dictionary(Of Integer, String)()
    Dim Condition As String
    Public Sub New()
        InitializeComponent()

        'gridControl.DataSource = GetDataSource()
        'Dim dataSource As BindingList(Of Customer) = GetDataSource()
        'gridControl.DataSource = dataSource
        'bsiRecordsCount.Caption = "RECORDS : " & dataSource.Count
    End Sub
    Private Sub bbiPrintPreview_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiPrintPreview.ItemClick
        gridControl1.ShowRibbonPrintPreview()
    End Sub
    Public Function GetDataSource() As BindingList(Of Customer)
        Dim result As New BindingList(Of Customer)()
        result.Add(New Customer() With {.ID = 1, .Name = "ACME", .Address = "2525 E El Segundo Blvd", .City = "El Segundo", .State = "CA", .ZipCode = "90245", .Phone = "(310) 536-0611"})
        result.Add(New Customer() With {.ID = 2, .Name = "Electronics Depot", .Address = "2455 Paces Ferry Road NW", .City = "Atlanta", .State = "GA", .ZipCode = "30339", .Phone = "(800) 595-3232"})
        Return result
    End Function
    Public Class Customer
        <Key, Display(AutoGenerateField:=False)>
        Public Property ID() As Integer
        <Required>
        Public Property Name() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property State() As String
        <Display(Name:="Zip Code")>
        Public Property ZipCode() As String
        Public Property Phone() As String
    End Class

    Sub refreshData()
        Call Koneksi()

        Condition = " Where 1=1 "

        If BarEditItemUsername.EditValue IsNot Nothing Then
            If BarEditItemUsername.EditValue.ToString() IsNot "" Then
                Condition = Condition & " and u.username like '%" & BarEditItemUsername.EditValue.ToString() & "%'"
            End If
        End If
        If BarEditItemFullName.EditValue IsNot Nothing Then
            If BarEditItemFullName.EditValue.ToString() IsNot "" Then
                Condition = Condition & "and u.fullname like '%" & BarEditItemFullName.EditValue.ToString() & "%'"
            End If
        End If
        If BarEditItemDivisi.EditValue IsNot Nothing Then
            If DirectCast(BarEditItemDivisi.EditValue, Integer) >= 0 Then
                Condition = Condition & " and d.divisi_id = '" & DirectCast(BarEditItemDivisi.EditValue, Integer) & "'"
            End If
        End If

        Dim Cari_Data As String = "SELECT u.user_id as user_id, u.fullname as fullname, u.username as username, u.password as password, d.divisi_id as divisi_id,  d.divisi_name as divisi_name, c.id as cabang_id, c.nama as cabang_name, u.chat_id_telegram as id_telegram, u.is_admin as is_admin, u.user_crt as user_crt, u.user_upd as user_upd, u.dtm_crt as dtm_crt, u.dtm_upd as dtm_upd 
                                   FROM user u 
                                      left join divisi d on u.divisi_id = d.divisi_id
                                      left join mcabang c on c.id = u.id_cabang" & Condition

        Dim Cmd As New MySqlCommand(Cari_Data, Conn)

        Dim Adapter As New MySqlDataAdapter(Cmd)
        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet)

        gridControl1.DataSource = DataSet.Tables(0)

        Dim View As GridView = gridControl1.MainView
        View.OptionsBehavior.Editable = False

        View.OptionsView.ColumnAutoWidth = False

        View.Columns("fullname").Width = 200
        View.Columns("username").Width = 150
        View.Columns("password").Width = 150
        View.Columns("divisi_name").Width = 150
        View.Columns("cabang_name").Width = 150
        View.Columns("id_telegram").Width = 100
        View.Columns("is_admin").Width = 100
        View.Columns("user_crt").Width = 100
        View.Columns("user_upd").Width = 100
        View.Columns("dtm_crt").Width = 100
        View.Columns("dtm_upd").Width = 100

        View.Columns("fullname").Caption = "Nama Lengkap"
        View.Columns("username").Caption = "Username"
        View.Columns("password").Caption = "Password"
        View.Columns("divisi_name").Caption = "Divisi"
        View.Columns("cabang_name").Caption = "Cabang"
        View.Columns("id_telegram").Caption = "Id Telegram"
        View.Columns("is_admin").Caption = "Is Admin"
        View.Columns("user_crt").Caption = "User Create"
        View.Columns("user_upd").Caption = "User Update"
        View.Columns("dtm_crt").Caption = "Dtm Create"
        View.Columns("dtm_upd").Caption = "Dtm Update"

        View.Columns("user_id").Visible = False
        View.Columns("divisi_id").Visible = False
        View.Columns("cabang_id").Visible = False

        gridControl1.RefreshDataSource()
        bsiRecordsCount.Caption = "Jumlah Data : " & DirectCast(gridControl1.DataSource, DataTable).Rows.Count.ToString()
    End Sub

    Sub resetForm()
        BarEditItemDivisi.EditValue = -1
        BarEditItemFullName.EditValue = Nothing
        BarEditItemUsername.EditValue = Nothing
        gridControl1.DataSource = Nothing
        gridControl1.RefreshDataSource()
    End Sub
    Sub setComboboxValue()
        divisiDictionary.Clear()
        BarEditItemDivisi.EditValue = Nothing
        Call Koneksi()
        Cmd = New MySqlCommand("SELECT divisi_id, divisi_name FROM divisi", Conn)
        Rd = Cmd.ExecuteReader
        divisiDictionary.Add(-1, "Pilih Divisi")

        Do While Rd.Read
            Dim divisiId As Integer = Rd.GetInt32("divisi_id")
            Dim divisiName As String = Rd.GetString("divisi_name")

            If activeUserData.getIsAdmin Then
                divisiDictionary.Add(divisiId, divisiName)
            Else
                If divisiId <> activeUserData.getDivisionId Then
                    divisiDictionary.Add(divisiId, divisiName)
                End If
            End If
        Loop

        Dim repositoryItemLookUpEditDivisi As New RepositoryItemLookUpEdit()
        repositoryItemLookUpEditDivisi.DataSource = New BindingSource(divisiDictionary, Nothing)
        repositoryItemLookUpEditDivisi.DisplayMember = "Value"
        repositoryItemLookUpEditDivisi.ValueMember = "Key"

        BarEditItemDivisi.Edit = repositoryItemLookUpEditDivisi
        BarEditItemDivisi.EditValue = -1
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiRefresh.ItemClick
        refreshData()
    End Sub

    Private Sub XtraFormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
        setComboboxValue()
    End Sub

    Private Sub BarButtonItemSearch_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemSearch.ItemClick
        refreshData()
    End Sub

    Private Sub BarButtonItemReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemReset.ItemClick
        resetForm()
    End Sub

    Private Sub bbiNew_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiNew.ItemClick
        Using f As New FormAddUser
            f.ShowDialog()
            refreshData()
        End Using
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiEdit.ItemClick
        Using f As New FormAddUser(TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0))
            f.ShowDialog(Me)
            refreshData()
        End Using
    End Sub
    Sub hapusData()
        Dim rowView As DataRowView = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)
        Call Koneksi()
        Cmd = New MySqlCommand("delete from user where user_id = '" & TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0) & "'", Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("User " & rowView("fullname").ToString() & " telah dihapus", vbOKOnly, "Success Message")
        MessageBox.Show("User " & rowView("fullname").ToString() & " telah dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refreshData()
    End Sub
    Private Sub BarButtonItemDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemDelete.ItemClick
        Dim rowView As DataRowView = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)
        Select Case MessageBox.Show("Apakah anda yakin ingin menghapus User " & rowView("fullname").ToString() & " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case MsgBoxResult.Yes
                hapusData()
        End Select
    End Sub
End Class
