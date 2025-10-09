namespace Prace_do_dvojice_6_10_2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            cislomin = new Label();
            cislomax = new Label();
            vysledekVplusu = new Label();
            VysledekVminusu = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(241, 109);
            button1.Name = "button1";
            button1.Size = new Size(321, 41);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(369, 235);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "Osa čísel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(352, 21);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Gingerlator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 166);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "vysledek:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(241, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 10);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(399, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 34);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(241, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 34);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(551, 283);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 34);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(477, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(8, 32);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(324, 283);
            panel6.Name = "panel6";
            panel6.Size = new Size(8, 32);
            panel6.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(391, 330);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 11;
            label4.Text = "0";
            // 
            // cislomin
            // 
            cislomin.AutoSize = true;
            cislomin.Location = new Point(218, 330);
            cislomin.Name = "cislomin";
            cislomin.Size = new Size(70, 20);
            cislomin.TabIndex = 12;
            cislomin.Text = "-cislomin";
            // 
            // cislomax
            // 
            cislomax.AutoSize = true;
            cislomax.Location = new Point(551, 330);
            cislomax.Name = "cislomax";
            cislomax.Size = new Size(67, 20);
            cislomax.TabIndex = 13;
            cislomax.Text = "cislomax";
            // 
            // vysledekVplusu
            // 
            vysledekVplusu.AutoSize = true;
            vysledekVplusu.Location = new Point(437, 330);
            vysledekVplusu.Name = "vysledekVplusu";
            vysledekVplusu.Size = new Size(108, 20);
            vysledekVplusu.TabIndex = 14;
            vysledekVplusu.Text = "vysledekVplusu";
            // 
            // VysledekVminusu
            // 
            VysledekVminusu.AutoSize = true;
            VysledekVminusu.Location = new Point(294, 330);
            VysledekVminusu.Name = "VysledekVminusu";
            VysledekVminusu.Size = new Size(122, 20);
            VysledekVminusu.TabIndex = 15;
            VysledekVminusu.Text = "VysledekVminusu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(VysledekVminusu);
            Controls.Add(vysledekVplusu);
            Controls.Add(cislomax);
            Controls.Add(cislomin);
            Controls.Add(label4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private Label cislomin;
        private Label cislomax;
        private Label vysledekVplusu;
        private Label VysledekVminusu;
    }
}
