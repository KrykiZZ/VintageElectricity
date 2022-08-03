using VintageElectricity.Blocks;
using Vintagestory.API.Common;

namespace VintageElectricity
{
    public class VintageElectricity : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("trampoline", typeof(TrampolineBlock));
        }
    }
}
