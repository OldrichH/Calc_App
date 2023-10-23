using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calculator_App.Models.db
{
    public class CalcHistoryRepository
    {
        private DataContext Context;

        public CalcHistoryRepository(DataContext context)
        {
            Context = context;
        }

        public List<Calculation> FindLatest()
        {
            return Context.Calculation.OrderByDescending(h => h.Date).Take(10).ToList();
        }

        public void CreateRecord(Calculation record)
        {
            Context.Calculation.Add(record);
            Context.SaveChanges();
        }
    }
}
