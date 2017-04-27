using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourModName.Items.Armor
{
    public class Leggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Star Leggings";
            item.width = 18;
            item.height = 18;
            AddTooltip("This is a Star leg armor.");
            AddTooltip2("5% increased movement speed");
            item.value = 10;
            item.rare = 2;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;  //player movement speed incresed 0.05f = 5%
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}