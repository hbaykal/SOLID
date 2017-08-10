using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After
{
    public interface ICoordinatingServices
    {
        void CoordinateTransaction(IList<IWidget> widgets);
    }
}
