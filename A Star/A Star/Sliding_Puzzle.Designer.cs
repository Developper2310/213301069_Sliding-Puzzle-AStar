namespace A_Star
{
    partial class Sliding_Puzzle
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
            ımageList1 = new ImageList(components);
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            button4 = new Button();
            radioButton2 = new RadioButton();
            Hesapla = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            Ekle = new Button();
            Deger = new TextBox();
            lab5 = new Label();
            Sutun = new TextBox();
            Satır = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            Olustur = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            groupBox1 = new GroupBox();
            HedefM = new Button();
            button1 = new Button();
            label5 = new Label();
            Ekle2 = new Button();
            Deger2 = new TextBox();
            listBox3 = new ListBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(29, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(216, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Değerleri kendim gireceğim";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(394, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 160);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button4
            // 
            button4.Location = new Point(28, 115);
            button4.Name = "button4";
            button4.Size = new Size(164, 29);
            button4.TabIndex = 5;
            button4.Text = "Rastgele matris Üret";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(29, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(136, 24);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Rastgele oluştur";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Hesapla
            // 
            Hesapla.Location = new Point(394, 398);
            Hesapla.Name = "Hesapla";
            Hesapla.Size = new Size(170, 92);
            Hesapla.TabIndex = 6;
            Hesapla.Text = "Hesapla";
            Hesapla.UseVisualStyleBackColor = true;
            Hesapla.Click += Hesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 189);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 7;
            label2.Text = "Başlangıç Matris";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(394, 559);
            label3.Name = "label3";
            label3.Size = new Size(434, 41);
            label3.TabIndex = 8;
            label3.Text = "Hesaplanıyor lüten bekleyiniz ...";
            label3.Visible = false;
            label3.Click += H;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(Ekle);
            groupBox3.Controls.Add(Deger);
            groupBox3.Location = new Point(49, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 191);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(87, 114);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Sıfırla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 2;
            label1.Text = "1. Değeri girin";
            // 
            // Ekle
            // 
            Ekle.Location = new Point(185, 69);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(94, 29);
            Ekle.TabIndex = 1;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = true;
            Ekle.Click += Ekle_Click;
            // 
            // Deger
            // 
            Deger.Location = new Point(45, 71);
            Deger.Name = "Deger";
            Deger.Size = new Size(125, 27);
            Deger.TabIndex = 0;
            // 
            // lab5
            // 
            lab5.AutoSize = true;
            lab5.Location = new Point(185, 41);
            lab5.Name = "lab5";
            lab5.Size = new Size(46, 20);
            lab5.TabIndex = 4;
            lab5.Text = "Sütun";
            // 
            // Sutun
            // 
            Sutun.Location = new Point(185, 64);
            Sutun.Name = "Sutun";
            Sutun.Size = new Size(66, 27);
            Sutun.TabIndex = 1;
            // 
            // Satır
            // 
            Satır.Location = new Point(46, 64);
            Satır.Name = "Satır";
            Satır.Size = new Size(73, 27);
            Satır.TabIndex = 0;
            Satır.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 41);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Satır";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lab5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(Olustur);
            groupBox4.Controls.Add(Sutun);
            groupBox4.Controls.Add(Satır);
            groupBox4.Location = new Point(49, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(303, 181);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // Olustur
            // 
            Olustur.Location = new Point(99, 118);
            Olustur.Name = "Olustur";
            Olustur.Size = new Size(94, 29);
            Olustur.TabIndex = 2;
            Olustur.Text = "Olustur";
            Olustur.UseVisualStyleBackColor = true;
            Olustur.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(815, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 504);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(394, 212);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(179, 164);
            listBox2.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HedefM);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Ekle2);
            groupBox1.Controls.Add(Deger2);
            groupBox1.Location = new Point(49, 429);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 171);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // HedefM
            // 
            HedefM.Location = new Point(185, 114);
            HedefM.Name = "HedefM";
            HedefM.Size = new Size(94, 29);
            HedefM.TabIndex = 4;
            HedefM.Text = "Varsayılan";
            HedefM.UseVisualStyleBackColor = true;
            HedefM.Click += HedefM_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Sıfırla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 35);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 2;
            label5.Text = "1. Değeri girin";
            // 
            // Ekle2
            // 
            Ekle2.Location = new Point(185, 69);
            Ekle2.Name = "Ekle2";
            Ekle2.Size = new Size(94, 29);
            Ekle2.TabIndex = 1;
            Ekle2.Text = "Ekle";
            Ekle2.UseVisualStyleBackColor = true;
            Ekle2.Click += Ekle2_Click;
            // 
            // Deger2
            // 
            Deger2.Location = new Point(45, 71);
            Deger2.Name = "Deger2";
            Deger2.Size = new Size(125, 27);
            Deger2.TabIndex = 0;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(579, 212);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(188, 164);
            listBox3.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 189);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 13;
            label6.Text = "Hedef Matris";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 196);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 8;
            label7.Text = "Başlangıç Matris";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 406);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 14;
            label8.Text = "Hedef Matris";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(579, 470);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 5;
            label9.Text = "Satır";
            label9.Visible = false;
            // 
            // Sliding_Puzzle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 628);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listBox3);
            Controls.Add(groupBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox4);
            Controls.Add(label3);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(Hesapla);
            Controls.Add(groupBox2);
            Name = "Sliding_Puzzle";
            Text = "Sliding_Puzzle";
            Load += Sliding_Puzzle_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ımageList1;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private Button button4;
        private Button Hesapla;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private Button button2;
        private Label label1;
        private Button Ekle;
        private TextBox Deger;
        private Label lab5;
        private TextBox Sutun;
        private TextBox Satır;
        private Label label4;
        private GroupBox groupBox4;
        private Button Olustur;
        private ListBox listBox1;
        private ListBox listBox2;
        private GroupBox groupBox1;
        private Button button1;
        private Label label5;
        private Button Ekle2;
        private TextBox Deger2;
        private ListBox listBox3;
        private Label label6;
        private Button HedefM;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}