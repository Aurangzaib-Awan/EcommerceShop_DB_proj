namespace WinFormsApp1
{
    partial class Order_Tracking
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Track Your Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, Date, Status, Cost });
            dataGridView1.Location = new Point(25, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 155);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 8;
            OrderID.Name = "OrderID";
            OrderID.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 8;
            Cost.Name = "Cost";
            Cost.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 336);
            label2.Name = "label2";
            label2.Size = new Size(427, 25);
            label2.TabIndex = 2;
            label2.Text = "For issues contact us at ecommerce@gmail.com .";
            // 
            // Order_Tracking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Order_Tracking";
            Text = "Order_Tracking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Cost;
        private Label label2;
    }
}
