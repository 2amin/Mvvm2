using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veiw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public VeiwModel.Person Ref_PersonVeiwModel { get; set; }
        private void btnclick_Click(object sender, EventArgs e)
        {
            Ref_PersonVeiwModel = new VeiwModel.Person(txtname.Text, txtsurname.Text);
        }
    }
}
