using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace theJerryMod.Projectiles
{

    public class dragonPiecer : ModProjectile
    {
        // The Display Name and Tooltip of this projectile can be edited in the 'Localization/en-US_Mods.theJerryMod.hjson' file.
        public override void SetDefaults()
        {
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.friendly = true; // This makes the projectile able to damage enemies.
            Projectile.hostile = false; // This makes the projectile not able to damage the player.
            Projectile.DamageType = DamageClass.Ranged; // Set the damage type to ranged.
            Projectile.penetrate = 5; // This makes the projectile disappear after hitting an enemy once.
            Projectile.timeLeft = 600; // The projectile will last for 10 seconds (600 ticks) before disappearing on its own.
            Projectile.ignoreWater = true; // affected by water?
            Projectile.tileCollide = true; // collide with tiles?
            Projectile.aiStyle = 1; // behave like a standard bullet.
            AIType = ProjectileID.WoodenArrowFriendly; // Use the AI of the Wooden Arrow projectile for movement and behavior.
        }
    }
}