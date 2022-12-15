
Console.Clear();
Console.WriteLine("Введите число от 1-7");
 int day = Convert.ToInt32(Console.ReadLine());
  if(day < 5 && day < 7 ){
  Console.WriteLine("нет");
  }
else if (day >= 6 && day <= 7){
    Console.WriteLine("да");
}
