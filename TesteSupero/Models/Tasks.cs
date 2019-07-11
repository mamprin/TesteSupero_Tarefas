using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TesteSupero.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }

    public class Tarefa
    {
        [Key]
        public int IdTarefa { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o nome da Tarefa")]
        public string NomeTarefa { get; set; }

        public bool StatusTarefa { get; set; }
    }

}
