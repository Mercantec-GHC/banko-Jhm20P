//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//
//List<List<List<string>>> numbersInCard = new List<List<List<string>>>(){
//new List<List<string>>{
//new List<string>{"1", "x", "21", "31", "40", "x", "x", "x", "80"},
//new List<string>{"x", "13", "x", "x", "x", "51", "64", "72", "88"},
//new List<string>{"7", "17", "x", "x", "46", "58", "66", "x", "x"}
//},
//new List<List<string>> {
//new List<string>{"1", "11", "x", "33", "42", "52", "x", "x", "x"},
//new List<string>{"x", "x", "27", "35", "x", "x", "68", "75", "89"},
//new List<string>{"x", "18", "29", "x", "x", "x", "69", "77", "90"}
//},
//
//new List<List<string>>{
//new List<string>{"1", "x", "x", "33", "x", "53", "x", "70", "81"},
//new List<string>{"x", "17", "27", "x", "48", "54", "x", "x", "83"},
//new List<string>{"7", "18", "x", "x", "x", "x", "67", "75", "86"}
//},
//new List<List<string>>{	
//new List<string>{"2", "x", "20", "33", "x", "51", "62", "x", "x"},
//new List<string>{"x", "15", "x", "x", "44", "53", "64", "72", "x"},
//new List<string>{"x", "x", "x", "39", "x", "56", "65", "74", "90"}
//},
//new List<List<string>>{
//new List<string>{"4", "12", "x", "30", "x", "51", "x", "x", "82"},
//new List<string>{"x", "13", "24", "31", "x", "x", "x", "73", "84"},
//new List<string>{"x", "x", "x", "x", "46", "55", "68", "74", "88"}
//}
//};
//
//string[] names = {"Jonas", "Tobias", "Kristian", "Mads", "Charlie"};
//
//foreach (List<List<string>> row in numbersInCard){
//    foreach (List<string> plade in row){
//	    foreach (string number in plade){
//		Console.Write(number + " ");
//
//	}
//	    Console.WriteLine();
//    }
//    Console.WriteLine();
//}
using System;
using System.Collections.Generic;
using System.Linq;

class BingoCard
{
    public List<List<int>> numbers = new List<List<int>>();
    public int PlayerId { get; set; }
    public BingoCard(int playerId)
    {
        switch (playerId)
        {
            case 1:
                numbers = new List<List<int>>{
        new List<int>{0, 0, 20, 30, 43, 55, 0,  70, 0},
        new List<int>{4, 14, 0, 33, 44, 0, 67, 0, 0},
        new List<int>{0, 0, 29, 0, 49, 0, 68, 78, 87},
       };
                break;
            case 2:
                numbers = new List<List<int>>{
        new List<int>{0, 0, 24, 30, 40, 54, 64, 0, 0},
        new List<int>{0, 18, 27, 0, 42, 0, 65, 71, 0},
        new List<int>{7, 0, 0, 0, 43, 57, 69, 0, 89},
       };
                break;
            case 3:
                numbers = new List<List<int>>{
        new List<int>{2, 0, 20, 34, 0, 52, 60, 0, 0},
        new List<int>{0, 14, 0, 35, 0, 0, 64, 76, 84},
        new List<int>{7, 0, 26, 0, 47, 55, 0, 0, 88},
       };
                break;
            case 4:
                numbers = new List<List<int>>{
        new List<int>{1, 0, 0, 30, 43, 0, 62, 0, 83},
        new List<int>{8, 14, 26, 0, 0, 55, 0, 76, 0},
        new List<int>{9, 0, 0, 38, 49, 0, 0, 79, 90},
       };
                break;
            case 5:
                numbers = new List<List<int>>{
        new List<int>{5, 10, 0, 0, 44, 51, 0, 70, 0},
        new List<int>{0, 13, 25, 36, 47, 0, 62, 0, 0},
        new List<int>{0, 17, 29, 39, 49, 0, 0, 0, 89},
       };
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        PlayerId = playerId;
    }

    public void PrintCard()
    {
        Console.WriteLine($"Player {PlayerId}'s Card:");

        for (int i = 0; i < numbers.Count; i++)
        {
            foreach (int number in numbers[i])
            {
                if (number == 0)
                {
                    Console.Write(" \t");
                }
                else
                {
                    Console.Write($"{number}\t");
                }
            }
            Console.WriteLine();


        }
    }
}

class BingoGame
{
    internal List<BingoCard> cards = new List<BingoCard>();
    private List<int> calledNumbers = new List<int>();
    public void CreateCards(int numPlayers)
    {
        for (int playerId = 1; playerId <= numPlayers; playerId++)
        {
            var card = new BingoCard(playerId);
            Random random = new Random();
            cards.Add(card);
        }
    }
    public void CallNumber(int number)
    {
        calledNumbers.Add(number);
        Console.WriteLine($"Called number: {number}");
        foreach (var card in cards)
        {
            card.PrintCard();
            CheckForMatches(card);
        }
    }

    public void CheckForMatches(BingoCard card)
    {
        int rowsMatched = 0;
        for (int i = 0; i < card.numbers.Count; i++)
        {
            bool rowComplete = true;
            foreach (int number in card.numbers[i])
            {
                if (number != 0 && calledNumbers[i] != number)
                {
                    rowComplete = false;
                    break;

                }
            }
            if (rowComplete)
            {
                Console.WriteLine($"Player {card.PlayerId} has completed row {i + 1}");
                rowsMatched++;
            }
        }
        if (rowsMatched == 3)
        {
            Console.WriteLine($"Congratulations! Player {card.PlayerId} has Bingo!");
        }
        else if (rowsMatched == 2)
        {
            Console.WriteLine($"Player {card.PlayerId} has completed 2 rows!");
        }
    }
}

class Program
{
    static void Main()
    {
        BingoGame game = new BingoGame();
        game.CreateCards(5);
        int inputNumber;


        bool isvalid = int.TryParse(Console.ReadLine(), out inputNumber);
        if (isvalid)
        {
            foreach (var number in game.cards)
            {
                game.CallNumber(inputNumber);
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
        // To check a specific number
        //Console.WriteLine("Enter a number to check: ");
        //int checkNumber = int.Parse(Console.ReadLine());
        //foreach (var card in game.cards)
        //{
        //    if (card.numbers.Contains(checkNumber))
        //    {
        //        Console.WriteLine($"Player {card.PlayerId} has a match for number {checkNumber}!");
        //    }
        //}
    }
}

//
