Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class XtraFormTask

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
        'If activeUserData.getIsAdmin Then
        '    Condition = " Where 1=1 "
        '    If ComboBoxFromDivisi.SelectedItem IsNot Nothing Then
        '        If DirectCast(ComboBoxFromDivisi.SelectedValue, Integer) >= 0 Then
        '            Condition = Condition & " and dFrom.divisi_id = '" & DirectCast(ComboBoxFromDivisi.SelectedValue, Integer) & "'"
        '        End If
        '    End If
        'Else
        '    Condition = " Where dFrom.divisi_id = " & activeUserData.getDivisionId
        'End If

        'If TextBoxRequestId.Text IsNot "" Then
        '    Condition = Condition & " and r.request_id = '" & TextBoxRequestId.Text & "'"
        'End If
        'If TextBoxSubject.Text IsNot "" Then
        '    Condition = Condition & " and r.subject like '%" & TextBoxSubject.Text & "%'"
        'End If
        'If ComboBoxDivisi.SelectedItem IsNot Nothing Then
        '    If DirectCast(ComboBoxDivisi.SelectedValue, Integer) >= 0 Then
        '        Condition = Condition & " and dTo.divisi_id = '" & DirectCast(ComboBoxDivisi.SelectedValue, Integer) & "'"
        '    End If
        'End If
        'If ComboBoxStatus.SelectedItem IsNot Nothing Then
        '    If DirectCast(ComboBoxStatus.SelectedValue, Integer) >= 0 Then
        '        Condition = Condition & " and rs.ref_status_id = '" & DirectCast(ComboBoxStatus.SelectedValue, Integer) & "'"
        '    End If
        'End If
        'If DateEdit1.Text IsNot "" Then
        '    Condition = Condition & " and date(r.dtm_crt) >= '" & DateEdit1.Text & "'"
        'End If
        'If DateEdit2.Text IsNot "" Then
        '    Condition = Condition & " and date(r.dtm_crt) <= '" & DateEdit2.Text & "'"
        'End If
        Dim Cari_Data As String = "select r.request_id as request_id, r.request_no as request_no, r.subject as subject, r.description description, dTo.divisi_name as to_divisi, dFrom.divisi_name as from_divisi, dFrom.divisi_id as from_divisi_id,
                                 rp.prioritas_name as prioritas_name, rp.ref_prioritas_id as ref_prioritas_id, rs.status_name as status_name, rs.ref_status_id as ref_status_id, mc.id as cabang_id, mc.nama as cabang_name,
                                 r.user_crt as user_crt, r.user_upd as user_upd, r.dtm_crt as dtm_crt, r.dtm_upd as dtm_upd 
                        from request r 
                            left join divisi dTo on dTo.divisi_id = r.to_divisi 
                            left join divisi dFrom on dFrom.divisi_id = r.from_divisi 
                            left join ref_status rs on rs.ref_status_id = r.status
                            left join ref_prioritas rp on rp.ref_prioritas_id = r.prioritas
                            left join user u on u.user_id = r.user_id
                            left join mcabang mc on mc.id = u.id_cabang
                            Where dTo.divisi_id = " & activeUserData.getDivisionId

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

    Private Sub XtraFormTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
        BarButtonItemAccept.Visibility = BarItemVisibility.Never
        BarButtonItemReject.Visibility = BarItemVisibility.Never
        BarButtonItemOnProgress.Visibility = BarItemVisibility.Never
        BarButtonItemDone.Visibility = BarItemVisibility.Never
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
                        RibbonPageGroup7.Text = "No Request : " & cellValue.ToString() & ", Status : " & row.Row.ItemArray(9)
                        If row.Row.ItemArray(10) = 1 Or row.Row.ItemArray(10) = 2 Or row.Row.ItemArray(10) = 9 Then
                            BarButtonItemAccept.Visibility = BarItemVisibility.Always
                            BarButtonItemReject.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemAccept.Visibility = BarItemVisibility.Never
                            BarButtonItemReject.Visibility = BarItemVisibility.Never

                        End If
                        If row.Row.ItemArray(10) = 5 Then
                            BarButtonItemOnProgress.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemOnProgress.Visibility = BarItemVisibility.Never
                        End If

                        If row.Row.ItemArray(10) = 6 Then
                            BarButtonItemDone.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemDone.Visibility = BarItemVisibility.Never
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
