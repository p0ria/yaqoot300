using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaqoot300.Interfaces
{
    public interface IAction
    {
        string Type { get; }
    }

    public interface IReducer<TState>
    {
        void Reduce(TState state, IAction action);
    }
}
