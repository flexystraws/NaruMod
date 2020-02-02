using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaruMod.Items.Armor.ArmorSets
{
    [AutoloadEquip(EquipType.Legs)]
    public class SandDemonLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("13% Increased Chakra Damage"
                + "\n9% Increased Chakra Crit Chance" +
                               "\n+300 Max Chakra" +
                               "\nIncreased Chakra Regen" +
                               "\n12% Decreased movement speed");
            DisplayName.SetDefault("Legendary Sand Demon's Leggings");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 18000;
            item.rare = 5;
            item.defense = 8;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed -= 0.12f;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.SandBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}