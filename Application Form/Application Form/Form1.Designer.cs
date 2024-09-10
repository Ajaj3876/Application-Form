namespace Application_Form
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dttpDOB = new DateTimePicker();
            cmbGen = new ComboBox();
            cmbReligion = new ComboBox();
            cmbCaCateg = new ComboBox();
            txtFthName = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cmbDistrict = new ComboBox();
            cmbState = new ComboBox();
            cmbCountry = new ComboBox();
            txtAddress = new TextBox();
            txtPin = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel4 = new Panel();
            list = new ListBox();
            button2 = new Button();
            button1 = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label18 = new Label();
            label19 = new Label();
            pictureBox1 = new PictureBox();
            btnSubmit = new Button();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dttpDOB);
            panel1.Controls.Add(cmbGen);
            panel1.Controls.Add(cmbReligion);
            panel1.Controls.Add(cmbCaCateg);
            panel1.Controls.Add(txtFthName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 43);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 91);
            panel1.TabIndex = 0;
            // 
            // dttpDOB
            // 
            dttpDOB.Location = new Point(979, 3);
            dttpDOB.Name = "dttpDOB";
            dttpDOB.Size = new Size(250, 34);
            dttpDOB.TabIndex = 12;
            // 
            // cmbGen
            // 
            cmbGen.FormattingEnabled = true;
            cmbGen.Items.AddRange(new object[] { "None", "Male", "Female", "Others" });
            cmbGen.Location = new Point(979, 50);
            cmbGen.Name = "cmbGen";
            cmbGen.Size = new Size(250, 36);
            cmbGen.TabIndex = 11;
            // 
            // cmbReligion
            // 
            cmbReligion.FormattingEnabled = true;
            cmbReligion.Items.AddRange(new object[] { "None", "Hindu", "Muslim", "Sikh", "Isayi", "Punjabi", "Gujrati", "Bihari" });
            cmbReligion.Location = new Point(124, 50);
            cmbReligion.Name = "cmbReligion";
            cmbReligion.Size = new Size(267, 36);
            cmbReligion.TabIndex = 10;
            // 
            // cmbCaCateg
            // 
            cmbCaCateg.FormattingEnabled = true;
            cmbCaCateg.Items.AddRange(new object[] { "None", "GEN", "OBC", "ST", "SC" });
            cmbCaCateg.Location = new Point(568, 50);
            cmbCaCateg.Name = "cmbCaCateg";
            cmbCaCateg.Size = new Size(238, 36);
            cmbCaCateg.TabIndex = 9;
            // 
            // txtFthName
            // 
            txtFthName.Location = new Point(568, 3);
            txtFthName.Name = "txtFthName";
            txtFthName.Size = new Size(238, 34);
            txtFthName.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 34);
            txtName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(19, 58);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 5;
            label7.Text = "Religion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(887, 58);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 4;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(413, 58);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 3;
            label5.Text = "Caste Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(846, 6);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 2;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(431, 11);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 1;
            label3.Text = "Father Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 6);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 4;
            label1.Text = "Personal Details";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbDistrict);
            panel2.Controls.Add(cmbState);
            panel2.Controls.Add(cmbCountry);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtPin);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(23, 172);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 91);
            panel2.TabIndex = 5;
            // 
            // cmbDistrict
            // 
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Items.AddRange(new object[] { "None", "Lucknow", "Faizabad", "S K Nagar", "Basti", "Gorakhpur", "Allahabad", "PrataGarh" });
            cmbDistrict.Location = new Point(768, 6);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(185, 36);
            cmbDistrict.TabIndex = 12;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "None", "UP", "MH", "AP", "AP", "Manipur", "Gujrat", "Mizoram", "chathissgarh", "Punjab" });
            cmbState.Location = new Point(431, 6);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(185, 36);
            cmbState.TabIndex = 11;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "None", "India", "England", "Newzeland", "Nepal", "Pakistan", "Japan", "China", "Indonessia", "Hong Kong", "Instanbul", "Afganistan" });
            cmbCountry.Location = new Point(124, 3);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(185, 36);
            cmbCountry.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(124, 50);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1131, 34);
            txtAddress.TabIndex = 7;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(1070, 6);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(185, 34);
            txtPin.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(20, 58);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(991, 6);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 4;
            label9.Text = "Pin Code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(672, 6);
            label11.Name = "label11";
            label11.Size = new Size(63, 23);
            label11.TabIndex = 2;
            label11.Text = "District";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(343, 6);
            label12.Name = "label12";
            label12.Size = new Size(48, 23);
            label12.TabIndex = 1;
            label12.Text = "State";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(19, 6);
            label13.Name = "label13";
            label13.Size = new Size(71, 23);
            label13.TabIndex = 0;
            label13.Text = "Country";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(25, 138);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(97, 30);
            label14.TabIndex = 6;
            label14.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(24, 267);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(116, 30);
            label10.TabIndex = 7;
            label10.Text = "Education";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(checkBox4);
            panel3.Controls.Add(checkBox3);
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(checkBox1);
            panel3.Location = new Point(24, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(1255, 53);
            panel3.TabIndex = 8;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(979, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(175, 32);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Post Graduation";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(663, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(133, 32);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Graduation";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(270, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(249, 32);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Inter Mediate / Diploma ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 32);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "High School";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(list);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Font = new Font("Segoe UI", 9F);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(3, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(1279, 79);
            panel4.TabIndex = 9;
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.Items.AddRange(new object[] { "Spider Man, Iron Man, Salaar, Pathan, Jawan, Dunki", "", "Cricket, volleyBall, FootBaal, Chess, Carom" });
            list.Location = new Point(463, -1);
            list.Name = "list";
            list.Size = new Size(354, 84);
            list.TabIndex = 4;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(172, 38);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(172, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(3, 34);
            label17.Name = "label17";
            label17.Size = new Size(115, 23);
            label17.TabIndex = 1;
            label17.Text = "Playing Game";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(-1, 0);
            label16.Name = "label16";
            label16.Size = new Size(109, 23);
            label16.TabIndex = 0;
            label16.Text = "Watch Movie";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(3, 356);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(99, 30);
            label15.TabIndex = 10;
            label15.Text = "Hobbies";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(27, 471);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(87, 30);
            label18.TabIndex = 11;
            label18.Text = "Picture";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(1056, 480);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(113, 30);
            label19.TabIndex = 12;
            label19.Text = "Signature";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_5592;
            pictureBox1.Location = new Point(25, 504);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Yellow;
            btnSubmit.Location = new Point(306, 537);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(160, 41);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 668);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1267, 250);
            dataGridView1.TabIndex = 16;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdate.Location = new Point(532, 537);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 41);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(778, 537);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 41);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1015, 529);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(238, 120);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1294, 919);
            Controls.Add(richTextBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(btnSubmit);
            Controls.Add(pictureBox1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label15);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmRegistration";
            Text = "Registration";
            Load += FrmRegistration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label10;
        private Panel panel3;
        private Panel panel4;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label18;
        private ComboBox cmbCaCateg;
        private TextBox txtFthName;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPin;
        private Label label19;
        private DateTimePicker dttpDOB;
        private ComboBox cmbGen;
        private ComboBox cmbReligion;
        private ComboBox cmbDistrict;
        private ComboBox cmbState;
        private ComboBox cmbCountry;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnSubmit;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
        private RichTextBox richTextBox1;
        private ListBox list;
    }
}
