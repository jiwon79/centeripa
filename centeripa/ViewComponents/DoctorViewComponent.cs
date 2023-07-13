using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

using centeripa.Models;

namespace centeripa.ViewComponents
{
    public class DoctorViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(DoctorModel doctor)
        {
            return View(doctor);
        }

        // private Task<List<DoctorModel>> GetListAsync()
        // {
        //     return Task.FromResult(GetList());
        // }

        // private List<DoctorModel> GetList()
        // {
        //     DoctorRepository repository = new DoctorRepository();

        //     return repository.GetList();
        // }
    }
}