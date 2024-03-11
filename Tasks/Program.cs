// // Задача1. Задайте массив символов (тип char []). Создайте строку из
// // символов этого массива.

// char[] array = new char[] { 'ц', 'r', '7', '%', 'w'};

// string str = "";

// foreach (char item in array)
// {
// str = str + item;
// }

// Console.WriteLine(str);


// // Задача2. 
// // На основе символов строки (тип string) сформировать массив
// // символов (тип char[]). Вывести массив на экран.

// System.Console.WriteLine("Введите строчку");
// string str = Console.ReadLine();

// char[] array = new char[str.Length];

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = str[i];

// Console.Write(array[i]);
// }

// // Задача3.
// // Считайте строку с консоли, состоящую из латинских букв
// // в нижнем регистре. выяснить, сколько
// // среди введенных букв главных
// // пример
// // "hello" => 

// System.Console.WriteLine("Введите строку");
// string userInput = Console.ReadLine();

// string vowels = "aeioyu";

// int countVowels = 0;

// foreach (char item in userInput)
// {
//     if (vowels.Contains(item))
//     {
//         countVowels++;
//     }
// }

// System.Console.WriteLine(countVowels);

// // https://metanit.com/sharp/tutorial/7.2.php  ссылка на методы работы со строками
