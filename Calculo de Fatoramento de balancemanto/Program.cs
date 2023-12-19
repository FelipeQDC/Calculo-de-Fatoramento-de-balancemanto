using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArvoreAVL
{
    class Arvore
    {
        public Arvore(int n) // Construtor
        {
            info = n;
            fb = 0;
            sae = sad = null;
        }
        public void Insere(Arvore arv)
        {
            int aux;
            if (arv.info <= this.info)
            {
                if (this.sae == null)
                {
                    this.sae = arv;
                    this.fb = this.fb - 1;
                }
                else
                {
                    aux = this.sae.fb;
                    (this.sae).Insere(arv);
                    if (Math.Abs(this.sae.fb) > Math.Abs(aux))
                        this.fb = this.fb - 1;
                }
            }
            else
            {
                if (this.sad == null)
                {
                    this.sad = arv;
                    this.fb = this.fb + 1;
                }
                else
                {
                    aux = this.sad.fb;
                    (this.sad).Insere(arv);
                    if (Math.Abs(this.sad.fb) > Math.Abs(aux))
                        this.fb = this.fb + 1;
                }
            }
        }
        private int info;
        private int fb;
        Arvore sae;
        Arvore sad;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arvore RAIZ = null;
            Arvore arv;
            int[] vetor = new int[]
            { 50, 40, 35, 42 };
            int n, escolha;
            arv = new Arvore(vetor[0]);
            RAIZ = arv;
            for (int i = 1; i < vetor.Length; i++)
            {
                n = vetor[i];
                arv = new Arvore(n);
                RAIZ.Insere(arv);
            }
            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Árvore");
                Console.WriteLine("(2) - Pesquisa um elemento na Árvore");
                Console.WriteLine("(3) - Lista Arvore - Pré-Ordem");
                Console.WriteLine("(4) - Lista Arvore - Ordem Simétrica");
                Console.WriteLine("(5) - Lista Arvore - Pos-Ordem");
                Console.WriteLine("(6) - Lista Arvore - Em Ordem");
                Console.WriteLine("(7) - Calcula Maior Nivel");
                Console.WriteLine("(8) - Para SAIR");
                escolha = int.Parse(Console.ReadKey(true).KeyChar.ToString
               ());
                switch (escolha)
                {
                    case 1: // Insere um elemento na Arvore
                        Console.Clear();
                        Console.Write("Entre com um numero : ");
                        n = int.Parse(Console.ReadLine());
                        arv = new Arvore(n);
                        if (RAIZ == null)
                            RAIZ = arv;
                        else
                            RAIZ.Insere(arv);
                        break;
                }
            } while (escolha != 8);
        }
    }
}