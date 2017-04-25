using Terraria;
using Terraria.ModLoader;
 
namespace TerrariaPlus.Items.Banners
{
    public class DesertZombieBannerItem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Desert Zombie Banner";
            item.width = 10;
            item.height = 24;            
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 1;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("DesertZombieBannerTile");
            item.placeStyle = 0;
        }
    }
}
