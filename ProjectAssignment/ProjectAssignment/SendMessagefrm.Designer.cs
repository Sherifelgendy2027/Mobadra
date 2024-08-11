namespace ProjectAssignment
{
    partial class SendMessagefrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjecttextBox = new System.Windows.Forms.TextBox();
            this.Msgbodytxt = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.usersListbox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // SubjecttextBox
            // 
            this.SubjecttextBox.Location = new System.Drawing.Point(284, 23);
            this.SubjecttextBox.Multiline = true;
            this.SubjecttextBox.Name = "SubjecttextBox";
            this.SubjecttextBox.Size = new System.Drawing.Size(254, 30);
            this.SubjecttextBox.TabIndex = 3;
            // 
            // Msgbodytxt
            // 
            this.Msgbodytxt.Location = new System.Drawing.Point(117, 132);
            this.Msgbodytxt.Multiline = true;
            this.Msgbodytxt.Name = "Msgbodytxt";
            this.Msgbodytxt.Size = new System.Drawing.Size(480, 235);
            this.Msgbodytxt.TabIndex = 4;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(536, 415);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 6;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // usersListbox
            // 
            this.usersListbox.FormattingEnabled = true;
            this.usersListbox.Location = new System.Drawing.Point(683, 150);
            this.usersListbox.Name = "usersListbox";
            this.usersListbox.Size = new System.Drawing.Size(120, 94);
            this.usersListbox.TabIndex = 7;
            // 
            // SendMessagefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersListbox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.Msgbodytxt);
            this.Controls.Add(this.SubjecttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SendMessagefrm";
            this.Text = "SendMessagefrm";
            this.Load += new System.EventHandler(this.SendMessagefrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjecttextBox;
        private System.Windows.Forms.TextBox Msgbodytxt;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.CheckedListBox usersListbox;
    }
}