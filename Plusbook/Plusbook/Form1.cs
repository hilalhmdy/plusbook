using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Plusbook
{
    public partial class Form1 : Form
    {
        //PRIVATE VARS
        private ProfileList profile_list;
        private OpenFileDialog ofd;


        // PUBLIC
        public Form1()
        {
            // INIT
            InitializeComponent();
            profile_list = new ProfileList();
            ofd = new OpenFileDialog();
            // END INIT



        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
