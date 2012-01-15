using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igor
{
    public class IgorService : IIgorService
    {
        public IEnumerable<ItemAction> GetActionsFor(string p)
        {
            return new List<ItemAction>() { new ItemAction() };
        }
    }
}
