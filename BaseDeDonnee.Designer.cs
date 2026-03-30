namespace ProgEvent_Séance2_25_26
{
    partial class BaseDeDonnee
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
            lbConsole = new ListBox();
            bConsulter = new Button();
            bDenombrer = new Button();
            bAjouter = new Button();
            lPrenom = new Label();
            lNom = new Label();
            tbPrenom = new TextBox();
            tbNom = new TextBox();
            SuspendLayout();
            // 
            // lbConsole
            // 
            lbConsole.FormattingEnabled = true;
            lbConsole.Location = new Point(12, 26);
            lbConsole.Name = "lbConsole";
            lbConsole.Size = new Size(264, 364);
            lbConsole.TabIndex = 0;
            // 
            // bConsulter
            // 
            bConsulter.Location = new Point(282, 26);
            bConsulter.Name = "bConsulter";
            bConsulter.Size = new Size(148, 41);
            bConsulter.TabIndex = 1;
            bConsulter.Text = "Consulter";
            bConsulter.UseVisualStyleBackColor = true;
            bConsulter.Click += bConsulter_Click;
            // 
            // bDenombrer
            // 
            bDenombrer.Location = new Point(282, 124);
            bDenombrer.Name = "bDenombrer";
            bDenombrer.Size = new Size(148, 41);
            bDenombrer.TabIndex = 2;
            bDenombrer.Text = "Dénombrer";
            bDenombrer.UseVisualStyleBackColor = true;
            bDenombrer.Click += bDenombrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(282, 348);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(148, 42);
            bAjouter.TabIndex = 3;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new Point(282, 181);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new Size(60, 20);
            lPrenom.TabIndex = 4;
            lPrenom.Text = "Prénom";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(282, 253);
            lNom.Name = "lNom";
            lNom.Size = new Size(42, 20);
            lNom.TabIndex = 5;
            lNom.Text = "Nom";
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(282, 204);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(125, 27);
            tbPrenom.TabIndex = 6;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(282, 276);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(125, 27);
            tbNom.TabIndex = 7;
            // 
            // BaseDeDonnee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNom);
            Controls.Add(tbPrenom);
            Controls.Add(lNom);
            Controls.Add(lPrenom);
            Controls.Add(bAjouter);
            Controls.Add(bDenombrer);
            Controls.Add(bConsulter);
            Controls.Add(lbConsole);
            Name = "BaseDeDonnee";
            Text = "Manipulations de base sur BD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbConsole;
        private Button bConsulter;
        private Button bDenombrer;
        private Button bAjouter;
        private Label lPrenom;
        private Label lNom;
        private TextBox tbPrenom;
        private TextBox tbNom;
    }
}