using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class Edit_Personal_In4 : Form
    {
        login nv;
        DataloginDataContext db;
        Manager_DataDataContext dataContext = new Manager_DataDataContext();
        Manager Manager = new Manager();
        Manager_Information manager_Information = new Manager_Information();
        public Edit_Personal_In4(Manager_Information _Information)
        {
            InitializeComponent();
            manager_Information = _Information;
            AID_label.Text = manager_Information.ID1.ToString();
            //var manager = (from s in dataContext.Managers where s.Id == currentID select s);
            Display_Personal_In4();
            Manager = dataContext.Managers.Where(m=> m.Email == manager_Information.Email).FirstOrDefault();
            db = new DataloginDataContext();
            nv = db.logins.Where(m=>m.email == manager_Information.Email).FirstOrDefault();
        }
        private void Display_Personal_In4()
        {
            //MessageBox.Show("Hello im here");
            if (manager_Information.First_name!=null)
            {
                //MessageBox.Show("Hi from fn");
                FN_label.Text = manager_Information.First_name;
            }
            if (manager_Information.Last_name!=null)
            {
                LN_label.Text=manager_Information.Last_name;
            }
            if (manager_Information.Sex!=null)
            {
                Sex_value_label.Text = manager_Information.Sex;
            }
            if (manager_Information.DoB1!= default)
            {
                DOB_value_label.Text = manager_Information.DoB1.ToShortDateString();
            }
            if (manager_Information.Email!=null)
            {
                Email_Value_label.Text = manager_Information.Email;
            }
            if (manager_Information.Phone_number!=null)
            {
                Phone_Number_Value_label.Text = manager_Information.Phone_number;
            }
            if (manager_Information.Address!=null)
            {
                Address_Value_label.Text = manager_Information.Address;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Value_Information_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool Check_Valid_Phone_Number()
        {
            string test_text = textBox1.Text;
            for (int i = 0; i < test_text.Length; i++)
            {
                //MessageBox.Show(test_text[i] + "_", "Character");
                if (test_text[i] <='9' && test_text[i] >='0')
                {
                    continue;
                   
                }
                else
                {
                    MessageBox.Show("Invalid phone number!", "Notice");
                    return false;
                }
            }
            return true;
        }
        private bool Check_Valid_Input()
        {
            if (!Check_Valid_Phone_Number())
            {
                return false;
            }
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty
                || textBox1.Text.Length > 10 || !textBox2.Text.Contains("@gmail.com") || FN_edit_textbox.Text == string.Empty
                || LN_edit_textbox.Text == string.Empty) 
            {
                MessageBox.Show("Invalid input! Try again!", "Notice");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Doi gia tri label, dong thoi cap nhat gia tri cho manager (class), sau do su dung phuong thuc tinh tranfer de chuyen no vao manager (database)
        /// </summary>
        private void Update_Information()
        {
            LN_label.Text = LN_edit_textbox.Text;
            manager_Information.Last_name = LN_edit_textbox.Text;

            FN_label.Text = FN_edit_textbox.Text;
            manager_Information.First_name = FN_edit_textbox.Text;

            Phone_Number_Value_label.Text = textBox1.Text;
            manager_Information.Phone_number = textBox1.Text;

            Email_Value_label.Text = textBox2.Text;
            manager_Information.Email = Email_Value_label.Text;
            Manager.Email = manager_Information.Email;
            dataContext.SubmitChanges();
            nv.email = manager_Information.Email;
            db.SubmitChanges();

            Address_Value_label.Text = textBox3.Text;
            manager_Information.Address = Address_Value_label.Text;

            if (RB_Female.Checked)
            {
                Sex_value_label.Text = "Female";
                manager_Information.Sex = Sex_value_label.Text;
            }
            else if (RB_Male.Checked)
            {
                Sex_value_label.Text = "Male";
                manager_Information.Sex = Sex_value_label.Text;
            }
            else
            {
                Sex_value_label.Text = "Others";
                manager_Information.Sex = Sex_value_label.Text;
            }

            DOB_value_label.Text = dateTimePicker1.Value.ToShortDateString();
            manager_Information.DoB1 = dateTimePicker1.Value;

            Manager = new Manager();
            dataContext = new Manager_DataDataContext();
            Manager = dataContext.Managers.Where(m => m.Id == manager_Information.ID1).Single();
            Manager_Information.Transfer_Manager_Detail(manager_Information, ref Manager);
            dataContext.SubmitChanges();

        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            /*LN_label.Visible = false;
            FN_label.Visible = false;
            LN_edit_textbox.Visible = true;
            FN_edit_textbox.Visible = true;*/
            Value_Information_panel.Visible = false;
            Edit_PI_panel.Visible = true;


            Contact_Value_panel.Visible = false;
            Edit_Contact_Value_panel.Visible = true;

            Edit_button.Visible = false;
            Save_button.Visible = true;
            Back_button.Visible = true;

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            bool check = Check_Valid_Input();
            if (check)
            {
                Update_Information();
                Value_Information_panel.Visible = true;
                Edit_PI_panel.Visible = false;


                Contact_Value_panel.Visible = true;
                Edit_Contact_Value_panel.Visible = false;

                Edit_button.Visible = true;
                Save_button.Visible = false;

                Back_button.Visible = false;
                MessageBox.Show("Update successfully!", "Notice");
                return;
            }
            else
            {
                
                return;
            }
        }

        private void Edit_Personal_In4_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Manager_G_ID.gID.ToString());
        }

        private void ID_label_Click(object sender, EventArgs e)
        {

        }

        private void Title_label_Click(object sender, EventArgs e)
        {

        }

        private void FN_edit_textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FN_edit_textbox.Clear();
        }

        private void LN_edit_textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LN_edit_textbox.Clear();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Edit_Contact_Value_panel.Visible = false;
            Value_Information_panel.Visible = true;

            Contact_Value_panel.Visible = true;
            Edit_Contact_Value_panel.Visible = false;

            Back_button.Visible = false;
            Edit_button.Visible = true;
            Save_button.Visible = false;
        }
    }
}
