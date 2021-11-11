
namespace SJF_Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.RunBtn = new System.Windows.Forms.Button();
            this.NonPreemptiveBtn = new System.Windows.Forms.RadioButton();
            this.PreemptiveBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotThoiGianXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GanttChartPanel = new System.Windows.Forms.Panel();
            this.CountTime = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuật toán SJF";
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(724, 225);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(85, 53);
            this.RunBtn.TabIndex = 1;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // NonPreemptiveBtn
            // 
            this.NonPreemptiveBtn.AutoSize = true;
            this.NonPreemptiveBtn.Checked = true;
            this.NonPreemptiveBtn.Location = new System.Drawing.Point(8, 18);
            this.NonPreemptiveBtn.Name = "NonPreemptiveBtn";
            this.NonPreemptiveBtn.Size = new System.Drawing.Size(97, 21);
            this.NonPreemptiveBtn.TabIndex = 2;
            this.NonPreemptiveBtn.TabStop = true;
            this.NonPreemptiveBtn.Text = "Độc quyền";
            this.NonPreemptiveBtn.UseVisualStyleBackColor = true;
            // 
            // PreemptiveBtn
            // 
            this.PreemptiveBtn.AutoSize = true;
            this.PreemptiveBtn.Location = new System.Drawing.Point(8, 45);
            this.PreemptiveBtn.Name = "PreemptiveBtn";
            this.PreemptiveBtn.Size = new System.Drawing.Size(140, 21);
            this.PreemptiveBtn.TabIndex = 3;
            this.PreemptiveBtn.Text = "Không độc quyền";
            this.PreemptiveBtn.UseVisualStyleBackColor = true;
            this.PreemptiveBtn.CheckedChanged += new System.EventHandler(this.NonPreemptiveBtn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PreemptiveBtn);
            this.panel1.Controls.Add(this.NonPreemptiveBtn);
            this.panel1.Location = new System.Drawing.Point(83, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 84);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(252, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // stt
            // 
            this.stt.HeaderText = "Tiến trình";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // CotThoiGianDen
            // 
            this.CotThoiGianDen.HeaderText = "Thời gian đến";
            this.CotThoiGianDen.MinimumWidth = 6;
            this.CotThoiGianDen.Name = "CotThoiGianDen";
            this.CotThoiGianDen.Width = 125;
            // 
            // CotThoiGianXuLy
            // 
            this.CotThoiGianXuLy.HeaderText = "Thời gian xử lý";
            this.CotThoiGianXuLy.MinimumWidth = 6;
            this.CotThoiGianXuLy.Name = "CotThoiGianXuLy";
            this.CotThoiGianXuLy.Width = 125;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(724, 107);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 42);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Remove";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(724, 59);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 42);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time:";
            // 
            // GanttChartPanel
            // 
            this.GanttChartPanel.AutoScroll = true;
            this.GanttChartPanel.AutoScrollMargin = new System.Drawing.Size(5000, 0);
            this.GanttChartPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GanttChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GanttChartPanel.Location = new System.Drawing.Point(8, 299);
            this.GanttChartPanel.Name = "GanttChartPanel";
            this.GanttChartPanel.Size = new System.Drawing.Size(918, 97);
            this.GanttChartPanel.TabIndex = 11;
            this.GanttChartPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GanttChartPanel_Scroll);
            // 
            // CountTime
            // 
            this.CountTime.AutoSize = true;
            this.CountTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTime.Location = new System.Drawing.Point(63, 399);
            this.CountTime.Name = "CountTime";
            this.CountTime.Size = new System.Drawing.Size(16, 18);
            this.CountTime.TabIndex = 1;
            this.CountTime.Text = "0";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(161, 225);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(85, 53);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gantt Chart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Result";
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(8, 449);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(918, 223);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 673);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.CountTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.GanttChartPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "SJF";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.RadioButton NonPreemptiveBtn;
        private System.Windows.Forms.RadioButton PreemptiveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotThoiGianXuLy;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GanttChartPanel;
        private System.Windows.Forms.Label CountTime;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

