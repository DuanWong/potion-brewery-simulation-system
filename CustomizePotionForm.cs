using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PotionBrewerySystem.Models;

namespace PotionBrewerySystem
{
    public partial class CustomizePotionForm : Form
    {
        public CustomizePotionForm()
        {
            InitializeComponent();
            LoadBrewedPotions(); 
            LoadGridBrewedPotions();

            gridBrewedPotions.CellValueChanged += gridBrewedPotions_CellValueChanged;
        }

        private void LoadBrewedPotions()
        {
            using (var context = new BreweryContext())
            {
                var potions = context.BrewedPotions
                    .AsNoTracking()
                    .OrderBy(p => p.CustomName)
                    .ToList();

                comboPotionList.DataSource = potions;
                comboPotionList.DisplayMember = "CustomName";
                comboPotionList.ValueMember = "BrewedPotionID";
                comboPotionList.SelectedIndex = -1;

                ClearFields();
            }
        }

        private void LoadGridBrewedPotions()
        {
            using (var context = new BreweryContext())
            {
                var potions = context.BrewedPotions
                    .OrderBy(p => p.BrewedPotionID)
                    .Select(p => new
                    {
                        p.BrewedPotionID,
                        p.CustomName,
                        p.Attributes
                    })
                    .ToList();

                gridBrewedPotions.DataSource = potions;
            }
        }

        private void comboPotionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPotionList.SelectedItem is BrewedPotion selectedPotion)
            {
                txtNewName.Text = selectedPotion.CustomName;
                txtNewAttributes.Text = selectedPotion.Attributes;
                lblStatus.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboPotionList.SelectedItem is not BrewedPotion selectedPotion)
            {
                lblStatus.Text = "Please select a potion.";
                return;
            }

            string newName = txtNewName.Text.Trim();
            string newAttributes = txtNewAttributes.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                lblStatus.Text = "Potion name cannot be empty.";
                return;
            }

            try
            {
                using (var context = new BreweryContext())
                {
                    var potion = context.BrewedPotions
                        .FirstOrDefault(p => p.BrewedPotionID == selectedPotion.BrewedPotionID);

                    if (potion != null)
                    {
                        potion.CustomName = newName;
                        potion.Attributes = newAttributes;
                        context.SaveChanges();
                        lblStatus.Text = "Potion updated successfully.";
                    }
                    else
                    {
                        lblStatus.Text = "Potion not found in database.";
                    }
                }

                LoadBrewedPotions();
                LoadGridBrewedPotions();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void gridBrewedPotions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = gridBrewedPotions.Rows[e.RowIndex];
            if (row.Cells["BrewedPotionID"].Value == null) return;

            int id = Convert.ToInt32(row.Cells["BrewedPotionID"].Value);
            string newName = row.Cells["CustomName"].Value?.ToString()?.Trim() ?? "";
            string newAttributes = row.Cells["Attributes"].Value?.ToString()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(newName))
            {
                lblStatus.Text = "Potion name cannot be empty.";
                return;
            }

            try
            {
                using (var context = new BreweryContext())
                {
                    var potion = context.BrewedPotions.FirstOrDefault(p => p.BrewedPotionID == id);
                    if (potion != null)
                    {
                        potion.CustomName = newName;
                        potion.Attributes = newAttributes;
                        context.SaveChanges();
                        lblStatus.Text = $"Potion ID {id} updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void ClearFields()
        {
            txtNewName.Clear();
            txtNewAttributes.Clear();
            lblStatus.Text = "";
        }
    }
}
