namespace losowanieocen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            randomiseButton.Enabled = false;

            Random rnd = new Random();
            List<int> wyniki = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int ocena = rnd.Next(1, 6);
                wyniki.Add(ocena);
                int ocena2 = ocena;
                int ocena3 = ocena;
                numbern2Label.Text = ocena.ToString();
                if (ocena > 1)
                {
                    ocena2 = rnd.Next(1, 6);
                    ocena3 = rnd.Next(1, 6);
                }
                else if (ocena == 1)
                {
                    ocena3 = rnd.Next(ocena, 6);
                    ocena2 = rnd.Next(ocena, 6);
                }
                else if (ocena == 6)
                {
                    ocena2 = rnd.Next(1, ocena);
                    ocena3 = rnd.Next(1, ocena);
                }
                numbern1Label.Text = ocena2.ToString();
                numbern3Label.Text = ocena3.ToString();
                groupBox1.Text = "Ocena : " + ocena.ToString();
                switch (ocena)
                {
                    case 1:
                        groupBox3.BackColor = Color.Red;
                        break;
                    case 2:
                        groupBox3.BackColor = Color.Orange;
                        break;
                    case 3:
                        groupBox3.BackColor = Color.Yellow;
                        break;
                    case 4:
                        groupBox3.BackColor = Color.LightGreen;
                        break;
                    case 5:
                        groupBox3.BackColor = Color.Green;
                        break;
                    case 6:
                        groupBox3.BackColor = Color.Blue;
                        break;
                    default:
                        groupBox3.BackColor = Color.White;
                        break;
                }
                switch (ocena2)
                {
                    case 1:
                        groupBox2.BackColor = Color.Red;
                        break;
                    case 2:
                        groupBox2.BackColor = Color.Orange;
                        break;
                    case 3:
                        groupBox2.BackColor = Color.Yellow;
                        break;
                    case 4:
                        groupBox2.BackColor = Color.LightGreen;
                        break;
                    case 5:
                        groupBox2.BackColor = Color.Green;
                        break;
                    case 6:
                        groupBox2.BackColor = Color.Blue;
                        break;
                    default:
                        groupBox2.BackColor = Color.White;
                        break;
                }
                switch (ocena3)
                {
                    case 1:
                        groupBox8.BackColor = Color.Red;
                        break;
                    case 2:
                        groupBox8.BackColor = Color.Orange;
                        break;
                    case 3:
                        groupBox8.BackColor = Color.Yellow;
                        break;
                    case 4:
                        groupBox8.BackColor = Color.LightGreen;
                        break;
                    case 5:
                        groupBox8.BackColor = Color.Green;
                        break;
                    case 6:
                        groupBox8.BackColor = Color.Blue;
                        break;
                    default:
                        groupBox8.BackColor = Color.White;
                        break;
                }
                await Task.Delay(500);
            }

            int ostatniaOcena = wyniki.Last();
            using (StreamWriter writer = new StreamWriter("saved.txt"))
            {
                writer.WriteLine(ostatniaOcena);
            }

            using (StreamReader reader = new StreamReader("saved.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Ustawienie koloru tekstu w zale¿noœci od wartoœci
                    WynikrRichTextBox.SelectionStart = WynikrRichTextBox.TextLength;
                    WynikrRichTextBox.SelectionLength = 0;
                    switch (line)
                    {
                        case "1":
                            WynikrRichTextBox.SelectionColor = Color.Red;
                            break;
                        case "2":
                            WynikrRichTextBox.SelectionColor = Color.Orange;
                            break;
                        case "3":
                            WynikrRichTextBox.SelectionColor = Color.Yellow;
                            break;
                        case "4":
                            WynikrRichTextBox.SelectionColor = Color.LightGreen;
                            break;
                        case "5":
                            WynikrRichTextBox.SelectionColor = Color.Green;
                            break;
                        case "6":
                            WynikrRichTextBox.SelectionColor = Color.Blue;
                            break;
                        default:
                            WynikrRichTextBox.SelectionColor = Color.White;
                            break;
                    }
                    WynikrRichTextBox.AppendText(line + "\n");
                    WynikrRichTextBox.SelectionColor = WynikrRichTextBox.ForeColor; // Resetowanie koloru
                }
            }
            randomiseButton.Enabled = true;
        }
    }
}
