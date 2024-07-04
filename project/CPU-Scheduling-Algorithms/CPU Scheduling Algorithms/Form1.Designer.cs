
namespace CPU_Scheduling_Algorithms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.CountTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GanttChartPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotThoiGianXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreemptiveBtn = new System.Windows.Forms.RadioButton();
            this.NonPreemptiveBtn = new System.Windows.Forms.RadioButton();
            this.RunBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FCFS_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SJF_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.RR_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Algorithm = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.qInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.RRPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qInput)).BeginInit();
            this.RRPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(42, 456);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(781, 128);
            this.txtConsole.TabIndex = 22;
            this.txtConsole.WordWrap = false;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // CountTime
            // 
            this.CountTime.AutoSize = true;
            this.CountTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTime.Location = new System.Drawing.Point(167, 393);
            this.CountTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountTime.Name = "CountTime";
            this.CountTime.Size = new System.Drawing.Size(14, 15);
            this.CountTime.TabIndex = 18;
            this.CountTime.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Completion Time:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Red;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(170, 242);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(121, 37);
            this.ClearBtn.TabIndex = 26;
            this.ClearBtn.Text = "Reset";
            this.toolTip1.SetToolTip(this.ClearBtn, "Nút làm lại cuộc đời");
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GanttChartPanel
            // 
            this.GanttChartPanel.AutoScroll = true;
            this.GanttChartPanel.AutoScrollMargin = new System.Drawing.Size(5000, 0);
            this.GanttChartPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GanttChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GanttChartPanel.Location = new System.Drawing.Point(42, 305);
            this.GanttChartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.GanttChartPanel.Name = "GanttChartPanel";
            this.GanttChartPanel.Size = new System.Drawing.Size(810, 84);
            this.GanttChartPanel.TabIndex = 25;
            this.GanttChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GanttChartPanel_Paint);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(741, 123);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 33);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Remove";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addBtn.Location = new System.Drawing.Point(741, 81);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 34);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.CotThoiGianDen,
            this.CotThoiGianXuLy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(335, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 216);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "PROCES";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // CotThoiGianDen
            // 
            this.CotThoiGianDen.HeaderText = "ARRIVAL TIME";
            this.CotThoiGianDen.MinimumWidth = 6;
            this.CotThoiGianDen.Name = "CotThoiGianDen";
            this.CotThoiGianDen.Width = 125;
            // 
            // CotThoiGianXuLy
            // 
            this.CotThoiGianXuLy.HeaderText = "BURST TIME";
            this.CotThoiGianXuLy.MinimumWidth = 6;
            this.CotThoiGianXuLy.Name = "CotThoiGianXuLy";
            this.CotThoiGianXuLy.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PreemptiveBtn);
            this.panel1.Controls.Add(this.NonPreemptiveBtn);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(127, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 76);
            this.panel1.TabIndex = 21;
            // 
            // PreemptiveBtn
            // 
            this.PreemptiveBtn.AutoSize = true;
            this.PreemptiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreemptiveBtn.Location = new System.Drawing.Point(17, 40);
            this.PreemptiveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PreemptiveBtn.Name = "PreemptiveBtn";
            this.PreemptiveBtn.Size = new System.Drawing.Size(121, 17);
            this.PreemptiveBtn.TabIndex = 3;
            this.PreemptiveBtn.Text = "NON PREEMPTIVE";
            this.PreemptiveBtn.UseVisualStyleBackColor = true;
            // 
            // NonPreemptiveBtn
            // 
            this.NonPreemptiveBtn.AutoSize = true;
            this.NonPreemptiveBtn.Checked = true;
            this.NonPreemptiveBtn.Location = new System.Drawing.Point(17, 14);
            this.NonPreemptiveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NonPreemptiveBtn.Name = "NonPreemptiveBtn";
            this.NonPreemptiveBtn.Size = new System.Drawing.Size(94, 17);
            this.NonPreemptiveBtn.TabIndex = 2;
            this.NonPreemptiveBtn.TabStop = true;
            this.NonPreemptiveBtn.Text = "PREEMPTIVE";
            this.NonPreemptiveBtn.UseVisualStyleBackColor = true;
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.Location = new System.Drawing.Point(741, 242);
            this.RunBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(111, 37);
            this.RunBtn.TabIndex = 20;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "CPU SCHEDULING ALGORITHM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 27);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FCFS_menu,
            this.SJF_menu,
            this.RR_menu});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 23);
            this.toolStripMenuItem1.Text = "SELECT ALGORITHM ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FCFS_menu
            // 
            this.FCFS_menu.DoubleClickEnabled = true;
            this.FCFS_menu.Name = "FCFS_menu";
            this.FCFS_menu.Size = new System.Drawing.Size(157, 24);
            this.FCFS_menu.Text = "FCFS";
            this.FCFS_menu.Click += new System.EventHandler(this.FCFS_menu_Click);
            // 
            // SJF_menu
            // 
            this.SJF_menu.Name = "SJF_menu";
            this.SJF_menu.Size = new System.Drawing.Size(157, 24);
            this.SJF_menu.Text = "SJF";
            this.SJF_menu.Click += new System.EventHandler(this.SJF_menu_Click);
            // 
            // RR_menu
            // 
            this.RR_menu.Name = "RR_menu";
            this.RR_menu.Size = new System.Drawing.Size(157, 24);
            this.RR_menu.Text = "Round Robin";
            this.RR_menu.Click += new System.EventHandler(this.RR_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Algorithm);
            this.panel2.Location = new System.Drawing.Point(127, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 42);
            this.panel2.TabIndex = 34;
            // 
            // Algorithm
            // 
            this.Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algorithm.ForeColor = System.Drawing.Color.Black;
            this.Algorithm.Location = new System.Drawing.Point(5, 11);
            this.Algorithm.Margin = new System.Windows.Forms.Padding(4);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.ReadOnly = true;
            this.Algorithm.Size = new System.Drawing.Size(150, 21);
            this.Algorithm.TabIndex = 0;
            this.Algorithm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qInput
            // 
            this.qInput.Location = new System.Drawing.Point(80, 2);
            this.qInput.Name = "qInput";
            this.qInput.Size = new System.Drawing.Size(83, 20);
            this.qInput.TabIndex = 35;
            this.qInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Quantum";
            // 
            // RRPanel
            // 
            this.RRPanel.Controls.Add(this.qInput);
            this.RRPanel.Controls.Add(this.label5);
            this.RRPanel.Location = new System.Drawing.Point(127, 195);
            this.RRPanel.Name = "RRPanel";
            this.RRPanel.Size = new System.Drawing.Size(164, 40);
            this.RRPanel.TabIndex = 37;
            this.RRPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "RESULT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "GANTT CHART";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "<---- Select the algorithm here";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.CountTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.GanttChartPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RRPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CPU SCHEDULING ALGORITHM";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qInput)).EndInit();
            this.RRPanel.ResumeLayout(false);
            this.RRPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label CountTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel GanttChartPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PreemptiveBtn;
        private System.Windows.Forms.RadioButton NonPreemptiveBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FCFS_menu;
        private System.Windows.Forms.ToolStripMenuItem SJF_menu;
        private System.Windows.Forms.ToolStripMenuItem RR_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Algorithm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown qInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel RRPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotThoiGianXuLy;
        private System.Windows.Forms.Label label3;
    }
}

