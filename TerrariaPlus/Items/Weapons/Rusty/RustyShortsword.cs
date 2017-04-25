using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Weapons.Rusty
{
	public class RustyShortsword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Rusty Shortsword"; // The item display name in-game.
			item.damage = 8; // The amount of damage the item deals.
			item.melee = true; // Confirms that the item is indeed a melee item.
			item.width = 16; // The width of the item in-game.
			item.height = 16; // The height of the item in-game.
			item.toolTip = "A Rusty old Shortsword!"; // The displayed tool-tip in-game.
			item.useTime = 11; // The amount of time it takes the item to be used.
			item.useAnimation = 11; // The amount of time the animation is displayed.
			item.useStyle = 3; // The use style of the item.
			item.knockBack = 4; // The knockback of the item.
			item.value = Item.buyPrice(0, 0, 15, 0); // The items value in PGSC.
			item.rare = 1; // The font color and rarity of the item.
			item.UseSound = SoundID.Item1; // The sound the items make when used.
			item.autoReuse = false; // "Auto swing"
		}

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod); // Required.
			recipe1.AddIngredient(ItemID.CopperShortsword, 1 ); // The rquired ingredients.
      			recipe1.AddIngredient(ItemID.Cobweb, 6 ); // The rquired ingredients.
			recipe1.AddTile(TileID.WorkBenches); // The rquired crafting station.
			recipe1.SetResult(this); // The result of crafting.
			recipe1.AddRecipe(); // Required.
			
			ModRecipe recipe2 = new ModRecipe(mod); // Required.
			recipe2.AddIngredient(ItemID.TinShortsword, 1 ); // The rquired ingredients.
      			recipe2.AddIngredient(ItemID.Cobweb, 6 ); // The rquired ingredients.
			recipe2.AddTile(TileID.WorkBenches); // The rquired crafting station.
			recipe2.SetResult(this); // The result of crafting.
			recipe2.AddRecipe(); // Required.
		}
	}
}
