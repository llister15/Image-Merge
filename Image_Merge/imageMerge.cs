/*This solution adds an overlay on an image
 * This application was created by Wonkasoft
 * Created 8/12/2016
 * Lead Developer: Dev-Turtle */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Media;
using System.Drawing.Text;
using System.Threading;

namespace Image_Merge {
    public partial class ImageMerge : Form {
        public ImageMerge() {
            InitializeComponent();
        }
        
        // Start of my custom code
        // Source Button Click Event
        private void sourceBtn_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderDialogBox = new FolderBrowserDialog();
            if (folderDialogBox.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                sourceText.Text = folderDialogBox.SelectedPath;
            }
        }

        // Overlay Button Click Event
        private void selectOverlayBtn_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialogBox = new OpenFileDialog ();
            fileDialogBox.Filter = "PNG|*.png| JPG|*.jpg";
            fileDialogBox.Title = "Choose Overlay File";
            if ( fileDialogBox.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    overlayText.Text = fileDialogBox.FileName;
            }
        }

        // Destination Button Click Event
        private void selectDestinationBtn_Click ( object sender , EventArgs e ) {
            FolderBrowserDialog folderDialogBox = new FolderBrowserDialog ();
            if ( folderDialogBox.ShowDialog () == System.Windows.Forms.DialogResult.OK ) {
                destinationText.Text = folderDialogBox.SelectedPath;
            }
        }

        // Enable Text Options Check Box
        private void enableTextChkBox_CheckedChanged ( object sender , EventArgs e ) {
            if ( enableTextChkBox.Checked ) {
                alignmentBox.Enabled = true;
                fontsizeBox.Enabled = true;
                fontcolorBox.Enabled = true;
                customText.Enabled = true;
            } else {
                alignmentBox.Enabled = false;
                fontsizeBox.Enabled = false;
                fontcolorBox.Enabled = false;
                customText.Enabled = false;
            }

            if ( customText.Focus()) {
                customText.SelectAll();
            }
        }

        // Start Merge Button Click Event
        private void startBtn_Click ( object sender , EventArgs e ) {

        }

        // Preview Button Click Event
        private void previewBtn_Click ( object sender , EventArgs e ) {

        }

        // Clear Button Click Event
        private void clearBtn_Click ( object sender , EventArgs e ) {
            foreach ( var item in this.Controls ) {
                if ( item.GetType().Equals ( typeof ( TextBox ) ) ) {
                    TextBox text1 = item as TextBox;
                    text1.Text = string.Empty;
                }
            }
            enableTextChkBox.Checked = false;
        }

        // Clear Menu Button Click Event
        private void saveToolStripMenuItem_Click ( object sender , EventArgs e ) {
            foreach ( var item in this.Controls ) {
                if ( item.GetType ().Equals ( typeof ( TextBox ) ) ) {
                    TextBox text1 = item as TextBox;
                    text1.Text = string.Empty;
                }
            }
            enableTextChkBox.Checked = false;
        }

        // Exit Button Click Event
        private void exitBtn_Click ( object sender , EventArgs e ) {
            DialogResult confirm = MessageBox.Show ( "Are You Sure You Want To Exit?" , "Exit Image Merge" , MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            if ( confirm == System.Windows.Forms.DialogResult.Yes ) {
                Application.Exit ();
            }   
        }

        // Exit Menu Button Click Event
        private void exitToolStripMenuItem_Click ( object sender , EventArgs e ) {
            DialogResult confirm = MessageBox.Show ( "Are You Sure You Want To Exit?" , "Exit Image Merge" , MessageBoxButtons.YesNo , MessageBoxIcon.Question );
            if ( confirm == System.Windows.Forms.DialogResult.Yes ) {
                Application.Exit ();
            }
        }

        // Exit Menu Button With Out Confirmation Click Event Ctl F12
        private void exitNoConfirmToolStripMenuItem_Click ( object sender , EventArgs e ) {
            Application.Exit ();
        }
    } // End of Form
} // End of namespace
