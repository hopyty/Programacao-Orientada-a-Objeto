using System.Runtime.InteropServices;

namespace Roteiro_08_POO
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                panel1.Name = "panel1";
                panel1.Size = new Size(800, 88);
                panel1.TabIndex = 0;
                panel1.MouseMove += panel1_MouseDown;
            }
        }

        private void AbrirFormNopainel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Form();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNopainel<Form2>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button5.Visible = true;
        }

        private void button5_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button5.Visible = false;
            button4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormNopainel<Form3>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormNopainel<Form4>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormNopainel<Form5>();
        }
    }
}
