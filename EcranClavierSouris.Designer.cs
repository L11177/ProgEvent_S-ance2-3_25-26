namespace ProgEvent_Séance2_25_26
{
    partial class EcranClavierSouris
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
            pnlSouris = new Panel();
            lblClavier = new Label();
            lblClicGauche = new Label();
            lblClicDroit = new Label();
            lblPositionX = new Label();
            lblPositionY = new Label();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.BackColor = Color.DimGray;
            pnlSouris.BorderStyle = BorderStyle.Fixed3D;
            pnlSouris.Location = new Point(230, 66);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(490, 347);
            pnlSouris.TabIndex = 0;
            pnlSouris.Paint += pnlSouris_Paint;
            pnlSouris.MouseDown += pnlSouris_MouseDown;
            pnlSouris.MouseMove += pnlSouris_MouseMove;
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(26, 9);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(138, 20);
            lblClavier.TabIndex = 1;
            lblClavier.Text = "Interception Clavier";
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(230, 9);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(85, 20);
            lblClicGauche.TabIndex = 2;
            lblClicGauche.Text = "Clic gauche";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(366, 9);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(69, 20);
            lblClicDroit.TabIndex = 3;
            lblClicDroit.Text = "Clic droit";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(516, 9);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(74, 20);
            lblPositionX.TabIndex = 4;
            lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(635, 9);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(73, 20);
            lblPositionY.TabIndex = 5;
            lblPositionY.Text = "Position Y";
            // 
            // lsbClavier
            // 
            lsbClavier.FormattingEnabled = true;
            lsbClavier.Location = new Point(26, 36);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(198, 344);
            lsbClavier.TabIndex = 6;
            lsbClavier.KeyDown += lsbClavier_KeyDown;
            lsbClavier.KeyPress += lsbClavier_KeyPress;
            lsbClavier.KeyUp += lsbClavier_KeyUp;
            // 
            // butRAZ
            // 
            butRAZ.BackColor = SystemColors.ActiveBorder;
            butRAZ.Location = new Point(26, 385);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(173, 44);
            butRAZ.TabIndex = 7;
            butRAZ.Text = "Remise à Zero";
            butRAZ.UseVisualStyleBackColor = false;
            butRAZ.Click += butRAZ_Click;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(230, 36);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.ReadOnly = true;
            tbxClicGauche.Size = new Size(85, 27);
            tbxClicGauche.TabIndex = 8;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(366, 36);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.ReadOnly = true;
            tbxClicDroit.Size = new Size(85, 27);
            tbxClicDroit.TabIndex = 9;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(516, 36);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.ReadOnly = true;
            tbxPositionX.Size = new Size(85, 27);
            tbxPositionX.TabIndex = 10;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(635, 36);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.ReadOnly = true;
            tbxPositionY.Size = new Size(85, 27);
            tbxPositionY.TabIndex = 9;
            // 
            // EcranClavierSouris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(tbxPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(lblPositionY);
            Controls.Add(lblPositionX);
            Controls.Add(lblClicDroit);
            Controls.Add(lblClicGauche);
            Controls.Add(lblClavier);
            Controls.Add(pnlSouris);
            Name = "EcranClavierSouris";
            Text = "Clavier/Souris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private Label lblClavier;
        private Label lblClicGauche;
        private Label lblClicDroit;
        private Label lblPositionX;
        private Label lblPositionY;
        private ListBox lsbClavier;
        private Button butRAZ;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
    }
}