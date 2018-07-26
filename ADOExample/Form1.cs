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

namespace ADOExample
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbshop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            //commbobox
            string genger = cbgender.SelectedItem.ToString();
            //rdiobutton
            string membership = "";
            if (rbfree.Checked)
            {
                membership = rbfree.Text;


            }
            if (rbpaid.Checked)
            {
                membership = rbpaid.Text;
            }

            string shopping = "";
            foreach(var d in clbshop.CheckedItems)
            {
                shopping += d +",";
            }
            string cod = "";
            if (cbcod.Checked)
            {
                cod = "yes";
            }
            else
            {
                cod = "no";

            }
            string pass = txtpassword.Text;
            MessageBox.Show(name+"\n"+genger+"\n"+membership+"\n"+shopping+"\n"+cod+"\n"+pass);




            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into RegisterShopping values(@nm,@gen,@mem,@pre,@cod,@pwd)";//parameters to sql query
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@gen", genger);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@pre", shopping);
                cmd.Parameters.AddWithValue("@cod",cod);
                cmd.Parameters.AddWithValue("@pwd", pass);
                int res=cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data inserted " + res);
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);


            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }



        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from RegisterShopping";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for(int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);
                       
                    }
                    lbselect.Items.Add("*******");
                }



            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbId.SelectedValue;
                MessageBox.Show("ID is :" + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from RegisterShopping where ID=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Deleted" + res);
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string member = "";
                if (rbpaid.Checked)
                    member = rbpaid.Text;
                if (rbfree.Checked)
                {
                    member = rbfree.Text;
                }
                string shop = "";
                foreach(var s in clbshop.CheckedItems)
                {
                    shop += s + ",";
                }
                string pass = txtpassword.Text;
                int id = (int)cbId.SelectedValue;
                con = new SqlConnection(constr);
                con.Open();
                string query = "update RegisterShopping set Membership=@mem,ShoppingPreference=@pre,password=@pwd where ID=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@mem", member);
                cmd.Parameters.AddWithValue("@pre", shop);
               
                cmd.Parameters.AddWithValue("@pwd", pass);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data inserted " + res);
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }
    }
}
