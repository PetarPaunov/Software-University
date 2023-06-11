﻿namespace _1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static Dictionary<int, List<int>> graph;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbersOfPairs = int.Parse(Console.ReadLine());

            graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                var kvp = Console.ReadLine()
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                var node = int.Parse(kvp[0]);

                if (kvp.Length == 1)
                {
                    graph[node] = new List<int>();
                    continue;
                }

                var childs = kvp[1].Split()
                    .Select(int.Parse)
                    .ToList();

                graph[node] = childs;
            }

            for (int i = 0; i < numbersOfPairs; i++)
            {
                var pairs = Console.ReadLine()
                    .Split('-')
                    .Select(int.Parse)
                    .ToArray();

                var start = pairs[0];
                var destination = pairs[1];

                var steps = BFS(start, destination);

                Console.WriteLine($"{{{start}, {destination}}} -> {steps}");
            }
        }

        private static int BFS(int start, int destination)
        {
            var queue = new Queue<int>();
            queue.Enqueue(start);

            var visited = new HashSet<int> { start };
            var parent = new Dictionary<int, int> { { start, -1 } };

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == destination)
                {
                    return GetPath(parent, destination);
                }

                foreach (var child in graph[node])
                {
                    if (visited.Contains(child))
                    {
                        continue;
                    } 

                    visited.Add(child);
                    queue.Enqueue(child);
                    parent[child] = node;
                }
            }

            return -1;
        }

        private static int GetPath(Dictionary<int, int> parent, int destination)
        {
            var steps = 0;
            var node = destination;

            while (node != -1)
            {
                node = parent[node];
                steps++;
            }

            return steps - 1;
        }
    }
}