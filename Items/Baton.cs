using Terraria.ID;
using Terraria.ModLoader;

namespace ContainmentTerraria.Items
{
	public class Baton : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Security Baton");
			Tooltip.SetDefault("The first line of defense for any aspiring foundation personnel.");
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.IronBar, 11);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.LeadBar, 11);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}