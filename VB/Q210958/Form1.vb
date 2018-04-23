Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace Q210958
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)

		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			Dim view As GridView = CType(sender, GridView)
			Dim viewInfo As GridViewInfo = CType(view.GetViewInfo(), GridViewInfo)
			Dim ci As GridColumnsInfo = viewInfo.ColumnsInfo
			If (Not view.IsDataRow(e.RowHandle)) OrElse e.RowHandle = view.FocusedRowHandle OrElse ci.FirstColumnInfo.Column IsNot e.Column Then
				Return
			End If
			Dim even As Boolean = e.RowHandle Mod 2 = 0
			Dim hStyle As HatchStyle = If(even, HatchStyle.BackwardDiagonal, HatchStyle.Cross)
			Dim fColor As Color = If(even, Color.AliceBlue, Color.AntiqueWhite)
			Dim bColor As Color = If(even, Color.Aqua, Color.Aquamarine)
			Dim row As New Rectangle(viewInfo.ViewRects.Rows.Left, e.Bounds.Y, viewInfo.ViewRects.Rows.Width, e.Bounds.Height)
			Using brush As Brush = New HatchBrush(hStyle, fColor, bColor)
				e.Cache.FillRectangle(brush, row)
			End Using
		End Sub
	End Class
End Namespace