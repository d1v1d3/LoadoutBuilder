using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadoutBuilder.ViewModels.Loadout;

namespace LoadoutBuilder.Services.Contracts
{
    public interface ILoadoutService
    {
        Task<IEnumerable<LoadoutIndexViewModel>> GetLoadoutsByUserOrderedByIdAsync();
        Task AddLoadoutAsync(LoadoutFormModel model);

    }
}
