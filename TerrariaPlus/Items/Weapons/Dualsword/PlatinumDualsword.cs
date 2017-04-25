using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Weapons.Dualsword
{
	public class PlatinumDualsword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Platinum Dualsword"; // The item display name in-game.
			item.damage = 15; // The amount of damage the item deals.
			item.melee = true; // Confirms that the item is indeed a melee item.
			item.width = 16; // The width of the item in-game.
			item.height = 16; // The height of the item in-game.
			item.toolTip = "Left click to swing"; // The displayed tool-tip in-game.
      			item.toolTip2 = "Right click to stab"; // Another tool-tip.
			item.useTime = 19; // The amount of time it takes the item to be used.
			item.useAnimation = 19; // The amount of time the animation is displayed.
			item.useStyle = 1; // The use style of the item.
			item.knockBack = 5; // The knockback of the item.
			item.value = Item.buyPrice(0, 2, 0, 0); // The items value in PGSC.
			item.rare = 1; // The font color and rarity of the item.
			item.UseSound = SoundID.Item1; // The sound the items make when used.
			item.autoReuse = false; // "Auto swing"
		}
    
    		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
    
    		// The "Right click" method.
    		public override bool UseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.damage = 26; // The amount of damage the item deals.
				item.useTime = 10; // The amount of time it takes the item to be used.
				item.useAnimation = 10; // The amount of time the animation is displayed.
				item.useStyle = 3; // The use style of the item.
				item.knockBack = 4; // The knockback of the item.
				item.autoReuse = false; // "Auto swing"
			}
			else
			{
				item.damage = 15; // The amount of damage the item deals.
				item.useTime = 19; // The amount of time it takes the item to be used.
				item.useAnimation = 19; // The amount of time the animation is displayed.
				item.useStyle = 1; // The use style of the item.
				item.knockBack = 5; // The knockback of the item.
				item.autoReuse = false; // "Auto swing"
			}
			return base.CanUseItem(player);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); // Required.
			recipe.AddIngredient(ItemID.PlatinumShortsword, 1 ); // The rquired ingredients.
      			recipe.AddIngredient(ItemID.PlatinumBroadsword, 1 ); // The rquired ingredients.
      			recipe.AddIngredient(ItemID.GoldBar, 4 ); // The rquired ingredients.
			recipe.AddTile(TileID.Anvils); // The rquired crafting station.
			recipe.SetResult(this); // The result of crafting.
			recipe.AddRecipe(); // Required.
		}
	}
}
