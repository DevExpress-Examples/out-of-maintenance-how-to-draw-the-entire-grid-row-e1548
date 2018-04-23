using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing.Drawing2D;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Q210958 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);

        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
            GridView view = (GridView)sender;
            GridViewInfo viewInfo = (GridViewInfo)view.GetViewInfo();
            GridColumnsInfo ci = viewInfo.ColumnsInfo;
            if (!view.IsDataRow(e.RowHandle) || e.RowHandle == view.FocusedRowHandle ||
                ci.FirstColumnInfo.Column != e.Column) 
                return;
            bool even = e.RowHandle % 2 == 0;
            HatchStyle hStyle = even ? HatchStyle.BackwardDiagonal : HatchStyle.Cross;
            Color fColor = even ? Color.AliceBlue : Color.AntiqueWhite;
            Color bColor = even ? Color.Aqua : Color.Aquamarine;
            Rectangle row = new Rectangle(viewInfo.ViewRects.Rows.Left, e.Bounds.Y,
                viewInfo.ViewRects.Rows.Width, e.Bounds.Height);
            using (Brush brush = new HatchBrush(hStyle, fColor, bColor)) {
                e.Graphics.FillRectangle(brush, row);
            }
        }
    }
}