namespace TimeToMetaLand
{
    partial class RealEstateScreen
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealEstateScreen));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 555);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(144, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 380);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(914, 3);
            button1.Name = "button1";
            button1.Size = new Size(76, 32);
            button1.TabIndex = 2;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 480);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 0;
            button2.Text = "satın al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(187, 480);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 3;
            button3.Text = "kirala";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(445, 462);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(445, 506);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(879, 506);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 7;
            label2.Text = "100";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(885, 440);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 465);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 509);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // button4
            // 
            button4.Location = new Point(24, 89);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 10;
            button4.Text = "Mağaza";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(24, 121);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(90, 27);
            button5.TabIndex = 11;
            button5.Text = "Market";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(24, 153);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(90, 27);
            button6.TabIndex = 12;
            button6.Text = "Emlak";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(24, 245);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(90, 37);
            button7.TabIndex = 13;
            button7.Text = "Kur";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 195);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 27);
            textBox3.TabIndex = 14;
            // 
            // label4
            // 
            label4.Location = new Point(18, 355);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 390);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(18, 326);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 27);
            textBox5.TabIndex = 18;
            textBox5.Visible = false;
            // 
            // label5
            // 
            label5.Location = new Point(9, 289);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 30);
            label5.TabIndex = 17;
            label5.Text = "Kurulum Maaliyeti";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(670, 448);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(90, 37);
            button8.TabIndex = 19;
            button8.Text = "Sat";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(670, 496);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(90, 37);
            button9.TabIndex = 20;
            button9.Text = "Kiraya Ver";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // RealEstateScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "RealEstateScreen";
            Size = new Size(999, 557);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        public Label label2;
        public PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Button button8;
        private Button button9;
    }
}