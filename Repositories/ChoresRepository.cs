using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_list.Repositories;

public class ChoresRepository
{
    private List<Chore> dbChores = new List<Chore>();
    public ChoresRepository(){
        dbChores.Add(new Chore("laundry", "laundry", 1, true));
        dbChores.Add(new Chore("journal", "week 9 day 1-4 + quiz", 2, true));
        dbChores.Add(new Chore("food", "eat to survive", 3, false));
    }
    internal List<Chore> GetAllChores(){
        return dbChores.ToList();
    }
}
