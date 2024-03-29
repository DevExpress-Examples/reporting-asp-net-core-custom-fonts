Namespace DocumentViewerApp.PredefinedReports

    Partial Class TestReport

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentViewerApp.PredefinedReports.TestReport))
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' pageInfo1
            ' 
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
            Me.pageInfo1.StyleName = "PageInfo"
            ' 
            ' pageInfo2
            ' 
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
            Me.ReportHeader.HeightF = 60F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' label1
            ' 
            Me.label1.Font = New DevExpress.Drawing.DXFont("Arial", 30F)
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(650F, 49.99999F)
            Me.label1.Text = "Report"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.GroupHeader1.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 27F
            Me.GroupHeader1.Level = 1
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.StylePriority.UseFont = False
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 1R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "GroupCaption1"
            Me.tableCell1.Text = "CATEGORY ID"
            Me.tableCell1.Weight = 3177252.772742609R
            Me.tableCell1.WordWrap = False
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryID]")})
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "GroupData1"
            Me.tableCell2.Weight = 7472346.6022573914R
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader2.HeightF = 28F
            Me.GroupHeader2.Level = 2
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table2.Name = "table2"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
            Me.table2.SizeF = New System.Drawing.SizeF(650F, 28F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 1R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "DetailCaption1"
            Me.tableCell3.StylePriority.UseBorders = False
            Me.tableCell3.Text = "Category Name"
            Me.tableCell3.Weight = 0.29834482046274041R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "DetailCaption1"
            Me.tableCell4.Text = "Description"
            Me.tableCell4.Weight = 0.2344280066856971R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "DetailCaption1"
            Me.tableCell5.Text = "Picture"
            Me.tableCell5.Weight = 0.1609015596829928R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "DetailCaption1"
            Me.tableCell6.Text = "Icon17"
            Me.tableCell6.Weight = 0.153162841796875R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "DetailCaption1"
            Me.tableCell7.Text = "Icon25"
            Me.tableCell7.Weight = 0.15316274789663462R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            ' 
            ' table3
            ' 
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table3.Name = "table3"
            Me.table3.OddStyleName = "DetailData3_Odd"
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
            Me.table3.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 11.5R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData1"
            Me.tableCell8.StylePriority.UseBorders = False
            Me.tableCell8.Weight = 0.29834482046274041R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.StyleName = "DetailData1"
            Me.tableCell9.Weight = 0.2344280066856971R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox1})
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StyleName = "DetailData1"
            Me.tableCell10.Weight = 0.1609015596829928R
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.pictureBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.pictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(102.5027F, 25F)
            Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox2})
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.StyleName = "DetailData1"
            Me.tableCell11.Weight = 0.153162841796875R
            ' 
            ' pictureBox2
            ' 
            Me.pictureBox2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.pictureBox2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.pictureBox2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Icon17]")})
            Me.pictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.SizeF = New System.Drawing.SizeF(97.47251F, 25F)
            Me.pictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox3})
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.StyleName = "DetailData1"
            Me.tableCell12.Weight = 0.15316274789663462R
            ' 
            ' pictureBox3
            ' 
            Me.pictureBox3.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.pictureBox3.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.pictureBox3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Icon25]")})
            Me.pictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.SizeF = New System.Drawing.SizeF(97.47245F, 25F)
            Me.pictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label2})
            Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
            Me.GroupFooter1.HeightF = 6F
            Me.GroupFooter1.Name = "GroupFooter1"
            ' 
            ' label2
            ' 
            Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label2.Name = "label2"
            Me.label2.SizeF = New System.Drawing.SizeF(650F, 2.08F)
            Me.label2.StyleName = "GroupFooterBackground3"
            Me.label2.StylePriority.UseBorders = False
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table4.Name = "Categories"
            columnExpression1.Table = table4
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table4
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table4
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table4
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Icon17"
            columnExpression5.Table = table4
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Icon25"
            columnExpression6.Table = table4
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table4)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New DevExpress.Drawing.DXFont("Arial", 14.25F)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((70)))))), (CInt(((CByte((80)))))))
            Me.Title.Name = "Title"
            Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ' 
            ' GroupCaption1
            ' 
            Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((181)))))), (CInt(((CByte((211)))))), (CInt(((CByte((142)))))))
            Me.GroupCaption1.BorderColor = System.Drawing.Color.White
            Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupCaption1.BorderWidth = 2F
            Me.GroupCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8F)
            Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((228)))))), (CInt(((CByte((228)))))), (CInt(((CByte((228)))))))
            Me.GroupCaption1.Name = "GroupCaption1"
            Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' GroupData1
            ' 
            Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((181)))))), (CInt(((CByte((211)))))), (CInt(((CByte((142)))))))
            Me.GroupData1.BorderColor = System.Drawing.Color.White
            Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupData1.BorderWidth = 2F
            Me.GroupData1.Font = New DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupData1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((70)))))), (CInt(((CByte((80)))))))
            Me.GroupData1.Name = "GroupData1"
            Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption1
            ' 
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((181)))))), (CInt(((CByte((211)))))), (CInt(((CByte((142)))))))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2F
            Me.DetailCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((70)))))), (CInt(((CByte((80)))))))
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData1
            ' 
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2F
            Me.DetailData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupFooterBackground3
            ' 
            Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((117)))))), (CInt(((CByte((129)))))))
            Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
            Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupFooterBackground3.BorderWidth = 2F
            Me.GroupFooterBackground3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((228)))))), (CInt(((CByte((228)))))), (CInt(((CByte((228)))))))
            Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
            Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((245)))))), (CInt(((CByte((248)))))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((70)))))), (CInt(((CByte((80)))))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ' 
            ' TestReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.Detail, Me.GroupFooter1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.PageInfo})
            Me.Version = "24.1"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private label2 As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupData1 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
