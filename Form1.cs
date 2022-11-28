namespace ThirdBlock
{
    public partial class Form1 : Form
    {
        int index = 0;
        
        int x,y;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBank.newTree = new Tree(550);
            int w = pictureBox1.ClientSize.Width;
            int h = pictureBox1.ClientSize.Height;
            DataBank.newTree.AddNumLevel(9, w, h);
            label1.Text = "N/A";
            label2.Text = "N/A";


        }

        private void PrintTreeInBox(object sender, PaintEventArgs e)
        {
           
            
            if (index == 1)
            {
                DataBank.newTree.PaintTree(e);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
            pictureBox1.Refresh();
        }
        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (x <= DataBank.newTree.root.coordT.X+5 && x >= DataBank.newTree.root.coordT.X-5)
            {
                DataBank.Level = 0;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl1[0].coordT.X-5 && x <= DataBank.newTree.lvl1[0].coordT.X + 5)
            {
                DataBank.Level = 1;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl2[0].coordT.X - 5 && x <= DataBank.newTree.lvl2[0].coordT.X + 5)
            {
                DataBank.Level = 2;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl3[0].coordT.X-5 && x <= DataBank.newTree.lvl3[0].coordT.X-5 + 10)
            {
                DataBank.Level = 3;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl4[0].coordT.X-5 && x <= DataBank.newTree.lvl4[0].coordT.X-5 + 10)
            {
                DataBank.Level = 4;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl5[0].coordT.X-5 && x <= DataBank.newTree.lvl5[0].coordT.X-5 + 10)
            {
                DataBank.Level = 5;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl6[0].coordT.X-5 && x <= DataBank.newTree.lvl6[0].coordT.X-5 + 10)
            {
                DataBank.Level = 6;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }
            if (x >= DataBank.newTree.lvl7[0].coordT.X-5 && x <= DataBank.newTree.lvl7[0].coordT.X-5 + 10)
            {
                DataBank.Level = 7;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl8[0].coordT.X-5 && x <= DataBank.newTree.lvl8[0].coordT.X-5 + 10)
            {
                DataBank.Level = 8;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }

            if (x >= DataBank.newTree.lvl9[0].coordT.X-5 && x <= DataBank.newTree.lvl9[0].coordT.X-5 + 10)
            {
                DataBank.Level = 9;
                Form FormFractals = new Fractals();
                FormFractals.Show();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x = Convert.ToInt32(e.X); // координата по оси X
            y = Convert.ToInt32(e.Y); // координата по оси Y
            label1.Text = x.ToString();
            label2.Text = y.ToString();
           
        }
    }
}