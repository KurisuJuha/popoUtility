using System;

namespace JuhaKurisu.PopoTools.Utility
{
    public class ActionForOnlyOnce
    {
        public event Action action;
        public bool invoked { get; private set; }

        public ActionForOnlyOnce(Action action)
        {
            this.action = action;
        }

        public bool Invoke()
        {
            // 呼んだことがあるなら呼ばない
            if (invoked) return false;

            action.Invoke();
            invoked = true;
            return true;
        }

        public void Reset()
        {
            invoked = false;
        }
    }
}