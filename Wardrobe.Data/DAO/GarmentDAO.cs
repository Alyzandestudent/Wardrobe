using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wardrobe.Data.IDAO;

namespace Wardrobe.Data.DAO
{
    public class GarmentDAO : IGarmentDAO
    {
        private b8041046Entities _context;
        public GarmentDAO()
        {
            _context = new b8041046Entities();
        }
        public IList<Garment> GetGarments()
        {
            IQueryable<Garment> _garments;
            _garments = from Garment
                        in _context.Garment
                        select Garment;
            return _garments.ToList<Garment>();
        }
 
 
    }
}
