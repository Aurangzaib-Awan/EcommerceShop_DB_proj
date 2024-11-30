namespace WinFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nameBox = new TextBox();
            passwordBox = new TextBox();
            confBox = new TextBox();
            roleBox = new ComboBox();
            phoneBox = new TextBox();
            addressBox = new TextBox();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 179);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 224);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 268);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 3;
            label3.Text = "Confirm It";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 311);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 4;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 356);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 5;
            label5.Text = "Phone #";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 405);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(157, 176);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(150, 31);
            nameBox.TabIndex = 7;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(157, 221);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(150, 31);
            passwordBox.TabIndex = 8;
            // 
            // confBox
            // 
            confBox.Location = new Point(157, 265);
            confBox.Name = "confBox";
            confBox.Size = new Size(150, 31);
            confBox.TabIndex = 9;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Customer", "Manager", "Admin" });
            roleBox.Location = new Point(157, 311);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(150, 33);
            roleBox.TabIndex = 10;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(157, 356);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(150, 31);
            phoneBox.TabIndex = 11;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(157, 399);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(150, 31);
            addressBox.TabIndex = 12;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(320, 454);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 13;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(454, 512);
            Controls.Add(registerButton);
            Controls.Add(addressBox);
            Controls.Add(phoneBox);
            Controls.Add(roleBox);
            Controls.Add(confBox);
            Controls.Add(passwordBox);
            Controls.Add(nameBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nameBox;
        private TextBox passwordBox;
        private TextBox confBox;
        private ComboBox roleBox;
        private TextBox phoneBox;
        private TextBox addressBox;
        private Button registerButton;
    }
}
