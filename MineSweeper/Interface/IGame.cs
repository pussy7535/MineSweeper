using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineSweeper.Interface
{
    public interface IGame
    {
		IRules Rule { get; }
		Block[] Blocks { get; } 
		void Generate(GameConfigure gameConfigure);
    }
}
