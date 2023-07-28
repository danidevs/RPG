using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_.Impostor.src.entidades
{
    public class Sindrome : EntidadeBase
    {
         public Sindrome(string Name, int Forca){
            this.Name = Name;
            this.Forca = Forca;
        }
        public override string Attack()
        {
            return this.Name + " " + "Atacou com pensamentos de incapacidade";
        }
        public string Attack(int Estudou){
            if(Estudou > 6){
                return this.Name + " "  + "Atacou com depressão "+ " " + Estudou;
            }else{
                return this.Name + " " + "Atacou com sentimento de incapacidade!"; 
         } 
      }
    }
}