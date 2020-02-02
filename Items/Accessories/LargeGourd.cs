﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaruMod.Items.Accessories
{
    [AutoloadEquip(EquipType.Back)]
    public class LargeGourd : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An overgrown Gourd filled with Chakra. Oddly filled with living sand that seems to really like you.'"
               + "\n  8  increased magic crit"
               + "\n 20% increased mana regen"
               + "\n 10% decreased magic damage");
            DisplayName.SetDefault("Large Sand-Filled Gourd");
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 30;
            item.value = 70000;
            item.rare = 4;
            item.accessory = true;
            item.defense = 5;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            {
                player.manaRegen *= 2;
                player.magicCrit += 8;
                player.magicDamage -= 0.1F;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SandBlock, 50);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.ClayBlock, 10);
            recipe.AddIngredient(ItemID.ManaCrystal, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}