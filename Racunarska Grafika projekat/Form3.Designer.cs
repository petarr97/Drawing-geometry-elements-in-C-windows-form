namespace Racunarska_Grafika_projekat
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
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.poluprecnikKruga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite poluprecnik kruga:";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.okButton.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.pozadina;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(-1, 129);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(205, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // poluprecnikKruga
            // 
            this.poluprecnikKruga.Location = new System.Drawing.Point(24, 84);
            this.poluprecnikKruga.Name = "poluprecnikKruga";
            this.poluprecnikKruga.Size = new System.Drawing.Size(140, 20);
            this.poluprecnikKruga.TabIndex = 2;
            this.poluprecnikKruga.TextChanged += new System.EventHandler(this.poluprecnikKruga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Napomena(Dimenzije su u centimetrima)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(204, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poluprecnikKruga);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 191);
            this.Name = "Form3";
            this.Text = "Izbor poluprecnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox poluprecnikKruga;
        private System.Windows.Forms.Label label2;
    }
}