namespace CST_250_Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string colorChoice = "";
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                pictureBox1.BackColor = color;
                colorChoice = color.Name;
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "Speed: " + hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = "Stamina: " + hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = "Strength: " + hScrollBar3.Value.ToString();
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int total = this.hScrollBar1.Value + this.hScrollBar2.Value + this.hScrollBar3.Value;

            if (total > 100)
            {
                MessageBox.Show("Combined attribute values cannot be more than 100.");


            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = "Dark Side Propensity: " + trackBar1.Value.ToString();
        }
    }
}