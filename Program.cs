//i need to display the numbers in the array in a 3x9 grid
//List<List<int>> numbers = new List<List<int>>();
//for (int i = 0; i < 3; i++){
//    numbers.Add(new List<int>());
//    for (int j = 0; j < 9; j++){
//	 numbers[i][j];
//    }
//}

//foreach (List<int> row in numbers){
 //   foreach (int number in row){
//	Console.Write(number + " ");
  //  }
 //   Console.WriteLine();
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

List<List<List<string>>> numbersInCard = new List<List<List<string>>>(){
new List<List<string>>{
new List<string>{"1", "x", "21", "31", "40", "x", "x", "x", "80"},
new List<string>{"x", "13", "x", "x", "x", "51", "64", "72", "88"},
new List<string>{"7", "17", "x", "x", "46", "58", "66", "x", "x"}
},
new List<List<string>> {
new List<string>{"1", "11", "x", "33", "42", "52", "x", "x", "x"},
new List<string>{"x", "x", "27", "35", "x", "x", "68", "75", "89"},
new List<string>{"x", "18", "29", "x", "x", "x", "69", "77", "90"}
},

new List<List<string>>{
new List<string>{"1", "x", "x", "33", "x", "53", "x", "70", "81"},
new List<string>{"x", "17", "27", "x", "48", "54", "x", "x", "83"},
new List<string>{"7", "18", "x", "x", "x", "x", "67", "75", "86"}
},
new List<List<string>>{	
new List<string>{"2", "x", "20", "33", "x", "51", "62", "x", "x"},
new List<string>{"x", "15", "x", "x", "44", "53", "64", "72", "x"},
new List<string>{"x", "x", "x", "39", "x", "56", "65", "74", "90"}
},
new List<List<string>>{
new List<string>{"4", "12", "x", "30", "x", "51", "x", "x", "82"},
new List<string>{"x", "13", "24", "31", "x", "x", "x", "73", "84"},
new List<string>{"x", "x", "x", "x", "46", "55", "68", "74", "88"}
}
};

string[] names = {"Jonas", "Tobias", "Kristian", "Mads", "Charlie"};

foreach (List<List<string>> row in numbersInCard){
    foreach (List<string> plade in row){
	    foreach (string number in plade){
		Console.Write(number + " ");

	}
	    Console.WriteLine();
    }
    Console.WriteLine();
}

bool fullPlayerCard = false;
bool firtRow = false;
bool seccondRow = false;
List<string> inputNumbers = new List<string>();
int rowsWon = 0; 

for (int playerCardIdx = 0; playerCardIdx < numbersInCard.Count; playerCardIdx++) {
    for (int rowIdx = 0; rowIdx < numbersInCard[playerCardIdx].Count; rowIdx++) {
        
        inputNumbers.Clear();

        Console.WriteLine($"Checking Row {rowIdx + 1} of Player Card {playerCardIdx + 1}...");

        while (!fullPlayerCard) {
		while(!seccondRow){
			while(!firstRow){
            string inputForNumber = Console.ReadLine();

            if (inputForNumber != null) {
                inputForNumber = inputForNumber.ToLower().Trim();
            }

            foreach (string number in numbersInCard[playerCardIdx][rowIdx]) {
                if (number == inputForNumber)
                    inputNumbers.Add(number);
            }

            foreach (string number in inputNumbers) {
                Console.WriteLine(number + " is a match!");
            }

            Console.WriteLine($"You have {inputNumbers.Count} numbers correct in Row {rowIdx + 1} of Player Card {playerCardIdx + 1}.");

            if (inputNumbers.Count == numbersInCard[playerCardIdx][rowIdx].Count && 
                inputNumbers.All(num => num != "x")) {
                Console.WriteLine("You have won this row!");
                rowsWon++;
		firstRow = true;
            }

            if (firstRow) {
                break;
            }
			}
		}
        }
    }
}

Console.WriteLine($"You have won {rowsWon} rows!");

//class bankoCard{
//    public int[,] card = new int[3,9];
//    public bankoCard(){
//	Random random = new Random();
//	for (int i = 0; i < 3; i++){
//	    for (int j = 0; j < 5; j++){
//		card[random.Next(i),j] = random.Next(1, 91);
//	    }
//	}
//    }
//    public void printCard(){
//	for (int i = 0; i < 3; i++){
//	    for (int j = 0; j < 9; j++){
//		Console.Write(card[i,j] + " ");
//	    }
//	    Console.WriteLine();
//	}
//    }
//}


