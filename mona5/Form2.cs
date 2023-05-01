using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mona5
{


    public partial class Form2 : Form
    {


        private List<Item> items = new List<Item>();
        private List<Item> selectedItems = new List<Item>();
       

        public Form2()
        {
            InitializeComponent();
            
            ///datagridview1 Columns 

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Gold";
            dataGridView1.Columns[1].Name = "Weight";
            dataGridView1.Columns[2].Name = "Value"; 


           ///for equel width
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }



        //class to represent an item with its weight and value 
       public class Item              
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Value { get; set; }

            public Item(string name, int weight, int value)
            {
                Name = name;
                Weight = weight;
                Value = value;
            }

        }  

       
        ///list مترتبه
        private List<Item> SortItems(List<Item> items)
        {
            return items.OrderByDescending(i => (double)i.Value / (double)i.Weight).ToList();
        }

        private void ClearItemInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }




        private void remove_Click(object sender, EventArgs e)
        {


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dataGridView1.Rows.Clear();


        }




        private void add_Click(object sender, EventArgs e)
        {
            

            ///read inputs from textboxes.
            string name = textBox1.Text;
            int weight = Convert.ToInt32(textBox2.Text);
            int value = Convert.ToInt32(textBox3.Text);
            ///create item object.
            Item item = new Item(name, weight, value);
            ///add item ti list of items.
            items.Add(item);
            ///display items in datagridview.
            dataGridView1.Rows.Add(name, weight, value);
            ///clear input textboxes
           /// textBox1.Clear();
           /// textBox2.Clear();
           /// textBox3.Clear();
            ClearItemInputs(); 
          //  dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
          //  int Capacity = Convert.ToInt32(textBox4.Text);
            


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void solve_Click(object sender, EventArgs e)
        {

           

            /// Get the maximum weight of the knapsack
            int maxWeight = Convert.ToInt32(textBox4.Text);

            /// Sort the items by their value-to-weight ratio
            items = SortItems(items);

            /// Fill the knapsack with the highest value-to-weight ratio items
            ///  Select items greedily
            int currentWeight = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (currentWeight + items[i].Weight <= maxWeight)
                {
                    selectedItems.Add(items[i]);
                    currentWeight += items[i].Weight;
                }
            }

           ///هيمسح اللي datagridview القديمه ويحط فيها القيم الجديده
            /// Display the selected items in the datagridview
            
            dataGridView1.Rows.Clear();

            for (int i = 0; i < selectedItems.Count; i++)
            {
                dataGridView1.Rows.Add(selectedItems[i].Name, selectedItems[i].Weight, selectedItems[i].Value);
            }

            /// Calculate the max value of the selected items
            int Maxvalue = 0;

            for (int i = 0; i < selectedItems.Count; i++)
            {
                Maxvalue += selectedItems[i].Value;
            }

            /// Display the total value in the label

            label1.Text = "Maximum value: " + Maxvalue.ToString();


        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();  //كده هيخفي الفورم التانيه  ويفتح الفورم الاولي//
            back.Show();
            this.Hide(); 
        }


    }
      
        
    }
      
     
  
