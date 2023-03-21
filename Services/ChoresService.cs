using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_list.Services
{
    public class ChoresService
    {
        private readonly ChoresRepository _choresRepository;
        public ChoresService(ChoresRepository choresRepository){
            _choresRepository = choresRepository;
        }
        public List<Chore> GetAllChores(){
            return _choresRepository.GetAllChores();
        }
    }
}