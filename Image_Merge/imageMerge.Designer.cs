namespace Image_Merge
{
    partial class ImageMerge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageMerge));
            this.selectSourceBtn = new System.Windows.Forms.Button();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOverlayBtn = new System.Windows.Forms.Button();
            this.selectDestinationBtn = new System.Windows.Forms.Button();
            this.overlayText = new System.Windows.Forms.TextBox();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.overlayLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.textoptionLabel = new System.Windows.Forms.Label();
            this.textoptionIcon = new System.Windows.Forms.PictureBox();
            this.alignmentIcon = new System.Windows.Forms.PictureBox();
            this.fontIcon = new System.Windows.Forms.PictureBox();
            this.fontcolorIcon = new System.Windows.Forms.PictureBox();
            this.textinputIcon = new System.Windows.Forms.PictureBox();
            this.alignmentBox = new System.Windows.Forms.ComboBox();
            this.fontsizeBox = new System.Windows.Forms.ComboBox();
            this.fontcolorBox = new System.Windows.Forms.ComboBox();
            this.customText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.enableTextChkBox = new System.Windows.Forms.CheckBox();
            this.exitNoConfirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textoptionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontcolorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textinputIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // selectSourceBtn
            // 
            this.selectSourceBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectSourceBtn.BackgroundImage = global::Image_Merge.Properties.Resources.sourceIcon;
            this.selectSourceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectSourceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSourceBtn.FlatAppearance.BorderSize = 0;
            this.selectSourceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.selectSourceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectSourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSourceBtn.ForeColor = System.Drawing.Color.Transparent;
            this.selectSourceBtn.Location = new System.Drawing.Point(123, 186);
            this.selectSourceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.selectSourceBtn.Name = "selectSourceBtn";
            this.selectSourceBtn.Size = new System.Drawing.Size(55, 50);
            this.selectSourceBtn.TabIndex = 0;
            this.selectSourceBtn.UseVisualStyleBackColor = false;
            this.selectSourceBtn.Click += new System.EventHandler(this.sourceBtn_Click);
            // 
            // sourceText
            // 
            this.sourceText.BackColor = System.Drawing.SystemColors.Menu;
            this.sourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceText.Location = new System.Drawing.Point(37, 267);
            this.sourceText.Name = "sourceText";
            this.sourceText.ReadOnly = true;
            this.sourceText.Size = new System.Drawing.Size(217, 23);
            this.sourceText.TabIndex = 1;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.BackColor = System.Drawing.Color.Transparent;
            this.sourceLabel.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceLabel.Location = new System.Drawing.Point(52, 249);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(182, 15);
            this.sourceLabel.TabIndex = 2;
            this.sourceLabel.Text = "Select Image Source Folder";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(781, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem,
            this.exitNoConfirmToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Image_Merge.Properties.Resources.startButton;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.newToolStripMenuItem.Text = "Start Merge";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Image_Merge.Properties.Resources.previewBottonIcon;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.openToolStripMenuItem.Text = "Preview";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(207, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Image_Merge.Properties.Resources.clearButtonIcon;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.saveToolStripMenuItem.Text = "Clear All";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Image_Merge.Properties.Resources.exitButtonIcon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // selectOverlayBtn
            // 
            this.selectOverlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectOverlayBtn.BackgroundImage = global::Image_Merge.Properties.Resources.overlayIcon;
            this.selectOverlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectOverlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectOverlayBtn.FlatAppearance.BorderSize = 0;
            this.selectOverlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.selectOverlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectOverlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOverlayBtn.Location = new System.Drawing.Point(366, 181);
            this.selectOverlayBtn.Name = "selectOverlayBtn";
            this.selectOverlayBtn.Size = new System.Drawing.Size(65, 61);
            this.selectOverlayBtn.TabIndex = 4;
            this.selectOverlayBtn.UseVisualStyleBackColor = false;
            this.selectOverlayBtn.Click += new System.EventHandler(this.selectOverlayBtn_Click);
            // 
            // selectDestinationBtn
            // 
            this.selectDestinationBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectDestinationBtn.BackgroundImage = global::Image_Merge.Properties.Resources.destIcon;
            this.selectDestinationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectDestinationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDestinationBtn.FlatAppearance.BorderSize = 0;
            this.selectDestinationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.selectDestinationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectDestinationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDestinationBtn.Location = new System.Drawing.Point(613, 186);
            this.selectDestinationBtn.Name = "selectDestinationBtn";
            this.selectDestinationBtn.Size = new System.Drawing.Size(59, 50);
            this.selectDestinationBtn.TabIndex = 5;
            this.selectDestinationBtn.UseVisualStyleBackColor = false;
            this.selectDestinationBtn.Click += new System.EventHandler(this.selectDestinationBtn_Click);
            // 
            // overlayText
            // 
            this.overlayText.BackColor = System.Drawing.SystemColors.Menu;
            this.overlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overlayText.Location = new System.Drawing.Point(287, 268);
            this.overlayText.Name = "overlayText";
            this.overlayText.ReadOnly = true;
            this.overlayText.Size = new System.Drawing.Size(219, 22);
            this.overlayText.TabIndex = 6;
            // 
            // destinationText
            // 
            this.destinationText.BackColor = System.Drawing.SystemColors.Menu;
            this.destinationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationText.Location = new System.Drawing.Point(540, 268);
            this.destinationText.Name = "destinationText";
            this.destinationText.ReadOnly = true;
            this.destinationText.Size = new System.Drawing.Size(217, 22);
            this.destinationText.TabIndex = 7;
            // 
            // overlayLabel
            // 
            this.overlayLabel.AutoSize = true;
            this.overlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.overlayLabel.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overlayLabel.Location = new System.Drawing.Point(309, 249);
            this.overlayLabel.Name = "overlayLabel";
            this.overlayLabel.Size = new System.Drawing.Size(169, 15);
            this.overlayLabel.TabIndex = 8;
            this.overlayLabel.Text = "Select Overlay Image File";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.BackColor = System.Drawing.Color.Transparent;
            this.destinationLabel.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(564, 249);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(169, 15);
            this.destinationLabel.TabIndex = 9;
            this.destinationLabel.Text = "Select Destination Folder";
            // 
            // textoptionLabel
            // 
            this.textoptionLabel.AutoSize = true;
            this.textoptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.textoptionLabel.Font = new System.Drawing.Font("DejaVu Sans Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoptionLabel.Location = new System.Drawing.Point(72, 324);
            this.textoptionLabel.Name = "textoptionLabel";
            this.textoptionLabel.Size = new System.Drawing.Size(142, 22);
            this.textoptionLabel.TabIndex = 10;
            this.textoptionLabel.Text = "Text Options";
            // 
            // textoptionIcon
            // 
            this.textoptionIcon.BackColor = System.Drawing.Color.Transparent;
            this.textoptionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textoptionIcon.Image = global::Image_Merge.Properties.Resources.textOptIcon;
            this.textoptionIcon.Location = new System.Drawing.Point(25, 318);
            this.textoptionIcon.Name = "textoptionIcon";
            this.textoptionIcon.Size = new System.Drawing.Size(41, 32);
            this.textoptionIcon.TabIndex = 12;
            this.textoptionIcon.TabStop = false;
            // 
            // alignmentIcon
            // 
            this.alignmentIcon.BackColor = System.Drawing.Color.Transparent;
            this.alignmentIcon.BackgroundImage = global::Image_Merge.Properties.Resources.alignmentIcon;
            this.alignmentIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alignmentIcon.Location = new System.Drawing.Point(25, 370);
            this.alignmentIcon.Name = "alignmentIcon";
            this.alignmentIcon.Size = new System.Drawing.Size(41, 36);
            this.alignmentIcon.TabIndex = 13;
            this.alignmentIcon.TabStop = false;
            // 
            // fontIcon
            // 
            this.fontIcon.BackColor = System.Drawing.Color.Transparent;
            this.fontIcon.BackgroundImage = global::Image_Merge.Properties.Resources.fontSizeIcon;
            this.fontIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fontIcon.Location = new System.Drawing.Point(25, 421);
            this.fontIcon.Name = "fontIcon";
            this.fontIcon.Size = new System.Drawing.Size(41, 34);
            this.fontIcon.TabIndex = 14;
            this.fontIcon.TabStop = false;
            // 
            // fontcolorIcon
            // 
            this.fontcolorIcon.BackColor = System.Drawing.Color.Transparent;
            this.fontcolorIcon.BackgroundImage = global::Image_Merge.Properties.Resources.colorIcon;
            this.fontcolorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fontcolorIcon.Location = new System.Drawing.Point(25, 461);
            this.fontcolorIcon.Name = "fontcolorIcon";
            this.fontcolorIcon.Size = new System.Drawing.Size(41, 40);
            this.fontcolorIcon.TabIndex = 15;
            this.fontcolorIcon.TabStop = false;
            // 
            // textinputIcon
            // 
            this.textinputIcon.BackColor = System.Drawing.Color.Transparent;
            this.textinputIcon.BackgroundImage = global::Image_Merge.Properties.Resources.noteIcon;
            this.textinputIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.textinputIcon.Location = new System.Drawing.Point(25, 520);
            this.textinputIcon.Name = "textinputIcon";
            this.textinputIcon.Size = new System.Drawing.Size(43, 50);
            this.textinputIcon.TabIndex = 16;
            this.textinputIcon.TabStop = false;
            // 
            // alignmentBox
            // 
            this.alignmentBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Please make a selection"});
            this.alignmentBox.DisplayMember = "Please make a selection";
            this.alignmentBox.Enabled = false;
            this.alignmentBox.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignmentBox.FormattingEnabled = true;
            this.alignmentBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.alignmentBox.Items.AddRange(new object[] {
            "Please make a selection",
            "Left",
            "Center",
            "Right"});
            this.alignmentBox.Location = new System.Drawing.Point(90, 383);
            this.alignmentBox.Name = "alignmentBox";
            this.alignmentBox.Size = new System.Drawing.Size(249, 23);
            this.alignmentBox.TabIndex = 17;
            this.alignmentBox.Text = "Please make a selection";
            this.alignmentBox.ValueMember = "Please make a selection";
            // 
            // fontsizeBox
            // 
            this.fontsizeBox.Enabled = false;
            this.fontsizeBox.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontsizeBox.FormattingEnabled = true;
            this.fontsizeBox.Location = new System.Drawing.Point(90, 432);
            this.fontsizeBox.Name = "fontsizeBox";
            this.fontsizeBox.Size = new System.Drawing.Size(249, 23);
            this.fontsizeBox.TabIndex = 18;
            this.fontsizeBox.Text = "Please make a selection";
            // 
            // fontcolorBox
            // 
            this.fontcolorBox.Enabled = false;
            this.fontcolorBox.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontcolorBox.FormattingEnabled = true;
            this.fontcolorBox.Location = new System.Drawing.Point(90, 478);
            this.fontcolorBox.Name = "fontcolorBox";
            this.fontcolorBox.Size = new System.Drawing.Size(249, 23);
            this.fontcolorBox.TabIndex = 19;
            this.fontcolorBox.Text = "Please make a selection";
            // 
            // customText
            // 
            this.customText.Enabled = false;
            this.customText.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customText.Location = new System.Drawing.Point(90, 547);
            this.customText.Name = "customText";
            this.customText.Size = new System.Drawing.Size(668, 23);
            this.customText.TabIndex = 20;
            this.customText.Text = "Enter your custom text here...";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BackgroundImage = global::Image_Merge.Properties.Resources.startButton;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(483, 346);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(96, 60);
            this.startBtn.TabIndex = 21;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.BackColor = System.Drawing.Color.Transparent;
            this.previewBtn.BackgroundImage = global::Image_Merge.Properties.Resources.previewBottonIcon;
            this.previewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previewBtn.FlatAppearance.BorderSize = 0;
            this.previewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.previewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBtn.Location = new System.Drawing.Point(634, 348);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(90, 56);
            this.previewBtn.TabIndex = 22;
            this.previewBtn.UseVisualStyleBackColor = false;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BackgroundImage = global::Image_Merge.Properties.Resources.clearButtonIcon;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(483, 445);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(96, 56);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = global::Image_Merge.Properties.Resources.exitButtonIcon;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(634, 445);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 56);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 589);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(745, 10);
            this.progressBar1.TabIndex = 25;
            // 
            // enableTextChkBox
            // 
            this.enableTextChkBox.AutoSize = true;
            this.enableTextChkBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableTextChkBox.Location = new System.Drawing.Point(214, 324);
            this.enableTextChkBox.Name = "enableTextChkBox";
            this.enableTextChkBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.enableTextChkBox.Size = new System.Drawing.Size(125, 22);
            this.enableTextChkBox.TabIndex = 26;
            this.enableTextChkBox.Text = "Enable Text";
            this.enableTextChkBox.UseVisualStyleBackColor = true;
            this.enableTextChkBox.CheckedChanged += new System.EventHandler(this.enableTextChkBox_CheckedChanged);
            // 
            // exitNoConfirmToolStripMenuItem
            // 
            this.exitNoConfirmToolStripMenuItem.Name = "exitNoConfirmToolStripMenuItem";
            this.exitNoConfirmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.exitNoConfirmToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitNoConfirmToolStripMenuItem.Text = "Exit No Confirm";
            this.exitNoConfirmToolStripMenuItem.Visible = false;
            this.exitNoConfirmToolStripMenuItem.Click += new System.EventHandler(this.exitNoConfirmToolStripMenuItem_Click);
            // 
            // ImageMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Image_Merge.Properties.Resources.Image_Merge_UI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 609);
            this.Controls.Add(this.enableTextChkBox);
            this.Controls.Add(this.selectDestinationBtn);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.customText);
            this.Controls.Add(this.fontcolorBox);
            this.Controls.Add(this.fontsizeBox);
            this.Controls.Add(this.alignmentBox);
            this.Controls.Add(this.textinputIcon);
            this.Controls.Add(this.fontcolorIcon);
            this.Controls.Add(this.fontIcon);
            this.Controls.Add(this.alignmentIcon);
            this.Controls.Add(this.textoptionIcon);
            this.Controls.Add(this.textoptionLabel);
            this.Controls.Add(this.overlayLabel);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.overlayText);
            this.Controls.Add(this.selectOverlayBtn);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.selectSourceBtn);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 648);
            this.MinimumSize = new System.Drawing.Size(797, 648);
            this.Name = "ImageMerge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Merge";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textoptionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontcolorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textinputIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectSourceBtn;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button selectOverlayBtn;
        private System.Windows.Forms.Button selectDestinationBtn;
        private System.Windows.Forms.TextBox overlayText;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Label overlayLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label textoptionLabel;
        private System.Windows.Forms.PictureBox textoptionIcon;
        private System.Windows.Forms.PictureBox alignmentIcon;
        private System.Windows.Forms.PictureBox fontIcon;
        private System.Windows.Forms.PictureBox fontcolorIcon;
        private System.Windows.Forms.PictureBox textinputIcon;
        private System.Windows.Forms.ComboBox alignmentBox;
        private System.Windows.Forms.ComboBox fontsizeBox;
        private System.Windows.Forms.ComboBox fontcolorBox;
        private System.Windows.Forms.TextBox customText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox enableTextChkBox;
        private System.Windows.Forms.ToolStripMenuItem exitNoConfirmToolStripMenuItem;
    }
}

