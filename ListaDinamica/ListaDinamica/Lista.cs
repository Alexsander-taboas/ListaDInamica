using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    /**
        * ok - Inserir(valor);            // Insere no final da lista
        * ok - Inserir(valor, posicao);   // Insere na posição desejada 
        * ok - Excluir();                 // Exclui a última posição
        * ok - Excluir(posicao);          // Exclui a posicao desejada
        * ok - Imprimir();                // Imprime todos os valores da lista
        * ok - Ordenacao();               // Ordenacao da lista crescente/decrescente
        * ok - Pesquisar(valor);          // Pesquisa por valor e retorna T/F
        * Alterar(valor, posicao); // Altera o valor da posição desejada 
    **/

    class Lista
    {
        Noh primeiro = null;
        Noh ultimo = null;
        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public void Inserir(string Valor)
        {
            Noh nn = new Noh();

            Quantidade++;

            if(Quantidade == 1)
            {
                nn.Valor = Valor;
                nn.Frente = null;
                nn.Atras = null;

                primeiro = nn;
                ultimo = nn;
            }
            else
            {
                nn.Valor = Valor;
                nn.Frente = ultimo;
                nn.Atras = null;

                ultimo.Atras = nn;
                ultimo = nn;
            }
        }

        public void Inserir(string Valor, int Posicao)
        {
            Noh nn = new Noh();   // é o novo valor
            Noh npos = primeiro; // noh que recebe os dados da posição que será
                                  // inserido o novo valor

            Quantidade++;

            if (Posicao == 1)
            {
                nn.Valor = Valor;
                nn.Frente = null;
                nn.Atras = primeiro;
                primeiro = nn;
            }
            else
            {
                if (Posicao > Quantidade)
                {
                    Inserir(Valor);  // é um inserir simple no final da lista
                }
                else
                {
                    for (int i = 1; i < Posicao; i++)
                    {
                        npos = npos.Atras;
                    }

                    nn.Valor = Valor;
                    nn.Frente = npos.Frente;
                    nn.Atras = npos;
                    npos.Frente = nn;
                    nn.Frente.Atras = nn;
                    nn.Atras.Frente = nn;
                }
            }

        }
        
        public void Imprimir()
        {
            Noh aux = primeiro;

            for (int i = 1; i <= Quantidade; i++)
            {
                Console.WriteLine(aux.Valor);
                aux = aux.Atras;
            }
                

        }

        public void Excluir()
        {
            if (Quantidade == 1)
            {
                primeiro = null;
                ultimo = null;
                Quantidade = 0;
            }
            else
            {
                ultimo = ultimo.Frente;
                Quantidade--;
            }
        }

        public void Excluir(int posicao)
        {

            if(posicao == 1)
            {
                if(Quantidade == 1)
                {
                    primeiro = null;
                    ultimo = null;
                    Quantidade = 0;
                }
                else
                {
                    primeiro = primeiro.Atras;
                    Quantidade--;
                }
            }
            else
            {
                if(posicao >= Quantidade)
                {
                    Excluir();
                }
                else
                {
                    Noh ne = primeiro;
                    for (int i = 1; i < posicao; i++)
                    {
                        ne = ne.Atras;
                    }

                    // NE dê um passo para frente e quem vai estar
                    // atras será o que está atrás de do NE 
                    ne.Frente.Atras = ne.Atras;
                    ne.Atras.Frente = ne.Frente;
                    Quantidade--;

                }
            }
        }

        public void Ordenar()
        {
            Noh auxFixa = primeiro;
            Noh auxProx;
            string auxTroca = null;

            for (int i = 1; i < Quantidade; i++)
            {
                auxProx = auxFixa.Atras;

                for (int j = i+1; j <= Quantidade; j++)
                {
                    if (auxFixa.Valor.CompareTo(auxProx.Valor) > 0)
                    {
                        auxTroca = auxFixa.Valor;
                        auxFixa.Valor = auxProx.Valor;
                        auxProx.Valor = auxTroca;
                    }
                    auxProx = auxProx.Atras;
                }
                auxFixa = auxFixa.Atras;
            }
        }

        public bool Pesquisar(string valorPesquisa)
        {
            Noh np = primeiro;

            for (int i = 1; i <= Quantidade; i++)
            {
                if(valorPesquisa == np.Valor)
                {
                    return true;
                }

                np = np.Atras;
            }

            return false;        
        }
    }
}
