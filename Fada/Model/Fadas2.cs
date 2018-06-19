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

        private string nome2;

        private string nome3;

        private string familia;

        private string familia2;

        private string cor;

        private string cor2;

        private string corAsa;

        private decimal tamanhoAsa;

        private bool asaQuebrada;

        private bool ehMulher;

        private bool barulho;

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
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }

                nome = value;
            }
        }

        public string Nome2
        {
            get { return nome2; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }

                nome2 = value;
            }
        }

        public string Nome3
        {
            get { return nome3; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }

                nome3 = value;
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

        public string Familia2
        {
            get { return familia2; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Família deve ser preenchida");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Família deve conter no mínimo 2 caracteres");
                }

                familia2 = value;
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

                cor = value;
            }
        }

        public string Cor2
        {
            get { return cor2; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor deve ser preencher");
                }

                cor2 = value;
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

        public decimal TamanhoAsa
        {
            get { return tamanhoAsa; }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Tamanho da asa deve conter pequeno, médio e grande");
                }

                tamanhoAsa = value;
            }
        }

        public bool AsaQuebrada
        {
            get { return asaQuebrada; }

            set
            {
                if (asaQuebrada == true)
                {
                    throw new Exception("Asa quebrada deve ser preenchida");
                }

                asaQuebrada = value;
            }
        }

        public bool EhMulher
        {
            get { return ehMulher; }

            set
            {
                if (ehMulher == true)
                {
                    throw new Exception("Sexo deve ser preenchida");
                }

                ehMulher = value;
            }
        }

        public bool Barulho
        {
            get { return barulho; }

            set
            {
                if (barulho == true)
                {
                    throw new Exception("Faz barulho deve ser preenchida");
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


        public Fadas2(string nome, string familia, string cor, bool ehMulher)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
            EhMulher = ehMulher;
        }

        public Fadas2(string nome2, string familia2, string cor2)
        {
            Nome2 = nome2;
            Familia2 = familia2;

        }
    }
}