using ContainmentTerraria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ContainmentTerraria.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SecurityVisor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Security Visor");
			Tooltip.SetDefault("A visor to keep out the nasties.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("SecurityChestplate") && legs.type == mod.ItemType("SecurityLeggings");
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
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 25);
			recipe.AddTile(mod.TileType("ScpFabricator"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}