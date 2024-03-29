﻿using RPGSimulator.Bots;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Simulator
{
    class Simulation
    {
        public List<Bot> ParticipatingBots { get; }

        public Simulation(List<Bot> participatingBots)
        {
            ParticipatingBots = participatingBots;
        }

        public void Run()
        {
            Bot starter = ChooseStarter(ParticipatingBots);
            List<Bot> otherBots = FindOtherBots(starter, ParticipatingBots);

            Game game = new Game(starter.Character, otherBots[0].Character);  
            
            while (game.GameState != GameState.Finished)
            {
                Bot currentBot = ParticipatingBots.Find(bot => game.ActualSelf == bot.Character);
                currentBot.Controller.DoTurn(game);
                game.CyclePlayers();
                RevaluateGameState(game);
            }

            Console.WriteLine(FindWinner(ParticipatingBots).Character + " has won the game!");
            AssignWinsDefeats(ParticipatingBots);
        }

        private void RevaluateGameState(Game game)
        {
            if (game.Enemy.Health.CurrentHealth == 0 || game.Self.Health.CurrentHealth == 0)
            {
                game.GameState = GameState.Finished;
            }

            game.DidCurrentPlayerAct = false;
        }

        private void AssignWinsDefeats(List<Bot> bots)
        {
            Bot winner = bots.Find(bot => bot.Character.Health.CurrentHealth > 0);
            winner.Wins++;

            Bot loser = bots.Find(bot => bot.Character.Health.CurrentHealth == 0);
            loser.Defeats++;
        }

        private Bot FindWinner(List<Bot> bots)
        {
            return bots.Find(bot => bot.Character.Health.CurrentHealth > 0);
        }

        private List<Bot> FindOtherBots(Bot starter, List<Bot> bots)
        {
            List<Bot> otherBots = new List<Bot>();

            foreach (var bot in bots)
            {
                if (bot != starter)
                {
                    otherBots.Add(bot);
                }
            }

            return otherBots;
        }

        private Bot ChooseStarter(List<Bot> bots)
        {
            Random random = new Random();
            return bots[random.Next(1, 2)];
        }
    }
}
