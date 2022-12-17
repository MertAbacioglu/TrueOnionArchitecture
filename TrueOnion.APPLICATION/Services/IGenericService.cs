﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.APPLICATION.Services
{
    public interface IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : ISaveVM
        where ViewModel : IBaseVM
        where Entity : BaseEntity
    {
        //Find Command
        Task<Result<SaveViewModel>> FindAsync(params object[] values);

        //Linq 
        Task<Result<bool>> AnyAsync(Expression<Func<Entity, bool>> expression);
        Task<Result<ViewModel>> FirstOrDefault(Expression<Func<Entity, bool>> expression);
        //Task<Response<object>> Select(Expression<Func<Entity, object>> expression); //toDo : usage ?

        //List Commands
        Task<Result<List<ViewModel>>> GetAll();
        Task<Result<List<ViewModel>>> GetActives();
        Task<Result<List<ViewModel>>> GetPassives();
        Task<Result<List<ViewModel>>> GetModifieds();

        //Modify Commands
        Task AddAsync(SaveViewModel viewModel);
        Task AddRangeAsync(IEnumerable<ViewModel> viewModels);
        Task UpdateAsync(ViewModel viewModel);
        Task RemoveAsync(ViewModel viewModel);
        Task RemoveRangeAsync(IEnumerable<ViewModel> viewModels);
        Task DestroyAsync(ViewModel viewModel);
        Task DestroyRangeAsync(IEnumerable<ViewModel> viewModels);
    }
}