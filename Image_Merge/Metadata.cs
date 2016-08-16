using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Merge {
    public partial class Metadata: Form {
        public Metadata () {
            InitializeComponent ();
        }


        // Cancel Button Click Event
        private void cancelBtn_Click ( object sender , EventArgs e ) {
            this.Close ();
        }
    }
}
