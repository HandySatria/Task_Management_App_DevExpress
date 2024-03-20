Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class XtraFormDivisi

    Dim Condition As String = ""

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
        Condition = "Where 1=1 "
        If BarEditItemDivisiName.EditValue IsNot Nothing Then
            If BarEditItemDivisiName.EditValue.ToString() IsNot "" Then
                Condition = Condition & " and divisi_name like '%" & BarEditItemDivisiName.EditValue.ToString() & "%'"
            End If
        End If

        Call Koneksi()

        Dim Cari_Data As String = "SELECT divisi_id, divisi_name, user_crt, user_upd, dtm_crt,dtm_upd FROM divisi " & Condition

        Dim Cmd As New MySqlCommand(Cari_Data, Conn)

        Dim Adapter As New MySqlDataAdapter(Cmd)
        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet)

        gridControl1.DataSource = DataSet.Tables(0)

        Dim View As GridView = gridControl1.MainView
        View.OptionsBehavior.Editable = False

        View.OptionsView.ColumnAutoWidth = False

        View.Columns("divisi_id").Width = 50
        View.Columns("divisi_name").Width = 200
        View.Columns("user_crt").Width = 100
        View.Columns("user_upd").Width = 100
        View.Columns("dtm_crt").Width = 100
        View.Columns("dtm_upd").Width = 100

        View.Columns("divisi_id").Caption = "Id Divisi"
        View.Columns("divisi_name").Caption = "Nama Divisi"
        View.Columns("user_crt").Caption = "User Creat"
        View.Columns("user_upd").Caption = "User Update"
        View.Columns("dtm_crt").Caption = "Dtm Create"
        View.Columns("dtm_upd").Caption = "Dtm Update"

        gridControl1.RefreshDataSource()
    End Sub

    Sub resetData()
        BarEditItemDivisiName.EditValue = Nothing
        gridControl1.DataSource = Nothing
        gridControl1.RefreshDataSource()
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiRefresh.ItemClick
        refreshData()
    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click

    End Sub

    Private Sub XtraFormDivisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
    End Sub

    Private Sub BarButtonItemSearch_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemSearch.ItemClick
        refreshData()
    End Sub

    Private Sub BarButtonItemReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemReset.ItemClick
        resetData()
    End Sub

    Private Sub BarButtonItemPrintPreview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemPrintPreview.ItemClick
        gridControl1.ShowRibbonPrintPreview()
    End Sub

    Private Sub bbiNew_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiNew.ItemClick
        Using f As New FormAddDivisi
            f.ShowDialog()
            refreshData()
        End Using
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiEdit.ItemClick
        Using f As New FormAddDivisi(TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0), TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(1))
            f.ShowDialog()
            refreshData()
        End Using
    End Sub

    Sub hapusData()
        Dim rowView As DataRowView = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)
        Call Koneksi()
        Cmd = New MySqlCommand("delete from divisi where divisi_id = '" & TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0) & "'", Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Divisi " & rowView("divisi_name").ToString() & " telah dihapus", vbOKOnly, "Success Message")
        refreshData()
    End Sub

    Private Sub BarButtonItemDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemDelete.ItemClick
        Dim rowView As DataRowView = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)

        Select Case MsgBox("Apakah anda yakin ingin menghapus Divisi " & rowView("divisi_name").ToString() & " ?", MsgBoxStyle.YesNo, "MESSAGE")
            Case MsgBoxResult.Yes
                hapusData()
        End Select
    End Sub
End Class
