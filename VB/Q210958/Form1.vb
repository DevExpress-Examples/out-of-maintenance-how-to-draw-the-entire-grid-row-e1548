Imports Microsoft.VisualBasic
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
			If (Not view.IsDataRow(e.RowHandle)) OrElse e.RowHandle = view.FocusedRowHandle OrElse e.Column.VisibleIndex <> 1 Then
				Return
			End If
			Dim even As Boolean = e.RowHandle Mod 2 = 0
			Dim hStyle As HatchStyle
			If even Then
				hStyle = HatchStyle.BackwardDiagonal
			Else
				hStyle = HatchStyle.Cross
			End If
			Dim fColor As Color
			If even Then
				fColor = Color.AliceBlue
			Else
				fColor = Color.AntiqueWhite
			End If
			Dim bColor As Color
			If even Then
				bColor = Color.Aqua
			Else
				bColor = Color.Aquamarine
			End If
			Dim viewInfo As GridViewInfo = CType(view.GetViewInfo(), GridViewInfo)
			Dim row As New Rectangle(viewInfo.ViewRects.Rows.Left, e.Bounds.Y, viewInfo.ViewRects.Rows.Width, e.Bounds.Height)
			Using brush As Brush = New HatchBrush(hStyle, fColor, bColor)
				e.Graphics.FillRectangle(brush, row)
			End Using
		End Sub
	End Class
End Namespace