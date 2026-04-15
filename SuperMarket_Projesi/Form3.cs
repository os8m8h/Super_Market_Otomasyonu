using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket_Projesi
{
    public partial class ProductForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-NJLRNMK\\SQLEXPRESS;Initial Catalog=SuperMarket;User ID=sa;Password=anas21");

       
        SqlDataAdapter adpt;
        DataTable dt;
        public ProductForm()
        {
            InitializeComponent();
            DisPlay();


        }
        
        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ÜrünForm_Load(object sender, EventArgs e)
        {
            string sql = " select * from Product_Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CatCB.DataSource = dt;
            CatCB.DisplayMember = "Category_name";
            CatCB.ValueMember = "Category_Id";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        int n = 0;

        private void EkleButton_Click(object sender, EventArgs e)
        {
                                     
            string date = Date1.Value.ToString("yyyy/MM/dd");
            
            SqlCommand cmnd = new SqlCommand("insert into Product(ProductId,ProductName,Quentity,Price,PurchasePrice,Details,Product_date,Suppliers,Category_Id) values ('" + prodId.Text + "','" + NameTxt.Text + "','" + QuenTxt.Text + "','" + PriceTxt.Text + "','" + PurchasePriceTxt.Text + "','" + Detailstxt.Text + "','" + date + "','" + Supply.Text + "',@ComCata)", Con);
           cmnd.Parameters.AddWithValue("@ComCata", CatCB.SelectedValue.ToString());
            Con.Open();
            cmnd.ExecuteNonQuery();
                   MessageBox.Show("Saved successfully");
                   Con.Close();
                   DisPlay();
                   Clear();
           /* SqlCommand cmnd = new SqlCommand("insert into Product values ('" + prodId.Text + "','" + NameTxt.Text + "','" + QuenTxt.Text + "','" + PurchasePriceTxt.Text + "','" + PriceTxt.Text + "','" + Detailstxt.Text + "','" + date + "''" + Supply.Text + "','" + CatCB.Text + "')", Con);
*/

            /*     Con.Open();
                 cmnd = new SqlCommand("insert into Product values (@Poduct_Id,@ProductName,@Quantity,@Price,@PurchasePrice,@Details)", Con);

                 cmnd.Parameters.AddWithValue("@Poduct_Id", prodId.Text);
                 cmnd.Parameters.AddWithValue("@ProductName", NameTxt.Text);
                 cmnd.Parameters.AddWithValue("@Quantity", QuenTxt.Text);
                 cmnd.Parameters.AddWithValue("@Price", PriceTxt.Text);
                 cmnd.Parameters.AddWithValue("@PurchasePrice", PurchasePriceTxt.Text);
                 cmnd.Parameters.AddWithValue("@Details", Detailstxt.Text);
             cmnd.Parameters.AddWithValue("@date", Date1.Value.ToString("yyyy/MM/dd 00:00:00"));
             cmnd.Parameters.AddWithValue("@suplliers", Supply.Text);
             cmnd.Parameters.AddWithValue("@catagori", CatCB.SelectedValue.ToString());
             cmnd.ExecuteNonQuery();
                 MessageBox.Show("deleted successfuly");
                 Con.Close();
                 DisPlay();
                 Clear();

          */




        }
        public void DisPlay()
        {
            Con.Open();
            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select * from Product ", Con);
            adpt.Fill(dt);
            productdv2.DataSource = dt;
            Con.Close();
        }
        public void Clear()
        {
            prodId.Text = "";
            NameTxt.Text = "";
            QuenTxt.Text = "";
            PurchasePriceTxt.Text = "";
            PriceTxt.Text = "";
            Detailstxt.Text = "";
            Supply.Text = "";
        }

        private void Detailstxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuenTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catagory catagori = new Catagory();
            catagori.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellingForm satıs = new SellingForm();
            satıs.Show();
            this.Hide();
        }
       
       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            string date = Date1.Value.ToString("yyyy/MM/dd");

            SqlCommand cmnd = new SqlCommand("update Product set ProductName = '" + NameTxt.Text + "', Quentity = '" + QuenTxt.Text + "', Price = '" + PriceTxt.Text + "',PurchasePrice = '" + PurchasePriceTxt.Text + "', Details ='" + Detailstxt.Text + "',Product_date ='" + date + "',Suppliers= '" + Supply.Text + "' where ProductId = '"+prodId.Text+"'", Con);
            Con.Open();
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully");
            Con.Close();
            DisPlay();
            Clear();

            //(ProductId, ProductName, Quentity, PurchasePrice, Price, Details, Product_date, Suppliers, Category_Id)
            /* SqlCommand cmnd = new SqlCommand(sql, Con);*//*
            cmnd.Parameters.AddWithValue("@id", prodId.Text);
            cmnd.Parameters.AddWithValue("@name", NameTxt.Text);
    cmnd.Parameters.AddWithValue("@quen", QuenTxt.Text);
    cmnd.Parameters.AddWithValue("@pprice", PriceTxt.Text);
    cmnd.Parameters.AddWithValue("@price", PurchasePriceTxt.Text);
    cmnd.Parameters.AddWithValue("@dtls", Detailstxt.Text);
    cmnd.Parameters.AddWithValue("@supls", Supply.Text);*/
            // cmnd.Parameters.AddWithValue("@ComCata", CatCB.SelectedValue.ToString());

            //+ prodId.Text + "','" + NameTxt.Text + "','" + QuenTxt.Text + "','" + PurchasePriceTxt.Text + "','" + PriceTxt.Text + "','" + Detailstxt.Text + "','" + date + "','" + Supply.Text + "',@ComCata)"






        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Hide();
        }

        private void productdv2_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void productdv2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void productdv2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("delete Product where ProductId = @id", Con);
            Con.Open();
            cmnd.Parameters.AddWithValue("@id", prodId.Text);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("deleted successfully");
            Con.Close();
            DisPlay();
            Clear();
        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productdv2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            prodId.Text = productdv2.Rows[e.RowIndex].Cells[0].Value.ToString();
            NameTxt.Text = productdv2.Rows[e.RowIndex].Cells[1].Value.ToString();
            QuenTxt.Text = productdv2.Rows[e.RowIndex].Cells[2].Value.ToString();
            PriceTxt.Text = productdv2.Rows[e.RowIndex].Cells[3].Value.ToString();
            PurchasePriceTxt.Text = productdv2.Rows[e.RowIndex].Cells[4].Value.ToString();
            Detailstxt.Text = productdv2.Rows[e.RowIndex].Cells[5].Value.ToString();
            Date1.Text = productdv2.Rows[e.RowIndex].Cells[6].Value.ToString();
            Supply.Text = productdv2.Rows[e.RowIndex].Cells[7].Value.ToString();
          //  CatCB.Text = productdv2.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
