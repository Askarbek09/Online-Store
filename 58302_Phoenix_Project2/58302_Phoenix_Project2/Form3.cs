using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _58302_Phoenix_Project2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string Size = "SIZE:";
        string Smart = "SMART:";
        string ResTime = "RESPONSE TIME:";
        Int32 length = ProductList.TVobjects.Count;
         
        private void button2_Click(object sender, EventArgs e)
        {
            int indexOflb = listBox1.SelectedIndex;
            if (comboBox11.Text=="TV")
            {
                int difference = 0;
                for (int i = 0; i < ProductList.TVcounter; i++)
                {
                        if (indexOflb == i)
                        {
                            label6.Text = ProductList.TVobjects.ElementAt(0 + difference);
                            label7.Text = ProductList.TVobjects.ElementAt(1 + difference);
                            label8.Text = ProductList.TVobjects.ElementAt(2 + difference);
                            label9.Text = ProductList.TVobjects.ElementAt(3 + difference);
                            label10.Text = Smart + ProductList.TVobjects.ElementAt(4 + difference);
                            label11.Text = Size + ProductList.TVobjects.ElementAt(5 + difference);
                            label12.Text = ResTime + ProductList.TVobjects.ElementAt(6 + difference);
                        }
                        else if (indexOflb>0)
                        {
                            difference+=7;
                        }
                }
                
            }
            else if(comboBox11.Text=="FRIDGE")
            {
                string capacity = "CAPACITY:";
                string electricity = "ELECTRICITY:";
                string noise = "NOISE:";

                int difference = 0;
                for (int i = 0; i < ProductList.FridgeCounter; i++)
                {
                    if (indexOflb == i)
                    {
                        label6.Text = ProductList.FridgeObjects.ElementAt(0 + difference);
                        label7.Text = ProductList.FridgeObjects.ElementAt(1 + difference);
                        label8.Text = ProductList.FridgeObjects.ElementAt(2 + difference);
                        label9.Text = ProductList.FridgeObjects.ElementAt(3 + difference);
                        label10.Text = capacity + ProductList.FridgeObjects.ElementAt(4 + difference);
                        label11.Text = electricity + ProductList.FridgeObjects.ElementAt(5 + difference);
                        label12.Text = noise + ProductList.FridgeObjects.ElementAt(6 + difference);
                    }
                    else if (indexOflb > 0)
                    {
                        difference += 7;
                    }
                }
            }
            else
            {
                string numOfHe = "NUMBER OF HEATERS:";
                string oven = "OVEN:";
                string gas = "GAS:";
                int difference = 0;
                for (int i = 0; i < ProductList.StoveCounter; i++)
                {
                    if (indexOflb == i)
                    {
                        label6.Text = ProductList.StoveObjects.ElementAt(0 + difference);
                        label7.Text = ProductList.StoveObjects.ElementAt(1 + difference);
                        label8.Text = ProductList.StoveObjects.ElementAt(2 + difference);
                        label9.Text = ProductList.StoveObjects.ElementAt(3 + difference);
                        label10.Text = numOfHe + ProductList.StoveObjects.ElementAt(4 + difference);
                        label11.Text = oven + ProductList.StoveObjects.ElementAt(5 + difference);
                        label12.Text = gas + ProductList.StoveObjects.ElementAt(6 + difference);
                    }
                    else if (indexOflb > 0)
                    {
                        difference += 7;
                    }
                }
            }
            groupBox1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox11.Text=="TV")
            {
                listBox1.Items.Clear();
                foreach(string item in ProductList.listOfTv)
                {
                    
                        listBox1.Items.Add(item);
                    
                }
                
            }
            else if (comboBox11.Text == "FRIDGE")
            {
                listBox1.Items.Clear();
                foreach (string item in ProductList.listOfFridge)
                {
                    listBox1.Items.Add(item);
                }
               
                

            }
            else 
            {
                listBox1.Items.Clear();
                foreach (string item in ProductList.listOfStove)
                {
                    listBox1.Items.Add(item);
                }
                

            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
