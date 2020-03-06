using Terraria.ID;
using Terraria.ModLoader;

namespace ContainmentTerraria.Items
{
	public class Cup : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cup");
			Tooltip.SetDefault("An empty cup, wishing to one day be full.");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.melee = false;
			item.width = 10;
			item.height = 14;
			item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}