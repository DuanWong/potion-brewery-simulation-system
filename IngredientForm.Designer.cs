namespace PotionBrewerySystem
{
    partial class IngredientForm
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
            dataGridView1 = new DataGridView();
            lblName = new Label();
            txtName = new TextBox();
            lblStock = new Label();
            numStock = new NumericUpDown();
            lblThreshold = new Label();
            numThreshold = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThreshold).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(413, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(157, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(205, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(157, 69);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(88, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock Quantity:";
            // 
            // numStock
            // 
            numStock.Location = new Point(252, 66);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 4;
            // 
            // lblThreshold
            // 
            lblThreshold.AutoSize = true;
            lblThreshold.Location = new Point(407, 71);
            lblThreshold.Name = "lblThreshold";
            lblThreshold.Size = new Size(86, 15);
            lblThreshold.TabIndex = 5;
            lblThreshold.Text = "Min Threshold:";
            // 
            // numThreshold
            // 
            numThreshold.Location = new Point(510, 69);
            numThreshold.Name = "numThreshold";
            numThreshold.Size = new Size(120, 23);
            numThreshold.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(162, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(278, 107);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(585, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // IngredientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(numThreshold);
            Controls.Add(lblThreshold);
            Controls.Add(numStock);
            Controls.Add(lblStock);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dataGridView1);
            Name = "IngredientForm";
            Text = "Ingredient Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThreshold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblName;
        private TextBox txtName;
        private Label lblStock;
        private NumericUpDown numStock;
        private Label lblThreshold;
        private NumericUpDown numThreshold;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
