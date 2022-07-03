namespace Mouse_wave
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRenderHorizontal = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRenderVertical = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.btnApplyTimerInterval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRenderHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelRenderVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.panelRenderHorizontal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.panelRenderVertical);
            this.splitContainer1.Size = new System.Drawing.Size(785, 405);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Позиция по горизонтали:";
            // 
            // panelRenderHorizontal
            // 
            this.panelRenderHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRenderHorizontal.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelRenderHorizontal.Location = new System.Drawing.Point(3, 22);
            this.panelRenderHorizontal.Name = "panelRenderHorizontal";
            this.panelRenderHorizontal.Size = new System.Drawing.Size(350, 380);
            this.panelRenderHorizontal.TabIndex = 0;
            this.panelRenderHorizontal.TabStop = false;
            this.panelRenderHorizontal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRenderHorizontal_Paint);
            this.panelRenderHorizontal.Resize += new System.EventHandler(this.panelRenderHorizontal_Resize);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Позиция по вертикали:";
            // 
            // panelRenderVertical
            // 
            this.panelRenderVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRenderVertical.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelRenderVertical.Location = new System.Drawing.Point(3, 22);
            this.panelRenderVertical.Name = "panelRenderVertical";
            this.panelRenderVertical.Size = new System.Drawing.Size(417, 380);
            this.panelRenderVertical.TabIndex = 0;
            this.panelRenderVertical.TabStop = false;
            this.panelRenderVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRenderVertical_Paint);
            this.panelRenderVertical.Resize += new System.EventHandler(this.panelRenderVertical_Resize);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Интервал обновления:";
            // 
            // numericUpDownTimerInterval
            // 
            this.numericUpDownTimerInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownTimerInterval.Location = new System.Drawing.Point(140, 420);
            this.numericUpDownTimerInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimerInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTimerInterval.Name = "numericUpDownTimerInterval";
            this.numericUpDownTimerInterval.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownTimerInterval.TabIndex = 4;
            this.numericUpDownTimerInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnApplyTimerInterval
            // 
            this.btnApplyTimerInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyTimerInterval.Location = new System.Drawing.Point(199, 418);
            this.btnApplyTimerInterval.Name = "btnApplyTimerInterval";
            this.btnApplyTimerInterval.Size = new System.Drawing.Size(75, 23);
            this.btnApplyTimerInterval.TabIndex = 5;
            this.btnApplyTimerInterval.Text = "Применить";
            this.btnApplyTimerInterval.UseVisualStyleBackColor = true;
            this.btnApplyTimerInterval.Click += new System.EventHandler(this.btnApplyTimerInterval_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApplyTimerInterval);
            this.Controls.Add(this.numericUpDownTimerInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Mouse wave";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelRenderHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelRenderVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox panelRenderVertical;
        private System.Windows.Forms.PictureBox panelRenderHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTimerInterval;
        private System.Windows.Forms.Button btnApplyTimerInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

