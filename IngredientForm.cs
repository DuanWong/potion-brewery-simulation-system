using PotionBrewerySystem.Models;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PotionBrewerySystem
{
    public partial class IngredientForm : Form
    {
        public IngredientForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            using (var context = new BreweryContext())
            {
                var ingredients = context.Ingredients.ToList();

                // 在第一个位置插入新原材料空行
                ingredients.Insert(0, new Ingredient
                {
                    Name = "(New Ingredient)",
                    StockQuantity = 0,
                    MinStockThreshold = 0
                });

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ingredients;
                dataGridView1.Columns["IngredientID"].Visible = false;
            }

            // 默认选中第一行
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;

                // 聚焦到第一个可编辑单元格（如名称列）
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["Name"];
                dataGridView1.BeginEdit(true); // 自动进入编辑状态
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new BreweryContext())
            {
                var ingredient = new Ingredient
                {
                    Name = txtName.Text,
                    StockQuantity = (int)numStock.Value,
                    MinStockThreshold = (int)numThreshold.Value
                };

                context.Ingredients.Add(ingredient);
                context.SaveChanges();
            }
            LoadIngredients();
            MessageBox.Show("Ingredient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Ingredient selected)
            {
                using (var context = new BreweryContext())
                {
                    var ingredient = context.Ingredients.Find(selected.IngredientID);
                    if (ingredient != null)
                    {
                        ingredient.Name = txtName.Text;
                        ingredient.StockQuantity = (int)numStock.Value;
                        ingredient.MinStockThreshold = (int)numThreshold.Value;

                        context.SaveChanges();
                    }
                }
                LoadIngredients();
                MessageBox.Show("Ingredient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Ingredient selected)
            {
                using (var context = new BreweryContext())
                {
                    bool isUsed = context.RecipeIngredients.Any(ri => ri.IngredientID == selected.IngredientID);
                    if (isUsed)
                    {
                        MessageBox.Show("This ingredient is used in a recipe and cannot be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var ingredient = context.Ingredients.Find(selected.IngredientID);
                    if (ingredient != null)
                    {
                        context.Ingredients.Remove(ingredient);
                        context.SaveChanges();
                    }
                }
                LoadIngredients();
                MessageBox.Show("Ingredient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Ingredient selected)
            {
                txtName.Text = selected.IngredientID != 0 ? selected.Name : string.Empty;
                numStock.Value = selected.StockQuantity;
                numThreshold.Value = selected.MinStockThreshold;
            }
        }
    }
}
