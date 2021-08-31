using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesApp
{
    public partial class ListDisplay : Form
    {
        public ListDisplay()
        {
            InitializeComponent();
        }

        internal void SetText(string listOfPrimes)       
            => displayOfPrimes.AppendText(listOfPrimes);       
    }
}
