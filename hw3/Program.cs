//int s_a(int num)
//{
//return num / 10 % 10;                 >>> ПОКАЗЫВАЕТ 2 ЦИФРУ ТРЕХЗНАЧНОГО ЧИСЛА
//}
//Console.WriteLine(s_a(169));     





//void num()
//{
// int mid = new Random().Next(100, 1000);                    >>> УДАЛЯЕТ 2 ЧИСЛО 
//Console.WriteLine($"{mid} ->, {mid / 100}{mid % 10}");
//}
//num();




//void Thirdnum(int num)
//{
//  int Newnum = -1;
//string txt;
//Console.Write($"{num} -> ");

//while (num > 99)
//{
//  Newnum = num % 10;             >>> ПОКАЗЫЫВАЕТ 3 ЧИСЛО
//num = num / 10;                   
//}
//txt = $"{Newnum}";
//if (Newnum == -1)
//{
//  txt = "No third digit";
//}
//Console.WriteLine(txt);
//}
//Thirdnum(45);
//Thirdnum(478);
//Thirdnum(12952943);





//void Weekend(int num)
//{

//  if (num == 7 || num == 6)
//{
//  Console.WriteLine("Yes");
//}                                        >>> ПОКАЗЫВАЕТ ВЫХОДНЫЕ ДНИ
//else
//{
//  Console.WriteLine("No");
//}
//}
//Weekend(7);
//Weekend(3);