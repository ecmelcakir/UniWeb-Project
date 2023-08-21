using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class OrnekRepository : BaseRepository<Student>
    {
        public OrnekRepository(UniContext context) : base(context)
        {

        }
    }
}
