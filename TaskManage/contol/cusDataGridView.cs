using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManage.contol
{
    [ToolboxBitmap(typeof(cusDataGridView), "Bitmap.GridViewControl.bmp")] 
    public class cusDataGridView : DataGridView
    {
        private Color _ColumnHeaderColor1 = Color.White;
        private Color _ColumnHeaderColor2 = Color.FromArgb(212, 208, 200);
        private Color _SelectedRowColor1 = Color.White;
        private Color _SelectedRowColor2 = Color.FromArgb(171, 217, 254);
        private Color _PrimaryRowColor1 = Color.White;
        private Color _PrimaryRowColor2 = Color.FromArgb(255, 249, 232);
        private Color _SecondaryRowColor1 = Color.White;
        private Color _SecondaryRowColor2 = Color.White;
        private int _SecondaryLength = 2;

        public Color ColumnHeaderColor1 //表头起始颜色
        {
            get { return _ColumnHeaderColor1; }
            set
            {
                _ColumnHeaderColor1 = value;
                this.Invalidate();
            }
        }

        public Color ColumnHeaderColor2 //表头终止颜色
        {
            get { return _ColumnHeaderColor2; }
            set
            {
                _ColumnHeaderColor2 = value;
                this.Invalidate();
            }
        }

        public Color PrimaryRowcolor1 //奇行起始颜色
        {
            get { return _PrimaryRowColor1; }
            set
            {
                if (value.IsEmpty || value == Color.Transparent)
                    _PrimaryRowColor1 = Color.White;
                else
                    _PrimaryRowColor1 = value;
            }
        }

        public Color PrimaryRowcolor2//奇行终止颜色
        {
            get { return _PrimaryRowColor2; }
            set
            {
                if (value.IsEmpty || value == Color.Transparent)
                    _PrimaryRowColor2 = Color.White;
                else
                    _PrimaryRowColor2 = value;
            }
        }

        public Color SecondaryRowColor1//偶行起始颜色
        {
            get { return _SecondaryRowColor1; }
            set
            {
                if (value.IsEmpty || value == Color.Transparent)
                    _SecondaryRowColor1 = Color.White;
                else
                    _SecondaryRowColor1 = value;
            }
        }

        public Color SecondaryRowColor2//偶行起始颜色
        {
            get { return _SecondaryRowColor2; }
            set
            {
                if (value.IsEmpty || value == Color.Transparent)
                    _SecondaryRowColor2 = Color.White;
                else
                    _SecondaryRowColor2 = value;
            }
        }

        public int SecondaryLength //这个长度现在是指导隔多少个行出现一个偶行
        {
            get { return _SecondaryLength; }
            set { _SecondaryLength = value; }
        }

        private void Init()
        {
            this.RowPrePaint += new DataGridViewRowPrePaintEventHandler(this.GridView_RowPrePaint);
            this.CellPainting += new DataGridViewCellPaintingEventHandler(this.GridView_CellPainting);
        }

        public cusDataGridView()
        {
            Init();
        }

        public Color SelectedRowColor1 //选中行起始颜色
        {
            get { return _SelectedRowColor1; }

            set { _SelectedRowColor1 = value; }
        }

        public Color SelectedRowColor2 //选中行终止颜色
        {
            get { return _SelectedRowColor2; }

            set { _SelectedRowColor2 = value; }
        }

        private static void DrawLinearGradient(Rectangle Rec, Graphics Grp, Color Color1, Color Color2)
        {
            if (Color1 == Color2)
            {
                Brush backbrush = new SolidBrush(Color1);
                Grp.FillRectangle(backbrush, Rec);
            }
            else
            {
                using (Brush backbrush =
                    new LinearGradientBrush(Rec, Color1, Color2,
                                            LinearGradientMode.
                                                Vertical))
                {
                    Grp.FillRectangle(backbrush, Rec);
                }
            }
        }

        private void GridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (!(_ColumnHeaderColor1 == Color.Transparent) && !(_ColumnHeaderColor2 == Color.Transparent) &&
                    !_ColumnHeaderColor1.IsEmpty && !_ColumnHeaderColor2.IsEmpty)
                {
                    DrawLinearGradient(e.CellBounds, e.Graphics, _ColumnHeaderColor1, _ColumnHeaderColor2);
                    e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
                    e.Handled = true;
                }
            }
        }

        private
            void GridView_RowPrePaint
            (object
                 sender,
             DataGridViewRowPrePaintEventArgs e)
        {
            Rectangle rowBounds =
                new Rectangle(0, e.RowBounds.Top, this.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) -
                                                  this.HorizontalScrollingOffset + 1,
                              e.RowBounds.Height);
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                if (this.RowTemplate.DefaultCellStyle.SelectionBackColor == Color.Transparent)
                    DrawLinearGradient(rowBounds, e.Graphics, _SelectedRowColor1, _SelectedRowColor2);
            }
            else
            {
                if (this.RowTemplate.DefaultCellStyle.BackColor == Color.Transparent)
                {
                    if (e.RowIndex % _SecondaryLength == 1)
                    {
                        DrawLinearGradient(rowBounds, e.Graphics, _PrimaryRowColor1, _PrimaryRowColor2);
                    }
                    else
                    {
                        DrawLinearGradient(rowBounds, e.Graphics, _SecondaryRowColor1, _SecondaryRowColor2);
                    }
                }
            }
        }
    }
}
