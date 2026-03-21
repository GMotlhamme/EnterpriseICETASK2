using EnterpriseICETASK2.Models;
using Microsoft.AspNetCore.Mvc;


namespace EnterpriseICETASK2.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(Transaction dataFromForm)
        {
            if (dataFromForm.Subtotal <= 0)
            {
                ModelState.AddModelError("", "Subtotal must be greater than 0");
                return View("Index", dataFromForm);
            }

            // 1. Discount
            dataFromForm.Discount = Math.Round(dataFromForm.Subtotal * 0.075m, 2);

            // 2. Subtotal after discount
            var afterDiscount = dataFromForm.Subtotal - dataFromForm.Discount;

            // 3. VAT
            dataFromForm.VAT = Math.Round(afterDiscount * 0.15m, 2);

            // 4. Final Total
            dataFromForm.FinalTotal = Math.Round(afterDiscount + dataFromForm.VAT, 2);

            dataFromForm.Date = DateTime.Now;


            return View("Index", dataFromForm);
        }
    }
}
