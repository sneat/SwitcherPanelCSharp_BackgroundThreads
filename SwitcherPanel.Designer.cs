namespace SwitcherPanelCSharp
{
    partial class SwitcherPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSwitcherName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPreviewSel = new System.Windows.Forms.ComboBox();
            this.comboBoxProgramSel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.textBoxTransFramesRemaining = new System.Windows.Forms.TextBox();
            this.trackBarTransitionPos = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransitionPos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Switcher IP address:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(122, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(140, 20);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "192.168.10.240";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(268, 10);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Switcher Name:";
            // 
            // textBoxSwitcherName
            // 
            this.textBoxSwitcherName.Location = new System.Drawing.Point(122, 38);
            this.textBoxSwitcherName.Name = "textBoxSwitcherName";
            this.textBoxSwitcherName.ReadOnly = true;
            this.textBoxSwitcherName.Size = new System.Drawing.Size(221, 20);
            this.textBoxSwitcherName.TabIndex = 4;
            this.textBoxSwitcherName.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarTransitionPos);
            this.groupBox1.Controls.Add(this.textBoxTransFramesRemaining);
            this.groupBox1.Controls.Add(this.buttonCut);
            this.groupBox1.Controls.Add(this.buttonAuto);
            this.groupBox1.Controls.Add(this.comboBoxPreviewSel);
            this.groupBox1.Controls.Add(this.comboBoxProgramSel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mix Effect Block 1";
            // 
            // comboBoxPreviewSel
            // 
            this.comboBoxPreviewSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreviewSel.FormattingEnabled = true;
            this.comboBoxPreviewSel.Location = new System.Drawing.Point(61, 44);
            this.comboBoxPreviewSel.Name = "comboBoxPreviewSel";
            this.comboBoxPreviewSel.Size = new System.Drawing.Size(167, 21);
            this.comboBoxPreviewSel.TabIndex = 3;
            this.comboBoxPreviewSel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPreviewSel_SelectedIndexChanged);
            // 
            // comboBoxProgramSel
            // 
            this.comboBoxProgramSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgramSel.FormattingEnabled = true;
            this.comboBoxProgramSel.Location = new System.Drawing.Point(61, 17);
            this.comboBoxProgramSel.Name = "comboBoxProgramSel";
            this.comboBoxProgramSel.Size = new System.Drawing.Size(167, 21);
            this.comboBoxProgramSel.TabIndex = 2;
            this.comboBoxProgramSel.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgramSel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Preview:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Program:";
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(72, 71);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonAuto.TabIndex = 4;
            this.buttonAuto.Text = "Auto";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.Location = new System.Drawing.Point(153, 71);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(75, 23);
            this.buttonCut.TabIndex = 5;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // textBoxTransFramesRemaining
            // 
            this.textBoxTransFramesRemaining.Location = new System.Drawing.Point(9, 73);
            this.textBoxTransFramesRemaining.Name = "textBoxTransFramesRemaining";
            this.textBoxTransFramesRemaining.ReadOnly = true;
            this.textBoxTransFramesRemaining.Size = new System.Drawing.Size(57, 20);
            this.textBoxTransFramesRemaining.TabIndex = 6;
            this.textBoxTransFramesRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBarTransitionPos
            // 
            this.trackBarTransitionPos.Location = new System.Drawing.Point(283, 17);
            this.trackBarTransitionPos.Maximum = 100;
            this.trackBarTransitionPos.Name = "trackBarTransitionPos";
            this.trackBarTransitionPos.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTransitionPos.Size = new System.Drawing.Size(42, 159);
            this.trackBarTransitionPos.TabIndex = 7;
            this.trackBarTransitionPos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTransitionPos.Scroll += new System.EventHandler(this.trackBarTransitionPos_Scroll);
            // 
            // SwitcherPanel
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSwitcherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "SwitcherPanel";
            this.Text = "Switcher Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransitionPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSwitcherName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPreviewSel;
        private System.Windows.Forms.ComboBox comboBoxProgramSel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.TextBox textBoxTransFramesRemaining;
        private System.Windows.Forms.TrackBar trackBarTransitionPos;
    }
}

