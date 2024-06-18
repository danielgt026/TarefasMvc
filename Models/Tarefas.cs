using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarefasMvc.Models.Enuns;

namespace TarefasMvc.Models
{
    public class Tarefas
    {
         public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Prioridade Prioridade { get; set; }
        public Status Status { get; set; }
        public DateTime? DataCriacao { get; set; } //using System;
    }
}