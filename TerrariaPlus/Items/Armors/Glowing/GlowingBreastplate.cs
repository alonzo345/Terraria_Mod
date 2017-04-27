using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Armor.Glowing
{
    public class GlowingBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Glowing Breastplate";
            item.width = 18;
            item.height = 18;
            AddTooltip("It glows");
            AddTooltip2("+20 max mana");
            item.value = 10;
            item.rare = 2; 
            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 20;   //20 max mana
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBar, 20); 
            recipe.AddIngredient(ItemID.GlowingMushroom, 40);
            recipe.AddTile(TileID.AnyAnvil);  
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}