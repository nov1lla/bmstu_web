using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.RepositoryInterfaces
{
    public interface IPromoRepository
    {
        Promo GetPromo(int id);
        Promo GetPromo(string code);
        void AddPromo(Promo Promo);
        void DelPromo(Promo Promo);
        void UpdatePromo(Promo Promo);

        List<Promo> GetAllPromos();

        bool IsExistPromo(Promo Promo);
    }
}
