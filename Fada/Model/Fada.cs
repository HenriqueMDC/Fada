using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
        private string nome;

        private string familia;

        private string cor;

        private string corAsa;

        private double tamanhoAsa;

        private bool asaQuebrada;

        private bool ehMulher;

        private bool fazBarulho;

        private string elemento;


        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no minimo 2 caracteres");
                }

                nome = value;
            }
        }
    }
}
