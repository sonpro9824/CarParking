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
    public partial class Edit_Personal_In4_Attendant : Form
    {
        login nv;
        DataloginDataContext db;
        Attendant_DataDataContext dataContext = new Attendant_DataDataContext();

        Attendant attendant_db = new Attendant();
        Attendant_Information attendant_class = new Attendant_Information();
        public Edit_Personal_In4_Attendant(Attendant_Information attendant)
        {
            InitializeComponent();
            attendant_class = attendant;
            db = new DataloginDataContext();
            nv = (from n in db.logins where n.email == attendant_class.Email select n).FirstOrDefault();

            dataContext = new Attendant_DataDataContext();
            attendant_db = (from n in dataContext.Attendants where n.Email == attendant_class.Email select n).FirstOrDefault();
            Display_value();
        }

        private void Display_value()
        {
            information_value_panel.Visible = true;
            edit_information_panel.Visible = false;

            Contact_in4_value_panel.Visible = true;
            Edit_contact_in4_panel.Visible = false;

            ID_label.Text = attendant_class.ID1.ToString();

            if (attendant_class.First_name!= null )
            {
                First_name_value_label.Text = attendant_class.First_name;
            }

            if (attendant_class.Last_name != null)
            {
                Last_name_value_label.Text = attendant_class.Last_name;
            }

            if (attendant_class.Sex != null)
            {
                Sex_value_label.Text = attendant_class.Sex;
            }

            if (attendant_class.DoB1 != default)
            {
                DoB_value_label.Text = attendant_class.DoB1.ToShortDateString();
            }

            if (attendant_class.Date_Hired1 != default)
            {
                DH_value_label.Text = attendant_class.Date_Hired1.ToShortDateString();
            }

            if (attendant_class.Salary_base1 != null)
            {
                Salary_base_value_label.Text = attendant_class.Salary_base1.ToString();
            }

            if (attendant_class.Phone_number != null)
            {
                Phone_number_value_label.Text = attendant_class.Phone_number;
            }

            if (attendant_class.Email != null)
            {
                Email_value_lable.Text = attendant_class.Email;
            }

            if (attendant_class.Address != null)
            {
                Address_value_label.Text = attendant_class.Address;
            }
        }
        private void Contact_information_label_Click(object sender, EventArgs e)
        {

        }
        private bool Check_Valid_Phone_Number()
        {
            string test_text = Phone_number_edit_textbox.Text;
            for (int i = 0; i < test_text.Length; i++)
            {
                //MessageBox.Show(test_text[i] + "_", "Character");
                if (test_text[i] <= '9' && test_text[i] >= '0')
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
        private void Edit_Personal_In4_Attendant_Load(object sender, EventArgs e)
        {

        }
        private bool Check_Valid_Input()
        {
            var i = (from n in db.logins where n.email == Email_edit_textbox.Text select n).FirstOrDefault();
            if ( i != null)
            {
                MessageBox.Show("The email has already exist!", "Notice");
                return false;
            }
            if (!Check_Valid_Phone_Number())
            {
                return false;
            }
            if (First_name_edit_textbox.Text == string.Empty || Last_name_edit_textbox.Text == string.Empty || Salary_base_edit_textbox.Text == string.Empty
            || Phone_number_edit_textbox.Text.Length > 10 || !Email_edit_textbox.Text.Contains("@gmail.com") || Address_edit_textbox.Text == string.Empty
                || Phone_number_edit_textbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid input! Try again!", "Notice");
                return false;
            }
            return true;
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            Edit_contact_in4_panel.Visible = true;
            edit_information_panel.Visible = true;

            Contact_in4_value_panel.Visible = false;
            information_value_panel.Visible = false;

            Back_button.Visible = true;
            Save_button.Visible = true;
            Edit_button.Visible = false;
        }
        private void Update_Information()
        {
            Last_name_value_label.Text = Last_name_edit_textbox.Text;
            attendant_class.Last_name = Last_name_edit_textbox.Text;

            First_name_value_label.Text = First_name_edit_textbox.Text;
            attendant_class.First_name = First_name_edit_textbox.Text;

            Phone_number_value_label.Text = Phone_number_edit_textbox.Text;
            attendant_class.Phone_number = Phone_number_edit_textbox.Text;

            Email_value_lable.Text = Email_edit_textbox.Text;
            attendant_class.Email = Email_edit_textbox.Text;
            attendant_db.Email = attendant_class.Email;


            dataContext.SubmitChanges();
            nv.email = attendant_class.Email;
            db.SubmitChanges();

            Address_value_label.Text = Address_edit_textbox.Text;
            attendant_class.Address = Address_edit_textbox.Text;

            Salary_base_value_label.Text = Salary_base_edit_textbox.Text;
            attendant_class.Salary_base1 = Convert.ToInt32(Salary_base_edit_textbox.Text);

            if (RB_Female.Checked)
            {
                Sex_value_label.Text = "Female";
                attendant_class.Sex = Sex_value_label.Text;
            }
            else if (RB_Male.Checked)
            {
                Sex_value_label.Text = "Male";
                attendant_class.Sex = Sex_value_label.Text;
            }
            else
            {
                Sex_value_label.Text = "Others";
                attendant_class.Sex = Sex_value_label.Text;
            }

            DoB_value_label.Text = dateTimePicker_dob.Value.ToShortDateString();
            attendant_class.DoB1 = dateTimePicker_dob.Value;

            DH_value_label.Text = dateTimePicker_dh.Value.ToShortDateString();
            attendant_class.Date_Hired1 = dateTimePicker_dh.Value;

            attendant_db = new Attendant();
            dataContext = new Attendant_DataDataContext();
            attendant_db = dataContext.Attendants.Where (m => m.Email == attendant_class.Email).FirstOrDefault();
            Attendant_Information.Transfer_Attendant_Information(ref attendant_db, attendant_class);
            dataContext.SubmitChanges();
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            bool check = Check_Valid_Input();
            if (check)
            {
                Update_Information();
                information_value_panel.Visible = true;
                edit_information_panel.Visible = false;

                Edit_contact_in4_panel.Visible = false;
                Contact_in4_value_panel.Visible = true;

                Back_button.Visible = false;
                Save_button.Visible = false;
                Edit_button.Visible = true;
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Edit_contact_in4_panel.Visible = false;
            edit_information_panel.Visible = false;

            Contact_in4_value_panel.Visible = true;
            information_value_panel.Visible = true;

            Back_button.Visible = false;
            Save_button.Visible = false;
            Edit_button.Visible = true;
        }
    }
}
