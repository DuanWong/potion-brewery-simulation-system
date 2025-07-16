using System;
using System.Windows.Forms;

partial class RecipeForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView recipeGrid;
    private DataGridView recipeIngredientsGrid;
    private ComboBox ingredientCombo;
    private NumericUpDown quantityNumeric;
    private TextBox txtName;
    private TextBox txtDescription;
    private NumericUpDown numBrewingTime;
    private Button btnAddIngredient;
    private Button btnSaveRecipe;
    private Button btnDeleteRecipe;
    private Label lblName;
    private Label lblDescription;
    private Label lblBrewingTime;
    private Label lblIngredient;
    private Label lblQuantity;

    private void InitializeComponent()
    {
        recipeGrid = new DataGridView();
        recipeIngredientsGrid = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        ingredientCombo = new ComboBox();
        quantityNumeric = new NumericUpDown();
        txtName = new TextBox();
        txtDescription = new TextBox();
        numBrewingTime = new NumericUpDown();
        btnAddIngredient = new Button();
        btnSaveRecipe = new Button();
        btnDeleteRecipe = new Button();
        lblName = new Label();
        lblDescription = new Label();
        lblBrewingTime = new Label();
        lblIngredient = new Label();
        lblQuantity = new Label();
        ((System.ComponentModel.ISupportInitialize)recipeGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)recipeIngredientsGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numBrewingTime).BeginInit();
        SuspendLayout();
        // 
        // recipeGrid
        // 
        recipeGrid.Location = new Point(20, 20);
        recipeGrid.MultiSelect = false;
        recipeGrid.Name = "recipeGrid";
        recipeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        recipeGrid.Size = new Size(352, 242);
        recipeGrid.TabIndex = 0;
        recipeGrid.SelectionChanged += recipeGrid_SelectionChanged;
        // 
        // recipeIngredientsGrid
        // 
        recipeIngredientsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        recipeIngredientsGrid.Location = new Point(20, 320);
        recipeIngredientsGrid.Name = "recipeIngredientsGrid";
        recipeIngredientsGrid.Size = new Size(352, 154);
        recipeIngredientsGrid.TabIndex = 1;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "Ingredient ID";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Ingredient";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Quantity";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        // 
        // ingredientCombo
        // 
        ingredientCombo.Location = new Point(485, 326);
        ingredientCombo.Name = "ingredientCombo";
        ingredientCombo.Size = new Size(150, 23);
        ingredientCombo.TabIndex = 2;
        // 
        // quantityNumeric
        // 
        quantityNumeric.Location = new Point(485, 374);
        quantityNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        quantityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        quantityNumeric.Name = "quantityNumeric";
        quantityNumeric.Size = new Size(150, 23);
        quantityNumeric.TabIndex = 3;
        quantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // txtName
        // 
        txtName.Location = new Point(500, 40);
        txtName.Name = "txtName";
        txtName.Size = new Size(200, 23);
        txtName.TabIndex = 4;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(500, 90);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(200, 60);
        txtDescription.TabIndex = 5;
        // 
        // numBrewingTime
        // 
        numBrewingTime.Location = new Point(500, 170);
        numBrewingTime.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        numBrewingTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numBrewingTime.Name = "numBrewingTime";
        numBrewingTime.Size = new Size(120, 23);
        numBrewingTime.TabIndex = 6;
        numBrewingTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnAddIngredient
        // 
        btnAddIngredient.Location = new Point(390, 423);
        btnAddIngredient.Name = "btnAddIngredient";
        btnAddIngredient.Size = new Size(130, 23);
        btnAddIngredient.TabIndex = 7;
        btnAddIngredient.Text = "Add Ingredient";
        btnAddIngredient.Click += btnAddIngredient_Click;
        // 
        // btnSaveRecipe
        // 
        btnSaveRecipe.Location = new Point(390, 222);
        btnSaveRecipe.Name = "btnSaveRecipe";
        btnSaveRecipe.Size = new Size(118, 23);
        btnSaveRecipe.TabIndex = 8;
        btnSaveRecipe.Text = "Save Recipe";
        btnSaveRecipe.Click += btnSaveRecipe_Click;
        // 
        // btnDeleteRecipe
        // 
        btnDeleteRecipe.Location = new Point(553, 222);
        btnDeleteRecipe.Name = "btnDeleteRecipe";
        btnDeleteRecipe.Size = new Size(121, 23);
        btnDeleteRecipe.TabIndex = 9;
        btnDeleteRecipe.Text = "Delete Recipe";
        btnDeleteRecipe.Click += btnDeleteRecipe_Click;
        // 
        // lblName
        // 
        lblName.Location = new Point(450, 40);
        lblName.Name = "lblName";
        lblName.Size = new Size(100, 23);
        lblName.TabIndex = 10;
        lblName.Text = "Name:";
        // 
        // lblDescription
        // 
        lblDescription.Location = new Point(420, 90);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(100, 23);
        lblDescription.TabIndex = 11;
        lblDescription.Text = "Description:";
        // 
        // lblBrewingTime
        // 
        lblBrewingTime.Location = new Point(390, 170);
        lblBrewingTime.Name = "lblBrewingTime";
        lblBrewingTime.Size = new Size(100, 23);
        lblBrewingTime.TabIndex = 12;
        lblBrewingTime.Text = "Brewing Time (s):";
        // 
        // lblIngredient
        // 
        lblIngredient.Location = new Point(390, 329);
        lblIngredient.Name = "lblIngredient";
        lblIngredient.Size = new Size(100, 23);
        lblIngredient.TabIndex = 13;
        lblIngredient.Text = "Ingredient:";
        // 
        // lblQuantity
        // 
        lblQuantity.Location = new Point(390, 374);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(61, 23);
        lblQuantity.TabIndex = 14;
        lblQuantity.Text = "Quantity:";
        // 
        // RecipeForm
        // 
        ClientSize = new Size(750, 570);
        Controls.Add(recipeGrid);
        Controls.Add(recipeIngredientsGrid);
        Controls.Add(ingredientCombo);
        Controls.Add(quantityNumeric);
        Controls.Add(txtName);
        Controls.Add(txtDescription);
        Controls.Add(numBrewingTime);
        Controls.Add(btnAddIngredient);
        Controls.Add(btnSaveRecipe);
        Controls.Add(btnDeleteRecipe);
        Controls.Add(lblName);
        Controls.Add(lblDescription);
        Controls.Add(lblBrewingTime);
        Controls.Add(lblIngredient);
        Controls.Add(lblQuantity);
        Name = "RecipeForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Recipe Management";
        ((System.ComponentModel.ISupportInitialize)recipeGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)recipeIngredientsGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)numBrewingTime).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
}
