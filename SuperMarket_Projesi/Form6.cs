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
    public partial class Bills : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-NJLRNMK\\SQLEXPRESS;Initial Catalog=SuperMarket;User ID=sa;Password=anas21");

        SqlCommand cmnd;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataReader MyReader;
        public Bills()
        {
            InitializeComponent();
            DisPlay();
            Fill_ComBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prf = new ProductForm();
            prf.Show();
            this.Hide();
        }
        public void DisPlay()
        {
            Con.Open();
            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select * from Sales ", Con);
            adpt.Fill(dt);
            SellsData.DataSource = dt;
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
            Sumtxt.Text = "";
            CustoTxt.Text = "";


        }

        private void button13_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select * from Sales where SaleId ='" + SelId.Text + "'", Con);
            adpt.Fill(dt);
            SellsData.DataSource = dt;
            Con.Close();
        }
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
        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SelId.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SelId.Text = "";
        }

        private void Detailstxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SellsData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NameTxt.Text = SellsData.Rows[e.RowIndex].Cells[1].Value.ToString();
            QuenTxt.Text = SellsData.Rows[e.RowIndex].Cells[2].Value.ToString();
            PriceTxt.Text = SellsData.Rows[e.RowIndex].Cells[3].Value.ToString();
            PurchasePriceTxt.Text = SellsData.Rows[e.RowIndex].Cells[4].Value.ToString();
            Detailstxt.Text = SellsData.Rows[e.RowIndex].Cells[5].Value.ToString();
            Supply.Text = SellsData.Rows[e.RowIndex].Cells[6].Value.ToString();
            Sumtxt.Text = SellsData.Rows[e.RowIndex].Cells[8].Value.ToString();
            CustoTxt.Text = SellsData.Rows[e.RowIndex].Cells[9].Value.ToString();




        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmnd = new SqlCommand("update Sales set SaleName = @name,Quantity =@quen,Market_price=@pprice,PurchasePrice=@price,Details=@dtls,Supplies=@supls,Total_Price=@WholePrice,CutomerName=@CustoName,Sale_date=@date where  SaleId = @id", Con);
            /* SqlCommand cmnd = new SqlCommand(sql, Con);*/
            cmnd.Parameters.AddWithValue("@id", SelId.Text);
            cmnd.Parameters.AddWithValue("@name", NameTxt.Text);
            cmnd.Parameters.AddWithValue("@quen", QuenTxt.Text);
            cmnd.Parameters.AddWithValue("@price", PurchasePriceTxt.Text);
            cmnd.Parameters.AddWithValue("@pprice", PriceTxt.Text);
            cmnd.Parameters.AddWithValue("@dtls", Detailstxt.Text);
            cmnd.Parameters.AddWithValue("@supls", Supply.Text);
           // cmnd.Parameters.AddWithValue("@ComCata", CatCB.SelectedValue.ToString());
            cmnd.Parameters.AddWithValue("@WholePrice", Sumtxt.Text);
            cmnd.Parameters.AddWithValue("@CustoName", CustoTxt.Text);
            cmnd.Parameters.AddWithValue("@date", Selling_date.Value.ToString("yyyy/MM/dd 00:00:00"));
            //+ prodId.Text + "','" + NameTxt.Text + "','" + QuenTxt.Text + "','" + PurchasePriceTxt.Text + "','" + PriceTxt.Text + "','" + Detailstxt.Text + "','" + date + "','" + Supply.Text + "',@ComCata)"

            Con.Open();
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Updated successfuly");
            Con.Close();
            DisPlay();
            Clear();
           


        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("delete Sales where SaleId = @id", Con);
            Con.Open();
            cmnd.Parameters.AddWithValue("@id", SelId.Text);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("deleted successfuly");
            Con.Close();
            DisPlay();
            Clear();
        }

        private void Bills_Load(object sender, EventArgs e)
        {

        }
    }
}
