namespace InheritanceDistributionOfSweets
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
            buttonRefill = new Button();
            buttonGet = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            SuspendLayout();
            // 
            // buttonRefill
            // 
            buttonRefill.Location = new Point(96, 34);
            buttonRefill.Name = "buttonRefill";
            buttonRefill.Size = new Size(466, 34);
            buttonRefill.TabIndex = 0;
            buttonRefill.Text = "Перезаполнить";
            buttonRefill.UseVisualStyleBackColor = true;
            buttonRefill.Click += buttonRefill_Click;
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(476, 143);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(86, 144);
            buttonGet.TabIndex = 1;
            buttonGet.Text = "Взять";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(96, 74);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(466, 63);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(96, 143);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(374, 144);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(buttonGet);
            Controls.Add(buttonRefill);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRefill;
        private Button buttonGet;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
    }
}
