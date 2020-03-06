using ContainmentTerraria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class WonderHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dr. Wondertainment Helmet");
			Tooltip.SetDefault("Straight from Wondertainment Labs.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("WonderVest") && legs.type == mod.ItemType("WonderLeggings");
		}

		public override void UpdateArmorSet(Player player) {
			//player.setBonus = "To be added,";
			//player.allDamage -= 0.2f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 6);
			recipe.AddTile(mod.TileType("ToyBench"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}