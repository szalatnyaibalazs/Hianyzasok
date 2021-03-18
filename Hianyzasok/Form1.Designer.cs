namespace Hianyzasok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbOsztaly = new System.Windows.Forms.TextBox();
            this.tbElso = new System.Windows.Forms.TextBox();
            this.tbUtolso = new System.Windows.Forms.TextBox();
            this.tbMulasztott = new System.Windows.Forms.TextBox();
            this.lbKiadatok = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Osztály";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Első nap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Utolsó nap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mulasztott órák";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(142, 40);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(218, 20);
            this.tbNev.TabIndex = 5;
            // 
            // tbOsztaly
            // 
            this.tbOsztaly.Location = new System.Drawing.Point(142, 75);
            this.tbOsztaly.Name = "tbOsztaly";
            this.tbOsztaly.Size = new System.Drawing.Size(218, 20);
            this.tbOsztaly.TabIndex = 6;
            // 
            // tbElso
            // 
            this.tbElso.Location = new System.Drawing.Point(142, 110);
            this.tbElso.Name = "tbElso";
            this.tbElso.Size = new System.Drawing.Size(218, 20);
            this.tbElso.TabIndex = 7;
            // 
            // tbUtolso
            // 
            this.tbUtolso.Location = new System.Drawing.Point(142, 145);
            this.tbUtolso.Name = "tbUtolso";
            this.tbUtolso.Size = new System.Drawing.Size(218, 20);
            this.tbUtolso.TabIndex = 8;
            // 
            // tbMulasztott
            // 
            this.tbMulasztott.Location = new System.Drawing.Point(142, 180);
            this.tbMulasztott.Name = "tbMulasztott";
            this.tbMulasztott.Size = new System.Drawing.Size(218, 20);
            this.tbMulasztott.TabIndex = 9;
            // 
            // lbKiadatok
            // 
            this.lbKiadatok.FormattingEnabled = true;
            this.lbKiadatok.Location = new System.Drawing.Point(402, 40);
            this.lbKiadatok.Name = "lbKiadatok";
            this.lbKiadatok.Size = new System.Drawing.Size(386, 394);
            this.lbKiadatok.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "2017 szeptemberi hiányzsok listája";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hiányzás rögzítése a szeptember.csv-be";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbKiadatok);
            this.Controls.Add(this.tbMulasztott);
            this.Controls.Add(this.tbUtolso);
            this.Controls.Add(this.tbElso);
            this.Controls.Add(this.tbOsztaly);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbOsztaly;
        private System.Windows.Forms.TextBox tbElso;
        private System.Windows.Forms.TextBox tbUtolso;
        private System.Windows.Forms.TextBox tbMulasztott;
        private System.Windows.Forms.ListBox lbKiadatok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

