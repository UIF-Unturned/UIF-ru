﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIF
{
	public partial class itemList : Form
	{
		List<item> items;

		public itemList(List<item> _items)
		{
			if (_items == null)
			{
				MessageBox.Show("Ошибка в списке предметов.", "Ошибка!");
				return;
			}

			InitializeComponent();

			for (int i = 0; i < _items.Count; i++)
				ResultsListBox.Items.Add(_items[i].name + " (" + _items[i].id + ")");

			items = _items;
		}

		private void updateItemList()
		{
			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}
		private void clearTextBoxes()
		{
			ItemCapacityTextBox.Clear();
			DamageHeadTextBox.Clear();
			BodyDamageTextBox.Clear();
			ProtectionTextBox.Clear();
			ItemTypeTextBox.Clear();
			ItemType2TextBox.Clear();
			RangeTextBox.Clear();
			StructureDamageTextBox.Clear();
			PlayerDamageTextBox.Clear();
			EngineTextBox.Clear();
			ItemHealthTextBox.Clear();
			ShakeTextBox.Clear();
			VolumeTextBox.Clear();
			BarrelDamageTextBox.Clear();
		}

		private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex == -1)
			{
				NameTextBox.Clear();
				IdTextBox.Clear();

				clearTextBoxes();
			}
			else
			{
				clearTextBoxes();

				item currentItem = items[ResultsListBox.SelectedIndex];
				
				IdTextBox.Text = currentItem.id.ToString();
				NameTextBox.Text = ResultsListBox.SelectedItem.ToString().Replace(" (" + currentItem.id.ToString() + ")", String.Empty);

				if (currentItem.armor != null && currentItem.itemType.TryContains("Clothing"))
					ProtectionTextBox.Text = ((float)currentItem.armor).toPercentage()
						.ToString();

				if (currentItem.clothStorageHeight != null && currentItem.clothStorageWidth != null && currentItem.itemType.TryContains("Clothing"))
					ItemCapacityTextBox.Text = (currentItem.clothStorageHeight * currentItem.clothStorageWidth)
						.ToString();
				else if (currentItem.barricadeStorageHeight != null && currentItem.barricadeStorageWidth != null && currentItem.itemType2.TryContains("Storage"))
					ItemCapacityTextBox.Text = (currentItem.barricadeStorageHeight * currentItem.barricadeStorageWidth)
						.ToString();

				if (currentItem.headDamage != null && currentItem.itemType.TryContains("Melee", "Gun"))
					DamageHeadTextBox.Text = (currentItem.headDamage != null ? String.Empty : "~") +
						((currentItem.headDamage != null ? currentItem.headDamage : 1) *
						(currentItem.playerDamage != null ? currentItem.playerDamage : 1)).ToString();

				if (currentItem.bodyDamage != null && currentItem.itemType.TryContains("Melee", "Gun"))
					BodyDamageTextBox.Text = (currentItem.bodyDamage != null ? String.Empty : "~") +
						((currentItem.bodyDamage != null ? currentItem.bodyDamage : 1) *
						(currentItem.playerDamage != null ? currentItem.playerDamage : 1)).ToString();

				if (currentItem.range != null && currentItem.itemType.TryContains("Melee", "Gun"))
					RangeTextBox.Text = currentItem.range.ToString();

				if (currentItem.playerDamage != null && currentItem.itemType.TryContains("Gun", "Melee"))
					PlayerDamageTextBox.Text = currentItem.playerDamage.ToString();

				if (currentItem.structureDamage != null && (currentItem.itemType.TryContains("Gun", "Melee") ||
					currentItem.itemType2.TryContains("Charge")))
					StructureDamageTextBox.Text = (currentItem.explosive ? "~" : String.Empty) + currentItem.structureDamage.ToString();

				if (currentItem.itemType != null)
					ItemTypeTextBox.Text = currentItem.itemType;

				if (currentItem.itemType2 != null)
					ItemType2TextBox.Text = currentItem.itemType2;

				if (currentItem.itemType2.TryContains("Vehicle") || currentItem.itemType.TryContains("Vehicle"))
				{
					EngineTextBox.Text = currentItem.engine != null ? currentItem.engine.ToString() : "Car";

					ItemHealthTextBox.Text = currentItem.vehicleHealth != null ? currentItem.vehicleHealth.ToString() : String.Empty;
				}
				else if (currentItem.itemType.TryContains("Barricade", "Structure") ||
					currentItem.itemType2.TryContains("Barricade", "Structure"))
					ItemHealthTextBox.Text = currentItem.buildingHealth != null ? currentItem.buildingHealth.ToString() : String.Empty;

				if (currentItem.itemType2.TryContains("Grip", "Barrel", "Tactical"))
					ShakeTextBox.Text = currentItem.shake != null ? currentItem.shake.ToString() : String.Empty;

				if (currentItem.itemType2.TryContains("Barrel"))
					VolumeTextBox.Text = currentItem.barrelVolume != null ? currentItem.barrelVolume.ToString() : String.Empty;

				if ( currentItem.itemType2.TryContains("Barrel"))
					BarrelDamageTextBox.Text = currentItem.barrelDamage != null ? currentItem.barrelDamage.ToString() : "1";
			}
		}

		private void IdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(items[ResultsListBox.SelectedIndex].id.ToString());
		}

		private void NameIdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText((items[ResultsListBox.SelectedIndex].name
					+ " - "
					+ (IdPrefixTextBox.Text != String.Empty ? IdPrefixTextBox.Text + " " : String.Empty)
					+ items[ResultsListBox.SelectedIndex].id.ToString()));
		}

		private void AllNameIdToClipboard_Click(object sender, EventArgs e)
		{
			string copyStr = String.Empty;

			for (int i = 0; i < items.Count; i++)
			{
				copyStr += (items[i].name
					+ " - "
					+ (IdPrefixTextBox.Text != String.Empty ? IdPrefixTextBox.Text + " " : String.Empty)
					+ items[i].id.ToString())
					+ (i < items.Count ? "\n" : String.Empty);
			}

			Clipboard.SetText(copyStr);
		}

		private void SortCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

			updateItemList();
		}

		private void SortProtectionBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			updateItemList();
		}

		private void SortDamagePlayersBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			updateItemList();
		}

		private void MixBtn_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			items.Sort((a, b) => random.Next(int.MinValue, int.MaxValue));

			updateItemList();
		}

		private void SortDamageBuildingsBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			updateItemList();
		}

		private void NameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();

		private void IdLabel_Click(object sender, EventArgs e) => IdTextBox.Focus();

		private void SortVehicleHealthBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			updateItemList();
		}

		private void SortBarricadeCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureCapacity));

			updateItemList();
		}

		private void SortByBuildingHealthBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			updateItemList();
		}

        private void ItemCapacityLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultsLabel_Click(object sender, EventArgs e)
        {

        }

        private void BodyDamageLabel_Click(object sender, EventArgs e)
        {

        }

        private void BuildingsDamageLabel_Click(object sender, EventArgs e)
        {

        }

        private void ItemType2Label_Click(object sender, EventArgs e)
        {

        }

        private void InfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

		private void SortByShakeBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Shake));

			updateItemList();
		}

		private void SortByBarrelDamageBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelDamage));

			updateItemList();
		}

		private void SortByVolumeBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelVolume));

			updateItemList();
		}

        private void VolumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ItemHealthLabel_Click(object sender, EventArgs e)
        {

        }

        private void BarrelDamageLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShakeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VolumeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemHealthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
