namespace TaskManager
{
    public partial class Form1 : Form
    {
        new CustomDialogForm AddForm = new CustomDialogForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm.ShowDialog();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

        }


    }
}
