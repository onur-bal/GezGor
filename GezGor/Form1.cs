using GezGor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GezGor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            GezGorContext db = new GezGorContext();
            InitializeComponent();
            UlkeleriListele();
            SehirleriListele();
        }

        private void SehirleriListele()
        {
            throw new NotImplementedException();
        }

        private void UlkeleriListele()
        {
            throw new NotImplementedException();
        }
    }
}
