using MostenireWindowsForm.Mostenirea5;
using MostenireWindowsForm.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostenireWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Birou birou = new Birou("birou,12,795,1.14,1.31,1.87");
            this.Controls.Add(new PnlCardBirou(this,birou));

        }
    }
}
