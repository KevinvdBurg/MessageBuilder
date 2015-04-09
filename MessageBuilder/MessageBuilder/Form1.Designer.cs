namespace MessageBuilder
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbAllMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(481, 457);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(76, 20);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 457);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(463, 20);
            this.tbMessage.TabIndex = 1;
            // 
            // lbAllMessages
            // 
            this.lbAllMessages.FormattingEnabled = true;
            this.lbAllMessages.Location = new System.Drawing.Point(12, 12);
            this.lbAllMessages.Name = "lbAllMessages";
            this.lbAllMessages.Size = new System.Drawing.Size(545, 433);
            this.lbAllMessages.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 498);
            this.Controls.Add(this.lbAllMessages);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbAllMessages;
    }
}

