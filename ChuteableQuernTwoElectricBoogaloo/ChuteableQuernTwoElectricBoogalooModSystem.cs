using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace ChuteableQuernElectricBoogaloo
{
    public class ChuteableQuernTwoElectricBoogalooModSystem : ModSystem
    {
        public override void StartServerSide(ICoreServerAPI api)
        {
            api.RegisterBlockEntityClass("Quern", typeof(BlockEntityChuteableQuern));
        }
    }
}
