namespace Racunarska_Grafika_projekat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.elipsaButton = new System.Windows.Forms.RadioButton();
            this.krugButton = new System.Windows.Forms.RadioButton();
            this.pravougaonikButton = new System.Windows.Forms.RadioButton();
            this.trougaoButton = new System.Windows.Forms.RadioButton();
            this.duzButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.pozadina;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.snapButton);
            this.panel1.Controls.Add(this.elipsaButton);
            this.panel1.Controls.Add(this.krugButton);
            this.panel1.Controls.Add(this.pravougaonikButton);
            this.panel1.Controls.Add(this.trougaoButton);
            this.panel1.Controls.Add(this.duzButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 100);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.elipsa;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(296, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.krug;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(226, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(156, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources._2792357;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(86, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources._2708385;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(16, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // snapButton
            // 
            this.snapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.snapButton.BackColor = System.Drawing.Color.Transparent;
            this.snapButton.BackgroundImage = global::Racunarska_Grafika_projekat.Properties.Resources.pozadina;
            this.snapButton.Location = new System.Drawing.Point(1150, 3);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(75, 94);
            this.snapButton.TabIndex = 6;
            this.snapButton.Text = "Screenshot";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.snapButton_Click);
            // 
            // elipsaButton
            // 
            this.elipsaButton.AutoSize = true;
            this.elipsaButton.BackColor = System.Drawing.Color.Transparent;
            this.elipsaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elipsaButton.Location = new System.Drawing.Point(306, 69);
            this.elipsaButton.Name = "elipsaButton";
            this.elipsaButton.Size = new System.Drawing.Size(14, 13);
            this.elipsaButton.TabIndex = 5;
            this.elipsaButton.TabStop = true;
            this.elipsaButton.UseVisualStyleBackColor = false;
            // 
            // krugButton
            // 
            this.krugButton.AutoSize = true;
            this.krugButton.BackColor = System.Drawing.Color.Transparent;
            this.krugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krugButton.Location = new System.Drawing.Point(234, 69);
            this.krugButton.Name = "krugButton";
            this.krugButton.Size = new System.Drawing.Size(14, 13);
            this.krugButton.TabIndex = 4;
            this.krugButton.TabStop = true;
            this.krugButton.UseVisualStyleBackColor = false;
            // 
            // pravougaonikButton
            // 
            this.pravougaonikButton.AutoSize = true;
            this.pravougaonikButton.BackColor = System.Drawing.Color.Transparent;
            this.pravougaonikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pravougaonikButton.Location = new System.Drawing.Point(159, 69);
            this.pravougaonikButton.Name = "pravougaonikButton";
            this.pravougaonikButton.Size = new System.Drawing.Size(14, 13);
            this.pravougaonikButton.TabIndex = 3;
            this.pravougaonikButton.TabStop = true;
            this.pravougaonikButton.UseVisualStyleBackColor = false;
            // 
            // trougaoButton
            // 
            this.trougaoButton.AutoSize = true;
            this.trougaoButton.BackColor = System.Drawing.Color.Transparent;
            this.trougaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trougaoButton.Location = new System.Drawing.Point(86, 69);
            this.trougaoButton.Name = "trougaoButton";
            this.trougaoButton.Size = new System.Drawing.Size(14, 13);
            this.trougaoButton.TabIndex = 2;
            this.trougaoButton.TabStop = true;
            this.trougaoButton.UseVisualStyleBackColor = false;
            // 
            // duzButton
            // 
            this.duzButton.AutoSize = true;
            this.duzButton.BackColor = System.Drawing.Color.Transparent;
            this.duzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duzButton.Location = new System.Drawing.Point(16, 69);
            this.duzButton.Name = "duzButton";
            this.duzButton.Size = new System.Drawing.Size(14, 13);
            this.duzButton.TabIndex = 1;
            this.duzButton.TabStop = true;
            this.duzButton.UseVisualStyleBackColor = false;
            this.duzButton.CheckedChanged += new System.EventHandler(this.duzButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(410, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite oblik koji zelite da nacrtate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 552);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(868, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Petar_Rasevic_1647_Zadatak1Geometrija_Racunarska_Grafika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(860, 640);
            this.Name = "Form1";
            this.Text = "Geometrija by Petar Rasevic";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton trougaoButton;
        private System.Windows.Forms.RadioButton duzButton;
        private System.Windows.Forms.RadioButton elipsaButton;
        private System.Windows.Forms.RadioButton krugButton;
        private System.Windows.Forms.RadioButton pravougaonikButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

