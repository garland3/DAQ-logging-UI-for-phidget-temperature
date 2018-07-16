namespace TemperatureSensor_Example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempTxt = new System.Windows.Forms.TextBox();
            this.thermocoupletypeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtdTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtdWireSetupCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataIntervalTrk = new PhidgetsControlLibrary.CustomScroll();
            this.changeTriggerTrk = new PhidgetsControlLibrary.CustomScroll();
            this.phidgetInfoBox1 = new Phidget22.ExampleUtils.PhidgetInfoBox();
            this.button5 = new System.Windows.Forms.Button();
            this.outputBox.SuspendLayout();
            this.settingsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Controls.Add(this.label3);
            this.outputBox.Controls.Add(this.tempTxt);
            this.outputBox.Location = new System.Drawing.Point(329, 15);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(176, 39);
            this.outputBox.TabIndex = 98;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "Data";
            this.outputBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Temperature:";
            // 
            // tempTxt
            // 
            this.tempTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempTxt.Location = new System.Drawing.Point(82, 16);
            this.tempTxt.Name = "tempTxt";
            this.tempTxt.ReadOnly = true;
            this.tempTxt.Size = new System.Drawing.Size(75, 13);
            this.tempTxt.TabIndex = 0;
            this.tempTxt.TabStop = false;
            this.tempTxt.Text = "???";
            // 
            // thermocoupletypeCombo
            // 
            this.thermocoupletypeCombo.DisplayMember = "Value";
            this.thermocoupletypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thermocoupletypeCombo.FormattingEnabled = true;
            this.thermocoupletypeCombo.Location = new System.Drawing.Point(116, 19);
            this.thermocoupletypeCombo.Name = "thermocoupletypeCombo";
            this.thermocoupletypeCombo.Size = new System.Drawing.Size(148, 21);
            this.thermocoupletypeCombo.TabIndex = 0;
            this.thermocoupletypeCombo.ValueMember = "Key";
            this.thermocoupletypeCombo.SelectedIndexChanged += new System.EventHandler(this.thermocoupletypeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thermocouple Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rtdTypeCombo
            // 
            this.rtdTypeCombo.DisplayMember = "Value";
            this.rtdTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rtdTypeCombo.FormattingEnabled = true;
            this.rtdTypeCombo.Location = new System.Drawing.Point(116, 46);
            this.rtdTypeCombo.Name = "rtdTypeCombo";
            this.rtdTypeCombo.Size = new System.Drawing.Size(148, 21);
            this.rtdTypeCombo.TabIndex = 0;
            this.rtdTypeCombo.ValueMember = "Key";
            this.rtdTypeCombo.SelectedIndexChanged += new System.EventHandler(this.rtdTypeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RTD Type:";
            // 
            // rtdWireSetupCombo
            // 
            this.rtdWireSetupCombo.DisplayMember = "Value";
            this.rtdWireSetupCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rtdWireSetupCombo.FormattingEnabled = true;
            this.rtdWireSetupCombo.Location = new System.Drawing.Point(116, 73);
            this.rtdWireSetupCombo.Name = "rtdWireSetupCombo";
            this.rtdWireSetupCombo.Size = new System.Drawing.Size(148, 21);
            this.rtdWireSetupCombo.TabIndex = 0;
            this.rtdWireSetupCombo.ValueMember = "Key";
            this.rtdWireSetupCombo.SelectedIndexChanged += new System.EventHandler(this.rtdWireSetupCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RTD Wire Setup:";
            // 
            // settingsBox
            // 
            this.settingsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsBox.Controls.Add(this.rtdWireSetupCombo);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.thermocoupletypeCombo);
            this.settingsBox.Controls.Add(this.label4);
            this.settingsBox.Controls.Add(this.rtdTypeCombo);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Location = new System.Drawing.Point(12, 406);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(287, 112);
            this.settingsBox.TabIndex = 101;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            this.settingsBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "Select Output Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 104;
            this.button2.Text = "Start Recording Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 105;
            this.button3.Text = "Stop Recording Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 143);
            this.richTextBox1.TabIndex = 106;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 109;
            this.button4.Text = "Clear Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 138);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logging";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(329, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 111;
            this.checkBox1.Text = "Show Advanced Info";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataIntervalTrk
            // 
            this.dataIntervalTrk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataIntervalTrk.isIntValue = true;
            this.dataIntervalTrk.labelTxt = "Data Interval:";
            this.dataIntervalTrk.Location = new System.Drawing.Point(302, 415);
            this.dataIntervalTrk.Maximum = -1D;
            this.dataIntervalTrk.maxTxt = "max";
            this.dataIntervalTrk.Minimum = -1D;
            this.dataIntervalTrk.minTxt = "min";
            this.dataIntervalTrk.Name = "dataIntervalTrk";
            this.dataIntervalTrk.Size = new System.Drawing.Size(273, 37);
            this.dataIntervalTrk.TabIndex = 108;
            this.dataIntervalTrk.trkText = "-1";
            this.dataIntervalTrk.Unit = "";
            this.dataIntervalTrk.Value = -1D;
            this.dataIntervalTrk.Visible = false;
            this.dataIntervalTrk.LogScroll += new System.EventHandler(this.dataInvertalTrk_LogScroll);
            this.dataIntervalTrk.LogMouseUp += new System.Windows.Forms.MouseEventHandler(this.dataInvertalTrk_LogMouseUp);
            // 
            // changeTriggerTrk
            // 
            this.changeTriggerTrk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeTriggerTrk.isIntValue = false;
            this.changeTriggerTrk.labelTxt = "Change Trigger:";
            this.changeTriggerTrk.Location = new System.Drawing.Point(302, 458);
            this.changeTriggerTrk.Maximum = -1D;
            this.changeTriggerTrk.maxTxt = "max";
            this.changeTriggerTrk.Minimum = -1D;
            this.changeTriggerTrk.minTxt = "min";
            this.changeTriggerTrk.Name = "changeTriggerTrk";
            this.changeTriggerTrk.Size = new System.Drawing.Size(270, 35);
            this.changeTriggerTrk.TabIndex = 107;
            this.changeTriggerTrk.trkText = "-1.000";
            this.changeTriggerTrk.Unit = "";
            this.changeTriggerTrk.Value = -1D;
            this.changeTriggerTrk.Visible = false;
            this.changeTriggerTrk.LogScroll += new System.EventHandler(this.changeTriggerCustom_LogScroll);
            this.changeTriggerTrk.LogMouseUp += new System.Windows.Forms.MouseEventHandler(this.changeTriggerCustom_LogMouseUp);
            // 
            // phidgetInfoBox1
            // 
            this.phidgetInfoBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phidgetInfoBox1.Location = new System.Drawing.Point(12, 316);
            this.phidgetInfoBox1.MinimumSize = new System.Drawing.Size(396, 84);
            this.phidgetInfoBox1.Name = "phidgetInfoBox1";
            this.phidgetInfoBox1.Size = new System.Drawing.Size(493, 84);
            this.phidgetInfoBox1.TabIndex = 102;
            this.phidgetInfoBox1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 23);
            this.button5.TabIndex = 110;
            this.button5.Text = "Save Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(517, 589);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataIntervalTrk);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.changeTriggerTrk);
            this.Controls.Add(this.phidgetInfoBox1);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.outputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 634);
            this.MinimumSize = new System.Drawing.Size(533, 375);
            this.Name = "Form1";
            this.Text = "Temperature Sensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outputBox.ResumeLayout(false);
            this.outputBox.PerformLayout();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.ComboBox thermocoupletypeCombo;
        private Phidget22.ExampleUtils.PhidgetInfoBox phidgetInfoBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tempTxt;
        private System.Windows.Forms.Label label4;
        private PhidgetsControlLibrary.CustomScroll changeTriggerTrk;
        private PhidgetsControlLibrary.CustomScroll dataIntervalTrk;
        private System.Windows.Forms.ComboBox rtdTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rtdWireSetupCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
    }
}

