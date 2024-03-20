Public Class FluentDesignForm1
    Private Sub FluentDesignFormControl1_Click(sender As Object, e As EventArgs) Handles FluentDesignFormControl1.Click

    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub showForm(ByVal newForm As Form)
        ' Set parent dari form menjadi FluentDesignFormContainer1
        newForm.TopLevel = False
        newForm.FormBorderStyle = FormBorderStyle.None
        newForm.Dock = DockStyle.Fill
        FluentDesignFormContainer1.Controls.Clear()

        ' Tambahkan form ke FluentDesignFormContainer1
        FluentDesignFormContainer1.Controls.Add(newForm)

        ' Tampilkan form
        newForm.Show()
    End Sub





    Private Sub FluentDesignForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccordionControl1.Visible = False
        showForm(FormLogo)
    End Sub

    Private Sub AccordionControlDashboard_Click(sender As Object, e As EventArgs) Handles AccordionControlDashboard.Click
        showForm(FormDashboard)
    End Sub

    Private Sub AccordionControlRequest_Click(sender As Object, e As EventArgs) Handles AccordionControlRequest.Click
        showForm(XtraFormRequest)
    End Sub

    Private Sub AccordionControlTask_Click(sender As Object, e As EventArgs) Handles AccordionControlTask.Click
        showForm(XtraFormTask)
    End Sub

    Private Sub AccordionControlUser_Click(sender As Object, e As EventArgs) Handles AccordionControlUser.Click
        showForm(XtraFormUser)
    End Sub

    Private Sub AccordionControlDivisi_Click(sender As Object, e As EventArgs) Handles AccordionControlDivisi.Click
        showForm(XtraFormDivisi)
    End Sub

    Private Sub BarEditItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarEditItem3.ItemClick
        XtraFormLogin.ShowDialog()
    End Sub

    Private Sub BarStaticItemLogin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItemLogin.ItemClick
        XtraFormLogin.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLogin.ItemClick
        If BarButtonItemLogin.Caption = "LOGIN" Then
            FormLogin.ShowDialog()
        ElseIf BarButtonItemLogin.Caption = "LOGOUT" Then
            Select Case MsgBox("Apakah Anda Yakin Ingin Logout ?", MsgBoxStyle.YesNo, "MESSAGE")
                Case MsgBoxResult.Yes
                    XtraFormRequest.Close()
                    XtraFormTask.Close()
                    'FormMasterDivisi.Close()
                    'FormMasterUser.Close()
                    BarHeaderItem1.Caption = ""
                    AccordionControl1.Visible = False
                    showForm(FormLogo)
                    BarButtonItemLogin.Caption = "LOGIN"
            End Select
        End If
    End Sub
End Class
