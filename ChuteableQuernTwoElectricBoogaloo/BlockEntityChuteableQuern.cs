using HarmonyLib;
using System;
using System.Reflection;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
using Vintagestory.GameContent;

namespace ChuteableQuernElectricBoogaloo
{
    public class BlockEntityChuteableQuern : BlockEntityQuern
    {
        private static readonly FieldInfo inventoryField = typeof(BlockEntityQuern).GetField("inventory", BindingFlags.Instance | BindingFlags.NonPublic);
        private static readonly MethodInfo methodInfo = typeof(BlockEntityQuern).GetMethod("OnSlotModifid", BindingFlags.Instance | BindingFlags.NonPublic);

        public BlockEntityChuteableQuern()
        {
            InventoryChuteableQuern inventoryChuteableQuern = new InventoryChuteableQuern(null, null);
            inventoryField.SetValue(this, inventoryChuteableQuern);
            inventoryChuteableQuern.SlotModified += new Action<int>(this.OnSlotModified);
        }

        private void OnSlotModified(int slotId)
        {
            methodInfo.Invoke(this, [slotId]);
        }
    }
}
