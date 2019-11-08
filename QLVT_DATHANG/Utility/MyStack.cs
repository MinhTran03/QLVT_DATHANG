using System;
using System.Collections;

namespace QLVT_DATHANG.Utility
{
   public class MyStack : Stack
   {
      public event EventHandler<StackEventAgrs> StackPushed;
      public event EventHandler<StackEventAgrs> StackPopped;

      public override void Push(object obj)
      {
         base.Push(obj);
         OnStackPushed((ButtonAction)obj);
      }

      public override object Pop()
      {
         var obj = base.Pop();
         if(obj != null)
         {
            OnStackPopped((ButtonAction)obj);
         }
         return obj;
      }

      protected virtual void OnStackPushed(ButtonAction eventAgrs)
      {
         if (StackPushed != null)
            StackPushed.Invoke(this, new StackEventAgrs() { ButtonAction = eventAgrs });
      }

      protected virtual void OnStackPopped(ButtonAction eventAgrs)
      {
         if (StackPushed != null)
            StackPopped.Invoke(this, new StackEventAgrs() { ButtonAction = eventAgrs });
      }
   }
}
