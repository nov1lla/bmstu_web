using BL.Services;
using BL.Models;
using BL.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyException;

namespace UITech
{
    internal class UIPromo
    {
        private PromoService promoService;
        private UserService userService;
        public UIPromo(PromoService promoService, UserService userService)
        {
            this.promoService = promoService;
            this.userService = userService;
        }
        public void ViewAllPromos(int id_user)
        {
            List<Promo> promos = promoService.GetPromoByIdUser(id_user);
            foreach (var promo in promos)
            {
                Console.WriteLine($"ID: {promo.Id}, Code: {promo.Code}, Discount: {promo.Discount}, Data_start: {promo.Data_start}, Data_end: {promo.Data_end}");
            }
        }

        public int UsePromo(string code)
        {
            try
            {
                Promo promo = promoService.GetPromoByCode(code);
                if (promo == null)
                    throw new PromoNotFoundException();
                else
                {
                    if (promo.Data_start < DateTime.Now && DateTime.Now < promo.Data_end)
                    {
                        Console.WriteLine("Used promocode!");
                        return promo.Discount;
                    }
                    return 0;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 0; }

        }
    }
}
