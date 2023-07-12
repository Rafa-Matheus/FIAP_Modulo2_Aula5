using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declaração de lista e inserção de dados
            /*
            List<Editora> listaEditoras = new List<Editora>() { ... };
            listaEditoras.Add(new Editora("editora A", "site da editora", "telefone da editora"));

            Editora EditoraB = new Editora("editora B", "site da editora B", "telefone da editora B");
            listaEditoras.Add(EditoraB);
            */
            #endregion

            #region Mais operações usando lista
            /*
            List<int> listaInteiros = new List<int>() { 10, 20, 30, 40, 50 };
            Console.WriteLine(listaInteiros.Count);
            Console.ReadKey();
            */
            #endregion

            #region Expressão lambda com lista
            /*
            List<int> listaInteiros = new List<int>() { 100, 200, 300, 400, 500, 600 };

            // A expressão listaInteiros.Where(x => x >= 400) abaixo, retorna uma sequência de elementos
            // da lista listaInteiros, tal que cada elemento seja maior ou igual a 400.
            var resultado = listaInteiros.Where(x => x >= 400);

            Console.WriteLine($"{string.Join(", ", resultado)}"); // 400, 500, 600
            Console.ReadKey();
            */
            #endregion

            Console.WriteLine("Teste");
            Console.ReadKey();
        }
    }
}
