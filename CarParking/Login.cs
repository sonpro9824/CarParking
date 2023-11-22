using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarParking
{
    public partial class Form_Login : Form
    {
        login nv; 
        DataloginDataContext db; 
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel_sign.Show();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            nv = new login();
            db = new DataloginDataContext();
            panel_sign.Hide();
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(text_user != null && text_pass != null)
                {
                    var i = db.logins.Where(s => s.user == text_user.Text && s.pass == text_pass.Text).FirstOrDefault();
                    if(i != null)
                    {
                        //MessageBox.Show("Yeah sirrr");
                        this.Hide();
                        Welcome welcome = new Welcome();
                        welcome.Show();
                    }
                    else
                    {
                        MessageBox.Show(text_pass.Text);
                        MessageBox.Show("Sai ten hoac mat khau");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                
            }
        }

        private void button_signS_Click(object sender, EventArgs e)
        {
            if (text_mailS.Text == string.Empty || text_userS.Text == string.Empty || text_passS.Text == string.Empty)
            {
                MessageBox.Show("khong duoc de trong");
                return;
            }
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            bool check = true;
            do
            {
                var i = (from s in db.logins where s.Id == randomNumber select s);
                if (i != null)
                    check = false;
                else
                    randomNumber = random.Next(1, 101);
            } while (check);
            try
            {
                if (text_passS.Text == text_passS2.Text)
                {
                    nv.Id = randomNumber;
                    nv.email = text_mailS.Text;
                    nv.user = text_userS.Text;
                    nv.pass = text_passS.Text;
                    db.logins.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Done! Go back Login");
                    panel_sign.Hide();
                    text_user.Text = text_userS.Text;
                    
                    text_pass.Text = text_passS2.Text;
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("Erorr comfirm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr");
            }
            
        }

        private void text_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_passS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_passS2_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void text_mailS_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
