namespace MovingLabel
{
    public partial class Form1 : Form
    {
        private int sek;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Buttoni_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = lbl1.Location;
            if (n.Y - 10 >= 0)
            {
                n.Y -= 15;
                lbl1.Location = n;
                br++;
                brojac.Text = br.ToString();
            }
            else
            {
                MessageBox.Show(str);
                brojac.Text = br.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = lbl1.Location;
            int sirina = panel1.Width;
            if (n.X < sirina - 75)
            {
                n.X += 10;
                lbl1.Location = n;
                br++;
                brojac.Text = br.ToString();
            }
            else 
            {
                MessageBox.Show(str);
                brojac.Text = br.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = lbl1.Location;
            if (n.X > 15)
            {
                n.X -= 15;
                lbl1.Location = n;
                br++;
                brojac.Text = br.ToString();
            }
            else 
            {
                MessageBox.Show(str);
                brojac.Text = br.ToString();
            }
        }

        private void btnDole_Click(object sender, EventArgs e)
        {
            n = lbl1.Location;
            int visina = panel1.Size.Height;
            if (n.Y < visina - 20)
            {
                n.Y += 10;
                lbl1.Location = n;
                br++;
                brojac.Text = br.ToString();
            }
            else
            { 
                MessageBox.Show(str);
                brojac.Text = br.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Location = new Point(panel1.Width / 2 - lbl1.Width/2, panel1.Height / 2);
            brojac.Text = br.ToString();
            sek = 0;
            //pricali smo na casu da cu predati u toku subote
        }
        int br = 0;
        Point n = new Point(0, 0);
        string str = "Ne mozete dalje";
        private void Form1_Resize(object sender, EventArgs e)
        {
            lbl1.Location = new Point(panel1.Width / 2 - lbl1.Width/2, panel1.Height / 2);
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sek++;
            timerlbl.Text = sek.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}