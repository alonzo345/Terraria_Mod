using Terraria.ModLoader;

namespace TerrariaPlus
{
	class TerrariaPlus : Mod
	{
		public TerrariaPlus()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
