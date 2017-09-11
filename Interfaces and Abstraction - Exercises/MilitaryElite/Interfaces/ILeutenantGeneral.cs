using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        List<IPrivate> Privates { get; }
    }
}
