using Dapper;
using DestinyCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DestinyCore.EntityFrameworkCore
{
    public class DapperRepository : IDapperRepository
    {
        private readonly IUnitOfWork _unitOfWork = null;

        public DapperRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            DbConnection = _unitOfWork.GetDbContext().Database.GetDbConnection();
        }

        public IDbConnection DbConnection { get; set; }

        /// <summary>
        /// ��ʽ����Dispose���� 
        /// </summary>
        ~DapperRepository()
        {
            //Ϊfalse
            Dispose(false);
        }
        /// <summary>
        /// �ͷ�
        /// </summary>
        public void Dispose()
        {
            //����true
            Dispose(true);
            //���ٵ����ս�������������
            GC.SuppressFinalize(this);
        }

        protected bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                //����GC����Ҫ������������
                GC.SuppressFinalize(this);
                
            }
            DbConnection?.Dispose();
            _disposed = true;
        }

        public Task<IEnumerable<T>> QueryAsync<T>(string sql, object param)
        {
            return DbConnection.QueryAsync<T>(sql, param);
        }
    }
}