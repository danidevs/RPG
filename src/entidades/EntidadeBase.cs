using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_.Impostor.src.entidades
{
    public abstract class EntidadeBase
    {
        public EntidadeBase(string Name, int Forca){
            this.Name = Name;
            this.Forca = Forca;
        }
        public EntidadeBase(){

        }
        public String? Name;
        public int Forca;
        public override string ToString()
        {
            return this.Name + ":" + this.Forca;
        }
        public virtual string Attack()
        {
            return this.Name + ":" + "Atacou";
        }
        
    }
}