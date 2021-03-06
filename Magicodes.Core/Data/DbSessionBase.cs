﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magicodes.Web.Interfaces.Data;

namespace Magicodes.Core.Data
{
    [Obsolete("暂时废弃")]
    public class DbSessionBase<TDbContext> : IDbSession 
        where TDbContext:DbContext,new()
    {
        private bool isDisposed;
        protected TDbContext context = new TDbContext();
        public IUnitOfWork StartupUnitOfWork()
        {
           // return new UnitOfWorkBase<TDbContext>(context);
            return null;
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                context.Dispose();
                isDisposed = true;
            }
        }
    }
}
