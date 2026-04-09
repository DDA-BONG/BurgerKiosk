namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            chkCola = new CheckBox();
            grpOption = new GroupBox();
            grpMenu = new GroupBox();
            grpOrder = new GroupBox();
            btnInit = new Button();
            btnOrder = new Button();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpOption.SuspendLayout();
            grpMenu.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.FromArgb(255, 128, 0);
            lblAppName.Font = new Font("맑은 고딕", 30F);
            lblAppName.ForeColor = Color.Yellow;
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(465, 67);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.BackColor = Color.FromArgb(255, 128, 0);
            rdoHamBurger.Font = new Font("맑은 고딕", 15F);
            rdoHamBurger.ForeColor = Color.Yellow;
            rdoHamBurger.Location = new Point(17, 56);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(111, 39);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = false;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.BackColor = Color.FromArgb(255, 128, 0);
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 15F);
            rdoBulgogiBurger.ForeColor = Color.Yellow;
            rdoBulgogiBurger.Location = new Point(17, 174);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(161, 39);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.BackColor = Color.FromArgb(255, 128, 0);
            rdoChickenBurger.Font = new Font("맑은 고딕", 15F);
            rdoChickenBurger.ForeColor = Color.Yellow;
            rdoChickenBurger.Location = new Point(17, 296);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(136, 39);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(172, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(172, 271);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.BackColor = Color.FromArgb(255, 128, 0);
            chkPotato.Font = new Font("맑은 고딕", 12F);
            chkPotato.ForeColor = Color.Yellow;
            chkPotato.Location = new Point(16, 23);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(114, 32);
            chkPotato.TabIndex = 7;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = false;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.BackColor = Color.FromArgb(255, 128, 0);
            chkCheese.Font = new Font("맑은 고딕", 12F);
            chkCheese.ForeColor = Color.Yellow;
            chkCheese.Location = new Point(16, 130);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(121, 32);
            chkCheese.TabIndex = 8;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = false;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.BackColor = Color.FromArgb(255, 128, 0);
            chkSauce.Font = new Font("맑은 고딕", 12F);
            chkSauce.ForeColor = Color.Yellow;
            chkSauce.Location = new Point(16, 192);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(121, 32);
            chkSauce.TabIndex = 9;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = false;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.BackColor = Color.FromArgb(255, 128, 0);
            chkCola.Font = new Font("맑은 고딕", 12F);
            chkCola.ForeColor = Color.Yellow;
            chkCola.Location = new Point(16, 74);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(74, 32);
            chkCola.TabIndex = 10;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = false;
            // 
            // grpOption
            // 
            grpOption.BackColor = Color.FromArgb(255, 128, 0);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkCheese);
            grpOption.ForeColor = Color.Yellow;
            grpOption.Location = new Point(402, 140);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(143, 241);
            grpOption.TabIndex = 11;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            grpOption.Enter += groupBox1_Enter;
            // 
            // grpMenu
            // 
            grpMenu.BackColor = Color.FromArgb(255, 128, 0);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Font = new Font("맑은 고딕", 12F);
            grpMenu.ForeColor = Color.Yellow;
            grpMenu.Location = new Point(12, 94);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(343, 396);
            grpMenu.TabIndex = 12;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(btnInit);
            grpOrder.Controls.Add(btnOrder);
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 12F);
            grpOrder.ForeColor = Color.Yellow;
            grpOrder.Location = new Point(589, 78);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(326, 412);
            grpOrder.TabIndex = 13;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            grpOrder.Enter += groupBox3_Enter;
            // 
            // btnInit
            // 
            btnInit.ForeColor = Color.Red;
            btnInit.Location = new Point(178, 336);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(117, 56);
            btnInit.TabIndex = 3;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // btnOrder
            // 
            btnOrder.ForeColor = Color.Lime;
            btnOrder.Location = new Point(17, 336);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(117, 56);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 20F);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(6, 236);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(218, 46);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(6, 33);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(314, 200);
            lstOrder.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(927, 547);
            Controls.Add(grpOrder);
            Controls.Add(grpMenu);
            Controls.Add(grpOption);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private CheckBox chkCola;
        private GroupBox grpOption;
        private GroupBox grpMenu;
        private GroupBox grpOrder;
        private Button btnOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnInit;
    }
}
