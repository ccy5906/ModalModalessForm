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
    public partial class FormModaless : Form
    {
        public string Title
        {
            //폼의 타이틀 바꾸기
            set { this.Text = value; }
        }

        public FormModaless()
        {
            InitializeComponent();
        }
    }
}
