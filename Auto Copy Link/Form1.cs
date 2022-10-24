namespace Auto_Copy_Link
{
    public partial class Form1 : Form
    {
        string[] readText;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            string filePath = txtPath.Text;
            txtPosition.Text = 0.ToString();
            readText = File.ReadAllLines(filePath);
            txtLink.Text = readText[0];
            Clipboard.SetText(readText[0]);
        }

        private void btnNextCopy_Click(object sender, EventArgs e)
        {
            var pos = Convert.ToInt32(txtPosition.Text);
            pos++;
            txtPosition.Text = pos.ToString();
            txtLink.Text = readText[pos];
            Clipboard.SetText(readText[pos]);
        }
    }
}