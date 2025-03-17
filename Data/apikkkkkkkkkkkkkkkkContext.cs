using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apikkkkkkkkkkkkkkkk.Models;

namespace apikkkkkkkkkkkkkkkk.Data
{
    public class apikkkkkkkkkkkkkkkkContext : DbContext
    {
        public apikkkkkkkkkkkkkkkkContext (DbContextOptions<apikkkkkkkkkkkkkkkkContext> options)
            : base(options)
        {
        }

        public DbSet<apikkkkkkkkkkkkkkkk.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<apikkkkkkkkkkkkkkkk.Models.Professor> Professor { get; set; } = default!;
        public DbSet<apikkkkkkkkkkkkkkkk.Models.Escola> Escola { get; set; } = default!;
    }
}
