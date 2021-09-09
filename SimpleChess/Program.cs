using System;
using System.Net.Mime;
using System.Text;

namespace SimpleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Sets the encoding the console uses to write output.
            var board = new Board(); //Lager Sjakkbrettet med de gitte posisjonene til brikkene
            var queen = new Queen(); // Lager en Dronning brikke 
            var king = new King();  // Lager konge brikke
            var bishop = new Bishop(); // Lager en Løper brikke som står på Boardet
            var rook = new Rook(); // Lager et tårn som står på Boarder
            var pawn = new Pawn();
            board.Set("e4", bishop); // Her settes posisjonen til Bishop
            board.Set("f7", rook); // Her sette posisjonen til Rook
            board.Set("e5", queen); // Her settes posisjonen til Queen
            board.Set("a1", king); // Her setter posisjonen til King
            board.Set("c2", pawn);
            while (true)
            {
                board.Show(); // Board show funksjon
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\"."); //hjelp
                var positionFrom = Ask("Hvilken rute vil du flytte fra?"); //Ask funksjonen
                var positionTo = Ask("Hvilken rute vil du flytte til?"); // Ask funksjonen
                board.Move(positionFrom, positionTo); //move funksjonen
            }
        }

        private static string Ask(string question) //Ask funksjonen
        {
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }
    }
}
