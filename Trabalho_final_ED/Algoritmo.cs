using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_final_ED
{
    internal class Algoritmo
    {
        public static (List<string> Path, int Distance) Djisktra(Dictionary<string, Dictionary<string, int>> map, string origem, string destino)
        {
            try
            {
                // Inicializa a lista de cidades não visitadas
                var unvisited = new HashSet<string>(map.Keys);

                // Inicializa o dicionário de distâncias e o dicionário de caminhos
                var distances = map.ToDictionary(x => x.Key, x => int.MaxValue);
                var paths = map.ToDictionary(x => x.Key, x => new List<string>());

                // Define a cidade origem como o ponto de partida
                distances[origem] = 0;
                paths[origem].Add(origem);

                // Enquanto houver cidades não visitadas
                while (unvisited.Any())
                {
                    // Seleciona a cidade com a menor distância
                    var current = unvisited.
                        OrderBy(x => distances[x]).First();
                    // Remove a cidade da lista de não visitadas
                    unvisited.Remove(current);
                    //Para cada cidade vizinha à cidade atual
                    foreach (var neighbor in map[current])
                    {
                        // Calcula a distância através da cidade atual
                        var distance = distances[current] + neighbor.Value;

                        // Se a distância for menor do que a distância atual, atualiza a distância e o caminho
                        if (distance < distances[neighbor.Key])
                        {
                            distances[neighbor.Key] = distance;
                            paths[neighbor.Key] = new List<string>(paths[current]) { neighbor.Key };
                        }
                    }
                }

                // Retorna o menor caminho e a distância total
                return (paths[destino], distances[destino]);
            }
            catch(Exception e)
            {
                string erro = $"{e} \n [ERRO] , por favor execute o programa corretamente.";
                string[] conversaoErro = erro.Split(',');
                List<string> msgErro = new List<string>(conversaoErro);

                return (msgErro,0) ;
            }
        }
    }
}
