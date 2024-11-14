namespace WF.Niquel
{
    public partial class Form1 : Form
    {
        private Random random = new();
        private int contador;
        private int coin;
        public Form1()
        {
            InitializeComponent();
            coin = 20;
            lblcoin.Text = coin.ToString();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (coin <= 0)
            {
                MessageBox.Show("Você não possui moedas!");
                return;
            }
           
            contador = 0;
            label1.Text = "";
            coin--;
            lblcoin.Text = coin.ToString();
            timerSpin.Start();
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            int numeroRandomico = random.Next(1, 2);
            btn1.Text = numeroRandomico.ToString();

             numeroRandomico = random.Next(1, 2);
            btn2.Text = numeroRandomico.ToString();

             numeroRandomico = random.Next(1, 2);
            btn3.Text = numeroRandomico.ToString();


            contador++;

            if (contador >=20) 
            {
                timerSpin.Stop();
                //verifica se os valores são iguais 
                if (btn1.Text == btn2.Text && btn2.Text == btn3.Text)
                {
                    //exibir vitoria
                    label1.Text = "VOCÊ VENCEU!!! ";
                    coin += 5;
                    lblcoin.Text = coin.ToString();
                }
            }
        }
    }
}
