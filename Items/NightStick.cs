using Terraria.ID;
using Terraria.ModLoader;

namespace ContainmentTerraria.Items
{
	public class NightStick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Night Stick");
			Tooltip.SetDefault("An advanced, electrified version of the Security Baton.");
		}

		public override void SetDefaults() 
		{
			item.damage = 23;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Baton"), 1);
			recipe.AddIngredient(ItemID.MeteoriteBar, 12);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}