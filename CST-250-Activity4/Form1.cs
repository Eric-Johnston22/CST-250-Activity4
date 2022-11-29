using System.Collections;
using System.Security.Policy;

namespace CST_250_Activity4
{
    public partial class Form1 : Form
    {

        public string name;
        public decimal experience;
        public List<string> importantDates = new List<string>();
        public List<string> skills = new List<string>();
        public string officeLocation;
        public int speed;
        public int stamina;
        public int strength;
        public string capeColor = "";
        public int darkSide;
        public string transportation = "";
        public SuperHeroList heroList = new SuperHeroList();
        public static Form1 f1;

        public Form1()
        {
            InitializeComponent();
            f1 = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                pictureBox1.BackColor = color;
                capeColor = color.Name;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            experience = numericUpDown1.Value;
            importantDates.Add(dateTimePicker1.Text);
            importantDates.Add(dateTimePicker2.Text);
            importantDates.Add(dateTimePicker3.Text);
            if(checkBox1.Checked)
            {
                skills.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                skills.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                skills.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                skills.Add(checkBox4.Text);
            }
            if (checkBox5.Checked)
            {
                skills.Add(checkBox5.Text);
            }
            if (checkBox6.Checked)
            {
                skills.Add(checkBox6.Text);
            }
            if (checkBox7.Checked)
            {
                skills.Add(checkBox7.Text);
            }
            if (checkBox8.Checked)
            {
                skills.Add(checkBox8.Text);
            }
            if (checkBox9.Checked)
            {
                skills.Add(checkBox9.Text);
            }
            if (checkBox10.Checked)
            {
                skills.Add(checkBox10.Text);
            }
            officeLocation = listBox1.SelectedItem.ToString();
            speed = hScrollBar1.Value;
            stamina = hScrollBar2.Value;
            strength = hScrollBar3.Value;
            darkSide = trackBar1.Value;
            if (radioButton1.Checked)
            {
                transportation = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                transportation = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                transportation = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                transportation = radioButton4.Text;
            }
            SuperHero hero = new SuperHero(name, experience, importantDates, skills, officeLocation, speed, stamina, strength, capeColor, darkSide, transportation);
            heroList.listOfHeroes.Add(hero);
            Form2 f2 = new Form2(heroList, f1);
            this.Hide();
            f2.Show();
        }
    }
}