using System;
using System.Reflection.Metadata;


namespace ByteBank.Funcionarios
{
        // Classe Funcionario
    public class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // 3 - Gerente de Conta Corrente
        // 4 - Coordenador
        // N - ...
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}

