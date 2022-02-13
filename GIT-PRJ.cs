using System;
using System.Collections.Generic;
using System.Text;

namespace TP8
{
    class Batiment
    {
        
        private string adresse;

        public Batiment(string adresse)
        {
            this.adresse = adresse; 
        }
        public Batiment()
        {
            
        }
         
        public void setAdresse(string adresse)
        {
            this.adresse = adresse;
        }

        public string getAdresse()
        {
            return (adresse);
        }

        public virtual string toString()
        {
            return ("l'adresse de cette batiment est : " + adresse);
        }
    }

    class Maison : Batiment
    {
        private int NbPieces;

        public Maison() : base()
        {

        }

        public Maison(string adresse , int NbPiece) : base(adresse)
        {
            
            this.NbPieces = NbPiece;
        }

        public int getNb()
        {
            return NbPieces;
        }

        public void setNb(int Nb)
        {
            NbPieces = Nb;
        }

        public override string  toString()
        {
            return ( base.toString() + " le numero de piece est : " + NbPieces);
        }
    }
}

Test programme:
class Program
    {
        static void Main(string[] args)
        {

            Batiment B = new Batiment("Nador");
            Console.Out.WriteLine(B.toString());
            Maison M1 = new Maison("Oujda", 29);
            Console.Out.WriteLine(M1.toString());
            
        }

    }