using Terraria.ModLoader;
using Terraria.ID;

namespace NaruMod.Items
{
	public class SandCloud : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 300;
			item.rare = 3;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = mod.MountType("SandCloudMount");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SandCloud Whistle");
			Tooltip.SetDefault("'Suddenly, there's sand everywhere!'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cloud, 20);
			recipe.AddIngredient(ItemID.SandBlock, 500);
			recipe.AddTile(ItemID.WorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
