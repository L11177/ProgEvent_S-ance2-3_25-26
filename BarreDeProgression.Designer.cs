namespace ProgEvent_Séance2_25_26
{
    partial class FormProgression
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
            components = new System.ComponentModel.Container();
            progressBarPrincipale = new ProgressBar();
            progressBarSecondaire = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBarPrincipale
            // 
            progressBarPrincipale.Location = new Point(40, 40);
            progressBarPrincipale.Name = "progressBarPrincipale";
            progressBarPrincipale.Size = new Size(271, 55);
            progressBarPrincipale.TabIndex = 0;
            // 
            // progressBarSecondaire
            // 
            progressBarSecondaire.Location = new Point(40, 163);
            progressBarSecondaire.Name = "progressBarSecondaire";
            progressBarSecondaire.Size = new Size(271, 55);
            progressBarSecondaire.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 17);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 2;
            label1.Text = "Barre principale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 140);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "Barre secondaire";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            // 
            // FormProgression
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 437);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBarSecondaire);
            Controls.Add(progressBarPrincipale);
            Name = "FormProgression";
            Text = "Barre de Progression";
            Load += FormProgression_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarPrincipale;
        private ProgressBar progressBarSecondaire;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}