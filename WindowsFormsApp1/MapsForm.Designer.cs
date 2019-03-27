namespace WindowsFormsApp1
{
    partial class MapsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapsForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVikendi = new System.Windows.Forms.Button();
            this.buttonSanhok = new System.Windows.Forms.Button();
            this.buttonErangel = new System.Windows.Forms.Button();
            this.buttonMiramar = new System.Windows.Forms.Button();
            this.pictureboxMap = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 42);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVikendi);
            this.panel1.Controls.Add(this.buttonSanhok);
            this.panel1.Controls.Add(this.buttonErangel);
            this.panel1.Controls.Add(this.buttonMiramar);
            this.panel1.Controls.Add(this.pictureboxMap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(109, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 680);
            this.panel1.TabIndex = 20;
            // 
            // buttonVikendi
            // 
            this.buttonVikendi.BackColor = System.Drawing.Color.Gray;
            this.buttonVikendi.FlatAppearance.BorderSize = 0;
            this.buttonVikendi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVikendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVikendi.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonVikendi.Location = new System.Drawing.Point(720, 622);
            this.buttonVikendi.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVikendi.Name = "buttonVikendi";
            this.buttonVikendi.Size = new System.Drawing.Size(194, 50);
            this.buttonVikendi.TabIndex = 30;
            this.buttonVikendi.Text = "Vikendi";
            this.buttonVikendi.UseVisualStyleBackColor = false;
            this.buttonVikendi.Click += new System.EventHandler(this.buttonVikendi_Click);
            // 
            // buttonSanhok
            // 
            this.buttonSanhok.BackColor = System.Drawing.Color.Gray;
            this.buttonSanhok.FlatAppearance.BorderSize = 0;
            this.buttonSanhok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSanhok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSanhok.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonSanhok.Location = new System.Drawing.Point(526, 622);
            this.buttonSanhok.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSanhok.Name = "buttonSanhok";
            this.buttonSanhok.Size = new System.Drawing.Size(194, 50);
            this.buttonSanhok.TabIndex = 29;
            this.buttonSanhok.Text = "Sanhok";
            this.buttonSanhok.UseVisualStyleBackColor = false;
            this.buttonSanhok.Click += new System.EventHandler(this.buttonSanhok_Click);
            // 
            // buttonErangel
            // 
            this.buttonErangel.FlatAppearance.BorderSize = 0;
            this.buttonErangel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErangel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErangel.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonErangel.Location = new System.Drawing.Point(138, 622);
            this.buttonErangel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonErangel.Name = "buttonErangel";
            this.buttonErangel.Size = new System.Drawing.Size(194, 50);
            this.buttonErangel.TabIndex = 27;
            this.buttonErangel.Text = "Erangel";
            this.buttonErangel.UseVisualStyleBackColor = true;
            this.buttonErangel.Click += new System.EventHandler(this.buttonErangel_Click);
            // 
            // buttonMiramar
            // 
            this.buttonMiramar.BackColor = System.Drawing.Color.Gray;
            this.buttonMiramar.FlatAppearance.BorderSize = 0;
            this.buttonMiramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiramar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMiramar.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonMiramar.Location = new System.Drawing.Point(332, 622);
            this.buttonMiramar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMiramar.Name = "buttonMiramar";
            this.buttonMiramar.Size = new System.Drawing.Size(194, 50);
            this.buttonMiramar.TabIndex = 28;
            this.buttonMiramar.Text = "Miramar";
            this.buttonMiramar.UseVisualStyleBackColor = false;
            this.buttonMiramar.Click += new System.EventHandler(this.buttonMiramar_Click);
            // 
            // pictureboxMap
            // 
            this.pictureboxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxMap.BackColor = System.Drawing.Color.Gray;
            this.pictureboxMap.Image = global::WindowsFormsApp1.Properties.Resources.erangel;
            this.pictureboxMap.Location = new System.Drawing.Point(138, 0);
            this.pictureboxMap.Margin = new System.Windows.Forms.Padding(0);
            this.pictureboxMap.Name = "pictureboxMap";
            this.pictureboxMap.Size = new System.Drawing.Size(776, 630);
            this.pictureboxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxMap.TabIndex = 26;
            this.pictureboxMap.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(983, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 55);
            this.label2.TabIndex = 25;
            this.label2.Text = "Maps";
            // 
            // MapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1284, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MapsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVikendi;
        private System.Windows.Forms.Button buttonSanhok;
        private System.Windows.Forms.Button buttonMiramar;
        private System.Windows.Forms.Button buttonErangel;
        private System.Windows.Forms.PictureBox pictureboxMap;
        private System.Windows.Forms.Label label2;
    }
}