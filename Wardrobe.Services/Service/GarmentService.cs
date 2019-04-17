using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wardrobe.Data;
using Wardrobe.Data.IDAO;
using Wardrobe.Data.DAO;

namespace Wardrobe.Services.Service
{
    public class GarmentService : Wardrobe.Services.IService.IGarmentService

    {
        private IGarmentDAO _garmentDAO;
        public GarmentService()
        {
            _garmentDAO = new GarmentDAO();
        }
        public IList<Garment> GetAllGarments()
        {
            return _garmentDAO.GetAllGarments();
        }

    }
}
