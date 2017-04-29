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
            item.value = Item.buyPrice(0, 1, 50, 0);
            item.rare = 2; 
            item.defense = 3;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBar, 20); 
            recipe.AddIngredient(ItemID.GlowingMushroom, 40);
            recipe.AddTile(TileID.Anvils);  
            recipe.SetResult(this);
            recipe.AddRecipe();
  
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenBar, 20); 
            recipe.AddIngredient(ItemID.GlowingMushroom, 40);
            recipe.AddTile(TileID.Anvils);  
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
