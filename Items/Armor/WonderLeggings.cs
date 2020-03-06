using ContainmentTerraria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class WonderLeggings : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dr. Wondertainment Leggings");
			Tooltip.SetDefault("Straight from Wondertainment Labs.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddTile(mod.TileType("ToyBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}