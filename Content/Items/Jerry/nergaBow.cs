using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace theJerryMod.Content.Items.Jerry
{

    public class nergaBow : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.theJerryMod.hjson' file.
        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly; // This is an example, replace with your own projectile if needed.
            Item.shootSpeed = 16f; // Adjust the speed of the projectile as needed.
            Item.useAmmo = AmmoID.Arrow; // This makes the item use arrows as ammo.
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.damage = 500; // Set the damage for the alternate function (right-click).
            }
            else
            {
                Item.damage = 50; // Set the damage for the normal function (left-click).
            }
            return true; // Return true to allow the item to be used.
        }

        public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.altFunctionUse == 2)
            {
                int dragon = Projectile.NewProjectile(source, position, velocity, ProjectileID.FireArrow, damage, knockback, player.whoAmI);
                Main.projectile[dragon].friendly = true; // Make the projectile friendly (won't hurt the player).
                return false; // Return false to prevent the default shooting behavior from occurring.
            }

            return true; // Return true to allow the default shooting behavior to occur.
        }



        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}