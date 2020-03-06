using ContainmentTerraria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SecurityChestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Security Chestplate");
			Tooltip.SetDefault("Simple ballistic chestpiece.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 35);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 35);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}