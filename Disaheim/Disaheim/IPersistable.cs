using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public interface IPersistable
    {
        void Save();
        void Save(string fileName);
        void Load();
        void Load(string fileName);
    }
}
