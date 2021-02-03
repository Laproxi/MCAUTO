
namespace MCAUTO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jarList = new System.Windows.Forms.ComboBox();
            this.remainingValue = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.autoSaveIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.ramDropDown = new System.Windows.Forms.ComboBox();
            this.autoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.RichTextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.openJar = new System.Windows.Forms.Button();
            this.openJarDialogue = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.applicationTitle = new System.Windows.Forms.Label();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.versionLabel = new System.Windows.Forms.Label();
            this.creatorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoSaveIntervalBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(3, 373);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(3, 22);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.log.Size = new System.Drawing.Size(470, 270);
            this.log.TabIndex = 1;
            this.log.Text = "";
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.jarList);
            this.panel1.Controls.Add(this.remainingValue);
            this.panel1.Controls.Add(this.restartButton);
            this.panel1.Controls.Add(this.autoSaveIntervalBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.memoryLabel);
            this.panel1.Controls.Add(this.ramDropDown);
            this.panel1.Controls.Add(this.autoSaveCheckBox);
            this.panel1.Controls.Add(this.logLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.commandBox);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.openJar);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 443);
            this.panel1.TabIndex = 2;
            // 
            // jarList
            // 
            this.jarList.BackColor = System.Drawing.Color.Black;
            this.jarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jarList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jarList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jarList.ForeColor = System.Drawing.Color.White;
            this.jarList.FormattingEnabled = true;
            this.jarList.Location = new System.Drawing.Point(69, 337);
            this.jarList.Name = "jarList";
            this.jarList.Size = new System.Drawing.Size(338, 21);
            this.jarList.TabIndex = 15;
            this.jarList.SelectedIndexChanged += new System.EventHandler(this.jarList_SelectedIndexChanged);
            // 
            // remainingValue
            // 
            this.remainingValue.AutoSize = true;
            this.remainingValue.BackColor = System.Drawing.Color.Transparent;
            this.remainingValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remainingValue.Location = new System.Drawing.Point(34, 6);
            this.remainingValue.Name = "remainingValue";
            this.remainingValue.Size = new System.Drawing.Size(257, 13);
            this.remainingValue.TabIndex = 14;
            this.remainingValue.Text = "(Auto Save: Seconds Remaining) Temporary Display.";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Gold;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Location = new System.Drawing.Point(413, 409);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(60, 30);
            this.restartButton.TabIndex = 13;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // autoSaveIntervalBox
            // 
            this.autoSaveIntervalBox.BackColor = System.Drawing.Color.Black;
            this.autoSaveIntervalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autoSaveIntervalBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoSaveIntervalBox.ForeColor = System.Drawing.Color.White;
            this.autoSaveIntervalBox.Location = new System.Drawing.Point(319, 409);
            this.autoSaveIntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoSaveIntervalBox.Name = "autoSaveIntervalBox";
            this.autoSaveIntervalBox.Size = new System.Drawing.Size(88, 16);
            this.autoSaveIntervalBox.TabIndex = 12;
            this.autoSaveIntervalBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.autoSaveIntervalBox.ValueChanged += new System.EventHandler(this.autoSaveIntervalBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(166, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Auto Save Interval (Minutes): ";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(69, 376);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(94, 13);
            this.memoryLabel.TabIndex = 10;
            this.memoryLabel.Text = "Allocated Memory:";
            // 
            // ramDropDown
            // 
            this.ramDropDown.BackColor = System.Drawing.Color.Black;
            this.ramDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ramDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ramDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ramDropDown.ForeColor = System.Drawing.Color.White;
            this.ramDropDown.FormattingEnabled = true;
            this.ramDropDown.Items.AddRange(new object[] {
            "1GB RAM",
            "2GB RAM (64-Bit Java Only)",
            "3GB RAM (64-Bit Java Only)",
            "4GB RAM (64-Bit Java Only)",
            "5GB RAM (64-Bit Java Only)",
            "6GB RAM (64-Bit Java Only)"});
            this.ramDropDown.Location = new System.Drawing.Point(169, 373);
            this.ramDropDown.Name = "ramDropDown";
            this.ramDropDown.Size = new System.Drawing.Size(238, 21);
            this.ramDropDown.TabIndex = 9;
            this.ramDropDown.SelectedIndexChanged += new System.EventHandler(this.ramDropDown_SelectedIndexChanged);
            // 
            // autoSaveCheckBox
            // 
            this.autoSaveCheckBox.AutoSize = true;
            this.autoSaveCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.autoSaveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoSaveCheckBox.Checked = true;
            this.autoSaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSaveCheckBox.Location = new System.Drawing.Point(69, 408);
            this.autoSaveCheckBox.Name = "autoSaveCheckBox";
            this.autoSaveCheckBox.Size = new System.Drawing.Size(79, 17);
            this.autoSaveCheckBox.TabIndex = 8;
            this.autoSaveCheckBox.Text = "Auto Save:";
            this.autoSaveCheckBox.UseVisualStyleBackColor = false;
            this.autoSaveCheckBox.CheckedChanged += new System.EventHandler(this.autoSaveCheckBox_CheckedChanged);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(3, 6);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(25, 13);
            this.logLabel.TabIndex = 3;
            this.logLabel.Text = "Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Command";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.OrangeRed;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(413, 337);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 30);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // commandBox
            // 
            this.commandBox.BackColor = System.Drawing.Color.Black;
            this.commandBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandBox.ForeColor = System.Drawing.Color.White;
            this.commandBox.Location = new System.Drawing.Point(3, 311);
            this.commandBox.Multiline = false;
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(470, 20);
            this.commandBox.TabIndex = 5;
            this.commandBox.Text = "";
            this.commandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(413, 373);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 30);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // openJar
            // 
            this.openJar.BackColor = System.Drawing.Color.DodgerBlue;
            this.openJar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openJar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.openJar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.openJar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.openJar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openJar.ForeColor = System.Drawing.Color.White;
            this.openJar.Location = new System.Drawing.Point(3, 337);
            this.openJar.Name = "openJar";
            this.openJar.Size = new System.Drawing.Size(60, 30);
            this.openJar.TabIndex = 2;
            this.openJar.Text = "Open Jar";
            this.openJar.UseVisualStyleBackColor = false;
            this.openJar.Click += new System.EventHandler(this.openJar_Click);
            // 
            // openJarDialogue
            // 
            this.openJarDialogue.DefaultExt = "jar";
            this.openJarDialogue.Filter = "Jar Files|*.jar";
            this.openJarDialogue.Tag = "";
            this.openJarDialogue.Title = "Open Jar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.applicationTitle);
            this.panel2.Controls.Add(this.minimiseButton);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 26);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // applicationTitle
            // 
            this.applicationTitle.AutoSize = true;
            this.applicationTitle.Location = new System.Drawing.Point(3, 7);
            this.applicationTitle.Name = "applicationTitle";
            this.applicationTitle.Size = new System.Drawing.Size(48, 13);
            this.applicationTitle.TabIndex = 2;
            this.applicationTitle.Text = "MC Auto";
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.minimiseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimiseButton.BackgroundImage")));
            this.minimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiseButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.minimiseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.minimiseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.ForeColor = System.Drawing.Color.White;
            this.minimiseButton.Location = new System.Drawing.Point(451, 12);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(20, 11);
            this.minimiseButton.TabIndex = 1;
            this.minimiseButton.TabStop = false;
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(477, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // autoSaveTimer
            // 
            this.autoSaveTimer.Interval = 600000;
            this.autoSaveTimer.Tick += new System.EventHandler(this.autoSaveTimer_Tick);
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(425, 478);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.versionLabel.Size = new System.Drawing.Size(63, 13);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "0.0.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // creatorLinkLabel
            // 
            this.creatorLinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.creatorLinkLabel.AutoSize = true;
            this.creatorLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.creatorLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatorLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorLinkLabel.ForeColor = System.Drawing.Color.White;
            this.creatorLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.creatorLinkLabel.LinkColor = System.Drawing.Color.White;
            this.creatorLinkLabel.Location = new System.Drawing.Point(12, 478);
            this.creatorLinkLabel.Name = "creatorLinkLabel";
            this.creatorLinkLabel.Size = new System.Drawing.Size(111, 13);
            this.creatorLinkLabel.TabIndex = 7;
            this.creatorLinkLabel.TabStop = true;
            this.creatorLinkLabel.Text = "Developed by Laprox.";
            this.creatorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creatorLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.creatorLinkLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "MC Auto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoSaveIntervalBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button openJar;
        private System.Windows.Forms.OpenFileDialog openJarDialogue;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.RichTextBox commandBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Label applicationTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel creatorLinkLabel;
        private System.Windows.Forms.CheckBox autoSaveCheckBox;
        private System.Windows.Forms.ComboBox ramDropDown;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.NumericUpDown autoSaveIntervalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label remainingValue;
        private System.Windows.Forms.ComboBox jarList;
    }
}

