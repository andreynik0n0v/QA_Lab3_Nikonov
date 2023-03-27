using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andrey = new("Andrey", "Nikonov", DateTime.Parse("26.02.2001"), new()
            {
                new("Girl", "Alisa"),
                new("Boy", "Denis")
            });
            andrey.Display();
        }
    }
}
