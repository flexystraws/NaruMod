﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaruMod.Items.Accessories
{
    [AutoloadEquip(EquipType.Waist)]
    public class AncientLegendWaistCape : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A ancient garment made to imitate Gaara's bottom half of his outfit.");
            DisplayName.SetDefault("Ancient Legend Waistcape");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 150000;
            item.rare = 5;
            item.accessory = true;
            item.defense = 0;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            {
//                player.GetModPlayer<MyPlayer>(mod).KiDamage *= 1.06f;
//                player.GetModPlayer<MyPlayer>(mod).kiDrainMulti *= 0.86f;
//                player.GetModPlayer<MyPlayer>(mod).kiMax2 -= 250;
//                player.GetModPlayer<MyPlayer>(mod).legendWaistcape = true;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HardenedSand, 25);
            recipe.AddIngredient(ItemID.Silk, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}