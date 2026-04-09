namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalCost = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }
            else if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }
            if (totalCost == 0)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메뉴를 선택하십시오";
            }
            else
            {
                lblTotalCost.ForeColor = Color.Blue;
                lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
            }
        }


        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoHamBurger.Checked = false;
            chkCheese.Checked = false;
            chkCola.Checked = false;
            chkPotato.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Text = "총 금액 : 0원";
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

       
    }
}
