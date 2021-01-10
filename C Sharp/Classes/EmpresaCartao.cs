using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    class EmpresaCartao
    {
        public Comprador correntista;
        // private String nome; <--- Linha inutilizada

        public String Pais { get; private set; }

        public String Nome { get; private set; }

        public EmpresaCartao(String nome = "sem nome")
        {
            this.Nome = nome;
        }

        public EmpresaCartao(String nome = "sem nome", String pais = "sem pais")
        {
            this.Nome = nome;
            this.Pais = pais;
        }

        public void coisa(Comprador comprador) // Método criado para testes
        {

        }
    }
}
