using System.Data;

namespace QLVT_DATHANG.Utility
{
   public class ButtonAction
   {
      public ButtonActionType ActionType { get; set; }

      public DataRowView SaveDataRow { get; set; }

      public ButtonAction(ButtonActionType actionType, DataRowView saveDataRow)
      {
         ActionType = actionType;
         SaveDataRow = saveDataRow;
      }
   }
}
