Console.Clear();
Console.WriteLine("Введите трехзначное число. Выхода из программы команда 0.");
 while(true)
 {
  string number = Console.ReadLine();
   if (!number.Equals("0"))
      Console.WriteLine("{0}->{1}" , number , number[1] );
   else
   break;
   }
 


  