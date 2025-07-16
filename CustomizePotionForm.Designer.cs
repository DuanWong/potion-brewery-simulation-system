namespace PotionBrewerySystem
{
    partial class CustomizePotionForm
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
            label2 = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            comboPotionList = new ComboBox();
            txtNewName = new TextBox();
            txtNewAttributes = new TextBox();
            lblStatus = new Label();
            gridBrewedPotions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridBrewedPotions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 35);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose your potion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 129);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Attribute:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(62, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // comboPotionList
            // 
            comboPotionList.FormattingEnabled = true;
            comboPotionList.Location = new Point(179, 32);
            comboPotionList.Name = "comboPotionList";
            comboPotionList.Size = new Size(121, 23);
            comboPotionList.TabIndex = 4;
            comboPotionList.SelectedIndexChanged += comboPotionList_SelectedIndexChanged;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(142, 80);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(100, 23);
            txtNewName.TabIndex = 5;
            // 
            // txtNewAttributes
            // 
            txtNewAttributes.Location = new Point(142, 126);
            txtNewAttributes.Multiline = true;
            txtNewAttributes.Name = "txtNewAttributes";
            txtNewAttributes.Size = new Size(303, 23);
            txtNewAttributes.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.Info;
            lblStatus.Location = new Point(62, 215);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(106, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Create your potion";
            // 
            // gridBrewedPotions
            // 
            gridBrewedPotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBrewedPotions.Location = new Point(65, 268);
            gridBrewedPotions.Name = "gridBrewedPotions";
            gridBrewedPotions.Size = new Size(561, 150);
            gridBrewedPotions.TabIndex = 8;
            // 
            // CustomizePotionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(gridBrewedPotions);
            Controls.Add(lblStatus);
            Controls.Add(txtNewAttributes);
            Controls.Add(txtNewName);
            Controls.Add(comboPotionList);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomizePotionForm";
            Text = "Creative Potion Customization";
            ((System.ComponentModel.ISupportInitialize)gridBrewedPotions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnUpdate;
        private ComboBox comboPotionList;
        private TextBox txtNewName;
        private TextBox txtNewAttributes;
        private Label lblStatus;
        private DataGridView gridBrewedPotions;
    }
}