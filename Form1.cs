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
            lblTotalCost.Text = "총 금액 : 0원";
        }
    }
}
