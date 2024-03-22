using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit3
{
    public partial class MyTxtBx : TextBox
    {

        public Boolean _mandatory;
        public Color _entercolor;
        public Color _leavecolor;
        public Color _mandatorycolor;

        public MyTxtBx()
        {
            InitializeComponent();
        }

        [System.ComponentModel.Browsable(true)]
        [Description("Set TRUE if you want to show Mandatorycolor when user keeps Null")]
        [Category("category1")]
        public Boolean Mandatory
        {
            get { return _mandatory; }
            set { _mandatory = value; }
        }

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Category("category1")]
        public Color Mandatorycolor
        {
            get { return _mandatorycolor; }
            set { _mandatorycolor = value; }
        }


        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Category("category1")]
        public Color Entercolor
        {
            get { return _entercolor; }
            set { _entercolor = value; }
        }


        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Category("category1")]
        public Color Leavecolor
        {
            get { return _leavecolor; }
            set { _leavecolor = value; }
        }

        private void MyTxtBx_Load(object sender, EventArgs e)
        {

        }
    }
}
