namespace CellAutoProject
{
    partial class Input
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
            this.numBirth = new System.Windows.Forms.NumericUpDown();
            this.numDeath = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblDeath = new System.Windows.Forms.Label();
            this.btnExplode = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeath)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // numBirth
            // 
            this.numBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBirth.Location = new System.Drawing.Point(13, 33);
            this.numBirth.Name = "numBirth";
            this.numBirth.Size = new System.Drawing.Size(37, 35);
            this.numBirth.TabIndex = 0;
            // 
            // numDeath
            // 
            this.numDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeath.Location = new System.Drawing.Point(13, 96);
            this.numDeath.Name = "numDeath";
            this.numDeath.Size = new System.Drawing.Size(37, 35);
            this.numDeath.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBirth);
            this.panel1.Controls.Add(this.lblDeath);
            this.panel1.Controls.Add(this.numBirth);
            this.panel1.Controls.Add(this.numDeath);
            this.panel1.Location = new System.Drawing.Point(12, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 157);
            this.panel1.TabIndex = 2;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(10, 17);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(28, 13);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "Birth";
            // 
            // lblDeath
            // 
            this.lblDeath.AutoSize = true;
            this.lblDeath.Location = new System.Drawing.Point(10, 80);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(36, 13);
            this.lblDeath.TabIndex = 3;
            this.lblDeath.Text = "Death";
            // 
            // btnExplode
            // 
            this.btnExplode.Location = new System.Drawing.Point(5, 41);
            this.btnExplode.Name = "btnExplode";
            this.btnExplode.Size = new System.Drawing.Size(75, 23);
            this.btnExplode.TabIndex = 3;
            this.btnExplode.Text = "Explode";
            this.btnExplode.UseVisualStyleBackColor = true;
            this.btnExplode.Click += new System.EventHandler(this.btnExplode_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(5, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnExplode);
            this.panel2.Location = new System.Drawing.Point(12, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 72);
            this.panel2.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(86, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(86, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblWidth);
            this.panel3.Controls.Add(this.lblHeight);
            this.panel3.Controls.Add(this.numHeight);
            this.panel3.Controls.Add(this.numWidth);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 160);
            this.panel3.TabIndex = 6;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(11, 80);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(10, 17);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHeight.Location = new System.Drawing.Point(13, 33);
            this.numHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(62, 35);
            this.numHeight.TabIndex = 0;
            this.numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWidth.Location = new System.Drawing.Point(13, 96);
            this.numWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(62, 35);
            this.numWidth.TabIndex = 1;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(84, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "New";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnOpen);
            this.panel4.Location = new System.Drawing.Point(239, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 44);
            this.panel4.TabIndex = 9;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(419, 425);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Input_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeath)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBirth;
        private System.Windows.Forms.NumericUpDown numDeath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExplode;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStart;
    }
}