using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeller
{
    public static class Db
    {
        public static AppDbContext Context;
        public static void Initialize()
        {
            Context = new AppDbContext();
            Context.Database.EnsureCreated();
        }
    }
}
