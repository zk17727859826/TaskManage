namespace TaskManage
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVerified = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnNoComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.nfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timePosition = new System.Windows.Forms.Timer(this.components);
            this.dgvTask = new TaskManage.contol.cusDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskstatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.aa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskcontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keeper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTask);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 492);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnVerified);
            this.panel4.Controls.Add(this.btnCompleted);
            this.panel4.Controls.Add(this.btnNoComplete);
            this.panel4.Controls.Add(this.btnVerify);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnComplete);
            this.panel4.Controls.Add(this.btnShowAdd);
            this.panel4.Controls.Add(this.btnAll);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 42);
            this.panel4.TabIndex = 5;
            // 
            // btnVerified
            // 
            this.btnVerified.AccessibleDescription = "d";
            this.btnVerified.Location = new System.Drawing.Point(356, 12);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(75, 23);
            this.btnVerified.TabIndex = 1;
            this.btnVerified.Tag = "2";
            this.btnVerified.Text = "已确认";
            this.btnVerified.UseVisualStyleBackColor = true;
            this.btnVerified.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(184, 12);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(75, 23);
            this.btnCompleted.TabIndex = 1;
            this.btnCompleted.Tag = "1";
            this.btnCompleted.Text = "已完成";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnNoComplete
            // 
            this.btnNoComplete.Location = new System.Drawing.Point(98, 12);
            this.btnNoComplete.Name = "btnNoComplete";
            this.btnNoComplete.Size = new System.Drawing.Size(75, 23);
            this.btnNoComplete.TabIndex = 1;
            this.btnNoComplete.Tag = "0";
            this.btnNoComplete.Text = "未完成";
            this.btnNoComplete.UseVisualStyleBackColor = true;
            this.btnNoComplete.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(684, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(598, 12);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "完工";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.Location = new System.Drawing.Point(512, 12);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Size = new System.Drawing.Size(75, 23);
            this.btnShowAdd.TabIndex = 0;
            this.btnShowAdd.Text = "新增";
            this.btnShowAdd.UseVisualStyleBackColor = true;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(12, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 0;
            this.btnAll.Tag = "4";
            this.btnAll.Text = "所有任务";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // nfIcon
            // 
            this.nfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nfIcon.Icon")));
            this.nfIcon.Text = "任务管理";
            this.nfIcon.Visible = true;
            this.nfIcon.DoubleClick += new System.EventHandler(this.nfIcon_DoubleClick);
            // 
            // timePosition
            // 
            this.timePosition.Enabled = true;
            this.timePosition.Interval = 10;
            this.timePosition.Tick += new System.EventHandler(this.timePosition_Tick);
            // 
            // dgvTask
            // 
            this.dgvTask.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTask.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvTask.ColumnHeaderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.taskstatus,
            this.aa,
            this.taskcontent,
            this.keeper,
            this.createdate,
            this.completedate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTask.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(0, 42);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvTask.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTask.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTask.RowTemplate.Height = 23;
            this.dgvTask.RowTemplate.ReadOnly = true;
            this.dgvTask.SecondaryLength = 2;
            this.dgvTask.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvTask.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvTask.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvTask.SelectedRowColor2 = System.Drawing.Color.Gold;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(858, 450);
            this.dgvTask.TabIndex = 6;
            this.dgvTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTask_CellFormatting);
            this.dgvTask.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTask_RowPostPaint);
            this.dgvTask.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvTask_RowStateChanged);
            this.dgvTask.DoubleClick += new System.EventHandler(this.dgvTask_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // taskstatus
            // 
            this.taskstatus.DataPropertyName = "taskstatus";
            this.taskstatus.HeaderText = "状态";
            this.taskstatus.Name = "taskstatus";
            this.taskstatus.ReadOnly = true;
            this.taskstatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.taskstatus.Width = 50;
            // 
            // aa
            // 
            this.aa.DataPropertyName = "taskstatus";
            this.aa.HeaderText = "aaaa";
            this.aa.Name = "aa";
            // 
            // taskcontent
            // 
            this.taskcontent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskcontent.DataPropertyName = "taskcontent";
            this.taskcontent.HeaderText = "任务内容";
            this.taskcontent.Name = "taskcontent";
            this.taskcontent.ReadOnly = true;
            // 
            // keeper
            // 
            this.keeper.DataPropertyName = "keeper";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.keeper.DefaultCellStyle = dataGridViewCellStyle2;
            this.keeper.HeaderText = "负责人";
            this.keeper.Name = "keeper";
            this.keeper.ReadOnly = true;
            this.keeper.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.keeper.Width = 70;
            // 
            // createdate
            // 
            this.createdate.DataPropertyName = "createdate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.createdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.createdate.HeaderText = "创建时间";
            this.createdate.Name = "createdate";
            this.createdate.ReadOnly = true;
            this.createdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.createdate.Width = 130;
            // 
            // completedate
            // 
            this.completedate.DataPropertyName = "completedate";
            this.completedate.HeaderText = "完工时间";
            this.completedate.Name = "completedate";
            this.completedate.ReadOnly = true;
            this.completedate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.completedate.Width = 130;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "d";
            this.button1.Location = new System.Drawing.Point(270, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Tag = "3";
            this.button1.Text = "未确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(770, 12);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "确认";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 492);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务管理";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
        private contol.cusDataGridView dgvTask;
        private System.Windows.Forms.NotifyIcon nfIcon;
        private System.Windows.Forms.Timer timePosition;
        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnNoComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn taskstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn aa;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskcontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn keeper;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVerify;
    }
}

