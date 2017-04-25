using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.NPCs
{
	public class DesertZombie : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Desert Zombie"; // The displayed name while hovering over the NPC with the mouse.
			npc.width = 18; // The width of the NPC in-game.
			npc.height = 40; // The height of the NPC in-game.
			npc.damage = 14; // The amount of damage the NPC deals.
			npc.defense = 6; // The amount of defence the NPC have.
			npc.lifeMax = 50; // The amount of health the NPC have.
			npc.HitSound = SoundID.NPCHit1; // The sound the NPC makes when hit.
			npc.DeathSound = SoundID.NPCDeath2; // The sound the NPC makes when killed.
			npc.value = 80f; // The amount of money the NPC drops.
			npc.knockBackResist = 0.5f; // 
			npc.aiStyle = 3;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
      			banner = npc.type;
			bannerItem = mod.ItemType("DesertZombieBanner");
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
    
    		public override void NPCLoot()
		{
			if (Main.rand.Next(50) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Shackle);
			}
      			if (Main.rand.Next(250) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ZombieArm);
			}
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SandBlock, (Main.rand.Next(4) + 1));
		}
	}
}
