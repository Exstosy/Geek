Console.Clear();
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArrey(number, count));
int ReadInt(string message){
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}
int MakeArrey(int a , int b){

int resoult = 0;
   if ( b < 3){
    Console.WriteLine("Третьей цифры нет");
   }
    else
    {
      int c = 1;
      for (int i = b ; i > 3 ; i--)
      {
        c = c * 10;
      }
      resoult = ( a /c) % 10;
      
    }
   return resoult;
}