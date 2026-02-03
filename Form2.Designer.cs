namespace ProgEvent_Séance2_25_26
{
    partial class aProposForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = Properties.Resources.LUKA;
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 13);
            label1.Name = "label1";
            label1.Size = new Size(198, 23);
            label1.TabIndex = 1;
            label1.Text = "Premières Manipulations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 55);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 2;
            label2.Text = "Version sous-alpha 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 112);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 3;
            label3.Text = "CopyRight LUKA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 176);
            label4.Name = "label4";
            label4.Size = new Size(253, 40);
            label4.TabIndex = 4;
            label4.Text = "Et l'application se dit qu'un jour, elle \r\ndeviendra aussi grande que .NET";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Cursor = Cursors.WaitCursor;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 238);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(130, 270);
            button1.Name = "button1";
            button1.Size = new Size(139, 39);
            button1.TabIndex = 6;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // aProposForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(420, 321);
            Controls.Add(button1);
            Controls.Add(panel1);
            Cursor = Cursors.Help;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "aProposForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ecran à propos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button1;
    }
}