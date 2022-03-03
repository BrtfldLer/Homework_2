// Дано число. Проверить кратно ли оно 7 и 23
int randomNumber = new Random().Next(-1000,1001);
Console.WriteLine(randomNumber);
if (randomNumber % 7 == 0 & randomNumber % 23 == 0)
   {
       Console.WriteLine("Это число кратно 7 и 23");
   }
   else
   {
       Console.WriteLine("Это число не кратно 7 и 23");
   }