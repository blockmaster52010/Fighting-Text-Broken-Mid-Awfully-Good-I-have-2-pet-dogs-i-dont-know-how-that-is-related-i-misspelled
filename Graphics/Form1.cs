namespace Graphics
{
    public partial class Form1 : Form
    {
        static int bhealth = 100;
        static int phealth = 100;
        bool turn = true;
        int poison = 0;
        int bpoison = 0;
        int botchoice = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                bhealth -= 15;
                turn = false;
                bhealth = Math.Max(0, Math.Min(bhealth, 100));

            }
            label2.Text = "Health:" + bhealth.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (turn)
            {
                phealth += 10;

                turn = false;
                phealth = Math.Max(0, Math.Min(phealth, 100));
            }
            label1.Text = "Health:" + phealth.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                if (poison > 0)
                {
                    poison--;
                    bhealth -= 10;
                }
                else
                {
                    poison = 2;
                    bhealth -= 10;
                }
                bhealth = Math.Max(0, Math.Min(bhealth, 100));
                turn = false;
            }
            label2.Text = "Health:" + bhealth.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bhealth == 0)
            {
                label4.Text = "Winner: Player";
            }
            if (phealth == 0)
            {
                label4.Text = "Winner: Bot";
            }
            botchoice = random.Next(0, 3);
            switch (botchoice)
            {
                case 0:
                    phealth -= 15;
                    label1.Text = "Health:" + phealth.ToString();
                    phealth = Math.Max(0, Math.Min(phealth, 100));
                    label3.Text = "Choice: Fireball";
                    break;
                case 1:
                    bhealth += 10;
                    label2.Text = "Health:" + bhealth.ToString();
                    bhealth = Math.Max(0, Math.Min(bhealth, 100));
                    label3.Text = "Choice: Heal";
                    break;
                case 2:
                    if (bpoison > 0)
                    {
                        bpoison--;
                        phealth -= 10;
                    }
                    else
                    {
                        bpoison = 2;
                        phealth -= 10;
                    }
                    label3.Text = "Choice: Poison";
                    phealth = Math.Max(0, Math.Min(phealth, 100));
                    label1.Text = "Health:" + phealth.ToString();
                    break;

            }
            turn = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}