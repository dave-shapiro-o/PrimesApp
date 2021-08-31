using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesApp
{
    public partial class PrimeFinder : Form
    {
        private string size;
        private ListDisplay list;
        private string answer;
        private Stopwatch clock;

        public PrimeFinder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private async void button1_Click(object sender, EventArgs e)
        {
            if (size != null)
            {
                calculatingLabel.Visible = true;
                calculatingLabel.Text = "Calculating...";
                clock = new Stopwatch();

                await Task.Run(() => DoCalculations());

                calculatingLabel.Text = $"Calculation took {clock.Elapsed.TotalSeconds:N4} seconds";
                answerTextLeft.Text = ("There are");
                answerTextRight.Text = ($"primes below {int.Parse(size):N0}");

                GenerateList();

                showButton.Visible = true;
            }
        }

        private void GenerateList()
        {
            list = new ListDisplay();
            list.SetText(PrimeSieve.listOfPrimes);
            list.Text = $"List of {answer} primes below {int.Parse(size):N0}";
        }

        private void DoCalculations()
        {
            clock.Start();
            answer = PrimeSieve.Calculate(int.Parse(size)).ToString();
            clock.Stop();
            resultLabel.Text = answer;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int _)) { size = textBox1.Text; }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (list.IsDisposed) { GenerateList(); }
            list.Show();
        }

        private void pBoxClose_Click(object sender, EventArgs e)
            => Environment.Exit(0);

        private void pBoxClose_MouseEnter(object sender, EventArgs e)        
            => pBoxClose.Image = Image.FromFile("icons8-close-window-48_darker.png");
        
        private void pBoxClose_MouseLeave(object sender, EventArgs e)        
            => pBoxClose.Image = Image.FromFile("icons8-close-window-48.png");        
    }
}
