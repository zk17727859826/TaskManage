using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManage.common;
using TaskManage.dal;
using TaskManage.model;
using TaskManage.Properties;

namespace TaskManage
{
    public partial class frmMain : Form
    {
        TaskDal taskdal = new TaskDal();
        private string SelectedId = string.Empty;
        private string SelectedStatus = "3";//默认展示未确认的任务
        public frmMain()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;  //不显示在系统任务栏
            dgvTask.AutoGenerateColumns = false;//让控件不自动生成列
            this.TopMost = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                bindTask(SelectedStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindTask(string status)
        {
            List<task> tasklist = taskdal.LoadTask(status);
            if (tasklist != null)
            {
                tasklist = tasklist.OrderByDescending(p => p.createdate).ToList();
            }
            dgvTask.DataSource = tasklist;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                SelectedStatus = btn.Tag.ToString();
                bindTask(SelectedStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedId))
                {
                    DialogResult dresult = MessageBox.Show("确认完工？", "完工确认", MessageBoxButtons.OKCancel);
                    if (dresult == DialogResult.OK)
                    {
                        taskdal.CompleteTask(SelectedId);
                        bindTask(SelectedStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedId))
                {
                    DialogResult dresult = MessageBox.Show("确认检查完成？", "完工检查确认", MessageBoxButtons.OKCancel);
                    if (dresult == DialogResult.OK)
                    {
                        taskdal.VerifyTask(SelectedId);
                        bindTask(SelectedStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdd addframe = new frmAdd(null);
                addframe.ShowDialog();
                bindTask(SelectedStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTask_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                task tsk = taskdal.GetTask(SelectedId);
                frmAdd addframe = new frmAdd(tsk);
                addframe.ShowDialog();
                bindTask(SelectedStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedId))
                {
                    DialogResult dresult = MessageBox.Show("确认删除？", "删除确认", MessageBoxButtons.OKCancel);
                    if (dresult == DialogResult.OK)
                    {
                        taskdal.DeleteTask(SelectedId);
                        bindTask(SelectedStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTask_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (dgvTask.SelectedRows.Count > 0)
                {
                    string id = dgvTask.SelectedRows[0].Cells["id"].Value.ToString();
                    SelectedId = id;
                }
                else
                {
                    SelectedId = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                nfIcon.Visible = true;  //托盘图标可见
            }
        }

        private void nfIcon_DoubleClick(object sender, EventArgs e)
        {
            this.timePosition.Enabled = false;
            this.WindowState = FormWindowState.Normal;  //还原窗体
            if (this.Top < 15)
            {
                this.Top = 0;//设置窗体的Top属性为0
            }
            this.TopMost = true;
            this.Opacity = 1;
        }

        private void timePosition_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point pp = new Point(Cursor.Position.X, Cursor.Position.Y);//获取鼠标在屏幕的坐标点
            Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域 
            if ((this.Top < 0) && Win32API.PtInRect(ref Rects, pp))//当鼠标在当前窗体内，并且窗体的Top属性小于0 
            {
                this.Top = 0;//设置窗体的Top属性为0
                this.TopMost = true;
                this.Opacity = 1;
            }
            else //当窗体的上边框与屏幕的顶端的距离小于5时 
            {
                //if (this.Top > -5 && this.Top < 5 && !(Win32API.PtInRect(ref Rects, pp)))
                if (this.Top < 5 && !(Win32API.PtInRect(ref Rects, pp)))
                {
                    if (this.Top > (5 - this.Height))
                    {
                        this.Top -= 50;
                        this.Opacity = 0.5;
                    }
                    if (this.Top < 5 - this.Height)
                    {
                        this.Top = 5 - this.Height;
                        this.timePosition.Enabled = false;
                    }
                }
            }
        }

        private void dgvTask_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动编号，与数据无关
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dgvTask.RowHeadersWidth - 4,
               e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,
                  (e.RowIndex + 1).ToString(),
                   dgvTask.RowHeadersDefaultCellStyle.Font,
                   rectangle,
                   dgvTask.RowHeadersDefaultCellStyle.ForeColor,
                   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            this.timePosition.Enabled = true;
            this.TopMost = false;
        }

        private void dgvTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvTask.Columns[e.ColumnIndex].HeaderText.Equals("状态"))
                {
                    if (e.Value == null)
                    {
                        return;
                    }
                    switch (e.Value.ToString())
                    {
                        case "0"://未完成
                            e.Value = Resources.wait;
                            break;
                        case "1"://已完成
                            e.Value = Resources.notverified;
                            break;
                        case "2"://已确认
                            e.Value = Resources.verified;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}
