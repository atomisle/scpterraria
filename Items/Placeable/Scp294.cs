using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Placeable
{
	public class Scp294 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SCP-294");
			Tooltip.SetDefault("A coffee machine that allows creation of otherworldly drinks.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("Scp294");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 50);
			recipe.AddTile(mod.TileType("DocumentCrafters"));
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 50);
			recipe.AddTile(mod.TileType("DocumentCrafters"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}