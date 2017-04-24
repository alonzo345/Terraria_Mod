using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Tools.Shiny
{
	public class ShinyAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Shiny Axe"; // The item display name in-game.
			item.damage = 7; // The amount of damage the item deals.
			item.melee = true; // Confirms that the item is indeed a melee item.
			item.width = 16; // The width of the item in-game.
			item.height = 16; // The height of the item in-game.
			item.toolTip = "A Shiny new Axe!"; // The displayed tool-tip in-game.
			item.toolTip2 = "Divide axe power by 5" // Another tool-tip.
			item.useTime = 25;  // The amount of time it takes the item to be used.
			item.useAnimation = 25; // The amount of time the animation is displayed.
			item.axe = 55;  // The axe power of the item.
			item.useStyle = 1; // The use style of the item.
			item.knockBack = 4.5f; // The knockback of the item.
			item.value = Item.buyPrice(0, 0, 60, 0); // The items value in PGSC.
			item.rare = 1; // The font color and rarity of the item.
			item.UseSound = SoundID.Item1; // The sound the items make when used.
			item.autoReuse = true; // "Auto swing"
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); // Required.
      			recipe.AddIngredient(null, "RustyAxe"); // The required ingredients.
			recipe.AddTile(TileID.SharpeningStation); // The required crafting station.
			recipe.SetResult(this); // The result of crafting.
			recipe.AddRecipe(); // Required.
			
		}
	}
}
