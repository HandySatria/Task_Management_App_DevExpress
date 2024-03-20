<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraFormTask
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraFormTask))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemView = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemAccept = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemReject = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemOnProgress = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDone = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItemTaskId = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarEditItemTglRequest1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItemTglRequest2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItemSubjek = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarEditItemDariDivisi = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarEditItemStatus = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItemPrioritas = New DevExpress.XtraBars.BarEditItem()
        Me.BarButtonItemReset = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiPrintPreview, Me.bsiRecordsCount, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.BarButtonItemDelete, Me.BarButtonItemView, Me.BarButtonItemAccept, Me.BarButtonItemReject, Me.BarButtonItemOnProgress, Me.BarButtonItemDone, Me.BarEditItemTaskId, Me.BarEditItemTglRequest1, Me.BarEditItemTglRequest2, Me.BarEditItemSubjek, Me.BarEditItemDariDivisi, Me.BarEditItemStatus, Me.BarButtonItem1, Me.BarEditItemPrioritas, Me.BarButtonItemReset})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonControl.MaxItemId = 35
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.OptionsMenuMinWidth = 385
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Size = New System.Drawing.Size(1121, 193)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiPrintPreview
        '
        Me.bbiPrintPreview.Caption = "Print Preview"
        Me.bbiPrintPreview.Id = 14
        Me.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview"
        Me.bbiPrintPreview.Name = "bbiPrintPreview"
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "RECORDS : 0"
        Me.bsiRecordsCount.Id = 15
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'bbiNew
        '
        Me.bbiNew.Caption = "New"
        Me.bbiNew.Id = 16
        Me.bbiNew.ImageOptions.ImageUri.Uri = "New"
        Me.bbiNew.Name = "bbiNew"
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Edit"
        Me.bbiEdit.Id = 17
        Me.bbiEdit.ImageOptions.ImageUri.Uri = "Edit"
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 18
        Me.bbiDelete.ImageOptions.Image = CType(resources.GetObject("bbiDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.ImageOptions.LargeImage = CType(resources.GetObject("bbiDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 19
        Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'BarButtonItemDelete
        '
        Me.BarButtonItemDelete.Caption = "Delete"
        Me.BarButtonItemDelete.Id = 20
        Me.BarButtonItemDelete.ImageOptions.Image = CType(resources.GetObject("BarButtonItemDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemDelete.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemDelete.Name = "BarButtonItemDelete"
        Me.BarButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemView
        '
        Me.BarButtonItemView.Caption = "View"
        Me.BarButtonItemView.Id = 21
        Me.BarButtonItemView.ImageOptions.Image = CType(resources.GetObject("BarButtonItemView.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemView.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemView.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemView.Name = "BarButtonItemView"
        Me.BarButtonItemView.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemAccept
        '
        Me.BarButtonItemAccept.Caption = "Accept"
        Me.BarButtonItemAccept.Id = 22
        Me.BarButtonItemAccept.ImageOptions.Image = CType(resources.GetObject("BarButtonItemAccept.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemAccept.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemAccept.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemAccept.Name = "BarButtonItemAccept"
        Me.BarButtonItemAccept.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemReject
        '
        Me.BarButtonItemReject.Caption = "Reject"
        Me.BarButtonItemReject.Id = 23
        Me.BarButtonItemReject.ImageOptions.Image = CType(resources.GetObject("BarButtonItemReject.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemReject.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemReject.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemReject.Name = "BarButtonItemReject"
        Me.BarButtonItemReject.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemOnProgress
        '
        Me.BarButtonItemOnProgress.Caption = "On Progress"
        Me.BarButtonItemOnProgress.Id = 24
        Me.BarButtonItemOnProgress.ImageOptions.Image = CType(resources.GetObject("BarButtonItemOnProgress.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemOnProgress.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemOnProgress.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemOnProgress.Name = "BarButtonItemOnProgress"
        Me.BarButtonItemOnProgress.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemDone
        '
        Me.BarButtonItemDone.Caption = "Done"
        Me.BarButtonItemDone.Id = 25
        Me.BarButtonItemDone.ImageOptions.Image = CType(resources.GetObject("BarButtonItemDone.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemDone.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemDone.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemDone.Name = "BarButtonItemDone"
        Me.BarButtonItemDone.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarEditItemTaskId
        '
        Me.BarEditItemTaskId.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarEditItemTaskId.Caption = "Id Task        "
        Me.BarEditItemTaskId.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItemTaskId.EditWidth = 100
        Me.BarEditItemTaskId.Id = 26
        Me.BarEditItemTaskId.Name = "BarEditItemTaskId"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarEditItemTglRequest1
        '
        Me.BarEditItemTglRequest1.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarEditItemTglRequest1.Caption = "Tgl Task >= "
        Me.BarEditItemTglRequest1.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItemTglRequest1.EditWidth = 100
        Me.BarEditItemTglRequest1.Id = 27
        Me.BarEditItemTglRequest1.Name = "BarEditItemTglRequest1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarEditItemTglRequest2
        '
        Me.BarEditItemTglRequest2.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarEditItemTglRequest2.Caption = "Tgl Task <= "
        Me.BarEditItemTglRequest2.Edit = Me.RepositoryItemDateEdit2
        Me.BarEditItemTglRequest2.EditWidth = 100
        Me.BarEditItemTglRequest2.Id = 28
        Me.BarEditItemTglRequest2.Name = "BarEditItemTglRequest2"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'BarEditItemSubjek
        '
        Me.BarEditItemSubjek.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarEditItemSubjek.Caption = "Subjek     "
        Me.BarEditItemSubjek.Edit = Me.RepositoryItemTextEdit2
        Me.BarEditItemSubjek.EditWidth = 100
        Me.BarEditItemSubjek.Id = 29
        Me.BarEditItemSubjek.Name = "BarEditItemSubjek"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'BarEditItemDariDivisi
        '
        Me.BarEditItemDariDivisi.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarEditItemDariDivisi.Caption = "Dari Divisi     "
        Me.BarEditItemDariDivisi.Edit = Me.RepositoryItemComboBox1
        Me.BarEditItemDariDivisi.EditWidth = 100
        Me.BarEditItemDariDivisi.Id = 30
        Me.BarEditItemDariDivisi.Name = "BarEditItemDariDivisi"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'BarEditItemStatus
        '
        Me.BarEditItemStatus.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarEditItemStatus.Caption = "Status      "
        Me.BarEditItemStatus.Edit = Me.RepositoryItemComboBox2
        Me.BarEditItemStatus.EditWidth = 100
        Me.BarEditItemStatus.Id = 31
        Me.BarEditItemStatus.Name = "BarEditItemStatus"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Search"
        Me.BarButtonItem1.Id = 32
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarEditItemPrioritas
        '
        Me.BarEditItemPrioritas.Caption = "Prioritas   "
        Me.BarEditItemPrioritas.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItemPrioritas.EditWidth = 100
        Me.BarEditItemPrioritas.Id = 33
        Me.BarEditItemPrioritas.Name = "BarEditItemPrioritas"
        Me.BarEditItemPrioritas.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemReset
        '
        Me.BarButtonItemReset.Caption = "Reset"
        Me.BarButtonItemReset.Id = 34
        Me.BarButtonItemReset.ImageOptions.Image = CType(resources.GetObject("BarButtonItemReset.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemReset.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemReset.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemReset.Name = "BarButtonItemReset"
        Me.BarButtonItemReset.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup7, Me.RibbonPageGroup8, Me.ribbonPageGroup2})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Home"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiNew)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Tasks"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItemView)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItemAccept)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItemReject)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItemOnProgress)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItemDone)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarEditItemTglRequest1)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarEditItemTglRequest2)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarEditItemDariDivisi)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarEditItemSubjek)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarEditItemPrioritas)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarEditItemStatus)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItemReset)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.Text = "Search Data"
        '
        'ribbonPageGroup2
        '
        Me.ribbonPageGroup2.AllowTextClipping = False
        Me.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup2.ItemLinks.Add(Me.bbiPrintPreview)
        Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
        Me.ribbonPageGroup2.Text = "Print and Export"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.bsiRecordsCount)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 748)
        Me.ribbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1121, 30)
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbiPrintPreview)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Print and Export"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiPrintPreview)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Print and Export"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiPrintPreview)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Print and Export"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bbiPrintPreview)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Print and Export"
        '
        'gridView
        '
        Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gridView.DetailHeight = 431
        Me.gridView.GridControl = Me.gridControl1
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.ReadOnly = True
        '
        'gridControl1
        '
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridControl1.Location = New System.Drawing.Point(0, 193)
        Me.gridControl1.MainView = Me.gridView
        Me.gridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridControl1.MenuManager = Me.ribbonControl
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(1121, 585)
        Me.gridControl1.TabIndex = 2
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'XtraFormTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 778)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "XtraFormTask"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Private WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItemDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemAccept As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemReject As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemOnProgress As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemDone As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItemTaskId As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItemTglRequest1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItemTglRequest2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItemSubjek As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItemDariDivisi As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarEditItemStatus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BarEditItemPrioritas As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItemReset As DevExpress.XtraBars.BarButtonItem
End Class
