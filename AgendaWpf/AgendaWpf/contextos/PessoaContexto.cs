using AgendaWpf.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWpf.contextos
{
    public class PessoaContexto : DbContext
    {
        public PessoaContexto()
            : base(nameOrConnectionString: "agenda")
        {
          // Database.SetInitializer<PessoaContexto>(new PessoaInitializer());
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
    public class PessoaInitializer : DropCreateDatabaseAlways<PessoaContexto>
    {

    }
}
