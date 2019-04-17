using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe.Data.IDAO
{
    public interface IGarmentDAO
    {
        IList<Garment> GetAllGarments();
    }
}
