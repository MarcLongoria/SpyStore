using System;
using SpyStore.DAL.EF;
using SpyStore.Models.Entities;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace SpyStore.DAL.Tests.ContextTests
{
    [Collection("SpyStore.DAL")]
    public class CategoryTests : IDisposable    
    {
        private readonly StoreContext _db;
        public CategoryTests()
        {
            _db = new StoreContext();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
