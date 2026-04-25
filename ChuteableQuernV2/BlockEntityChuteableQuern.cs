using System;
using System.Reflection;
using Vintagestory.GameContent;

namespace ChuteableQuernElectricBoogaloo
{
    public class BlockEntityChuteableQuern : BlockEntityQuern
    {
        private static readonly FieldInfo inventoryField = typeof(BlockEntityQuern).GetField("inventory", BindingFlags.Instance | BindingFlags.NonPublic);
        private static readonly MethodInfo methodInfo = typeof(BlockEntityQuern).GetMethod("OnSlotModified", BindingFlags.Instance | BindingFlags.NonPublic);

        public BlockEntityChuteableQuern()
        {
            InventoryChuteableQuern inventoryChuteableQuern = new InventoryChuteableQuern(null, null);
            inventoryField.SetValue(this, inventoryChuteableQuern);
            inventoryChuteableQuern.SlotModified += new Action<int>(OnSlotModified);
        }

        private void OnSlotModified(int slotId)
        {
            methodInfo.Invoke(this, [slotId]);
        }
    }
}
