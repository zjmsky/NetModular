﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Abstractions.Entities;
using NetModular.Lib.Data.Abstractions.SqlQueryable.GroupByQueryable;
using NetModular.Lib.Data.Core.SqlQueryable.Internal;

namespace NetModular.Lib.Data.Core.SqlQueryable.GroupByQueryable
{
    internal class GroupByQueryable1<TKey, TEntity> : GroupByQueryableAbstract, IGroupByQueryable1<TKey, TEntity> where TEntity : IEntity
    {
        public GroupByQueryable1(IDbSet db, QueryBody queryBody, QueryBuilder queryBuilder, Expression expression) : base(db, queryBody, queryBuilder, expression)
        {
        }

        public IGroupByQueryable1<TKey, TEntity> Having(Expression<Func<INetSqlGrouping1<TKey, TEntity>, bool>> expression)
        {
            SetHaving(expression);
            return this;
        }

        public IGroupByQueryable1<TKey, TEntity> OrderBy(string customOrderBy)
        {
            SetOrderBy(customOrderBy);
            return this;
        }

        public IGroupByQueryable1<TKey, TEntity> OrderByDescending(string customOrderBy)
        {
            SetOrderByDescending(customOrderBy);
            return this;
        }

        public IGroupByQueryable1<TKey, TEntity> OrderBy<TResult>(Expression<Func<INetSqlGrouping1<TKey, TEntity>, TResult>> expression)
        {
            SetOrderBy(expression);
            return this;
        }

        public IGroupByQueryable1<TKey, TEntity> OrderByDescending<TResult>(Expression<Func<INetSqlGrouping1<TKey, TEntity>, TResult>> expression)
        {
            SetOrderByDescending(expression);
            return this;
        }

        public IGroupByQueryable1<TKey, TEntity> Select<TResult>(Expression<Func<INetSqlGrouping1<TKey, TEntity>, TResult>> expression)
        {
            SetSelect(expression);
            return this;
        }

        public IList<TEntity> ToList()
        {
            return ToList<TEntity>();
        }

        public Task<IList<TEntity>> ToListAsync()
        {
            return ToListAsync<TEntity>();
        }
    }
}
