using blogpessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace blogpessoal.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Postagem>().ToTable("tb_postagens");
            modelBuilder.Entity<Tema>().ToTable("tb_temas");
            modelBuilder.Entity<User>().ToTable("tb_usuarios");

            //Criando o relacionamento entre as duas entidades (UM PARA MUITOS)

            _ = modelBuilder.Entity<Postagem>()
                .HasOne(_ => _.Tema)                     //Indicando quem sera o lado UM da relação
                .WithMany(t => t.Postagem)              //Indicando quem sera o lado MUITOS da relação
                .HasForeignKey("TemaId")                //Indicando a chave estrangeira
                .OnDelete(DeleteBehavior.Cascade);      //Indicando o cascateamento de deletar temas

            _ = modelBuilder.Entity<Postagem>()
               .HasOne(_ => _.Usuario)                    
               .WithMany(u => u.Postagem)              
               .HasForeignKey("UsuarioId")                
               .OnDelete(DeleteBehavior.Cascade);
        }

        //Registrar um DbSet - Objeto responsável por manipular a tabela

        public DbSet<Postagem> Postagens { get; set; } = null!;
        public DbSet<Tema> Temas { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var insertedEntries = this.ChangeTracker.Entries()
                                   .Where(x => x.State == EntityState.Added)
                                   .Select(x => x.Entity);

            foreach (var insertedEntry in insertedEntries)
            {
                //Se uma propriedade da Classe Auditable estiver sendo criada. 
                if (insertedEntry is Auditable auditableEntity)
                {
                    auditableEntity.Data = new DateTimeOffset(DateTime.Now, new TimeSpan(-3,0,0));
                }
            }

            var modifiedEntries = ChangeTracker.Entries()
                       .Where(x => x.State == EntityState.Modified)
                       .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                //Se uma propriedade da Classe Auditable estiver sendo atualizada.  
                if (modifiedEntry is Auditable auditableEntity)
                {
                    auditableEntity.Data = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
