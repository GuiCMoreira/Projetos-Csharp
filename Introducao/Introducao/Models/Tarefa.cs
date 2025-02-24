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
        private DateTime? finalizada;
        private bool pronto;
        private int codigo;
        private static int id = 0;
    }
}
