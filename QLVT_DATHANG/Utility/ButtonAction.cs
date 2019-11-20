using System.Data;

namespace QLVT_DATHANG.Utility
{
   public class ButtonAction
   {
      public ButtonActionType ActionType { get; set; }

      public object[] SaveItems { get; set; }

      public ButtonAction(ButtonActionType actionType, object[] saveItems)
      {
         this.ActionType = actionType;
         this.SaveItems = saveItems;
      }
   }
}
