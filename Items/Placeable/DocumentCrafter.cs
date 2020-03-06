using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Placeable
{
	public class DocumentCrafter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A mysterious piece of furniture crafted from time.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("DocumentCrafter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ScpFabricator"), 1);
			recipe.AddIngredient(mod.ItemType("WanderersWorkbench"), 1);
			recipe.AddIngredient(mod.ItemType("ToyBench"), 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}