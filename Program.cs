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
List<bankoCard> cards = new List<bankoCard>();
for (int i = 0; i < 100; i++){
    cards.Add(new bankoCard());
}
foreach (bankoCard card in cards){
    Console.WriteLine(card);
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


class bankoCard{

public string id;

public int[,] card = new int[3,9];


}

