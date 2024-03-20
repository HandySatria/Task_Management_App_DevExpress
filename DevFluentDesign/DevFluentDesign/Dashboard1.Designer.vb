Namespace Win_Dashboards
    Partial Public Class Dashboard1
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.PieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.PieDashboardItem2 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.ChartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PieDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem1
            '
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Dimension1.DataMember = "dtm_crt"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension1.Name = "Month"
            Measure1.DataMember = "divisi_1_divisi_name"
            Measure1.Name = "Banyak Request (month)"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.ChartDashboardItem1.DataMember = "Query"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Chart 1"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "localhost_task_request_Connection"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            CustomSqlQuery1.Name = "Query"
            QueryParameter1.Name = "FromDivisiId"
            QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            QueryParameter1.Value = New DevExpress.DataAccess.Expression("?FromDivisiId", GetType(Integer))
            CustomSqlQuery1.Parameters.Add(QueryParameter1)
            CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'PieDashboardItem1
            '
            Dimension2.DataMember = "prioritas_name"
            Dimension2.Name = "Prioritas"
            Me.PieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.PieDashboardItem1.ComponentName = "PieDashboardItem1"
            Measure2.DataMember = "prioritas_name"
            Measure2.Name = "Prioritas"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.PieDashboardItem1.DataItemRepository.Clear()
            Me.PieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.PieDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.PieDashboardItem1.DataMember = "Query"
            Me.PieDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.PieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.PieDashboardItem1.Name = "Pies 1"
            Me.PieDashboardItem1.ShowCaption = True
            Me.PieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'PieDashboardItem2
            '
            Dimension3.DataMember = "status_name"
            Dimension3.Name = "Status"
            Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.PieDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.PieDashboardItem2.ComponentName = "PieDashboardItem2"
            Measure3.DataMember = "status_name"
            Measure3.Name = "Status"
            Measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.PieDashboardItem2.DataItemRepository.Clear()
            Me.PieDashboardItem2.DataItemRepository.Add(Measure3, "DataItem0")
            Me.PieDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.PieDashboardItem2.DataMember = "Query"
            Me.PieDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.PieDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.PieDashboardItem2.Name = "Pies 2"
            Me.PieDashboardItem2.ShowCaption = True
            Me.PieDashboardItem2.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure3})
            '
            'ChartDashboardItem2
            '
            Dimension4.DataMember = "cabang_name"
            Dimension4.Name = "Cabang"
            Dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ChartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ChartDashboardItem2.AxisX.TitleVisible = False
            Me.ChartDashboardItem2.ComponentName = "ChartDashboardItem2"
            Measure4.DataMember = "cabang_name"
            Measure4.Name = "Banyak Request (Cabang)"
            Measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ChartDashboardItem2.DataItemRepository.Clear()
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure4, "DataItem0")
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem1")
            Me.ChartDashboardItem2.DataMember = "Query"
            Me.ChartDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem2.Name = "Chart 2"
            ChartPane2.Name = "Pane 1"
            ChartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.TitleVisible = True
            ChartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.AddDataItem("Value", Measure4)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.ChartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane2})
            Me.ChartDashboardItem2.ShowCaption = True
            '
            'Dashboard1
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.PieDashboardItem1, Me.PieDashboardItem2, Me.ChartDashboardItem1, Me.ChartDashboardItem2})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem1.Weight = 52.435897435897438R
            DashboardLayoutItem2.DashboardItem = Me.PieDashboardItem1
            DashboardLayoutItem2.Weight = 47.564102564102562R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 50.955414012738856R
            DashboardLayoutItem3.DashboardItem = Me.PieDashboardItem2
            DashboardLayoutItem3.Weight = 52.435897435897438R
            DashboardLayoutItem4.DashboardItem = Me.ChartDashboardItem2
            DashboardLayoutItem4.Weight = 47.564102564102562R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem3, DashboardLayoutItem4})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Weight = 49.044585987261144R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "FromDivisiId"
            DashboardParameter1.Type = GetType(Integer)
            DashboardParameter1.Value = 0
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1})
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PieDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents PieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
        Friend WithEvents PieDashboardItem2 As DevExpress.DashboardCommon.PieDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ChartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem

#End Region
    End Class
End Namespace