using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_.Impostor.src.entidades
{
    public class Estima : EntidadeBase
    {
        public Estima(string Name, int Forca){
            this.Name = Name;
            this.Forca = Forca;
        }
        public override string Attack()
        {
            return this.Name + " " + " com sentimento de incapacidade!";
        }
         public string Attack(int Estudou){
            if(Estudou > 6){
                return this.Name + " "  + "Defedeu com estudos e dedicação "+ " " + Estudou;
            
            }else{
                return this.Name + " " + "com sentimento de incapacidade!"; 
         } 
      }
    }
}