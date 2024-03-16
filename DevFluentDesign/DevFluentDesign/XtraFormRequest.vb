Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls


Partial Public Class XtraFormRequest
    Dim divisiDictionary As New Dictionary(Of Integer, String)()
    Dim statusDictionary As New Dictionary(Of Integer, String)()
    Dim Condition As String

    Public Sub New()
        InitializeComponent()

        ' gridControl1.DataSource = GetDataSource()
        '  Dim dataSource As BindingList(Of Customer) = GetDataSource()
        'gridControl1.DataSource = dataSource
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
        'If activeUserData.getIsAdmin Then
        '    Condition = " Where 1=1 "
        '    If ComboBoxFromDivisi.SelectedItem IsNot Nothing Then
        '        If DirectCast(ComboBoxFromDivisi.SelectedValue, Integer) >= 0 Then
        '            Condition = Condition & " and dFrom.divisi_id = '" & DirectCast(ComboBoxFromDivisi.SelectedValue, Integer) & "'"
        '        End If
        '    End If
        'Else
        Condition = " Where dFrom.divisi_id = " & activeUserData.getDivisionId
        'End If

        If BarEditItemRequestId.EditValue IsNot Nothing Then
            If BarEditItemRequestId.EditValue.ToString() IsNot "" Then
                Condition = Condition & " and r.request_id = '" & BarEditItemRequestId.EditValue.ToString() & "'"
            End If
        End If
        If BarEditItemSubjek.EditValue IsNot Nothing Then
            If BarEditItemSubjek.EditValue.ToString() IsNot "" Then
                Condition = Condition & " and r.subject like '%" & BarEditItemSubjek.EditValue.ToString() & "%'"
            End If
        End If
        If BarEditItemDivisi.EditValue IsNot Nothing Then
            If DirectCast(BarEditItemDivisi.EditValue, Integer) >= 0 Then
                Condition = Condition & " and dTo.divisi_id = '" & DirectCast(BarEditItemDivisi.EditValue, Integer) & "'"
            End If
        End If
        If BarEditItemStatus.EditValue IsNot Nothing Then
            If DirectCast(BarEditItemStatus.EditValue, Integer) >= 0 Then
                Condition = Condition & " and rs.ref_status_id = '" & DirectCast(BarEditItemStatus.EditValue, Integer) & "'"
            End If
        End If
        If BarEditItemTglRequest1.EditValue IsNot Nothing Then
            Condition = Condition & " and date(r.dtm_crt) >= '" & Format(BarEditItemTglRequest1.EditValue, "yyyy-MM-dd") & "'"
        End If
        If BarEditItemTglRequest2.EditValue IsNot Nothing Then
            Condition = Condition & " and date(r.dtm_crt) <= '" & Format(BarEditItemTglRequest2.EditValue, "yyyy-MM-dd") & "'"
        End If

        Dim Cari_Data As String = "select r.request_id as request_id, r.request_no as request_no, r.subject as subject, r.description as description, dTo.divisi_name as to_divisi,dTo.divisi_id as to_divisi_id, dFrom.divisi_name as from_divisi, 
                                rp.prioritas_name as prioritas_name, rp.ref_prioritas_id as ref_prioritas_id, rs.status_name as status_name, rs.ref_status_id as ref_status_id, mc.id as cabang_id, mc.nama as cabang_name,
                                r.user_crt as user_crt, r.user_upd as user_upd, r.dtm_crt as dtm_crt, r.dtm_upd as dtm_upd 
                        from request r 
                            left join divisi dTo on dTo.divisi_id = r.to_divisi 
                            left join divisi dFrom on dFrom.divisi_id = r.from_divisi 
                            left join ref_status rs on rs.ref_status_id = r.status
                            left join ref_prioritas rp on rp.ref_prioritas_id = r.prioritas
                            left join user u on u.user_id = r.user_id
                            left join mcabang mc on mc.id = u.id_cabang " & Condition

        Dim Cmd As New MySqlCommand(Cari_Data, Conn)

        Dim Adapter As New MySqlDataAdapter(Cmd)
        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet)

        gridControl1.DataSource = DataSet.Tables(0)

        Dim View As GridView = gridControl1.MainView
        View.OptionsBehavior.Editable = False

        View.OptionsView.ColumnAutoWidth = False

        'If View.Columns("request_no") IsNot Nothing Then
        '    View.Columns("request_no").Caption = "Request No"
        'End If
        'If View.Columns("subject") IsNot Nothing Then
        '    View.Columns("subject").Caption = "Subject"
        'End If

        gridControl1.RefreshDataSource()
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiRefresh.ItemClick
        refreshData()
    End Sub


    Private Sub gridControl1_Click(sender As Object, e As EventArgs) Handles gridControl1.Click
        ' Assuming you have a GridControl named gridControl1
        Dim gridView As GridView = TryCast(gridControl1.FocusedView, GridView)

        If gridView IsNot Nothing Then
            Dim focusedRow As Integer = gridView.FocusedRowHandle

            ' Ensure the focused row handle is valid
            If focusedRow >= 0 AndAlso focusedRow < gridView.RowCount Then
                ' Replace 0 with the index of the column you want to retrieve
                Dim columnIndex As Integer = 1

                ' Get the focused row
                Dim row As DataRowView = TryCast(gridView.GetRow(focusedRow), DataRowView)

                If row IsNot Nothing Then
                    ' Get the cell value from the row using the column index
                    Dim cellValue As Object = row.Row.ItemArray(columnIndex)

                    If cellValue IsNot Nothing Then
                        ' Do something with the cell value
                        Console.WriteLine(cellValue.ToString())
                        RibbonPageGroup6.Text = "No Request : " & cellValue.ToString() & ", Status : " & row.Row.ItemArray(9)
                        If row.Row.ItemArray(10) = 7 Then
                            BarButtonItemApprove.Visibility = BarItemVisibility.Always
                            BarButtonItemNotApprove.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemApprove.Visibility = BarItemVisibility.Never
                            BarButtonItemNotApprove.Visibility = BarItemVisibility.Never
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        gridControl1.ShowRibbonPrintPreview()
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


        ' Mengatur RepositoryItemLookUpEdit ke BarEditItem
        BarEditItemDivisi.Edit = repositoryItemLookUpEditDivisi
        BarEditItemDivisi.EditValue = -1

        statusDictionary.Clear()
        BarEditItemStatus.EditValue = Nothing
        Call Koneksi()
        Cmd = New MySqlCommand("SELECT ref_status_id, status_name FROM ref_status", Conn)
        Rd = Cmd.ExecuteReader
        statusDictionary.Add(-1, "Pilih Status")

        Do While Rd.Read
            Dim statusId As Integer = Rd.GetInt32("ref_status_id")
            Dim statusName As String = Rd.GetString("status_name")
            If statusId = 3 Or statusId = 2 Then
            Else
                statusDictionary.Add(statusId, statusName)
            End If
        Loop

        Dim repositoryItemLookUpEditStatus As New RepositoryItemLookUpEdit()
        repositoryItemLookUpEditStatus.DataSource = New BindingSource(statusDictionary, Nothing)
        repositoryItemLookUpEditStatus.DisplayMember = "Value"
        repositoryItemLookUpEditStatus.ValueMember = "Key"


        ' Mengatur RepositoryItemLookUpEdit ke BarEditItem
        BarEditItemStatus.Edit = repositoryItemLookUpEditStatus
        BarEditItemStatus.EditValue = -1

    End Sub

    Private Sub XtraFormRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BarButtonItemApprove.Visibility = BarItemVisibility.Never
        BarButtonItemNotApprove.Visibility = BarItemVisibility.Never
        refreshData()
        setComboboxValue()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        refreshData()
    End Sub

    Private Sub BarEditItemDivisi_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItemDivisi.ItemClick

    End Sub

    Private Sub bbiNew_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiNew.ItemClick
        Using f As New XtraFormAddRequest
            If f.ShowDialog(Me) = DialogResult.OK Then
                refreshData()
            End If
        End Using
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiEdit.ItemClick
        Using f As New XtraFormAddRequest(TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0))
            If f.ShowDialog(Me) = DialogResult.OK Then
                refreshData()
            End If
        End Using
    End Sub
End Class
