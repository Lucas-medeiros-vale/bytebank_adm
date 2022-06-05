using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // N - ...
        //private int _tipo;
        public string Nome { get; set; }

        public string Cpf { get;  private set; }

        public double Salario { get; protected set; }


        public static int totalDeFunciorios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um Funcionario.");
            totalDeFunciorios++;
        }

        public abstract void AumentarSalario();
        public abstract double getBonificacao();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
