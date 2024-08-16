using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSweeper.Interface;

namespace MineSweeper
{
	public class StandardGame : IGame
	{
		public Block[] Blocks { get; private set; }
		public IRules Rule { get; private set; }
		public void Generate(GameConfigure gameConfigure)
		{

		}
	}
}
