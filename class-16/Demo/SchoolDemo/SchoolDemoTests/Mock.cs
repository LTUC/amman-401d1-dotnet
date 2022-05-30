using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using System;

namespace SchoolDemoTests
{
    public abstract class Mock
    {
        private readonly SqliteConnection _connection;
        protected readonly SchoolDbContext _db;
        public Mock()
        {
           
      }
    }
}
