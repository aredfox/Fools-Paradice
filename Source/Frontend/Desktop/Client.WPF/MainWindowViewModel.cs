using Client.WPF.Infrastructure;
using Domain.Dice;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Input;

namespace Client.WPF
{
    public class MainWindowViewModel : ViewModelBase
    {
        public int Width { get; set; } = 700;
        public int Height { get; set; } = 550;
        public string Title
        {
            get
            {
                return $"Fool's Paradice | Round #{Context.Game.Rounds.Count}";
            }
        }
        private int[] Input { get; set; }

        internal void SliderChange(int[] values) {
            Input = values.Where(i => i != 0).ToArray();
            AlgorithmInput = $"Your Input: {String.Join(", ", Input)}.";
            RaisePropertyChanged(nameof(AlgorithmInput));
        }

        public string AlgorithmInput { get; set; } = "Your Input: ?";
        public string AlgorithmOutput { get; set; } = "Output: ?";

        public string NextRoundButtonTitle => "Next Round";

        public ICommand NextRoundCommand =>
            new RelayCommand(
                execute: _ => {
                    var input = DiceSets.CreateFrom(Input);
                    var result = Context.Game.Round(input);
                    AlgorithmOutput = $"Output: {(result.HasError ? result.ErrorMessage : result.Value.ToString())}";
                    RaisePropertyChanged(nameof(AlgorithmOutput));
                },
                canExecute: _ => true
            );

        public MainWindowViewModel() {
            Context.RoundNumber.Subscribe(_ => {
                RaisePropertyChanged(nameof(Title));
            });
        }
    }
}
