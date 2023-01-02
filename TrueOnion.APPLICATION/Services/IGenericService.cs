using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.APPLICATION.Services
{
    public interface IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : SaveVM
        where ViewModel : IBaseVM
        where Entity : class, IEntity
    {
        //Find Command
        Task<Result<SaveViewModel>> FindAsync(params object[] values);

        //Linq 
        Task<Result<bool>> AnyAsync(Expression<Func<Entity, bool>> expression);
        Task<Result<ViewModel>> FirstOrDefaultAsync(Expression<Func<Entity, bool>> expression);
        //Task<Response<object>> Select(Expression<Func<Entity, object>> expression); //toDo : usage ?

        //List Commands
        Task<Result<List<ViewModel>>> GetAll();
        Task<Result<List<ViewModel>>> GetActives();
        Task<Result<List<ViewModel>>> GetPassives();
        Task<Result<List<ViewModel>>> GetModifieds();
        Task<Result<List<ViewModel>>> Where(Expression<Func<Entity, bool>> expression);

        //Modify Commands
        Task AddAsync(SaveViewModel viewModel);
        Task AddRangeAsync(IEnumerable<SaveViewModel> viewModels);
        Task UpdateAsync(SaveViewModel viewModel);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(IEnumerable<int> ids);
        Task DestroyAsync(ViewModel viewModel);
        Task DestroyRangeAsync(IEnumerable<ViewModel> viewModels);
    }
}
