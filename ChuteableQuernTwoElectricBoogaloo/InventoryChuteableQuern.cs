using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace ChuteableQuernElectricBoogaloo
{
    public class InventoryChuteableQuern : InventoryQuern
    {
        public InventoryChuteableQuern(string inventoryID, ICoreAPI api)
          : base(inventoryID, api)
        {
        }

        public InventoryChuteableQuern(string className, string instanceID, ICoreAPI api)
          : base(className, instanceID, api)
        {
        }

        public override ItemSlot GetAutoPullFromSlot(BlockFacing atBlockFace)
        {
            return base[1];
        }
    }
}
