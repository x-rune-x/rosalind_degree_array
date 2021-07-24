using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DegreeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var graphImporter = new GraphImporter();

            var graph = graphImporter.ImportGraph("C:/Users/masterofdoom/code projects/C#/DegreeArray/rosalind_deg.txt").ToList();

            foreach (string[] edge in graph)
            {
                Console.WriteLine($"{edge[0]} {edge[1]}");
            }

            int numberOfVertices = Int32.Parse(graph[0][0]);

            List<int> degreeOfVertex = new() { 0 };

            using StreamWriter sw = new("C:/Users/masterofdoom/code projects/C#/DegreeArray/solution.txt");
            {
                for (int i = 1; i <= numberOfVertices; i++)
                {
                    degreeOfVertex.Add(0);
                    for (int j = 1; j < graph.Count; j++)
                    {
                        string iString = i.ToString();
                        var edge = graph[j];
                        if (edge[0] == iString || edge[1] == iString)
                        {
                            degreeOfVertex[i] += 1;
                        }
                    }
                    Console.Write($"{degreeOfVertex[i]} ");
                    sw.Write($"{degreeOfVertex[i]} ");
                }
            }            
        }
    }
}
