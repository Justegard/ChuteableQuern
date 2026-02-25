using Vintagestory.API.Common;

namespace ChuteableQuernElectricBoogaloo
{
    public class ChuteableQuernV2ModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            api.RegisterBlockEntityClass("Quern", typeof(BlockEntityChuteableQuern));
        }
    }
}
