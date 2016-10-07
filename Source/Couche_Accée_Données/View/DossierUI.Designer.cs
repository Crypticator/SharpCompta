namespace CoucheAcceeDonnees
{
    partial class DossierUI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RaisonSocialTxt = new System.Windows.Forms.TextBox();
            this.AnneeTxt = new System.Windows.Forms.TextBox();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raison Social :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annee :";
            // 
            // RaisonSocialTxt
            // 
            this.RaisonSocialTxt.Location = new System.Drawing.Point(181, 43);
            this.RaisonSocialTxt.Name = "RaisonSocialTxt";
            this.RaisonSocialTxt.Size = new System.Drawing.Size(100, 20);
            this.RaisonSocialTxt.TabIndex = 2;
            this.RaisonSocialTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaisonSocialTxt_KeyDown);
            this.RaisonSocialTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RaisonSocialTxt_Validating);
            // 
            // AnneeTxt
            // 
            this.AnneeTxt.Location = new System.Drawing.Point(182, 80);
            this.AnneeTxt.MaxLength = 4;
            this.AnneeTxt.Name = "AnneeTxt";
            this.AnneeTxt.Size = new System.Drawing.Size(41, 20);
            this.AnneeTxt.TabIndex = 3;
            this.AnneeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnneeTxt_KeyDown);
            this.AnneeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.AnneeTxt_Validating);
            // 
            // ModifierButton
            // 
            this.ModifierButton.Location = new System.Drawing.Point(114, 132);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(75, 23);
            this.ModifierButton.TabIndex = 4;
            this.ModifierButton.Text = "&Modifier";
            this.ModifierButton.UseVisualStyleBackColor = true;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Location = new System.Drawing.Point(111, 9);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(0, 13);
            this.warn.TabIndex = 33;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "&Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DossierUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.ModifierButton);
            this.Controls.Add(this.AnneeTxt);
            this.Controls.Add(this.RaisonSocialTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "DossierUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration Dossier";
            this.Load += new System.EventHandler(this.DossierUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox RaisonSocialTxt;
        public System.Windows.Forms.TextBox AnneeTxt;
        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button button1;
    }
}