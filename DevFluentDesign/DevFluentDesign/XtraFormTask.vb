Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Partial Public Class XtraFormTask
    Dim divisiDictionary As New Dictionary(Of Integer, String)()
    Dim statusDictionary As New Dictionary(Of Integer, String)()
    Dim prioritasDictionary As New Dictionary(Of Integer, String)()
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
        'If activeUserData.getIsAdmin Then
        '    Condition = " Where 1=1 "
        '    If ComboBoxFromDivisi.SelectedItem IsNot Nothing Then
        '        If DirectCast(ComboBoxFromDivisi.SelectedValue, Integer) >= 0 Then
        '            Condition = Condition & " and dFrom.divisi_id = '" & DirectCast(ComboBoxFromDivisi.SelectedValue, Integer) & "'"
        '        End If
        '    End If
        'Else
        Condition = " Where r.is_cancel = 0 and dTo.divisi_id = " & activeUserData.getDivisionId
        'End If

        If BarEditItemPrioritas.EditValue IsNot Nothing Then
            If DirectCast(BarEditItemPrioritas.EditValue, Integer) >= 0 Then
                Condition = Condition & " and rp.ref_prioritas_id = '" & DirectCast(BarEditItemPrioritas.EditValue, Integer) & "'"
            End If
        End If
        If BarEditItemSubjek.EditValue IsNot Nothing Then
            If BarEditItemSubjek.EditValue.ToString() IsNot "" Then
                Condition = Condition & " and r.subject like '%" & BarEditItemSubjek.EditValue.ToString() & "%'"
            End If
        End If
        If BarEditItemDariDivisi.EditValue IsNot Nothing Then
            If DirectCast(BarEditItemDariDivisi.EditValue, Integer) >= 0 Then
                Condition = Condition & " and dFrom.divisi_id = '" & DirectCast(BarEditItemDariDivisi.EditValue, Integer) & "'"
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

        Dim Cari_Data As String = "select r.request_id as request_id, r.request_no as request_no, dFrom.divisi_name as from_divisi, dTo.divisi_name as to_divisi,dTo.divisi_id as to_divisi_id, r.subject as subject, r.description as description, 
                                rs.status_name as status_name, rs.ref_status_id as ref_status_id, rp.prioritas_name as prioritas_name, rp.ref_prioritas_id as ref_prioritas_id, mc.id as cabang_id, mc.nama as cabang_name, 
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

        View.Columns("request_no").Width = 120
        View.Columns("from_divisi").Width = 150
        View.Columns("to_divisi").Width = 150
        View.Columns("subject").Width = 200
        View.Columns("description").Width = 200
        View.Columns("status_name").Width = 100
        View.Columns("prioritas_name").Width = 100
        View.Columns("cabang_name").Width = 200

        View.Columns("request_no").Caption = "Nomor Request"
        View.Columns("from_divisi").Caption = "Dari Divisi"
        View.Columns("to_divisi").Caption = "Ke Divisi"
        View.Columns("subject").Caption = "Subjek"
        View.Columns("description").Caption = "Deskripsi"
        View.Columns("status_name").Caption = "Status"
        View.Columns("prioritas_name").Caption = "Prioritas"
        View.Columns("cabang_name").Caption = "Cabang"

        View.Columns("request_id").Visible = False
        View.Columns("to_divisi_id").Visible = False
        View.Columns("ref_prioritas_id").Visible = False
        View.Columns("ref_status_id").Visible = False
        View.Columns("cabang_id").Visible = False
        View.Columns("user_crt").Visible = False
        View.Columns("user_upd").Visible = False
        View.Columns("dtm_crt").Visible = False
        View.Columns("dtm_upd").Visible = False

        AddHandler View.RowCellStyle, AddressOf View_RowCellStyle

        gridControl1.RefreshDataSource()
    End Sub

    Private Sub View_RowCellStyle(sender As Object, e As RowCellStyleEventArgs)
        Dim View As GridView = TryCast(sender, GridView)

        If e.Column.FieldName = "status_name" AndAlso e.RowHandle >= 0 Then
            Dim value As Object = View.GetRowCellValue(e.RowHandle, "ref_status_id")

            If value IsNot Nothing AndAlso Not Equals(value, System.DBNull.Value) Then
                Dim statusId As Integer = Convert.ToInt32(value)

                Select Case statusId
                    Case 1 '
                        e.Appearance.BackColor = Color.LightYellow
                    Case 2
                        e.Appearance.BackColor = Color.Yellow
                    Case 4
                        e.Appearance.BackColor = Color.Red
                    Case 5
                        e.Appearance.BackColor = Color.LightBlue
                    Case 6
                        e.Appearance.BackColor = Color.Blue
                    Case 7
                        e.Appearance.BackColor = Color.LawnGreen
                    Case 8
                        e.Appearance.BackColor = Color.Green
                    Case 9
                        e.Appearance.BackColor = Color.MediumSlateBlue
                End Select
            End If
        End If
        If e.Column.FieldName = "prioritas_name" AndAlso e.RowHandle >= 0 Then
            Dim value As Object = View.GetRowCellValue(e.RowHandle, "ref_prioritas_id")

            If value IsNot Nothing AndAlso Not Equals(value, System.DBNull.Value) Then
                Dim refPrioritasId As Integer = Convert.ToInt32(value)

                Select Case refPrioritasId
                    Case 1 '
                        e.Appearance.ForeColor = Color.Red
                    Case 2
                        e.Appearance.ForeColor = Color.Blue
                    Case 3
                        e.Appearance.ForeColor = Color.Green
                End Select
            End If
        End If
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiRefresh.ItemClick
        refreshData()
    End Sub

    Sub setComboboxValue()
        divisiDictionary.Clear()
        BarEditItemDariDivisi.EditValue = Nothing
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
        BarEditItemDariDivisi.Edit = repositoryItemLookUpEditDivisi
        BarEditItemDariDivisi.EditValue = -1

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

        BarEditItemStatus.Edit = repositoryItemLookUpEditStatus
        BarEditItemStatus.EditValue = -1

        prioritasDictionary.Clear()
        BarEditItemPrioritas.EditValue = Nothing
        Call Koneksi()
        Cmd = New MySqlCommand("SELECT ref_prioritas_id, prioritas_name FROM ref_prioritas", Conn)
        Rd = Cmd.ExecuteReader
        prioritasDictionary.Add(-1, "Pilih Prioritas")

        Do While Rd.Read
            Dim statusId As Integer = Rd.GetInt32("ref_prioritas_id")
            Dim statusName As String = Rd.GetString("prioritas_name")

            prioritasDictionary.Add(statusId, statusName)

        Loop

        Dim repositoryItemLookUpEditPrioritas As New RepositoryItemLookUpEdit()
        repositoryItemLookUpEditPrioritas.DataSource = New BindingSource(prioritasDictionary, Nothing)
        repositoryItemLookUpEditPrioritas.DisplayMember = "Value"
        repositoryItemLookUpEditPrioritas.ValueMember = "Key"

        BarEditItemPrioritas.Edit = repositoryItemLookUpEditPrioritas
        BarEditItemPrioritas.EditValue = -1

    End Sub

    Sub resetForm()
        BarEditItemPrioritas.EditValue = -1
        BarEditItemDariDivisi.EditValue = -1
        BarEditItemStatus.EditValue = -1
        BarEditItemSubjek.EditValue = Nothing
        BarEditItemTglRequest1.EditValue = Nothing
        BarEditItemTglRequest2.EditValue = Nothing
        gridControl1.DataSource = Nothing
        gridControl1.RefreshDataSource()
    End Sub

    Private Sub XtraFormTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
        setComboboxValue()
        BarButtonItemAccept.Visibility = BarItemVisibility.Never
        BarButtonItemReject.Visibility = BarItemVisibility.Never
        BarButtonItemOnProgress.Visibility = BarItemVisibility.Never
        BarButtonItemDone.Visibility = BarItemVisibility.Never
    End Sub

    Private Sub gridControl1_Click(sender As Object, e As EventArgs) Handles gridControl1.Click
        Dim gridView As GridView = TryCast(gridControl1.FocusedView, GridView)

        If gridView IsNot Nothing Then
            Dim focusedRow As Integer = gridView.FocusedRowHandle

            If focusedRow >= 0 AndAlso focusedRow < gridView.RowCount Then
                Dim columnIndex As Integer = 1
                Dim row As DataRowView = TryCast(gridView.GetRow(focusedRow), DataRowView)

                If row IsNot Nothing Then
                    Dim cellValue As Object = row.Row.ItemArray(columnIndex)

                    If cellValue IsNot Nothing Then
                        RibbonPageGroup7.Text = "No Request : " & cellValue.ToString() & ", Status : " & row.Row.ItemArray(9)
                        If Convert.ToInt32(row("ref_status_id")) = 1 Or Convert.ToInt32(row("ref_status_id")) = 2 Or Convert.ToInt32(row("ref_status_id")) = 9 Then
                            BarButtonItemAccept.Visibility = BarItemVisibility.Always
                            BarButtonItemReject.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemAccept.Visibility = BarItemVisibility.Never
                            BarButtonItemReject.Visibility = BarItemVisibility.Never

                        End If
                        If Convert.ToInt32(row("ref_status_id")) = 5 Then
                            BarButtonItemOnProgress.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemOnProgress.Visibility = BarItemVisibility.Never
                        End If

                        If Convert.ToInt32(row("ref_status_id")) = 6 Then
                            BarButtonItemDone.Visibility = BarItemVisibility.Always
                        Else
                            BarButtonItemDone.Visibility = BarItemVisibility.Never
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        refreshData()
    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click

    End Sub

    Private Sub BarButtonItemAccept_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemAccept.ItemClick
        XtraFormEstimasi.LabelId.Text = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0)
        XtraFormEstimasi.ShowDialog()
    End Sub

    Private Sub BarButtonItemReject_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemReject.ItemClick
        XtraFormNotApprove.LabelId.Text = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0)
        XtraFormNotApprove.LabelTitle.Text = "DATA REJECT"
        XtraFormNotApprove.LabelCatatan.Text = "ALASAN REJECT"
        XtraFormNotApprove.ShowDialog()
    End Sub

    Private Sub BarButtonItemOnProgress_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemOnProgress.ItemClick
        XtraFormRealisasi.LabelId.Text = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0)
        XtraFormRealisasi.LabelTgl.Text = "TGL MULAI"
        XtraFormRealisasi.ShowDialog()
    End Sub

    Private Sub BarButtonItemDone_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemDone.ItemClick
        XtraFormRealisasi.LabelId.Text = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0)
        XtraFormRealisasi.LabelTgl.Text = "TGL SELESAI"
        XtraFormRealisasi.ShowDialog()
    End Sub

    Private Sub BarButtonItemReset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemReset.ItemClick
        resetForm()
    End Sub

    Private Sub BarButtonItemView_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemView.ItemClick

        Dim rowValue As New List(Of String)

        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridView.Columns
            ' Mendapatkan nilai dari baris yang dipilih
            rowValue.Add(gridView.GetRowCellValue(gridView.FocusedRowHandle, col).ToString())
        Next

        Dim f As New FormRequestDetail(TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(0), rowValue)
        'f.LabelStatus.BackColor = cellBackColor
        'f.LabelPriority.ForeColor = TryCast(gridView.GetRow(gridView.FocusedRowHandle), DataRowView).Row.ItemArray(7)
        FluentDesignForm1.showForm(f)
    End Sub
End Class
