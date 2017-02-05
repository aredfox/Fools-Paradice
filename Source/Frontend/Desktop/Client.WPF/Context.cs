using Domain;
using System;
using System.Reactive.Linq;

namespace Client.WPF
{
    public static class Context
    {
        static Context() {
            Game = new NumberGame();
        }

        public static NumberGame Game { get; set; }

        public static IObservable<int> RoundNumber =>
            Observable
                .Interval(TimeSpan.FromMilliseconds(10))
                .Select(_ => Game.Rounds.Count)
                .DistinctUntilChanged();
    }
}
