namespace TimeToMetaLand
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
            shopScreen1 = new ShopScreen();
            marketScreen1 = new MarketScreen();
            realEstateScreen1 = new RealEstateScreen();
            loginScreen1 = new LoginScreen();
            gameScreen1 = new GameScreen();
            adminScreen1 = new AdminScreen();
            dataSet1 = new DataSet();
            SuspendLayout();
            // 
            // shopScreen1
            // 
            shopScreen1.Location = new Point(0, 0);
            shopScreen1.Name = "shopScreen1";
            shopScreen1.Size = new Size(987, 555);
            shopScreen1.TabIndex = 1;
            // 
            // marketScreen1
            // 
            marketScreen1.Location = new Point(0, 0);
            marketScreen1.Name = "marketScreen1";
            marketScreen1.Size = new Size(987, 560);
            marketScreen1.TabIndex = 2;
            marketScreen1.Load += marketScreen1_Load;
            // 
            // realEstateScreen1
            // 
            realEstateScreen1.Location = new Point(0, 0);
            realEstateScreen1.Name = "realEstateScreen1";
            realEstateScreen1.Size = new Size(998, 555);
            realEstateScreen1.TabIndex = 3;
            // 
            // loginScreen1
            // 
            loginScreen1.Location = new Point(0, 0);
            loginScreen1.Name = "loginScreen1";
            loginScreen1.Size = new Size(1000, 555);
            loginScreen1.TabIndex = 0;
            loginScreen1.Load += loginScreen1_Load;
            // 
            // gameScreen1
            // 
            gameScreen1.AutoSize = true;
            gameScreen1.Location = new Point(0, 0);
            gameScreen1.Name = "gameScreen1";
            gameScreen1.Size = new Size(998, 560);
            gameScreen1.TabIndex = 5;
            // 
            // adminScreen1
            // 
            adminScreen1.BackColor = SystemColors.ActiveCaption;
            adminScreen1.Location = new Point(0, 0);
            adminScreen1.Name = "adminScreen1";
            adminScreen1.Size = new Size(998, 560);
            adminScreen1.TabIndex = 6;
            // 
            // dataSet1
            // 
            dataSet1.Location = new Point(0, 0);
            dataSet1.Name = "dataSet1";
            dataSet1.Size = new Size(1040, 574);
            dataSet1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(988, 553);
            Controls.Add(dataSet1);
            Controls.Add(adminScreen1);
            Controls.Add(loginScreen1);
            Controls.Add(gameScreen1);
            Controls.Add(realEstateScreen1);
            Controls.Add(marketScreen1);
            Controls.Add(shopScreen1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ShopScreen shopScreen1;
        private MarketScreen marketScreen1;
        private RealEstateScreen realEstateScreen1;
        private LoginScreen loginScreen1;
        private GameScreen gameScreen1;
        private AdminScreen adminScreen1;
        private DataSet dataSet1;
    }
}