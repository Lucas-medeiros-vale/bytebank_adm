using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticado(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return senha == senha;
        }
    }
}
