namespace Racunarska_Grafika_projekat
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.duzinaStranice = new System.Windows.Forms.TextBox();
            this.visinaPravougaonika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite duzinu pravougaonika:";
            // 
            // duzinaStranice
            // 
            this.duzinaStranice.Location = new System.Drawing.Point(66, 25);
            this.duzinaStranice.Name = "duzinaStranice";
            this.duzinaStranice.Size = new System.Drawing.Size(151, 20);
            this.duzinaStranice.TabIndex = 1;
            this.duzinaStranice.TextChanged += new System.EventHandler(this.duzinaStranice_TextChanged);
            // 
            // visinaPravougaonika
            // 
            this.visinaPravougaonika.Location = new System.Drawing.Point(66, 64);
            this.visinaPravougaonika.Name = "visinaPravougaonika";
            this.visinaPravougaonika.Size = new System.Drawing.Size(151, 20);
            this.visinaPravougaonika.TabIndex = 3;
            this.visinaPravougaonika.TextChanged += new System.EventHandler(this.duzinaStranice_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(63, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite visinu pravougaonika:";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.okButton.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.pozadina;
            this.okButton.Enabled = false;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(28, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(225, 35);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(296, 123);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.visinaPravougaonika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duzinaStranice);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Izbor dimenzija pravougaonika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox duzinaStranice;
        private System.Windows.Forms.TextBox visinaPravougaonika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
    }
}