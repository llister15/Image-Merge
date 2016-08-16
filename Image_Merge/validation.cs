using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_Merge {
    class validation {
        public validation(string dirCheck) {
            DirectoryCheck = dirCheck;
        }
        
     public string DirectoryCheck {
        get;
        set;      
     }     
        
     public void emptyCheck(string source) {
        if ( DirectoryCheck == "" ) {
            System.Windows.Forms.MessageBox.Show ( "You must make a selection for " + source, "Error Message",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );  
        } else {
            return;
        }
     }   

     public void fileCheck() {
            if (DirectoryCheck =="") {
                return;
            } else {
                Bitmap overlay = new Bitmap ( DirectoryCheck );
                int overlayWidth = overlay.Width;
                int overlayHeight = overlay.Height;
                if ( overlayWidth <= 1024 && overlayHeight <= 720 ) {
                        System.Windows.Forms.MessageBox.Show ( "Your Image is " + overlayWidth + "x" + overlayHeight + " pixels and does not meet the minimum requirements of 1024x720 pixels","Image Requirements",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Asterisk );
                 } else {
                    return;
                }
            }
     }

    }
}
