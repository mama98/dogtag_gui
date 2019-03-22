namespace WindowsFormsApp1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonVikendi = new System.Windows.Forms.Button();
            this.buttonSanhok = new System.Windows.Forms.Button();
            this.buttonMiramar = new System.Windows.Forms.Button();
            this.buttonErangel = new System.Windows.Forms.Button();
            this.pictureboxMap = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(686, 627);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Location = new System.Drawing.Point(33, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 134);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Location = new System.Drawing.Point(33, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 134);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(33, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 134);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M416",
            "Beryl"});
            this.comboBox1.Location = new System.Drawing.Point(78, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gray;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "Weapon Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.buttonVikendi);
            this.panel2.Controls.Add(this.buttonSanhok);
            this.panel2.Controls.Add(this.buttonMiramar);
            this.panel2.Controls.Add(this.buttonErangel);
            this.panel2.Controls.Add(this.pictureboxMap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(602, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(669, 627);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(139, 526);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(372, 79);
            this.panel6.TabIndex = 5;
            // 
            // buttonVikendi
            // 
            this.buttonVikendi.BackColor = System.Drawing.Color.Gray;
            this.buttonVikendi.FlatAppearance.BorderSize = 0;
            this.buttonVikendi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVikendi.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVikendi.Location = new System.Drawing.Point(418, 492);
            this.buttonVikendi.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVikendi.Name = "buttonVikendi";
            this.buttonVikendi.Size = new System.Drawing.Size(93, 34);
            this.buttonVikendi.TabIndex = 9;
            this.buttonVikendi.Text = "Vikendi";
            this.buttonVikendi.UseVisualStyleBackColor = false;
            // 
            // buttonSanhok
            // 
            this.buttonSanhok.BackColor = System.Drawing.Color.Gray;
            this.buttonSanhok.FlatAppearance.BorderSize = 0;
            this.buttonSanhok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSanhok.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSanhok.Location = new System.Drawing.Point(325, 492);
            this.buttonSanhok.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSanhok.Name = "buttonSanhok";
            this.buttonSanhok.Size = new System.Drawing.Size(93, 34);
            this.buttonSanhok.TabIndex = 8;
            this.buttonSanhok.Text = "Sanhok";
            this.buttonSanhok.UseVisualStyleBackColor = false;
            // 
            // buttonMiramar
            // 
            this.buttonMiramar.BackColor = System.Drawing.Color.Gray;
            this.buttonMiramar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonMiramar.FlatAppearance.BorderSize = 0;
            this.buttonMiramar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMiramar.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMiramar.Location = new System.Drawing.Point(232, 492);
            this.buttonMiramar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMiramar.Name = "buttonMiramar";
            this.buttonMiramar.Size = new System.Drawing.Size(93, 34);
            this.buttonMiramar.TabIndex = 7;
            this.buttonMiramar.Text = "Miramar";
            this.buttonMiramar.UseVisualStyleBackColor = false;
            // 
            // buttonErangel
            // 
            this.buttonErangel.BackColor = System.Drawing.Color.Gray;
            this.buttonErangel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonErangel.FlatAppearance.BorderSize = 0;
            this.buttonErangel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonErangel.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErangel.Location = new System.Drawing.Point(139, 492);
            this.buttonErangel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonErangel.Name = "buttonErangel";
            this.buttonErangel.Size = new System.Drawing.Size(93, 34);
            this.buttonErangel.TabIndex = 6;
            this.buttonErangel.Text = "Erangel";
            this.buttonErangel.UseVisualStyleBackColor = false;
            this.buttonErangel.Click += new System.EventHandler(this.buttonErangel_Click);
            // 
            // pictureboxMap
            // 
            this.pictureboxMap.Image = global::WindowsFormsApp1.Properties.Resources.erangel;
            this.pictureboxMap.Location = new System.Drawing.Point(105, 108);
            this.pictureboxMap.Margin = new System.Windows.Forms.Padding(0);
            this.pictureboxMap.Name = "pictureboxMap";
            this.pictureboxMap.Size = new System.Drawing.Size(434, 384);
            this.pictureboxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxMap.TabIndex = 1;
            this.pictureboxMap.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(462, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Map";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonVikendi;
        private System.Windows.Forms.Button buttonSanhok;
        private System.Windows.Forms.Button buttonMiramar;
        private System.Windows.Forms.Button buttonErangel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureboxMap;
    }
}

