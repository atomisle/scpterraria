using ContainmentTerraria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class WonderVest : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dr. Wondertainment Vest");
			Tooltip.SetDefault("Straight from Wondertainment Labs.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 7);
			recipe.AddTile(mod.TileType("ToyBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}