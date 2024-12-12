namespace kursovaya
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
            label5 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            ResultButton = new Button();
            label3 = new Label();
            b1 = new ComboBox();
            label4 = new Label();
            z1 = new ComboBox();
            label6 = new Label();
            m = new ComboBox();
            label7 = new Label();
            z2 = new ComboBox();
            a = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            combobox3 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            tch = new ComboBox();
            label14 = new Label();
            F1 = new ComboBox();
            delta = new Label();
            label15 = new Label();
            i = new ComboBox();
            zp = new ComboBox();
            label12 = new Label();
            F = new ComboBox();
            z01 = new Label();
            Kd1 = new Label();
            SigmaSdr1 = new Label();
            sigmaSSd1 = new Label();
            kp1 = new Label();
            S1 = new Label();
            raschet = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 12);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 45;
            label5.Text = "Параметры";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 46;
            label1.Text = "Тип машины или оборудования";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Деревообрабатываемое оборудование", "Токарные станки и оборудование для типографии", "Сверильные, расточные, шлифовальные, фрезерные, поперечно-строгательные и долбежные станки", "Конвейеры ленточные", "Вентиляторы, подъемники и текстильные оборудование" });
            comboBox1.Location = new Point(307, 80);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 28);
            comboBox1.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "<150", "<250", "<400" });
            comboBox2.Location = new Point(400, 129);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 28);
            comboBox2.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 129);
            label2.Name = "label2";
            label2.Size = new Size(377, 20);
            label2.TabIndex = 49;
            label2.Text = "Максимальная пиковая нагрузка % от номинальной";
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(14, 811);
            ResultButton.Margin = new Padding(3, 4, 3, 4);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(241, 81);
            ResultButton.TabIndex = 50;
            ResultButton.Text = "Рассчитать";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 176);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 51;
            label3.Text = "ширина ремня b1";
            // 
            // b1
            // 
            b1.DropDownStyle = ComboBoxStyle.DropDownList;
            b1.FormattingEnabled = true;
            b1.Location = new Point(179, 170);
            b1.Margin = new Padding(3, 4, 3, 4);
            b1.Name = "b1";
            b1.Size = new Size(130, 28);
            b1.TabIndex = 52;
            b1.SelectedIndexChanged += b1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 225);
            label4.Name = "label4";
            label4.Size = new Size(246, 20);
            label4.TabIndex = 53;
            label4.Text = "число зубьев меньшего шкива, z1";
            // 
            // z1
            // 
            z1.DropDownStyle = ComboBoxStyle.DropDownList;
            z1.FormattingEnabled = true;
            z1.Items.AddRange(new object[] { "12", "14", "16", "18", "20", "22", "24", "26", "28" });
            z1.Location = new Point(284, 222);
            z1.Margin = new Padding(3, 4, 3, 4);
            z1.Name = "z1";
            z1.Size = new Size(95, 28);
            z1.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 287);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 55;
            label6.Text = "модуль ремня m";
            // 
            // m
            // 
            m.DropDownStyle = ComboBoxStyle.DropDownList;
            m.FormattingEnabled = true;
            m.Items.AddRange(new object[] { "2", "3", "4", "5", "7", "10" });
            m.Location = new Point(165, 279);
            m.Margin = new Padding(3, 4, 3, 4);
            m.Name = "m";
            m.Size = new Size(127, 28);
            m.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 344);
            label7.Name = "label7";
            label7.Size = new Size(241, 20);
            label7.TabIndex = 57;
            label7.Text = "число зубьев большего шкива z2";
            // 
            // z2
            // 
            z2.DropDownStyle = ComboBoxStyle.DropDownList;
            z2.FormattingEnabled = true;
            z2.Location = new Point(263, 336);
            z2.Margin = new Padding(3, 4, 3, 4);
            z2.Name = "z2";
            z2.Size = new Size(130, 28);
            z2.TabIndex = 58;
            z2.SelectedIndexChanged += z2_SelectedIndexChanged;
            // 
            // a
            // 
            a.DropDownStyle = ComboBoxStyle.DropDownList;
            a.FormattingEnabled = true;
            a.Location = new Point(284, 393);
            a.Margin = new Padding(3, 4, 3, 4);
            a.Name = "a";
            a.Size = new Size(130, 28);
            a.TabIndex = 60;
            a.SelectedIndexChanged += a_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 400);
            label8.Name = "label8";
            label8.Size = new Size(257, 20);
            label8.TabIndex = 59;
            label8.Text = "расстояние между осями шкифов a";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 465);
            label9.Name = "label9";
            label9.Size = new Size(232, 20);
            label9.TabIndex = 61;
            label9.Text = "число знакопостоянных циклов";
            // 
            // combobox3
            // 
            combobox3.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox3.FormattingEnabled = true;
            combobox3.Items.AddRange(new object[] { "Постоянный режим работы", "Переменный режим работы" });
            combobox3.Location = new Point(248, 453);
            combobox3.Margin = new Padding(3, 4, 3, 4);
            combobox3.Name = "combobox3";
            combobox3.Size = new Size(135, 28);
            combobox3.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 512);
            label10.Name = "label10";
            label10.Size = new Size(172, 20);
            label10.TabIndex = 63;
            label10.Text = "Число зубьев ремня zp";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 568);
            label11.Name = "label11";
            label11.Size = new Size(254, 20);
            label11.TabIndex = 65;
            label11.Text = "общее время работы передачи tch";
            // 
            // tch
            // 
            tch.DropDownStyle = ComboBoxStyle.DropDownList;
            tch.FormattingEnabled = true;
            tch.Location = new Point(284, 565);
            tch.Margin = new Padding(3, 4, 3, 4);
            tch.Name = "tch";
            tch.Size = new Size(130, 28);
            tch.TabIndex = 66;
            tch.SelectedIndexChanged += tch_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 661);
            label14.Name = "label14";
            label14.Size = new Size(372, 20);
            label14.TabIndex = 71;
            label14.Text = "максимально длительная действующая нагрузка, F1";
            // 
            // F1
            // 
            F1.DropDownStyle = ComboBoxStyle.DropDownList;
            F1.FormattingEnabled = true;
            F1.Location = new Point(381, 658);
            F1.Margin = new Padding(3, 4, 3, 4);
            F1.Name = "F1";
            F1.Size = new Size(130, 28);
            F1.TabIndex = 72;
            F1.SelectedIndexChanged += F1_SelectedIndexChanged;
            // 
            // delta
            // 
            delta.AutoSize = true;
            delta.Font = new Font("Segoe UI", 15F);
            delta.Location = new Point(1015, 345);
            delta.Name = "delta";
            delta.Size = new Size(104, 35);
            delta.TabIndex = 73;
            delta.Text = "Delta = ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 620);
            label15.Name = "label15";
            label15.Size = new Size(110, 20);
            label15.TabIndex = 74;
            label15.Text = "коэффициент i";
            // 
            // i
            // 
            i.DropDownStyle = ComboBoxStyle.DropDownList;
            i.FormattingEnabled = true;
            i.Location = new Point(162, 613);
            i.Margin = new Padding(3, 4, 3, 4);
            i.Name = "i";
            i.Size = new Size(130, 28);
            i.TabIndex = 75;
            i.SelectedIndexChanged += i_SelectedIndexChanged;
            // 
            // zp
            // 
            zp.DropDownStyle = ComboBoxStyle.DropDownList;
            zp.FormattingEnabled = true;
            zp.Location = new Point(231, 512);
            zp.Margin = new Padding(3, 4, 3, 4);
            zp.Name = "zp";
            zp.Size = new Size(130, 28);
            zp.TabIndex = 76;
            zp.SelectedIndexChanged += zp_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 37);
            label12.Name = "label12";
            label12.Size = new Size(206, 20);
            label12.TabIndex = 77;
            label12.Text = "Рабочая нагрузка ремнем, F";
            // 
            // F
            // 
            F.DropDownStyle = ComboBoxStyle.DropDownList;
            F.FormattingEnabled = true;
            F.Location = new Point(263, 29);
            F.Margin = new Padding(3, 4, 3, 4);
            F.Name = "F";
            F.Size = new Size(130, 28);
            F.TabIndex = 78;
            F.SelectedIndexChanged += F_SelectedIndexChanged;
            // 
            // z01
            // 
            z01.AutoSize = true;
            z01.Font = new Font("Segoe UI", 15F);
            z01.Location = new Point(1015, 117);
            z01.Name = "z01";
            z01.Size = new Size(70, 35);
            z01.TabIndex = 79;
            z01.Text = "z0 = ";
            // 
            // Kd1
            // 
            Kd1.AutoSize = true;
            Kd1.Font = new Font("Segoe UI", 15F);
            Kd1.Location = new Point(1016, 80);
            Kd1.Name = "Kd1";
            Kd1.Size = new Size(75, 35);
            Kd1.TabIndex = 80;
            Kd1.Text = "Кд = ";
            // 
            // SigmaSdr1
            // 
            SigmaSdr1.AutoSize = true;
            SigmaSdr1.Font = new Font("Segoe UI", 15F);
            SigmaSdr1.Location = new Point(1015, 308);
            SigmaSdr1.Name = "SigmaSdr1";
            SigmaSdr1.Size = new Size(152, 35);
            SigmaSdr1.TabIndex = 82;
            SigmaSdr1.Text = "SigmaSdr = ";
            // 
            // sigmaSSd1
            // 
            sigmaSSd1.AutoSize = true;
            sigmaSSd1.Font = new Font("Segoe UI", 15F);
            sigmaSSd1.Location = new Point(1015, 256);
            sigmaSSd1.Name = "sigmaSSd1";
            sigmaSSd1.Size = new Size(151, 35);
            sigmaSSd1.TabIndex = 83;
            sigmaSSd1.Text = "Sigma*sd = ";
            // 
            // kp1
            // 
            kp1.AutoSize = true;
            kp1.Font = new Font("Segoe UI", 15F);
            kp1.Location = new Point(1015, 211);
            kp1.Name = "kp1";
            kp1.Size = new Size(76, 35);
            kp1.TabIndex = 84;
            kp1.Text = "Кp = ";
            // 
            // S1
            // 
            S1.AutoSize = true;
            S1.Font = new Font("Segoe UI", 15F);
            S1.Location = new Point(1015, 161);
            S1.Name = "S1";
            S1.Size = new Size(72, 35);
            S1.TabIndex = 85;
            S1.Text = "S1 = ";
            // 
            // raschet
            // 
            raschet.AutoSize = true;
            raschet.Font = new Font("Segoe UI", 15F);
            raschet.Location = new Point(1015, 383);
            raschet.Name = "raschet";
            raschet.Size = new Size(282, 35);
            raschet.TabIndex = 86;
            raschet.Text = "Достоверен ли расчет?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 931);
            Controls.Add(raschet);
            Controls.Add(S1);
            Controls.Add(kp1);
            Controls.Add(sigmaSSd1);
            Controls.Add(SigmaSdr1);
            Controls.Add(Kd1);
            Controls.Add(z01);
            Controls.Add(F);
            Controls.Add(label12);
            Controls.Add(zp);
            Controls.Add(i);
            Controls.Add(label15);
            Controls.Add(delta);
            Controls.Add(F1);
            Controls.Add(label14);
            Controls.Add(tch);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(combobox3);
            Controls.Add(label9);
            Controls.Add(a);
            Controls.Add(label8);
            Controls.Add(z2);
            Controls.Add(label7);
            Controls.Add(m);
            Controls.Add(label6);
            Controls.Add(z1);
            Controls.Add(label4);
            Controls.Add(b1);
            Controls.Add(label3);
            Controls.Add(ResultButton);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Button ResultButton;
        private Label label3;
        private ComboBox b1;
        private Label label4;
        private ComboBox z1;
        private Label label6;
        private ComboBox m;
        private Label label7;
        private ComboBox z2;
        private ComboBox a;
        private Label label8;
        private Label label9;
        private ComboBox combobox3;
        private Label label10;
        private Label label11;
        private ComboBox tch;
        private Label label14;
        private ComboBox F1;
        private Label delta;
        private Label label15;
        private ComboBox i;
        private ComboBox zp;
        private Label label12;
        private ComboBox F;
        private Label z01;
        private Label Kd1;
        private Label SigmaSdr1;
        private Label sigmaSSd1;
        private Label kp1;
        private Label S1;
        private Label raschet;
    }
}