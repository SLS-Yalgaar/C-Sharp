namespace Yalgaar_DotNet_Client_TestApp
{
    partial class YalgaarWinFormExample
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_MsgSend = new System.Windows.Forms.TextBox();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.txt_Receive = new System.Windows.Forms.TextBox();
            this.txt_UUID = new System.Windows.Forms.TextBox();
            this.txt_Channel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ClientKey = new System.Windows.Forms.TextBox();
            this.btn_Unscuscribe = new System.Windows.Forms.Button();
            this.btn_SubWithPresence = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(52, 147);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(94, 29);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_MsgSend
            // 
            this.txt_MsgSend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MsgSend.Location = new System.Drawing.Point(130, 269);
            this.txt_MsgSend.Name = "txt_MsgSend";
            this.txt_MsgSend.Size = new System.Drawing.Size(205, 25);
            this.txt_MsgSend.TabIndex = 3;
            this.txt_MsgSend.Text = "Hello";
            // 
            // btn_Publish
            // 
            this.btn_Publish.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Publish.Location = new System.Drawing.Point(341, 269);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(86, 26);
            this.btn_Publish.TabIndex = 4;
            this.btn_Publish.Text = "Publish";
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // txt_Receive
            // 
            this.txt_Receive.Location = new System.Drawing.Point(53, 313);
            this.txt_Receive.Multiline = true;
            this.txt_Receive.Name = "txt_Receive";
            this.txt_Receive.Size = new System.Drawing.Size(290, 138);
            this.txt_Receive.TabIndex = 3;
            // 
            // txt_UUID
            // 
            this.txt_UUID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UUID.Location = new System.Drawing.Point(247, 111);
            this.txt_UUID.Name = "txt_UUID";
            this.txt_UUID.Size = new System.Drawing.Size(169, 25);
            this.txt_UUID.TabIndex = 4;
            this.txt_UUID.Text = "YalgaarUUID";
            // 
            // txt_Channel
            // 
            this.txt_Channel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Channel.Location = new System.Drawing.Point(159, 189);
            this.txt_Channel.Name = "txt_Channel";
            this.txt_Channel.Size = new System.Drawing.Size(257, 25);
            this.txt_Channel.TabIndex = 1;
            this.txt_Channel.Text = "YalgaarChannel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "UUID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Channel Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Client Key :";
            // 
            // txt_ClientKey
            // 
            this.txt_ClientKey.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClientKey.Location = new System.Drawing.Point(52, 111);
            this.txt_ClientKey.Name = "txt_ClientKey";
            this.txt_ClientKey.Size = new System.Drawing.Size(161, 25);
            this.txt_ClientKey.TabIndex = 15;
            // 
            // btn_Unscuscribe
            // 
            this.btn_Unscuscribe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unscuscribe.Location = new System.Drawing.Point(154, 225);
            this.btn_Unscuscribe.Name = "btn_Unscuscribe";
            this.btn_Unscuscribe.Size = new System.Drawing.Size(94, 26);
            this.btn_Unscuscribe.TabIndex = 19;
            this.btn_Unscuscribe.Text = "Unsubscribe";
            this.btn_Unscuscribe.UseVisualStyleBackColor = true;
            this.btn_Unscuscribe.Click += new System.EventHandler(this.btn_Unscuscribe_Click);
            // 
            // btn_SubWithPresence
            // 
            this.btn_SubWithPresence.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubWithPresence.Location = new System.Drawing.Point(52, 225);
            this.btn_SubWithPresence.Name = "btn_SubWithPresence";
            this.btn_SubWithPresence.Size = new System.Drawing.Size(94, 26);
            this.btn_SubWithPresence.TabIndex = 23;
            this.btn_SubWithPresence.Text = "Subscribe";
            this.btn_SubWithPresence.UseVisualStyleBackColor = true;
            this.btn_SubWithPresence.Click += new System.EventHandler(this.btn_SubWithPresence_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Yalgaar .Net SDK Example";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(154, 147);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 29);
            this.btnDisconnect.TabIndex = 25;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(348, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Message :";
            // 
            // YalgaarWinFormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_SubWithPresence);
            this.Controls.Add(this.btn_Unscuscribe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ClientKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Channel);
            this.Controls.Add(this.txt_UUID);
            this.Controls.Add(this.txt_Receive);
            this.Controls.Add(this.btn_Publish);
            this.Controls.Add(this.txt_MsgSend);
            this.Controls.Add(this.btn_Connect);
            this.Name = "YalgaarWinFormExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yalgaar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Yalgaar_DotNet_SDK_Test_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_MsgSend;
        private System.Windows.Forms.Button btn_Publish;
        private System.Windows.Forms.TextBox txt_Receive;
        private System.Windows.Forms.TextBox txt_UUID;
        private System.Windows.Forms.TextBox txt_Channel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ClientKey;
        private System.Windows.Forms.Button btn_Unscuscribe;
        private System.Windows.Forms.Button btn_SubWithPresence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
    }
}