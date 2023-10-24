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

List<List<string>> numbersInCard = new List<List<string>>();
numbersInCard.Add(new List<string>{"1","2","3","4","5","6","7","8","9"});
numbersInCard.Add(new List<string>{"1","2","3","4","5","6","7","8","9"});
numbersInCard.Add(new List<string>{"1","2","3","4","5","6","7","8","9"});


foreach (List<string> row in numbersInCard){
    foreach (string number in row){
	Console.Write(number + " ");
    }
    Console.WriteLine();
}

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


