using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormAbout : Form
    {
        public string Title
        {
            //폼의 text박스를 가져옴
            set { this.Text = value; }
        }

        public FormAbout()
        {
            InitializeComponent();
        }
    }
}
