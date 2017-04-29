using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Armors.Glowing
{
	public class GlowingMask : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Glowing Mask";
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 1, 50, 0);
			item.rare = 2;
			item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.GlowingBreastplate && legs.type == ItemID.GlowingLeggings;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "17% extra range damage";
			player.rangedDamage *= 0.17f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ItemID.GlowingMashroom, 20);
			recipe.AddTile(TileID.AnyAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
