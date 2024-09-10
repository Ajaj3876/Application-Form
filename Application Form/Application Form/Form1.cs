using System.Data;
using System.Data.SqlClient;

namespace Application_Form
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is DateTimePicker)
                {
                    if (((DateTimePicker)control).Value == null)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("One or more field are empty, Please fill First before Submitting");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-2DJ9G4B\\SQLEXPRESS02;Initial Catalog=Registration;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string insertQuery = "INSERT INTO tb1Register VALUES (@FullName, @FatherName, @DOB, @Religion, @Casste, @Gender, @Adress, @Country, @Statte, @District, @Pin)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFthName.Text);
                cmd.Parameters.AddWithValue("@DOB", dttpDOB.Value);
                cmd.Parameters.AddWithValue("@Religion", cmbReligion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Casste", cmbCaCateg.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Gender", cmbGen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Adress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Country", cmbCountry.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Statte", cmbState.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@District", cmbDistrict.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Pin", txtPin.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                BindRegistration();
                con.Close();
            }


        }
        private void Clear()
        {
            txtName.Clear(); txtFthName.Clear(); txtAddress.Clear(); txtPin.Clear();
            cmbCaCateg.Enabled = false; cmbGen.Enabled = false; cmbDistrict.Enabled = false; cmbCountry.Enabled = false; cmbReligion.Enabled = false; cmbState.Enabled = false;
            dttpDOB.Enabled = false;
        }
        private void BindRegistration()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-2DJ9G4B\\SQLEXPRESS02;Initial Catalog=Registration;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select FullName as Name, FatherName, DOB, Gender, Country, Statte as State, District, Pin, Adress from tb1Register", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cmbGen.SelectedIndex = 0;
            cmbReligion.SelectedIndex = 0;
            cmbCaCateg.SelectedIndex = 0;
            cmbCountry.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            cmbDistrict.SelectedIndex = 0;
            BindRegistration();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cmbReligion.Visible = false;
            cmbCaCateg.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnSubmit.Visible = false;

            txtName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFthName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dttpDOB.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cmbGen.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmbCountry.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbState.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbDistrict.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtPin.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-2DJ9G4B\\SQLEXPRESS02;Initial Catalog=Registration;Integrated Security=True;TrustServerCertificate=True");

            SqlCommand cmd = new SqlCommand ("UPDATE tb1Register SET @FatherName=FatherName, DOB=@DOB, Religion=@Religion, Casste=@Casste, Gender=@Gender, Adress=@Adress, Country=@Country, Statte=@Statte, District=@District, Pin=@Pin WHERE FullName=@FullName", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@FullName", txtName.Text);
            cmd.Parameters.AddWithValue("@FatherName", txtFthName.Text);
            cmd.Parameters.AddWithValue("@DOB", dttpDOB.Value);
            cmd.Parameters.AddWithValue("@Religion", cmbReligion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Casste", cmbCaCateg.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender", cmbGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Adress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Country", cmbCountry.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Statte", cmbState.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@District", cmbDistrict.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Pin", txtPin.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        
            MessageBox.Show("Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            BindRegistration();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-2DJ9G4B\\SQLEXPRESS02;Initial Catalog=Registration;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[tb1Register]" +
                "      WHERE [FullName]='"+txtName+"'", con);
            cmd.Parameters.AddWithValue("@FullName", txtName.Text);
            cmd.Parameters.AddWithValue("@FatherName", txtFthName.Text);
            cmd.Parameters.AddWithValue("@DOB", dttpDOB.Value);
            cmd.Parameters.AddWithValue("@Religion", cmbReligion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Casste", cmbCaCateg.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender", cmbGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Adress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Country", cmbCountry.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Statte", cmbState.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@District", cmbDistrict.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Pin", txtPin.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            BindRegistration();
            con.Close();
        }
    }
}
