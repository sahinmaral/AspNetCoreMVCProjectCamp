using System.Collections.Generic;

namespace CoreDemo.Logic
{
    public class LogicRules
    {
        public static string Run(Dictionary<string,bool> logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Value)
                {
                    return logic.Key;
                }
            }

            return string.Empty;
        }
    }
}
