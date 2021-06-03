﻿using DestinyCore.Entity;
using DestinyCore.Ui;
using System;
using System.Threading.Tasks;

namespace DestinyCore.Application
{
    public interface ICrudServiceAsync<TEntity, TPrimaryKey>
            where TEntity : IEntity<TPrimaryKey>, IEquatable<TPrimaryKey>
    {


        /// <summary>
        /// 异步添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<OperationResponse> AddAsync(TEntity entity);

        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<OperationResponse> UpdateAsync(TEntity entity);


        /// <summary>
        /// 异步删除sss
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<OperationResponse> DeleteAsync(TPrimaryKey key);
    }
}