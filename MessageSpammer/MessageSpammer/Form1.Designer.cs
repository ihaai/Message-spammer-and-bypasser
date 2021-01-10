
namespace MessageSpammer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.MessageSelectInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageSelectOutput = new System.Windows.Forms.TextBox();
            this.Set1 = new System.Windows.Forms.Button();
            this.SpammerButton = new System.Windows.Forms.Button();
            this.spammertimer = new System.Windows.Forms.Timer(this.components);
            this.MessageBypassInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MessageBypassOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Set2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message to spam:";
            // 
            // MessageSelectInput
            // 
            this.MessageSelectInput.Location = new System.Drawing.Point(131, 24);
            this.MessageSelectInput.Name = "MessageSelectInput";
            this.MessageSelectInput.Size = new System.Drawing.Size(182, 20);
            this.MessageSelectInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message to spam set to:";
            // 
            // MessageSelectOutput
            // 
            this.MessageSelectOutput.Enabled = false;
            this.MessageSelectOutput.Location = new System.Drawing.Point(167, 51);
            this.MessageSelectOutput.Name = "MessageSelectOutput";
            this.MessageSelectOutput.Size = new System.Drawing.Size(182, 20);
            this.MessageSelectOutput.TabIndex = 3;
            // 
            // Set1
            // 
            this.Set1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set1.Location = new System.Drawing.Point(325, 23);
            this.Set1.Name = "Set1";
            this.Set1.Size = new System.Drawing.Size(75, 21);
            this.Set1.TabIndex = 4;
            this.Set1.Text = "Set";
            this.Set1.UseVisualStyleBackColor = true;
            this.Set1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpammerButton
            // 
            this.SpammerButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpammerButton.Location = new System.Drawing.Point(16, 83);
            this.SpammerButton.Name = "SpammerButton";
            this.SpammerButton.Size = new System.Drawing.Size(75, 21);
            this.SpammerButton.TabIndex = 6;
            this.SpammerButton.Text = "Turn on";
            this.SpammerButton.UseVisualStyleBackColor = true;
            this.SpammerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // spammertimer
            // 
            this.spammertimer.Tick += new System.EventHandler(this.spammertimer_Tick);
            // 
            // MessageBypassInput
            // 
            this.MessageBypassInput.Location = new System.Drawing.Point(140, 165);
            this.MessageBypassInput.Name = "MessageBypassInput";
            this.MessageBypassInput.Size = new System.Drawing.Size(182, 20);
            this.MessageBypassInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message to bypass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Roblox chat bypasser ( Replaces letters with unicode ones )";
            // 
            // MessageBypassOutput
            // 
            this.MessageBypassOutput.Location = new System.Drawing.Point(171, 195);
            this.MessageBypassOutput.Name = "MessageBypassOutput";
            this.MessageBypassOutput.ReadOnly = true;
            this.MessageBypassOutput.Size = new System.Drawing.Size(182, 20);
            this.MessageBypassOutput.TabIndex = 12;
            this.MessageBypassOutput.Click += new System.EventHandler(this.MessageBypassOutput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Message to bypass set to:";
            // 
            // Set2
            // 
            this.Set2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set2.Location = new System.Drawing.Point(336, 164);
            this.Set2.Name = "Set2";
            this.Set2.Size = new System.Drawing.Size(75, 21);
            this.Set2.TabIndex = 13;
            this.Set2.Text = "Set";
            this.Set2.UseVisualStyleBackColor = true;
            this.Set2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Click on the text to copy it!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "YeeHay#8729";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Press F6 to send the message!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "If you want to spam the message spam F6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 276);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Set2);
            this.Controls.Add(this.MessageBypassOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageBypassInput);
            this.Controls.Add(this.SpammerButton);
            this.Controls.Add(this.Set1);
            this.Controls.Add(this.MessageSelectOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessageSelectInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Message Spammer and Roblox Chat Bypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessageSelectInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessageSelectOutput;
        private System.Windows.Forms.Button Set1;
        private System.Windows.Forms.Button SpammerButton;
        private System.Windows.Forms.Timer spammertimer;
        private System.Windows.Forms.TextBox MessageBypassInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MessageBypassOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Set2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

