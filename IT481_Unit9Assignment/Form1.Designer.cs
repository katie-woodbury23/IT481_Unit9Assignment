namespace IT481_Unit9Assignment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConnect = new Button();
            btnQuery1 = new Button();
            btnQuery4 = new Button();
            btnQuery2 = new Button();
            btnQuery5 = new Button();
            btnQuery3 = new Button();
            btnQuery6 = new Button();
            tbUser = new TextBox();
            tbServer = new TextBox();
            tbPassword = new TextBox();
            tbDatabase = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 67);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "USER:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 140);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(437, 67);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "SERVER:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(415, 135);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 3;
            label4.Text = "DATABASE:";
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(287, 205);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(226, 31);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "CONNECT";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnQuery1
            // 
            btnQuery1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery1.Location = new Point(12, 297);
            btnQuery1.Name = "btnQuery1";
            btnQuery1.Size = new Size(226, 37);
            btnQuery1.TabIndex = 5;
            btnQuery1.Text = "Get Customer Count";
            btnQuery1.UseVisualStyleBackColor = true;
            btnQuery1.Click += btnQuery1_Click;
            // 
            // btnQuery4
            // 
            btnQuery4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery4.Location = new Point(12, 367);
            btnQuery4.Name = "btnQuery4";
            btnQuery4.Size = new Size(226, 37);
            btnQuery4.TabIndex = 6;
            btnQuery4.Text = "Get Order Ship Names";
            btnQuery4.UseVisualStyleBackColor = true;
            btnQuery4.Click += btnQuery4_Click;
            // 
            // btnQuery2
            // 
            btnQuery2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery2.Location = new Point(290, 297);
            btnQuery2.Name = "btnQuery2";
            btnQuery2.Size = new Size(226, 37);
            btnQuery2.TabIndex = 7;
            btnQuery2.Text = "Get Company Names";
            btnQuery2.UseVisualStyleBackColor = true;
            btnQuery2.Click += btnQuery2_Click;
            // 
            // btnQuery5
            // 
            btnQuery5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery5.Location = new Point(290, 367);
            btnQuery5.Name = "btnQuery5";
            btnQuery5.Size = new Size(226, 37);
            btnQuery5.TabIndex = 8;
            btnQuery5.Text = "Get Employee Count";
            btnQuery5.UseVisualStyleBackColor = true;
            btnQuery5.Click += btnQuery5_Click;
            // 
            // btnQuery3
            // 
            btnQuery3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery3.Location = new Point(562, 297);
            btnQuery3.Name = "btnQuery3";
            btnQuery3.Size = new Size(226, 37);
            btnQuery3.TabIndex = 9;
            btnQuery3.Text = "Get Order Count";
            btnQuery3.UseVisualStyleBackColor = true;
            btnQuery3.Click += btnQuery3_Click;
            // 
            // btnQuery6
            // 
            btnQuery6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery6.Location = new Point(562, 367);
            btnQuery6.Name = "btnQuery6";
            btnQuery6.Size = new Size(226, 37);
            btnQuery6.TabIndex = 10;
            btnQuery6.Text = "Get Employee Names";
            btnQuery6.UseVisualStyleBackColor = true;
            btnQuery6.Click += btnQuery6_Click;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(144, 59);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(229, 29);
            tbUser.TabIndex = 11;
            // 
            // tbServer
            // 
            tbServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbServer.Location = new Point(534, 59);
            tbServer.Name = "tbServer";
            tbServer.Size = new Size(239, 29);
            tbServer.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(144, 132);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(229, 29);
            tbPassword.TabIndex = 13;
            // 
            // tbDatabase
            // 
            tbDatabase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDatabase.Location = new Point(534, 132);
            tbDatabase.Name = "tbDatabase";
            tbDatabase.Size = new Size(239, 29);
            tbDatabase.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDatabase);
            Controls.Add(tbPassword);
            Controls.Add(tbServer);
            Controls.Add(tbUser);
            Controls.Add(btnQuery6);
            Controls.Add(btnQuery3);
            Controls.Add(btnQuery5);
            Controls.Add(btnQuery2);
            Controls.Add(btnQuery4);
            Controls.Add(btnQuery1);
            Controls.Add(btnConnect);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConnect;
        private Button btnQuery1;
        private Button btnQuery4;
        private Button btnQuery2;
        private Button btnQuery5;
        private Button btnQuery3;
        private Button btnQuery6;
        private TextBox tbUser;
        private TextBox tbServer;
        private TextBox tbPassword;
        private TextBox tbDatabase;
    }
}