System.Console.WriteLine("Banko");
Random number = new Random();
int firstRow = number.Next(0, 91);
int seccondRow = number.Next(0, 91);
int thirdRow = number.Next(0, 91);
int[,] numbers = new int[3, 9];
for (int i = 0; i<3; i++){
    for (int j = 0; j < 9; j++){
        System.Console.WriteLine(numbers[i, j]);
    }
}