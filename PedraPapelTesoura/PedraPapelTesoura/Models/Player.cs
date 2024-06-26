using PedraPapelTesoura.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura.Models
{
    public class Player
    {
        public string Name {  get; set; }
        public EnumChoice Choice { get; set; }
        public int Score { get; set; }

        public Player() 
        {
            Score = 0;
        }
        public Player(string name)
        {
            Score = 0;
            this.Name = name;
        }
        
        public void pick() {
            // 0 - Paper; 1 - Scissors; 2 - Rock 
            Choice = (EnumChoice) new Random().Next(3);
        }
        public void pick(string choice) 
        {
            if(choice == "papel")
                Choice = EnumChoice.PAPER;
            else if (choice == "tesoura")
                Choice = EnumChoice.SCISSORS;
            else
                Choice = EnumChoice.ROCK;
        }
    }
}
