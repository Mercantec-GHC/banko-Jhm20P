// System.Console.WriteLine("Banko");
// Random number = new Random();
// int firstRow = number.Next(0, 91);
// int seccondRow = number.Next(0, 91);
// int thirdRow = number.Next(0, 91);
// int[,] numbers = new int[3, 9];
// for (int i = 0; i<3; i++){
//     for (int j = 0; j < 9; j++){
//         System.Console.WriteLine(numbers[i, j]);
//     }
// }


using System.Globalization;

// string[,] firstBankoCard ={{" ", " ", "20", "30", "43", "55", " ", "70", " "}, {"4", "14", " ", "33", "44", " ", "67", " ", " "}, {" ", " ", "29", " ", "49", " ", "68", "78", "87"}};
// for (int i = 0; i < firstBankoCard.GetLength(0); i++){
//     for (int j = 0; j < firstBankoCard.GetLength(1); j++){
//         System.Console.WriteLine(firstBankoCard[i,j] + " ");
//     }
// }


string[,] firstBankoCard = { { " ", " ", "20", "30", "43", "55", " ", "70", " " }, { "4", "14", " ", "33", "44", " ", "67", " ", " " }, { " ", " ", "29", " ", "49", " ", "68", "78", "87" } };
// for (int i = 0; i < firstBankoCard.GetLength(0); i++)
// {
//     for (int j = 0; j < firstBankoCard.GetLength(1); j++)
//     {


//             string bankoCard = string.Join(" ", firstBankoCard[i, j]);
//             System.Console.WriteLine(bankoCard);
//     }
// }

foreach (string number in firstBankoCard){
    string bankoCard2 = String.Join(number, number);
    System.Console.WriteLine(bankoCard2);
}
