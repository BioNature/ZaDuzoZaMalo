using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGry
{
    partial class Gra
    {
        //historia - lista ruchów
        private readonly List<ruch> historia;
        public IReadOnlyList<ruch> Historia => historia;


        //inner class
        public class ruch
        {
            public readonly int propozycja;
            public readonly Odpowiedz odpowiedz;
            public readonly DateTime kiedy;

            internal ruch(int prop,Odpowiedz odp)
            {
                propozycja = prop;
                odpowiedz = odp;
                kiedy = DateTime.Now;
            }

            public override string ToString() => $"({propozycja},{odpowiedz},{kiedy})";
        }
    }
}