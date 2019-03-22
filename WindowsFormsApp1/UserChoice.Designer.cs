namespace WindowsFormsApp1
{
    partial class UserChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChoice));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonWorkbench = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Panel1.Controls.Add(this.buttonLogout);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStats);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonWorkbench);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 696);
            this.splitContainer1.SplitterDistance = 642;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gray;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout.Location = new System.Drawing.Point(0, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(122, 42);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.Transparent;
            this.buttonStats.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStats.FlatAppearance.BorderSize = 3;
            this.buttonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStats.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStats.Location = new System.Drawing.Point(249, 549);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(175, 41);
            this.buttonStats.TabIndex = 0;
            this.buttonStats.Text = "Player\'s stats";
            this.buttonStats.UseVisualStyleBackColor = false;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonWorkbench
            // 
            this.buttonWorkbench.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorkbench.FlatAppearance.BorderSize = 3;
            this.buttonWorkbench.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkbench.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorkbench.Location = new System.Drawing.Point(257, 549);
            this.buttonWorkbench.Name = "buttonWorkbench";
            this.buttonWorkbench.Size = new System.Drawing.Size(175, 41);
            this.buttonWorkbench.TabIndex = 0;
            this.buttonWorkbench.Text = "Workbench";
            this.buttonWorkbench.UseVisualStyleBackColor = false;
            this.buttonWorkbench.Click += new System.EventHandler(this.buttonWorkbench_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(80, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(561, 436);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // UserChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 696);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserChoice";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserChoice_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserChoice_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonWorkbench;
    }
}