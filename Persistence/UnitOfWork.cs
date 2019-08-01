﻿using Knigosha.Core;

namespace Knigosha.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
