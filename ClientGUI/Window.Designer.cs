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
            this.room_request = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.owner_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playernr_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_text
            // 
            this.ip_text.Location = new System.Drawing.Point(94, 20);
            this.ip_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(196, 26);
            this.ip_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(302, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(94, 62);
            this.name_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(196, 26);
            this.name_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(956, 48);
            this.chat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(432, 632);
            this.chat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chat:";
            // 
            // chat_message
            // 
            this.chat_message.Location = new System.Drawing.Point(956, 695);
            this.chat_message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chat_message.Name = "chat_message";
            this.chat_message.Size = new System.Drawing.Size(306, 26);
            this.chat_message.TabIndex = 5;
            // 
            // chat_send
            // 
            this.chat_send.Location = new System.Drawing.Point(1272, 691);
            this.chat_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(112, 35);
            this.chat_send.TabIndex = 6;
            this.chat_send.Text = "Send";
            this.chat_send.UseVisualStyleBackColor = true;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 963);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "debug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // room_request
            // 
            this.room_request.Location = new System.Drawing.Point(18, 200);
            this.room_request.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.room_request.Name = "room_request";
            this.room_request.Size = new System.Drawing.Size(292, 35);
            this.room_request.TabIndex = 8;
            this.room_request.Text = "Refresh rooms";
            this.room_request.UseVisualStyleBackColor = true;
            this.room_request.Click += new System.EventHandler(this.room_request_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 242);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Create Room";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.owner_column,
            this.room_id,
            this.playernr_column});
            this.listView1.Location = new System.Drawing.Point(338, 29);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 692);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // owner_column
            // 
            this.owner_column.Text = "Owner";
            this.owner_column.Width = 163;
            // 
            // room_id
            // 
            this.room_id.Text = "room_id";
            this.room_id.Width = 184;
            // 
            // playernr_column
            // 
            this.playernr_column.Text = "Players";
            this.playernr_column.Width = 206;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(293, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete room";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(293, 35);
            this.button6.TabIndex = 13;
            this.button6.Text = "Join Room";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 764);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.room_request);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chat_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button room_request;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader owner_column;
        public System.Windows.Forms.ColumnHeader room_id;
        public System.Windows.Forms.ColumnHeader playernr_column;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}

