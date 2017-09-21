using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManage.dal;
using TaskManage.model;

namespace TaskManage
{
    public partial class frmAdd : Form
    {
        TaskDal taskdal = new TaskDal();
        private task TaskInfo;
        public frmAdd(task tsk)
        {
            InitializeComponent();
            TaskInfo = tsk;
            if (TaskInfo != null)
            {
                txtContent.Text = TaskInfo.taskcontent;
                txtKeeper.Text = TaskInfo.keeper;
                this.Text = "编辑任务";
            }
            else
            {
                this.Text = "新增任务";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string content = txtContent.Text.Trim();
                string keeper = txtKeeper.Text.Trim();

                if (string.IsNullOrEmpty(content))
                {
                    throw new Exception("请输入任务内容");
                }
                if (string.IsNullOrEmpty(keeper))
                {
                    throw new Exception("请输入负责人");
                }

                if (TaskInfo != null)
                {
                    taskdal.UpdateTask(TaskInfo.id, content, keeper);
                }
                else
                {
                    taskdal.InsertTask(content, keeper);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
