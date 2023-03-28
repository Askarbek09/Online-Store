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
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gbFridge.Enabled = false;
            gbStove.Enabled = false;
            gbTv.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string id;
        public string type;
        public string model;
        public string brand;
        public string price;
        string size;
        string respondTime;
        Boolean smart;


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Pleas enter the ID");
            }
            else if(tbModel.Text == "")
            {
                MessageBox.Show("Please enter the Model type");
            }
            else if (tbBrand.Text == "")
            {
                MessageBox.Show("Please enter the Brand type");
            }
            else if (tbPrice.Text == "")
            {
                MessageBox.Show("Please enter the Price");
            }
            else
            {
               
                    if (cbType.Text == "TV")
                    {
                        gbTv.Enabled = true;
                        gbFridge.Enabled = false;
                        gbStove.Enabled = false;
                    }
                    else if (cbType.Text == "FRIDGE")
                    {
                        gbFridge.Enabled = true;
                        gbStove.Enabled = false;
                        gbTv.Enabled = false;
                    }
                    else if (cbType.Text == "STOVE")
                    {
                        gbStove.Enabled = true;
                        gbFridge.Enabled = false;
                        gbTv.Enabled = false;
                    }
                    else
                    {
                        gbStove.Enabled = false;
                        gbFridge.Enabled = false;
                        gbTv.Enabled = false;
                    }

                    id = tbId.Text;
                    type = cbType.Text;
                    model = tbModel.Text;
                    brand = tbBrand.Text;
                    price = tbPrice.Text;
                    
                
                
            }

        }

        private void gbTv_Enter(object sender, EventArgs e)
        {
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                size = tbSize.Text;
                respondTime = tbRespondTime.Text;
                smart = checkSmart.Checked;
                
                
                if (size=="")
                {
                    MessageBox.Show("Please enter a size");

                }
                else if(respondTime=="")

                {
                    MessageBox.Show("Please enter a respond time");
                }
                else
                {
                    MessageBox.Show("Your TV sucesfully added");
                    tbId.Clear();
                    tbModel.Clear();
                    tbBrand.Clear();
                    tbPrice.Clear();
                    tbSize.Clear();
                    tbRespondTime.Clear(); 
                    gbTv.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            FileStream file1 = new FileStream("tv.txt",FileMode.Append,FileAccess.Write);
            StreamWriter ts = new StreamWriter(file1);
            ts.WriteLine(brand+"_"+id+"_"+model+"_"+price+"_"+size+"_"+respondTime+"_"+smart+"_"+type);
            ts.Close();
            file1.Close();
            TVproduct tv1 = new TVproduct(type, id, model, brand, price, size, respondTime, smart);
            ProductList.data = $"{brand} : {model}";
            ProductList.listOfTv.Add(ProductList.data);
            
            ProductList.TVobjects.Add(id);
            ProductList.TVobjects.Add(brand);
            ProductList.TVobjects.Add(model);
            ProductList.TVobjects.Add(price);
            ProductList.TVobjects.Add(smart.ToString());
            ProductList.TVobjects.Add(size);
            ProductList.TVobjects.Add(respondTime);
            ProductList.TVcounter++;
        }
        string capacity;
        string electricity;
        string noise;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                 capacity = tbCapacity.Text;
                 electricity = tbElectricity.Text;
                 noise = Noise.Text;

                
                if (capacity == "")
                {
                    MessageBox.Show("Please enter a capacity");

                }
                else if (electricity == "")

                {
                    MessageBox.Show("Please enter a electricity");
                }
                else if (noise == "")

                {
                    MessageBox.Show("Please enter a noise");
                }
                else
                {
                    MessageBox.Show("Your Fridge sucesfully added");
                    tbId.Clear();
                    tbModel.Clear();
                    tbBrand.Clear();
                    tbPrice.Clear();
                    tbCapacity.Clear();
                    tbElectricity.Clear();
                    Noise.Clear();
                    gbFridge.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FileStream file2 = new FileStream("fridge.txt", FileMode.Append, FileAccess.Write);
            StreamWriter fs = new StreamWriter(file2);
            fs.WriteLine(brand + "_" + id + "_" + model + "_" + price + "_" + capacity + "_" + electricity + "_" + noise + "_" + type);
            fs.Close();
            file2.Close();
            fridgeProduct fridge1 = new fridgeProduct(brand, id, model, price, capacity, electricity, noise, type);
            
            ProductList.data = $"{brand} : {model}";
            ProductList.listOfFridge.Add(ProductList.data);

            ProductList.FridgeObjects.Add(id);
            ProductList.FridgeObjects.Add(brand);
            ProductList.FridgeObjects.Add(model);
            ProductList.FridgeObjects.Add(price);
            ProductList.FridgeObjects.Add(capacity);
            ProductList.FridgeObjects.Add(electricity);
            ProductList.FridgeObjects.Add(noise);
            ProductList.FridgeCounter++;
        }
        string numOfHeaters;
        public Boolean oven1;
        Boolean gas1;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                 numOfHeaters = tbNumberOfHeaters.Text;
                 oven1 = oven.Checked;
                 gas1 = gas.Checked;

                


                if (numOfHeaters == "")
                {
                    MessageBox.Show("Please enter a capacity");

                }
                else
                {
                    MessageBox.Show("Your Fridge sucesfully added");
                    tbId.Clear();
                    tbModel.Clear();
                    tbBrand.Clear();
                    tbPrice.Clear();
                    tbNumberOfHeaters.Clear();
                    gbStove.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FileStream file3 = new FileStream("stove.txt", FileMode.Append, FileAccess.Write);
            StreamWriter ss = new StreamWriter(file3);
            ss.WriteLine(brand + "_" + id + "_" + model + "_" + price + "_" + numOfHeaters + "_" + oven1 + "_" + gas1 + "_" + type);
            ss.Close();
            file3.Close();
            Product productStove = new Product(type, id, model, brand, price);
            StoveProduct stove1 = new StoveProduct(numOfHeaters, gas1, oven1);

            
            ProductList.data = $"{brand} : {model}";
            ProductList.listOfStove.Add(ProductList.data);
            

            ProductList.StoveObjects.Add(id);
            ProductList.StoveObjects.Add(brand);
            ProductList.StoveObjects.Add(model);
            ProductList.StoveObjects.Add(price);
            ProductList.StoveObjects.Add(numOfHeaters);
            ProductList.StoveObjects.Add(oven1.ToString());
            ProductList.StoveObjects.Add(gas1.ToString());
            ProductList.StoveCounter++;

        }
    }
}
