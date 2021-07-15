using Data;
using Data.Models;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service
{
    public class BookService : IBook
    {
        private readonly ApplicationDbConext _context;

        public BookService(ApplicationDbConext context)
        {
            this._context = context;
        }

        public async Task<BookEntity> Add(BookEntity entity)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var result = await _context.Books.AddAsync(entity);
                if (result.State == EntityState.Added)
                {
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }

                return entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync();
                throw e;
            }

        }

        public async Task<bool> Delete(int id)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var result = await _context.Books.Where(b => b.Id == id).FirstOrDefaultAsync();
                if (result == null)
                    throw new Exception("Book not found");

                _context.Books.Remove(result);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                return true;

            }

            catch (Exception e)
            {
                await transaction.RollbackAsync();
                throw e;
            }
        }

        public BookEntity Get(int id)
        {
            var result = _context.Books.Where(b => b.Id == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<BookEntity> GetAll()
        {
            return _context.Books.ToList();
        }

        public async Task<bool> Update(BookEntity entity)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var result = await _context.Books.Where(b => b.Id == entity.Id).FirstOrDefaultAsync();
                if (result == null)
                    throw new Exception("Book not found");

                result = entity;
                _context.Books.Update(result);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }

        }
    }
}
