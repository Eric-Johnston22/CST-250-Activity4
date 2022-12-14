using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_250_Activity4
{

    public partial class Form2 : Form
    {
        public SuperHeroList myHeroList = new SuperHeroList();
        BindingSource HeroListBinding = new BindingSource();
        public Form1 f1;
        public Form2(SuperHeroList heroList, Form1 f1)
        {
            InitializeComponent();
            myHeroList = heroList;
            this.f1 = f1;
            setBindings();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void setBindings()
        {
            HeroListBinding.DataSource = myHeroList.listOfHeroes;
            listBox1.DataSource = HeroListBinding;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuperHero hero = listBox1.SelectedItem as SuperHero;
            textBox1.Text = hero.Display;
        }
    }
}
