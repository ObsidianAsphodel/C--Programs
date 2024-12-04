namespace NumberGambler;
class NumberGambler{
    static void Main(){
     var rand = new Random();
     for(int i = 0; i == 100; i++){
        Console.Write("{0,15:N0}",rand.Next());
     } Console.WriteLine();
    }
}