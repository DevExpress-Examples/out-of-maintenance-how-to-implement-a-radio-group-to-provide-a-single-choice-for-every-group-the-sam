Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colProduct As DevExpress.XtraGrid.Columns.GridColumn
		Private colInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private InStockCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private MachineCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.InStockCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.MachineCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.InStockCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.MachineCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.RelationName = "Level1"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.InStockCheckEdit, Me.MachineCheckEdit})
			Me.gridControl1.Size = New System.Drawing.Size(610, 354)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProduct, Me.colInStock, Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
'			Me.gridView1.Click += New System.EventHandler(Me.gridView1_Click);
			' 
			' colProduct
			' 
			Me.colProduct.Caption = "Product"
			Me.colProduct.FieldName = "Product"
			Me.colProduct.Name = "colProduct"
			Me.colProduct.Visible = True
			Me.colProduct.VisibleIndex = 0
			' 
			' colInStock
			' 
			Me.colInStock.Caption = "Selected (unbound)"
			Me.colInStock.ColumnEdit = Me.InStockCheckEdit
			Me.colInStock.FieldName = "UnboundChecked"
			Me.colInStock.Name = "colInStock"
			Me.colInStock.OptionsColumn.AllowEdit = False
			Me.colInStock.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
			Me.colInStock.Visible = True
			Me.colInStock.VisibleIndex = 1
			' 
			' InStockCheckEdit
			' 
			Me.InStockCheckEdit.AutoHeight = False
			Me.InStockCheckEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.InStockCheckEdit.Name = "InStockCheckEdit"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "CategoryID"
			Me.gridColumn1.FieldName = "CategoryID"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 2
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Selected (readonly)"
			Me.gridColumn2.FieldName = "Selected"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.ReadOnly = True
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 2
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "ItemDescription"
			Me.gridColumn3.FieldName = "ItemDescription"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 3
			' 
			' MachineCheckEdit
			' 
			Me.MachineCheckEdit.AutoHeight = False
			Me.MachineCheckEdit.Name = "MachineCheckEdit"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(610, 354)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.InStockCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.MachineCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private selectedItems As New Hashtable()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim myTable As New DataTable()
			myTable.Columns.Add("CategoryID", GetType(Integer))
			myTable.Columns.Add("Selected", GetType(Boolean))
			myTable.Columns.Add("ItemDescription", GetType(String))

			myTable.Rows.Add(New Object() { 1, False, "A" })
			myTable.Rows.Add(New Object() { 1, False, "B" })
			myTable.Rows.Add(New Object() { 2, False, "C" })
			myTable.Rows.Add(New Object() { 2, False, "D" })
			gridControl1.DataSource = myTable
			gridView1.ExpandAllGroups()
		End Sub

		Private Sub gridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.Click
			Dim view As GridView = CType(sender, GridView)
			Dim hit As GridHitInfo = view.CalcHitInfo(view.GridControl.PointToClient(MousePosition))
			If hit.InRowCell AndAlso hit.Column.FieldName = "UnboundChecked" Then
				Dim row As DataRow = gridView1.GetDataRow(hit.RowHandle)
				Dim key As Object = row("CategoryID")
				Dim prevRow As DataRow = CType(selectedItems(key), DataRow)
				If row Is prevRow Then
					Return
				End If
				If prevRow IsNot Nothing Then
				prevRow("Selected") = False
				End If
				view.RefreshRow(FindRowHandleByDataRow(view,prevRow))
				selectedItems(key) = view.GetDataRow(hit.RowHandle)
				view.GetDataRow(hit.RowHandle)("Selected") = True
				view.RefreshRow(hit.RowHandle)
			End If
		End Sub

		Private Function FindRowHandleByDataRow(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As DataRow) As Integer
			For i As Integer = 0 To view.DataRowCount - 1
				Dim r As DataRow = view.GetDataRow(i)
				If r Is row Then
					Return i
				End If
			Next i
			Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
		End Function

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.Column.FieldName = "UnboundChecked" Then
				If e.IsGetData Then
					Dim row As DataRowView = (CType((CType(sender, GridView)).DataSource, DataView))(e.ListSourceRowIndex)
					Dim key As Object = row("CategoryID")
					Dim selectedRow As DataRow = CType(selectedItems(key), DataRow)
					e.Value = (row.Row Is selectedRow)
				End If
			End If
		End Sub
	End Class
End Namespace
