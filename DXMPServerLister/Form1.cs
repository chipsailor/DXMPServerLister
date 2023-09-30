namespace DXMPServerLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string aboutmessage = "DXMP Server Browser made by TEK9 / Monica" + Environment.NewLine + "Copyright WhoCaresLmao 1990 - 9999";
            string titleMB = "About";
            MessageBoxButtons aboutButton = MessageBoxButtons.OK;
            MessageBoxIcon aboutIcon = MessageBoxIcon.Information;
            MessageBox.Show(aboutmessage, titleMB, aboutButton, aboutIcon);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var settingsForm = new Form2();
            settingsForm.Show();
        }
    }
}