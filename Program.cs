using desafio_abstraindo_jogo_rpg.src.Entities;

namespace desafio_abstraindo_jogo_rpg{
    public class Program{
        public static void Main(string[] args){
            Knight arus = new Knight("Arus", 20);
            WhiteWizard jenica = new WhiteWizard("Jenica", 23);
            Ninja wedge = new Ninja("Wedge", 13);

            Console.WriteLine(arus);
            Console.WriteLine(jenica);
            Console.WriteLine(wedge);

        }
    }
}
