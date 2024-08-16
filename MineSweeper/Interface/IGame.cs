using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineSweeper.Interface
{
    public interface IGame
    {
		IBlock[] Blocks { get; }
		void Generate(GameConfigure gameConfigure);
    }
}
