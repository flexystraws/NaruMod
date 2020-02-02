using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaruMod.Items.Armor.ArmorSets
{
    [AutoloadEquip(EquipType.Body)]
    public class SandDemonShirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("18% Increased Chakra Damage"
                + "\n14% Increased Chakra Crit Chance" +
                               "\n+700 Max Chakra" +
                               "\n+1 Maximum Charges");
            DisplayName.SetDefault("Sand Demon's Shirt");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 30000;
            item.rare = 5;
            item.defense = 12;
        }
		public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawArms = true;
            drawHands = true;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return legs.type == mod.ItemType("SandDemonLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Pressing `Armor Bonus` grants you Demonic Overdrive, granting infinite Defense for a very limited time.";
          //  MyPlayer.ModPlayer(player).demonBonus = true;
        }
        public override void UpdateEquip(Player player)
        {
        //    MyPlayer.ModPlayer(player).KiDamage += 0.18f;
         //   MyPlayer.ModPlayer(player).kiCrit += 14;
         //   MyPlayer.ModPlayer(player).kiMax2 += 700;
        //    MyPlayer.ModPlayer(player).chargeLimitAdd += 1;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 30);
            recipe.AddIngredient(ItemID.SandBlock, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}