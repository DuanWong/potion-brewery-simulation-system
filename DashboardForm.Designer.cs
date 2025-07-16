namespace PotionBrewerySystem
{
    partial class DashboardForm
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
            lblMostBrewedPotion = new Label();
            lblMostUsedIngredient = new Label();
            lblBrewedInRange = new Label();
            dateStart = new DateTimePicker();
            dateEnd = new DateTimePicker();
            btnGetCountInRange = new Button();
            btnOpenCustomization = new Button();
            btnOpenIngredient = new Button();
            btnOpenRecipe = new Button();
            btnOpenBrew = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblMostBrewedPotion
            // 
            lblMostBrewedPotion.AutoSize = true;
            lblMostBrewedPotion.Location = new Point(167, 38);
            lblMostBrewedPotion.Name = "lblMostBrewedPotion";
            lblMostBrewedPotion.Size = new Size(16, 15);
            lblMostBrewedPotion.TabIndex = 0;
            lblMostBrewedPotion.Text = "...";
            // 
            // lblMostUsedIngredient
            // 
            lblMostUsedIngredient.AutoSize = true;
            lblMostUsedIngredient.Location = new Point(168, 80);
            lblMostUsedIngredient.Name = "lblMostUsedIngredient";
            lblMostUsedIngredient.Size = new Size(16, 15);
            lblMostUsedIngredient.TabIndex = 1;
            lblMostUsedIngredient.Text = "...";
            // 
            // lblBrewedInRange
            // 
            lblBrewedInRange.AutoSize = true;
            lblBrewedInRange.Location = new Point(168, 127);
            lblBrewedInRange.Name = "lblBrewedInRange";
            lblBrewedInRange.Size = new Size(16, 15);
            lblBrewedInRange.TabIndex = 2;
            lblBrewedInRange.Text = "...";
            // 
            // dateStart
            // 
            dateStart.Location = new Point(122, 163);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 23);
            dateStart.TabIndex = 3;
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(122, 210);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(200, 23);
            dateEnd.TabIndex = 4;
            // 
            // btnGetCountInRange
            // 
            btnGetCountInRange.Location = new Point(122, 256);
            btnGetCountInRange.Name = "btnGetCountInRange";
            btnGetCountInRange.Size = new Size(75, 23);
            btnGetCountInRange.TabIndex = 5;
            btnGetCountInRange.Text = "Count";
            btnGetCountInRange.UseVisualStyleBackColor = true;
            btnGetCountInRange.Click += btnGetCountInRange_Click;
            // 
            // btnOpenCustomization
            // 
            btnOpenCustomization.Location = new Point(500, 201);
            btnOpenCustomization.Name = "btnOpenCustomization";
            btnOpenCustomization.Size = new Size(160, 23);
            btnOpenCustomization.TabIndex = 6;
            btnOpenCustomization.Text = "Customize Brewed Potions";
            btnOpenCustomization.UseVisualStyleBackColor = true;
            btnOpenCustomization.Click += btnOpenCustomization_Click;
            // 
            // btnOpenIngredient
            // 
            btnOpenIngredient.Location = new Point(502, 34);
            btnOpenIngredient.Name = "btnOpenIngredient";
            btnOpenIngredient.Size = new Size(158, 23);
            btnOpenIngredient.TabIndex = 7;
            btnOpenIngredient.Text = "Ingredient Management";
            btnOpenIngredient.UseVisualStyleBackColor = true;
            btnOpenIngredient.Click += btnOpenIngredient_Click;
            // 
            // btnOpenRecipe
            // 
            btnOpenRecipe.Location = new Point(502, 88);
            btnOpenRecipe.Name = "btnOpenRecipe";
            btnOpenRecipe.Size = new Size(158, 23);
            btnOpenRecipe.TabIndex = 8;
            btnOpenRecipe.Text = "Recipe Management";
            btnOpenRecipe.UseVisualStyleBackColor = true;
            btnOpenRecipe.Click += btnOpenRecipe_Click;
            // 
            // btnOpenBrew
            // 
            btnOpenBrew.Location = new Point(502, 142);
            btnOpenBrew.Name = "btnOpenBrew";
            btnOpenBrew.Size = new Size(158, 23);
            btnOpenBrew.TabIndex = 9;
            btnOpenBrew.Text = "Brewing Potion";
            btnOpenBrew.UseVisualStyleBackColor = true;
            btnOpenBrew.Click += btnOpenBrew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 10;
            label1.Text = "Most Brewed Potion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 11;
            label2.Text = "Most Used Ingredient:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 127);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 12;
            label3.Text = "Brewed quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 166);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 13;
            label4.Text = "FROM:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 216);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 14;
            label5.Text = "TO:";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenBrew);
            Controls.Add(btnOpenRecipe);
            Controls.Add(btnOpenIngredient);
            Controls.Add(btnOpenCustomization);
            Controls.Add(btnGetCountInRange);
            Controls.Add(dateEnd);
            Controls.Add(dateStart);
            Controls.Add(lblBrewedInRange);
            Controls.Add(lblMostUsedIngredient);
            Controls.Add(lblMostBrewedPotion);
            Name = "DashboardForm";
            Text = "Dashboard and Report";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMostBrewedPotion;
        private Label lblMostUsedIngredient;
        private Label lblBrewedInRange;
        private DateTimePicker dateStart;
        private DateTimePicker dateEnd;
        private Button btnGetCountInRange;
        private Button btnOpenCustomization;
        private Button btnOpenIngredient;
        private Button btnOpenRecipe;
        private Button btnOpenBrew;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}