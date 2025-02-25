using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao.Models
{
    public class Tarefa
    {
        private string nome;
        private string descricao;
        private DateTime inserida;
        private DateTime? concluida;
        private bool pronto;
        private int codigo;
        private static int id = 0;

        public Tarefa()
        {
            id++;
            codigo = id;
            inserida = DateTime.Now;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Inserida { get => inserida; }
        public DateTime? Concluida { get => concluida; }
        public bool Pronto { get => pronto; set => pronto = value; }
        public int Codigo { get => codigo; }
        public static int Id { get => id; }
    }
}
