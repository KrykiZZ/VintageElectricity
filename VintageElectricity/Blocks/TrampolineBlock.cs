using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace VintageElectricity.Blocks
{
    public class TrampolineBlock : Block
    {
        private AssetLocation _tickSound = new AssetLocation("game", "tick");

        public override void OnEntityCollide(IWorldAccessor world, Entity entity, BlockPos pos, BlockFacing facing, Vec3d collideSpeed, bool isImpact)
        {
            if (isImpact && facing.Axis == EnumAxis.Y)
            {
                world.PlaySoundAt(_tickSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                entity.Pos.Motion.Y *= -0.8;
            }
        }
    }
}
