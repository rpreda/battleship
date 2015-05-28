namespace ClientGUI
{
    partial class Window
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
            this.ip_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chat_message = new System.Windows.Forms.TextBox();
            this.chat_send = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_text
            // 
            this.ip_text.Location = new System.Drawing.Point(63, 13);
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(132, 20);
            this.ip_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.name_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ip_text);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(63, 40);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(132, 20);
            this.name_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(903, 28);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(289, 412);
            this.chat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(903, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chat:";
            // 
            // chat_message
            // 
            this.chat_message.Location = new System.Drawing.Point(903, 449);
            this.chat_message.Name = "chat_message";
            this.chat_message.Size = new System.Drawing.Size(205, 20);
            this.chat_message.TabIndex = 5;
            // 
            // chat_send
            // 
            this.chat_send.Location = new System.Drawing.Point(1114, 446);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(75, 23);
            this.chat_send.TabIndex = 6;
            this.chat_send.Text = "Send";
            this.chat_send.UseVisualStyleBackColor = true;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "debug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chat_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Window";
            this.Text = "Battleship - Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chat_message;
        private System.Windows.Forms.Button chat_send;
        private System.Windows.Forms.Button button2;
    }
}

