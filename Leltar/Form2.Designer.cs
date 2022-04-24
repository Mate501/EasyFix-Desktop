
namespace Leltar
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelCpuId = new System.Windows.Forms.Label();
            this.listBoxHibak = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberInRoom = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPrioritas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxLeiras = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonBugFix = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Számítógép azonosító:";
            // 
            // labelCpuId
            // 
            this.labelCpuId.AutoSize = true;
            this.labelCpuId.Location = new System.Drawing.Point(231, 19);
            this.labelCpuId.Name = "labelCpuId";
            this.labelCpuId.Size = new System.Drawing.Size(19, 25);
            this.labelCpuId.TabIndex = 1;
            this.labelCpuId.Text = "-";
            // 
            // listBoxHibak
            // 
            this.listBoxHibak.FormattingEnabled = true;
            this.listBoxHibak.ItemHeight = 25;
            this.listBoxHibak.Location = new System.Drawing.Point(594, 12);
            this.listBoxHibak.Name = "listBoxHibak";
            this.listBoxHibak.Size = new System.Drawing.Size(372, 429);
            this.listBoxHibak.TabIndex = 2;
            this.listBoxHibak.SelectedIndexChanged += new System.EventHandler(this.listBoxHibak_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Termen belüli sorszám: ";
            // 
            // labelNumberInRoom
            // 
            this.labelNumberInRoom.AutoSize = true;
            this.labelNumberInRoom.Location = new System.Drawing.Point(231, 106);
            this.labelNumberInRoom.Name = "labelNumberInRoom";
            this.labelNumberInRoom.Size = new System.Drawing.Size(19, 25);
            this.labelNumberInRoom.TabIndex = 4;
            this.labelNumberInRoom.Text = "-";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(231, 63);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(19, 25);
            this.labelRoom.TabIndex = 6;
            this.labelRoom.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Terem:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxPrioritas);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBoxLeiras);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxNev);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 365);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiba bejelentés";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Prioritás";
            // 
            // comboBoxPrioritas
            // 
            this.comboBoxPrioritas.FormattingEnabled = true;
            this.comboBoxPrioritas.Location = new System.Drawing.Point(6, 319);
            this.comboBoxPrioritas.Name = "comboBoxPrioritas";
            this.comboBoxPrioritas.Size = new System.Drawing.Size(171, 33);
            this.comboBoxPrioritas.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hiba leírása";
            // 
            // richTextBoxLeiras
            // 
            this.richTextBoxLeiras.Location = new System.Drawing.Point(6, 147);
            this.richTextBoxLeiras.Name = "richTextBoxLeiras";
            this.richTextBoxLeiras.Size = new System.Drawing.Size(545, 126);
            this.richTextBoxLeiras.TabIndex = 4;
            this.richTextBoxLeiras.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bejelentő email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(275, 68);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(276, 31);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(6, 68);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(263, 31);
            this.textBoxNev.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bejelentő neve";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(762, 468);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(204, 34);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Hibák Exportálása";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonBugFix
            // 
            this.buttonBugFix.Enabled = false;
            this.buttonBugFix.Location = new System.Drawing.Point(594, 470);
            this.buttonBugFix.Name = "buttonBugFix";
            this.buttonBugFix.Size = new System.Drawing.Size(162, 32);
            this.buttonBugFix.TabIndex = 9;
            this.buttonBugFix.Text = "Javitas";
            this.buttonBugFix.UseVisualStyleBackColor = true;
            this.buttonBugFix.Click += new System.EventHandler(this.buttonBugFix_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(978, 535);
            this.Controls.Add(this.buttonBugFix);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNumberInRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxHibak);
            this.Controls.Add(this.labelCpuId);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form2";
            this.Text = "Számítógép részletei";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCpuId;
        private System.Windows.Forms.ListBox listBoxHibak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumberInRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxLeiras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPrioritas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonBugFix;
    }
}

