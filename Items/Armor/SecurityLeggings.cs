using ContainmentTerraria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SecurityLeggings : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Security Leggings");
			Tooltip.SetDefault("Leg protection for security personnel.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 30);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 30);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}