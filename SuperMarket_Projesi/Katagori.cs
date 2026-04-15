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
using System.Data;

namespace SuperMarket_Projesi
{
    public partial class Catagory : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-NJLRNMK\\SQLEXPRESS;Initial Catalog=SuperMarket;User ID=sa;Password=anas21");
        SqlCommand cmnd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Catagory()
        {
            InitializeComponent();
            DisPlay();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellingForm satısform = new SellingForm();
            satısform.Show();
            this.Hide();
        }


      

        int n = 0;
        private void EkleButton_Click(object sender, EventArgs e)
        {

            /* string sql = " select" * from Product_Categories where Category_Id= @id ";
         SqlCommand cmnd = new SqlCommand(sql , Con);
         cmnd.Parameters.AddWithValue("@id", CataId.Text);
         SqlDataReader r;
         Con.Open();
         r =  cmnd.ExecuteReader();
         if (r.HasRows == true)
         {
             while (r.Read())
             {
                 CataName.Text = r["Category_name"].ToString();
                 CataDetails.Text = r["Description"].ToString();
             }
         }

         else
         {
             MessageBox.Show("eror");
         }
         Con.Close();



         Object[] ob1 = { CataId.Text.ToString(), CataName.Text.ToString(), CataDetails.ToString() };

                 CatagortTb1.Rows.Add(ob1);


*/



            /*
             * 
                        Con.Open();
                        cmnd = new SqlCommand()
                        string sql1 = "insert into Product_Categories values (@Id,@Name,@Desc)";
                        SqlCommand cmnd = new SqlCommand(sql1, Con);
                        cmnd.Parameters.AddWithValue("@Id", CataId.Text);
                        cmnd.Parameters.AddWithValue("@Name", CataName.Text);
                        cmnd.Parameters.AddWithValue("@Desc", CataDetails.Text);
                      */
            
            
                
                cmnd = new SqlCommand("insert into Product_Categories values ('" + CataId.Text + "','" + CataName.Text + "','" + CataDetails.Text + "')", Con);
                Con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("verileri başaralı kayd edilmış");
                Con.Close();
                DisPlay();
            Clear();
/*
            Object[] ob1 = { CataId.Text.ToString(), CataName.Text.ToString(), CataDetails.ToString() };

            CatagortTb1.Rows.Add(ob1);*/




        }
         
        public void DisPlay()
        {
            Con.Open();
            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select * from Product_Categories  ", Con);
          /*  cmnd.Parameters.AddWithValue("@id", CataId.Text);*/
            adpt.Fill(dt);
            CatagortTb1.DataSource = dt;
            Con.Close();
        }
        public void Clear()
        {
            CataId.Text = "";
            CataName.Text = "";
            CataDetails.Text = "";
        }
      

        private void CatagortTb1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CataId.Text = CatagortTb1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CataName.Text = CatagortTb1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CataDetails.Text = CatagortTb1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void CatagortTb1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CataId.Text = CatagortTb1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CataName.Text = CatagortTb1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CataDetails.Text = CatagortTb1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cmnd = new SqlCommand("update Product_Categories set  Category_name = @name,Description = @Des  where Category_Id= @id", Con);
                /* SqlCommand cmnd = new SqlCommand(sql, Con);*/
                cmnd.Parameters.AddWithValue("@id", CataId.Text);
                cmnd.Parameters.AddWithValue("@name", CataName.Text);
                cmnd.Parameters.AddWithValue("@Des", CataDetails.Text);

                cmnd.ExecuteNonQuery();
                MessageBox.Show("Updated successfuly");
                Con.Close();
                DisPlay();
                Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            
            /*            string sql = "  update Product_Categories set  Category_Id= @id,Category_name = @name,Description = @Des";
            */           /* SqlCommand cmnd = new SqlCommand(sql, Con);
                        cmnd.Parameters.AddWithValue("@id", CataId.Text);
                        cmnd.Parameters.AddWithValue("@name", CataName.Text);
                        cmnd.Parameters.AddWithValue("@Des", CataDetails.Text);

                        cmnd.ExecuteNonQuery();*/
            /* SqlDataReader r;

             r =  cmnd.ExecuteReader();
             if (r.HasRows == true)
             {
                 while (r.Read())
                 {
                     CataId.Text = r["Category_Id"].ToString();
                     CataName.Text = r["Category_name"].ToString();
                     CataDetails.Text = r["Description"].ToString();
                 }
                 MessageBox.Show("Updated successfuly");
             }

             else
             {
                 MessageBox.Show("eror");
             }
             Con.Close();



             Object[] ob1 = { CataId.Text.ToString(), CataName.Text.ToString(), CataDetails.ToString() };

                     CatagortTb1.Rows.Add(ob1);
           /* Con.Close();
            MessageBox.Show("Updated successfuly");
*/
        }

        private void CataDetails_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CataName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
            cmnd = new SqlCommand("delete Product_Categories where Category_Id = @id", Con);
            Con.Open();
            cmnd.Parameters.AddWithValue("@id", CataId.Text);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("deleted successfuly");
            Con.Close();
            DisPlay();
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Hide();
        }
    }
    }

