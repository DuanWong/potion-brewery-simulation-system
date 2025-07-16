namespace PotionBrewerySystem
{
    partial class PotionBrewingForm
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
            btnCheckStock = new Button();
            label1 = new Label();
            comboRecipe = new ComboBox();
            gridIngredients = new DataGridView();
            label2 = new Label();
            btnBrew = new Button();
            label3 = new Label();
            progressBrew = new ProgressBar();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)gridIngredients).BeginInit();
            SuspendLayout();
            // 
            // btnCheckStock
            // 
            btnCheckStock.Location = new Point(72, 288);
            btnCheckStock.Name = "btnCheckStock";
            btnCheckStock.Size = new Size(119, 23);
            btnCheckStock.TabIndex = 0;
            btnCheckStock.Text = "Check Availability";
            btnCheckStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Recipe:";
            // 
            // comboRecipe
            // 
            comboRecipe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRecipe.FormattingEnabled = true;
            comboRecipe.Location = new Point(149, 39);
            comboRecipe.Name = "comboRecipe";
            comboRecipe.Size = new Size(121, 23);
            comboRecipe.TabIndex = 2;
            comboRecipe.SelectedIndexChanged += comboRecipe_SelectedIndexChanged;
            // 
            // gridIngredients
            // 
            gridIngredients.AllowUserToAddRows = false;
            gridIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridIngredients.Location = new Point(72, 114);
            gridIngredients.Name = "gridIngredients";
            gridIngredients.ReadOnly = true;
            gridIngredients.Size = new Size(394, 150);
            gridIngredients.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 82);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingredients Required:";
            // 
            // btnBrew
            // 
            btnBrew.Enabled = false;
            btnBrew.Location = new Point(216, 288);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(96, 23);
            btnBrew.TabIndex = 5;
            btnBrew.Text = "Brew Potion";
            btnBrew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 323);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Brewing Progress:";
            // 
            // progressBrew
            // 
            progressBrew.Location = new Point(74, 351);
            progressBrew.Name = "progressBrew";
            progressBrew.Size = new Size(235, 23);
            progressBrew.Step = 1;
            progressBrew.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(76, 386);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Please select a recipe.";
            // 
            // PotionBrewingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(progressBrew);
            Controls.Add(label3);
            Controls.Add(btnBrew);
            Controls.Add(label2);
            Controls.Add(gridIngredients);
            Controls.Add(comboRecipe);
            Controls.Add(label1);
            Controls.Add(btnCheckStock);
            Name = "PotionBrewingForm";
            Text = "Brewing Potion";
            ((System.ComponentModel.ISupportInitialize)gridIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckStock;
        private Label label1;
        private ComboBox comboRecipe;
        private DataGridView gridIngredients;
        private Label label2;
        private Button btnBrew;
        private Label label3;
        private ProgressBar progressBrew;
        private Label lblStatus;
    }
}