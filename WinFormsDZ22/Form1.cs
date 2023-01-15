namespace WinFormsDZ22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if((e.X == 0) || (e.Y == 0))
                {
                    MessageBox.Show($"Клик левой кнопкой мыши на границе прямоугольника!", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"Клик левой кнопкой мыши внутри прямоугольника", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if ((e.X == 0) || (e.Y == 0))
                {
                    MessageBox.Show($"Клик правой кнопкой мыши на границе прямоугольника!", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show($"Width = {ClientSize.Width}, Height = {ClientSize.Height}", "Sizes of client's window");
                }
                else
                {
                    MessageBox.Show($"Клик правой кнопкой мыши внутри прямоугольника", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show($"Width = {ClientSize.Width}, Height = {ClientSize.Height}", "Sizes of client's window");
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if((e.X == ClientSize.Width - 10) || (e.Y == ClientSize.Height - 10))
                {
                    MessageBox.Show($"Клик левой кнопкой мыши на границе прямоугольника!", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"Клик левой кнопкой мыши за границами прямоугольника", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if ((e.X == ClientSize.Width - 10) || (e.Y == ClientSize.Height - 10))
                {
                    MessageBox.Show($"Клик правой кнопкой мыши на границе прямоугольника!", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show($"Width = {ClientSize.Width}, Height = {ClientSize.Height}", "Sizes of client's window");
                }
                else
                {
                    MessageBox.Show($"Клик правой кнопкой мыши за границами прямоугольника", "Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show($"Width = {ClientSize.Width}, Height = {ClientSize.Height}", "Sizes of client's window");
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
             Text = $"X {e.X} - Y {e.Y}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X {e.X} - Y {e.Y}";
        }
    }
}