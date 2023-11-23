﻿using System;
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
        Manager manager1;
        Manager_DataDataContext manager_Data;

        //int currentID = default;
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
            Panel_Role.Show();
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
                        string output = "Welcome back, " + i.role;
                        MessageBox.Show(output, "Notice");
                        /* Welcome welcome = new Welcome();
                         welcome.Show();*/
                        try
                        {
                            manager1 = new Manager();
                            manager_Data = new Manager_DataDataContext();
                            if (i.role == "Manager")
                            {
                                manager1 = manager_Data.Managers.Where(m => m.Email == i.email).FirstOrDefault();
                                //MessageBox.Show(manager1.Id.ToString());
                              
                                Manager_form manager_Form = new Manager_form(manager1.Id);
                                manager_Form.Show();
                            }
                            else
                            {
                                MessageBox.Show("Under development!");
                            }
                        }
                         catch (Exception ex)
                        {
                            //MessageBox.Show("Im here");
                            //MessageBox.Show(ex.Message, "Error");
                        }

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
            if(text_mailS.Text.Contains("@gmail.com")== false)
            {
                MessageBox.Show("The email is wrong");
                return;
            }
            if (text_mailS.Text == string.Empty || text_userS.Text == string.Empty || text_passS.Text == string.Empty)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            if (!Button_QuanLy.Checked && !Button_Attendant.Checked && !Button_Customer.Checked)
            {
                MessageBox.Show("You have not set your role!");
                return;
            }
            /* Random random = new Random();
             int randomNumber = random.Next(1, 101);
             bool checklop = true;
             do
             {

                 if (check[randomNumber] == false)
                 {
                     check[randomNumber] = true;
                     checklop = false;
                 }
                 else
                     randomNumber = random.Next(1, 101);
             } while (checklop);*/
           
            try
            {
                nv = new login();
                db = new DataloginDataContext();
                
                var i = db.logins.Where(s => s.user == text_userS.Text || s.email == text_mailS.Text).FirstOrDefault();
                if (i!=null)
                {
                    MessageBox.Show("The name has already existed!");
                    return;
                }
                if (text_passS.Text == text_passS2.Text)
                {
                   
                    //nv.Id = randomNumber;
                    nv.email = text_mailS.Text;
                    nv.user = text_userS.Text;
                    nv.pass = text_passS.Text;
                    if (Button_QuanLy.Checked)
                    {
                        manager_Data = new Manager_DataDataContext();
                        manager1 = new Manager();
                        Random random = new Random();
                        int randomNumber = random.Next(1, 1000);
                        bool checklop = true;
                        do
                        {

                            if (Manager_Information.check_ID_Manager[randomNumber] == true)
                            {
                                Manager_Information.check_ID_Manager[randomNumber] = false;
                                checklop = false;
                            }
                            else
                                randomNumber = random.Next(1, 1000);
                        } while (checklop);

                       /* manager_Data.Managers.InsertOnSubmit(manager1);
                        manager_Data.SubmitChanges();*/
                        nv.role = "Manager";
                        manager1.Email = nv.email;
                        manager1.Id = randomNumber;
                        manager_Data.Managers.InsertOnSubmit(manager1);
                        manager_Data.SubmitChanges();
                        
                    }
                    else if (Button_Attendant.Checked)
                    {
                        nv.role = "Attendant";
                    }
                    else if (Button_Customer.Checked)
                    {
                        nv.role = "Customer";
                    }
                    db.logins.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Done! Go back Login");
                    panel_sign.Hide();
                    text_user.Text = text_userS.Text;
                    
                    text_pass.Text = text_passS2.Text;
                    panel1.Show();
                    Panel_Role.Hide();
                }
                else
                {
                    MessageBox.Show("Error comfirm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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

        private void Button_QuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
