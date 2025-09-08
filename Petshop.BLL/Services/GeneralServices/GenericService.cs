﻿using AutoMapper;
using Microsoft.EntityFrameworkCore.Query;
using Petshop.BLL.Services.Contracts;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;
using System.Linq.Expressions;

namespace Petshop.BLL.Services.GeneralServices
{
    public class GenericService<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel> : IGenericService<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel> where TEntity : BaseEntity
    {
        internal readonly IRepository<TEntity> Repository;
        private readonly IMapper _mapper;

        public GenericService(IRepository<TEntity> repository, IMapper mapper)
        {
            Repository = repository;
            _mapper = mapper;
        }

        public async Task<TViewModel> AddAsync(TCreateViewModel entity)
        {
            var mappedEntity = _mapper.Map<TEntity>(entity);
            await Repository.AddAsync(mappedEntity);

            return _mapper.Map<TViewModel>(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await Repository.GetByIdAsync(id);
            
            if(entity == null)
            {
                return false;
            }

            return await Repository.DeleteAsync(entity);
        }

        public async Task<IList<TViewModel>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, bool asnotracking = false)
        {
            var categoriesFromDb = await Repository.GetAllAsync(predicate, include, orderBy, asnotracking);

            var categories = _mapper.Map<IList<TViewModel>>(categoriesFromDb);

            return categories.ToList();

        }

        public async Task<TViewModel?> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool asnotracking = false)
        {
            var entityFromDb = await Repository.GetAsync(predicate, include, asnotracking);

            if (entityFromDb == null)
            {
                return default;
            }

            var entity = _mapper.Map<TViewModel>(entityFromDb);

            return entity;
        }

        public async Task<TViewModel?> GetByIdAsync(int id)
        {
            var entityFromDb = await Repository.GetByIdAsync(id);

            if (entityFromDb == null)
            {
                return default;
            }

            var entity = _mapper.Map<TViewModel>(entityFromDb);

            return entity;
        }

        public async Task<bool> UpdateAsync(TUpdateViewModel entity)
        {
            var mappedEntity = _mapper.Map<TEntity>(entity);

            if(mappedEntity.Id == 0)
            {
                return false;
            }

            return await Repository.UpdateAsync(mappedEntity);
        }
    }
}
