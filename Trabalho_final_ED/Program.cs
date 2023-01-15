using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_final_ED
{
    internal class Program : Algoritmo
    {
        static void Main(string[] args)
        {
            // Mapa de distâncias entre cidades (em km)
            Dictionary<string, Dictionary<string, int>> map = new Dictionary<string, Dictionary<string, int>>
        {
            { "Itumbiara", new Dictionary<string, int> { { "Tupaciguara", 55}, { "Centralina", 40 } } },
            { "Centralina", new Dictionary<string, int> { { "Capinópolis", 40 }, { "Monte Alegre de Minas", 75 } } },
            { "Tupaciguara", new Dictionary<string, int> { { "Monte Alegre de Minas", 44 }, { "Itumbiara", 55 }, { "Uberlândia", 60 } } },
            { "Capinópolis", new Dictionary<string, int> { { "Centralina", 40 }, { "Ituiutaba", 30 } } },
            { "Ituiutaba", new Dictionary<string, int> { { "Capinópolis", 30 }, { "Douradinhos", 90 }, { "Monte Alegre de Minas", 85 } } },
            { "Douradinhos", new Dictionary<string, int> { { "Ituiutaba", 90 }, { "Monte Alegre de Minas", 28 }, { "Uberlândia", 63 } } },
            { "Monte Alegre de Minas", new Dictionary<string, int> { { "Ituiutaba", 85 }, { "Douradinhos", 28 }, { "Centralina", 75 }, { "Tupaciguara", 44 }, { "Uberlândia", 60 } } },
            { "Uberlândia", new Dictionary<string, int> { { "Tupaciguara", 60 }, { "Monte Alegre de Minas", 60 }, { "Douradinhos", 63 }, { "Araguari", 30 }, { "Indianópolis", 45 }, { "Romaria", 78 } } },
            { "Araguari", new Dictionary<string, int> { { "Uberlândia", 30 }, { "Estrela do Sul", 34 }, { "Cascalho Rico", 28 } } },
            { "Cascalho Rico", new Dictionary<string, int> { { "Araguari", 28 }, { "Grupiara", 32 } } },
            { "Grupiara", new Dictionary<string, int> { { "Cascalho Rico", 32 }, { "Estrela do Sul", 38 } } },
            { "Estrela do Sul", new Dictionary<string, int> { { "Araguari", 34 }, { "Grupiara", 38 }, { "Romaria", 27 } } },
            { "Romaria", new Dictionary<string, int> { { "Estrela do Sul", 27 }, { "Uberlândia", 78 }, { "São Juliana", 28 } } },
            { "Indianópolis", new Dictionary<string, int> { { "Uberlândia", 45 }, { "São Juliana", 40 } } },
            { "São Juliana", new Dictionary<string, int> { { "Indianópolis", 40 }, { "Romaria", 28 } } }
        };

            // Cidade origem e destino selecionadas pelo usuário
            Console.WriteLine("Insira a cidade de origem:");
            string origem = Console.ReadLine();
            Console.WriteLine("Insira a cidade de destino:");
            string destino = Console.ReadLine();

            // Executa o algoritmo de Djisktra
            var result = Djisktra(map, origem, destino);
            Console.WriteLine("----------------------------------------");
            // Imprime o menor caminho e a distância total
            Console.WriteLine("Menor caminho: " + string.Join(" -> ", result.Path));
            Console.WriteLine("Distância total: " + result.Distance + " km"); ;
            Console.ReadLine();
        }

        
    }
}
    

