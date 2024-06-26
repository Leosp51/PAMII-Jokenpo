using CommunityToolkit.Mvvm.ComponentModel;
using PedraPapelTesoura.Enums;
using PedraPapelTesoura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PedraPapelTesoura.ViewModels
{
    public partial class PlayerViewModel : ObservableObject
    {
        [ObservableProperty]
        public string playerName;
        [ObservableProperty]
        public string score;
        [ObservableProperty]
        public string playerChoice;
        [ObservableProperty]
        public string oponentChoice;
        [ObservableProperty]
        public string result;

        Player oponent = new Player("Oponente");
        Player user = new Player();

        public PlayerViewModel() 
        {
            oponentChoice ="";
            Result = "Seja Bem-Vindo";
            PlayCommand = new Command(Play);
        }
        public ICommand PlayCommand { get;}
        public void Play()
        {
            oponent.pick();
            OponentChoice = ChoiceToString(oponent.Choice);

            user.pick(PlayerChoice);

            if(user.Choice == oponent.Choice)
            {
                Result = $"{PlayerName}, você EMPATOU!";
            }else if((user.Choice == EnumChoice.PAPER && oponent.Choice == EnumChoice.SCISSORS) ||
                      (user.Choice == EnumChoice.SCISSORS && oponent.Choice == EnumChoice.ROCK) ||
                      (user.Choice == EnumChoice.ROCK && oponent.Choice == EnumChoice.PAPER))
            {
                Result = $"{PlayerName}, você PERDEU!";
            }
            else
            {
                user.Score++;
                Result = $"{PlayerName}, você GANHOU!";
            }
            Score = $"Pontuação: {user.Score}";

        }
        public string ChoiceToString(EnumChoice choice)
        {
            string result;
            if (choice == EnumChoice.PAPER)
            {
                result = "papel";
            }
            else if(choice == EnumChoice.SCISSORS)
            {
                result = "tesoura";
            }
            else
            {
                result = "pedra";
            }
            return result;
        }
    }
}
