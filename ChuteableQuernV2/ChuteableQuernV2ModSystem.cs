using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace ChuteableQuernElectricBoogaloo
{
    public class ChuteableQuernV2ModSystem : ModSystem
    {
        public override void StartServerSide(ICoreServerAPI api)
        {
            api.RegisterBlockEntityClass("Quern", typeof(BlockEntityChuteableQuern));
        }
    }
}
