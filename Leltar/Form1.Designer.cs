
namespace Leltar
{
    partial class Form1
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
            this.listBoxTermek = new System.Windows.Forms.ListBox();
            this.panelBal = new System.Windows.Forms.Panel();
            this.panelJobb = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTermek
            // 
            this.listBoxTermek.FormattingEnabled = true;
            this.listBoxTermek.ItemHeight = 25;
            this.listBoxTermek.Location = new System.Drawing.Point(12, 12);
            this.listBoxTermek.Name = "listBoxTermek";
            this.listBoxTermek.Size = new System.Drawing.Size(180, 429);
            this.listBoxTermek.TabIndex = 0;
            this.listBoxTermek.SelectedIndexChanged += new System.EventHandler(this.listBoxTermek_SelectedIndexChanged);
            // 
            // panelBal
            // 
            this.panelBal.Location = new System.Drawing.Point(206, 12);
            this.panelBal.Name = "panelBal";
            this.panelBal.Size = new System.Drawing.Size(350, 350);
            this.panelBal.TabIndex = 1;
            // 
            // panelJobb
            // 
            this.panelJobb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelJobb.Location = new System.Drawing.Point(616, 12);
            this.panelJobb.Name = "panelJobb";
            this.panelJobb.Size = new System.Drawing.Size(350, 350);
            this.panelJobb.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "T";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelJobb);
            this.Controls.Add(this.panelBal);
            this.Controls.Add(this.listBoxTermek);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTermek;
        private System.Windows.Forms.Panel panelBal;
        private System.Windows.Forms.Panel panelJobb;
        private System.Windows.Forms.Button button1;
    }
}

