using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Armors.Glowing
{
    public class GlowingLeggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Glowing Leggings";
            item.width = 18;
            item.height = 18;
            AddTooltip("5% increased movement speed");
            item.value = Item.buyPrice(0, 1, 50, 0);
            item.rare = 2;
            item.defense = 2;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;  //player movement speed incresed 0.05f = 5%
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBar, 15); 
            recipe.AddIngredient(ItemID.GlowingMushroom, 30);   
            recipe.AddTile(TileID.Anvils);  
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
