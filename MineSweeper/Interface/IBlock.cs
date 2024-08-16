using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.Interface
{
    public interface IBlock
    {
		bool IsMarked { get; }
		bool IsTriggered { get; }
		uint AdjacentMines { get; }
		IBlock[] AdjacentBlocks { get; }
		void Trigger();
		void Mark();
    }
}
