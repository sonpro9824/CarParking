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
        Manager_DataDataContext dataContext = new Manager_DataDataContext();

        Attendant attendant_db = new Attendant();
        Attendant_Information attendant_class = new Attendant_Information();
        public Edit_Personal_In4_Attendant(Attendant_Information attendant)
        {
            InitializeComponent();
            attendant_class = attendant;
            db = new DataloginDataContext();
            nv = (from n in db.logins where n.email == attendant_class.Email select n).FirstOrDefault();
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

        private void Edit_Personal_In4_Attendant_Load(object sender, EventArgs e)
        {

        }
     /*   private bool Check_Valid_Input()
        {
            if (!Check_Valid_Phone_Number())
            {
                return false;
            }
            if (First_name_edit_textbox.Text == string.Empty || Last_name_edit_textbox.Text == string.Empty || .Text == string.Empty
            || Phone_number_edit_textbox.Text.Length > 10 || !textBox2.Text.Contains("@gmail.com") || FN_edit_textbox.Text == string.Empty
                || LN_edit_textbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid input! Try again!", "Notice");
                return false;
            }
            return true;
        }*/
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

        private void Save_button_Click(object sender, EventArgs e)
        {

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
