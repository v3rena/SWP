﻿using GameInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class UninstallCommand : ICommand
	{
		IGame Game;

		public UninstallCommand(IGame game)
		{
			Game = game;
		}

		public string Execute()
		{
			return Game.UninstallGame();
		}
	}
}
