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
namespace POSPeachie
{
    public partial class frmChangePassword : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        DBConnection db = new DBConnection();
        frmPOS f;
        public frmChangePassword(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(db.MyConnection());
            f = frm;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string _oldpass = db.GetPassword(f.lblUser.Text);
                if(_oldpass != txtOld.Text)
                {
                    MessageBox.Show("OLD PASSOWRD DID NOT MATCHED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(txtNew.Text != txtConfirm.Text)
                {
                    MessageBox.Show("CONFIRM NEW PASSWORD DID NOT MATCH!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    if(MessageBox.Show("CHANGE PASSWORD?","CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("Update tbluser set password =@password where username = @username", cn);
                        cm.Parameters.AddWithValue("@password", txtNew.Text);
                        cm.Parameters.AddWithValue("@username", f.lblUser.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("PASSWORD HAS BEEN SUCCESSFULLY SAVED.", "SAVED PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();

                    }
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
