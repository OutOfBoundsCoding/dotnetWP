using DotnetWp.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetWp.Core
{
    
   public class WordPressDbContext: DbContext
   {
      public WordPressDbContext(DbContextOptions<WordPressDbContext> options) : base(options) { }
      public virtual DbSet<Term> Terms { get; set; }
      public virtual DbSet<TermTaxonomy> TermTaxonomies { get; set; }
      public virtual DbSet<Post> Posts { get; set; }
      public virtual DbSet<TermRelationship> TermRelationships { get; set; }
   }
}