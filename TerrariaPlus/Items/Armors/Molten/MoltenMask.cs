using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Armors.Molten
{
	public class MoltenMask : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Molten Mask";
			item.width = 20;
			item.height = 18;
			item.value = Item.buyPrice(0, 4, 50, 0);
			item.rare = 3;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "17% extra ranged damage";
			player.rangedDamage *= 0.17f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.AnyAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
