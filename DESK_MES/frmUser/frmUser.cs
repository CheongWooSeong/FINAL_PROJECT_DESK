using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESK_MES
{
    public partial class frmUser : FormStyle_2
    {
        public frmUser()
        {
            InitializeComponent();
            label1.Text = "사용자 관리";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PopUserResister pop = new PopUserResister();
            pop.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PopUserModify pop = new PopUserModify();
            pop.ShowDialog();
        }
    }
}
