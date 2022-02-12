using System;
using CriandoJogoRpgUsandoOrientação;

namespace CriandoJogoRpgUsandoOrientação
{
    public class wizard

    {
        static void Main(string[] args)
        {
            var arus = new Hero("Arus", 42, "Knigth");
            var wizard = new Wizard("Jennica", 42, "Write Wizard");
            var wedge = new Hero("Wedge", 42, "Ninja");
            var topapa = new Wizard("Topapa", 42, "Black Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());
        }
    }
}
