using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fadas2
    {
        private string nome;

        private string familia;

        private string cor;

        private string corAsa;

        private string tamanhoAsa;

        private string asaQuebrada;

        private string sexo;

        private string barulho;

        private string elemento;


        public string Nome
        {
            get { return nome; }

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

        public string Familia
        {
            get { return familia; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Familia deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Família deve conter no mínimo 2 caracteres");
                }

                familia = value;
            }
        }

        public string Cor
        {
            get { return cor; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Cor deve conter no mínimo 2 caracteres");
                }

                cor = value;
            }
        }

        public string CorAsa
        {
            get { return corAsa; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor da asa deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Cor de asa deve conter no mínimo 2 caracteres");
                }

                corAsa = value;
            }
        }

        public string TamanhoAsa
        {
            get { return tamanhoAsa; }

            set
            {
                if (value.Count() == 0)
                {
                    throw new Exception("Valor deve conter mais que Zero");
                }

                tamanhoAsa = value;
            }
        }

        public string AsaQuebrada
        {
            get { return asaQuebrada; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Asa quebrada deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Asa quebrada deve conter no mínimo 2 caracteres");
                }

                asaQuebrada = value;
            }
        }

        public string Sexo
        {
            get { return sexo; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Sexo deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Sexo deve conter no mínimo 2 caracteres");
                }

                sexo = value;
            }
        }

        public string Barulho
        {
            get { return barulho; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Faz barulho deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Faz barulho deve conter no mínimo 2 caracteres");
                }

                barulho = value;
            }
        }

        public string Elemento
        {
            get { return elemento; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Elemento deve ser preenchido");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Elemento deve conter no mínimo 2 caracteres");
                }

                elemento = value;
            }
        }


        public Fadas2(string nome, string familia, string cor, string sexo)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
            Sexo = sexo;
        }
    }
}
