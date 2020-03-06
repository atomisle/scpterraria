using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ContainmentTerraria.Items
{
	public class CupOfHealth : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cup of Health");
			Tooltip.SetDefault("How can health be a liquid?");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = 3;
			item.healLife = 500;
			item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Cup"), 1);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddTile(mod.TileType("Scp294"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
