﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Aardvark.Base
{
    public static class MinimumSpanningTree
    {
        /// <summary>
        /// Creates a minimum spanning tree from a set of weighted edges.
        /// The input are edges ((TVertex, TVertex), TWeight) of a graph.
        /// The output are a subset of these edges which form a minimum spanning tree.
        /// The type of the weight (TWeight) needs to be IComparable.
        /// </summary>
        public static IEnumerable<((TVertex, TVertex), TWeight)> Create<TVertex, TWeight>(
            IEnumerable<((TVertex, TVertex), TWeight)> edges
            )
            where TWeight : IComparable<TWeight>
        {
            if (edges is null) throw new ArgumentNullException(nameof(edges));

            Report.BeginTimed("create vertex set");
            var vertexSet = new HashSet<TVertex>(edges.SelectMany(e => e.Item1));
            Report.End();
            if (vertexSet.Count < 2) yield break;

            //compare function
            int compare(KeyValuePair<TWeight, TVertex> kvp0, KeyValuePair<TWeight, TVertex> kvp1) => kvp0.Key.CompareTo(kvp1.Key);

            // init per-vertex edge priority queues
            Report.BeginTimed("init per-vertex edge priority queues");
            //var v2es = new Dictionary<TVertex, PriorityQueue<TWeight, TVertex>>();
            //vertexSet.ForEach(v => v2es[v] = new PriorityQueue<TWeight, TVertex>());
            var v2es = new Dictionary<TVertex, List<KeyValuePair<TWeight, TVertex>>>();
            vertexSet.ForEach(v => v2es[v] = new List<KeyValuePair<TWeight, TVertex>>());
            foreach (var e in edges)
            {
                //v2es[e.E0.E0].Enqueue(e.E1, e.E0.E1);
                //v2es[e.E0.E1].Enqueue(e.E1, e.E0.E0);
                v2es[e.Item1.Item1].HeapEnqueue(compare, new KeyValuePair<TWeight, TVertex>(e.Item2, e.Item1.Item2));
                v2es[e.Item1.Item2].HeapEnqueue(compare, new KeyValuePair<TWeight, TVertex>(e.Item2, e.Item1.Item1));
            }
            Report.End();

            // mst
            var mst = new HashSet<TVertex>();
            void move(TVertex v) { vertexSet.Remove(v); mst.Add(v); }

            // build minimum spanning tree using Prim's algorithm
            Report.BeginTimed("build mst");
            move(vertexSet.First());
            while (vertexSet.Count > 0)
            {
                var candidateQueues = mst
                    .Where(v => v2es.ContainsKey(v))
                    .Select(v => (v, v2es[v])).Where(q => !q.Item2.IsEmptyOrNull())
                    ;
                foreach (var q in candidateQueues)
                {
                    //while (!q.E1.IsEmptyOrNull() && mst.Contains(q.E1.Peek()))
                    while (!q.Item2.IsEmptyOrNull() && mst.Contains(q.Item2[0].Value))
                        //q.E1.Dequeue();
                        q.Item2.HeapDequeue(compare);
                    if (q.Item2.IsEmptyOrNull()) v2es.Remove(q.Item1);
                }
                var best = candidateQueues
                    //.Select(q => (q.E0, q.E1.PeekKeyAndValue()))
                    .Select(q => (q.Item1, q.Item2[0]))
                    .Min((a, b) => a.Item2.Key.CompareTo(b.Item2.Key) < 0)
                    ;
                //v2es[best.E0].Dequeue();
                v2es[best.Item1].HeapDequeue(compare);
                move(best.Item2.Value);
                yield return ((best.Item1, best.Item2.Value), best.Item2.Key);
            }
            Report.End();
        }
    }

    public static class MinimumSpanningTreeTest
    {
        public static void Test()
        {
            var r = new Random();
            var es = from a in Enumerable.Range(1, 1000)
                     from b in Enumerable.Range(a + 1, 1000 - a - 1)
                     let w = r.NextDouble() + 1
                     select ((a, b), w)
                     ;
            Report.Line("number of edges: {0}", es.Count());

            /* unused variable error under mono:
            var edges = new Tup<Pair<string>, int>[]
            {
                (Pair.Create("A", "B"), 7),
                (Pair.Create("A", "D"), 5),
                (Pair.Create("D", "B"), 9),
                (Pair.Create("B", "C"), 8),
                (Pair.Create("B", "E"), 7),
                (Pair.Create("C", "E"), 5),
                (Pair.Create("E", "D"), 15),
                (Pair.Create("F", "D"), 6),
                (Pair.Create("E", "F"), 8),
                (Pair.Create("F", "G"), 11),
                (Pair.Create("E", "G"), 9),
            };
            */

            Report.BeginTimed("building mst");
            var mst = MinimumSpanningTree.Create(es).ToArray();
            Report.End();

            Report.Line("#edges in mst: {0}", mst.Length);
            //foreach (var e in mst) Console.WriteLine(e);
        }
    }
}
