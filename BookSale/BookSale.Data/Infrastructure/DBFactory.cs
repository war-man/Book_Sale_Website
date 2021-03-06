﻿namespace BookSale.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BookSaleDbContext dbContext;

        public BookSaleDbContext Init()
        {
            return dbContext ?? (dbContext = new BookSaleDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}