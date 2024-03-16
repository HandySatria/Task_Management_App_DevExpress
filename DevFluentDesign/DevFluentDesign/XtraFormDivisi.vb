Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class XtraFormDivisi

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
        Dim Cari_Data As String = "SELECT divisi_id, divisi_name, user_crt, user_upd, dtm_crt,dtm_upd FROM divisi"

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
End Class
