namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerationButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void GenerationButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = default, left = default;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;

                    left += 50;
                    this.Controls.Add(buttons[i, j]);

                    if ((i + j) % 2 == default)
                        buttons[i, j].BackColor = Color.Black;
                    else
                        buttons[i, j].BackColor = Color.White;
                }
                top += 50;
                left = default;

            }
        }
    }
}

