using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourModName.Items.Armor
{
    public class BreastplateName : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Star Breastplate";
            item.width = 18;
            item.height = 18;
            AddTooltip("This is a Star body armor.");
            AddTooltip2("+20 max mana");
            item.value = 10;
            item.rare = 2;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 20;   //20 max mana
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