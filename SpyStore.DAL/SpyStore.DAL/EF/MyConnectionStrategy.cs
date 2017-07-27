using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace SpyStore.DAL.EF
{
    public class MyConnectionStrategy : ExecutionStrategy
    {
        public MyConnectionStrategy(ExecutionStrategyContext context) : base(context, ExecutionStrategy.DefaultMaxRetryCount, ExecutionStrategy.DefaultMaxDelay)
        {

        }

        public MyConnectionStrategy(ExecutionStrategyContext context, int maxRetryCount, TimeSpan maxRetryDelay) : base(context, maxRetryCount, maxRetryDelay)
        {

        }

        protected override bool ShouldRetryOn(Exception exception)
        {
            return true;
        }
    }
}
