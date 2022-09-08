namespace ASP_winform_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string age = ageField.Text;
            showNameLabel.Text = name;
            MessageBox.Show("Hello "+name+" with age "+age+"..!");
        }
    }
}