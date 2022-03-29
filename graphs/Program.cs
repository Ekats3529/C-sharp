using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
	class Program
	{
		static void Main()
		{
			Graph g = new Graph("C:/Users/Ekaterina/source/repos/Graphs/Graphs/input.txt");

			Console.WriteLine("Graph:");
			g.Show();
			Console.WriteLine();

			Console.WriteLine("DFS:");
			g.Dfs(4);
			Console.WriteLine();

			Console.WriteLine("BFS:");
			g.Bfs(4);
			Console.WriteLine();

			Console.WriteLine("Dijkstr:");
			g.Dijkstr(4);
			Console.WriteLine();

			Console.WriteLine("Floyd:");
			g.Floyd();
		}
	}

}
