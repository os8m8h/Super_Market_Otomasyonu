using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Projesi
{
    public partial class SellingForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-NJLRNMK\\SQLEXPRESS;Initial Catalog=SuperMarket;User ID=sa;Password=anas21");

        SqlCommand cmnd;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataReader MyReader;
        public SellingForm()
        {
            InitializeComponent();
            Fill_ComBox();
            DisPlay();
            // Fill_ListBox();
        }
        public void DisPlay()
        {
            Con.Open();
            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select * from Sales ", Con);
            adpt.Fill(dt);
            Sells_DGD.DataSource = dt;
            Con.Close();
        }
        public void Clear()
        {
            
            NameTxt.Text = "";
            QuenTxt.Text = "";
            PurchasePriceTxt.Text = "";
            PriceTxt.Text = "";
            Detailstxt.Text = "";
            Supply.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustoTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SatısForm_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        /*public void Fill_ListBox()
        {
            Con.Open();
             string test = "select * from Product_Categories  ";
            cmnd = new SqlCommand(test, Con);
       
            MyReader = cmnd.ExecuteReader();
            while(MyReader.Read()){
                string Category_name = MyReader.GetString(1);
                CataListB.Items.Add(Category_name);
               
            }
            Con.Close();
        }*/
        public void Fill_ComBox()
        {
            Con.Open();
            string test = "select * from Product_Categories  ";
            cmnd = new SqlCommand(test, Con);

            MyReader = cmnd.ExecuteReader();
            while (MyReader.Read())
            {
                string Category_name = MyReader.GetString(1);
                CatCB.Items.Add(Category_name);

            }
            Con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProdId.Text = "";
        }
       
        
        private void button13_Click(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select ProductName,Quentity,price,PurchasePrice,Details,Suppliers from Product where ProductId ='" + ProdId.Text + "'", Con);
            adpt.Fill(dt);
            ProductGdv1.DataSource = dt;
            Con.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button  btn =  (Button) sender;
            ProdId.Text += btn.Text;
        }

        private void QuenTxt_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CataListB_DoubleClick(object sender, EventArgs e)
        {/*
            Con.Open();
            DataTable dt = new DataTable();

            adpt = new SqlDataAdapter("select * from Product where '" + CataListB + "'", Con);
            
            adpt.Fill(dt);
            ProductGdv1.DataSource = dt;
            Con.Close();*/
        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void ProductGdv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            NameTxt.Text = ProductGdv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            QuenTxt.Text = ProductGdv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            PriceTxt.Text = ProductGdv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PurchasePriceTxt.Text = ProductGdv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Detailstxt.Text = ProductGdv1.Rows[e.RowIndex].Cells[4].Value.ToString();
             Supply.Text = ProductGdv1.Rows[e.RowIndex].Cells[5].Value.ToString();
            
    }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Count_Click_1(object sender, EventArgs e)
        {
            double sum = double.Parse(QuenTxt.Text) * double.Parse(PriceTxt.Text);
            Sumtxt.Text = sum.ToString();
        }

        private void ADD_Click_1(object sender, EventArgs e)
        {
            string date = Selling_date.Value.ToString("yyyy/MM/dd");
            SqlCommand cmnd = new SqlCommand("insert into Sales(SaleId,SaleName,Quantity,Market_price,PurchasePrice,Details,Supplies,Total_Price,CutomerName,sale_date) values ('"+ProdId.Text+"','" + NameTxt.Text + "','" + QuenTxt.Text + "','" + PriceTxt.Text + "','" + PurchasePriceTxt.Text + "','" + Detailstxt.Text + "','" + Supply.Text + "','"+Sumtxt.Text+"','"+ CustoTxt.Text+"','"+date+"')" , Con);
            cmnd.Parameters.AddWithValue("@id", ProdId.Text);
            //cmnd.Parameters.AddWithValue("@ComCata", CatCB.SelectedValue.ToString());
            Con.Open();
            cmnd.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully");
            Con.Close();
            DisPlay();
            Clear();
          



        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("delete Sales where SaleId = @id", Con);
            Con.Open();
            cmnd.Parameters.AddWithValue("@id", ProdId.Text);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("deleted Successfuly");
            Con.Close();
            DisPlay();
            Clear();
        }

        private void ProdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void Bills1_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Hide();
        }
    }
}
