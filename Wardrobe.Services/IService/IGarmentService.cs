using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe.Services.IService
{
    public interface IGarmentService
    {
        IList<Wardrobe.Data.Garment> GetGarments();
        
    }
}
