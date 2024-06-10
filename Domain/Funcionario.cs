using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Funcionario : Base
    {
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public decimal salario { get; set; }
        public DateTime DataDeContratacao { get; set; }
        public DateTime DataDeDemicao { get; set; }
        public Base Base { get; set; }
    }
}
