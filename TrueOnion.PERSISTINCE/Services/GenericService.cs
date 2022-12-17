﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Common;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.PERSISTINCE.Services
{
    public class GenericService<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : ISaveVM
        where ViewModel : IBaseVM
        where Entity : BaseEntity
    {
        private readonly IGenericRepository<Entity> _repository;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(SaveViewModel viewModel)
        {
            await _repository.AddAsync(_mapper.Map<Entity>(viewModel));
        }

        public async Task AddRangeAsync(IEnumerable<ViewModel> viewModels)
        { 
           await  _repository.AddRangeAsync(_mapper.Map<IEnumerable<Entity>>(viewModels));
        }

        public async  Task<Result<bool>> AnyAsync(Expression<Func<Entity, bool>> expression)
        {
            bool isExist = await _repository.AnyAsync(expression);
            return Result<bool>.Success(StatusCodes.Status200OK, isExist);
        }

        public Task DestroyAsync(ViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task DestroyRangeAsync(IEnumerable<ViewModel> viewModels)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<SaveViewModel>> FindAsync(params object[] values)
        {
            Entity entity = await _repository.FindAsync(values);
            //ViewModel viewModel = _mapper.Map<ViewModel>(entity);
            SaveViewModel saveViewModel = _mapper.Map<SaveViewModel>(entity);
            return Result<SaveViewModel>.Success(StatusCodes.Status200OK, saveViewModel);
        }

        public async Task<Result<ViewModel>> FirstOrDefault(Expression<Func<Entity, bool>> expression)
        {
            Entity entity = await _repository.FirstOrDefaultAsync(expression);
            ViewModel viewModel = _mapper.Map<ViewModel>(entity);
            return Result<ViewModel>.Success(StatusCodes.Status200OK, viewModel);
        }

        public async Task<Result<List<ViewModel>>> GetActives()
        {
            IEnumerable<Entity> entities = (await _repository.GetAll(x => x.Status != DataStatus.Deleted));
            List<ViewModel> viewModels = _mapper.Map<List<ViewModel>>(entities);
            return Result<List<ViewModel>>.Success(StatusCodes.Status200OK, viewModels);
        }

        public async Task<Result<List<ViewModel>>> GetAll()
        {
            IEnumerable<Entity> entities = await _repository.GetAllAsIQueryable().ToListAsync();
            List<ViewModel> viewModels = _mapper.Map<List<ViewModel>>(entities);
            return Result<List<ViewModel>>.Success(StatusCodes.Status200OK, viewModels);
        }

        public async Task<Result<List<ViewModel>>> GetModifieds()
        {
            IEnumerable<Entity> entities = await _repository.GetAll(x => x.Status == DataStatus.Modified);
            List<ViewModel> viewModels = _mapper.Map<List<ViewModel>>(entities);
            return Result<List<ViewModel>>.Success(StatusCodes.Status200OK, viewModels);
        }

        public async Task<Result<List<ViewModel>>> GetPassives()
        {
            IEnumerable<Entity> entities = await _repository.GetAll(x => x.Status == DataStatus.Deleted);
            List<ViewModel> viewModels = _mapper.Map<List<ViewModel>>(entities);
            return Result<List<ViewModel>>.Success(StatusCodes.Status200OK, viewModels);
        }

        public Task RemoveAsync(ViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(IEnumerable<ViewModel> viewModels)
        {
            throw new NotImplementedException();
        }

        public async     Task<Result<object>> Select(Expression<Func<Entity, object>> expression)
        {
            object result = await _repository.Select(expression);
            return Result<object>.Success(StatusCodes.Status200OK,result);
        }

        public Task UpdateAsync(ViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}