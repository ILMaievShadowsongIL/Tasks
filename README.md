# ЗАДАНИЯ НА СООБРАЗИТЕЛЬНОСТЬ
## ***1 задание***
> Есть 90 человек. Каждый из этих 90 человек относится к одной из двух категорий. Одни на все вопросы говорят правду, другие — всегда врут. У каждого ровно 1 любимое      >блюдо из списка (макароны/пельмени/вареники). 
> 
>Каждому задают три вопроса:
> + Ваше любимое блюдо — макароны?
> + Ваше любимое блюдо — пельмени?
> + Ваше любимое блюдо — вареники?
>
>Результаты получились такие:
> + на первый вопрос утвердительно ответило 45 человек,
> + на второй — 35,
> + на третий — 30.
> 
> Сколько человек всегда говорят правду?
## ***Решение:***
Сколько всего было отвеов?
 
 45+35+30=110(о).

Сколько человек всегда врут?

  110-90=20(ч).

Сколько человек всегда говорят правду?

  90-20=70(ч).

***Ответ: 70 человек всегда говорят правду.***

## ***2 задание***
> Есть числа от трех до одиннадцати. Есть квадрат — 3 на 3 клетки:

 | а | б | в |
 |---|:--:|--:|
 | г | д | е |
 | ё | ж | з |
 
> (Буквы ничего не значат, кроме того, что числа не повторяются)
> Можно ли расставить числа в клетки квадрата таким образом, что перемножения чисел в строках дает тот же результат, что и произведение чисел в столбцах с теми же  >номерами?
> Если можно — расставьте, если нельзя — объясните почему.

## ***Решение:***
7 и 11 - являются простымы (Делятся на самих себя или на 1), поэтому расположим их на диагонали. 

9 тоже ставим на диагональ для баланса.

Далее, ищем пары, которые при перемножении будут давать одинаковый результат и размещаем их в таблице:

3*8=24

4*6=24

4*10=40

5*8=40 

3*10=30

5*6=30

***Ответ: Да, числа можно расставить так, чтобы перемножения чисел в строках давало тот же результат, что и произведение чисел в столбцах с теми же номерами.***

| 9 | 10 | 3 |
|---|:--:|--:|
| 5 | 7 | 8 |
| 6 | 4 | 11 |

## ***3 задание***
>Ученые разработали новый материал неизвестной прочности. Они знают, что материал разбивается при падении с высоты от 1 метра до 5 000 метров. Но не знают, с какой >именно высоты. Чтобы определить прочность, ученые поднимают предмет на некоторую высоту и сбрасывают его оттуда. Их задача — определить, начиная с какой именно высоты >предмет начнет разбиваться.
>Специальная платформа, с помощью которой они осуществляют эксперимент, скидывает предмет только с дискретных высот (1, 2, 3 ... 4999, 5000 метров — платформа не может >скинуть предмет, например, с 2,5 метров. Точности в 1 метр ученым вполне достаточно). При падении с высоты "n" метров предмет уничтожается. Если же его сбрасывали с >высоты ниже "n", то его можно использовать в повторных экспериментах.
>Нужно АБСОЛЮТНО ТОЧНО найти ту высоту, начиная с которой предметы разрушаются. Сделать это нужно за МИНИМАЛЬНО возможное число экспериментов. У ученых при этом всего >2 предмета, но они абсолютно одинаковые. Каким образом этого можно достигнуть? Сколько экспериментов при этом максимально потребуется?

## ***Решение:***
Узнаём примерную высоту с помощью 1-го предмета, который должен разбиться.

√5000=71(округлили).

Узнаём сколько экспериментов при этом максимально потребуется, с помощью 2-го предмета и на основе первого опыта.

71+70=141(больше, чем надо на 1-ин эксперимент).

***Ответ: Для нахождения абсолютно точной высоты небходимо 140 экспериментов.***

## ***4 задание***
>В университетскую столовую пришли трое студентов купить пирожки. Один хочет купить треть всех имеющихся в столовой пирожков и еще 2 пирожка. Другой хочет купить >четверть от всех имеющихся пирожков и ещё 3 пирожка. А третий хочет купить пятую часть всех пирожков и ещё 8 пирожков. Если все трое купят столько пирожков, сколько >планируют, то в столовой как раз закончатся все пирожки. Сколько пирожков есть в столовой? 

## ***Решение:***
Обозначим всё колличество пирожков,как x. На основе этого составим уравнение:

x-(1/3*x+2)-(1/4*x+3)-(1/5*x+8)=0 

Решиа данное уравнеие получим, что 60 пирожков есть в столовой.

***Ответ: 60 пирожков.***

# ЗАДАЧИ ПО ПРОГРАММИРОВАНИЮ

## ***Задача 1***

>Написать метод/функцию, который/которая на вход принимает массив городов. В качестве результата возвращает строку, где города разделены запятыми, а в конце стоит >точка. 
>
>***Пример:***
>
>«Москва, Санкт-Петербург, Воронеж.» 

## ***Решение:***



```C#
  public static void ChangingTheLine(string[] array)
        {
            string separatedNames = string.Join(",", array);
            Console.Write($"{separatedNames}. ");
        }
```

## ***Задача 2***

>Написать метод/функцию, который/которая на вход принимает число (float), а на выходе получает число, округленное до пятерок.
>
>Пример:
>
>27 => 25, 27.8 => 30, 41.7 => 40.

## ***Решение:***
```C#
 public static int RoundingTheNumber(float number)

        {
            return Convert.ToInt32(Math.Round(number, 5));
        }
```        

## ***Задача 3***

>Написать метод/функцию, который/которая на вход принимает число (int), а на выходе выдает слово “компьютер” в падеже, соответствующем указанному количеству. Например, >«25 компьютеров», «41 компьютер», «1048 компьютеров».

## ***Решение:***
```C#
public static void WePutItInTheCorrectForm(int number)
        {
            string[] WordForms = {"компьютер", "компьютера", "компьютеров" };
            


            if (number % 100 >= 11 && number % 100 <= 14 || number % 10 == 0 || number % 10 >= 5)

            {
                Console.WriteLine($"{number} " + $"{WordForms[2]}");
            }
            else if (number % 10 == 1)
            {
                Console.WriteLine($"{number} " + $"{WordForms[0]}");
               
            }
            else
            {
                Console.WriteLine($"{number} " + $"{WordForms[1]}");
            }

        }
```

## ***Задача 4***

>Написать метод/функцию, который/которая на вход принимает целое число, а на выходе возвращает то, является ли число простым (не имеет делителей кроме 1 и самого себя).

## ***Решение:***
```C#
public static bool CheckingTheNumber(int number)
        {

            if (number > 1)
            {
                for (int i = number - 1; i > 1; i--)
                {
                    if ((number % i) == 0)
                        return false;
                }
                return true;
            }
            return false;
        }
```
## ***Задача 5***
>Написать метод, который определяет, какие элементы присутствуют в двух экземплярах в каждом из массивов (= в двух и более, причем в каждом). На вход подаются два >массива. На выходе массив с необходимыми совпадениями.
>
>Пример:
>
>[7, 17, 1, 9, 1, 17, 56, 56, 23], [56, 17, 17, 1, 23, 34, 23, 1, 8, 1]
>
>На выходе [1, 17]

## ***Решение:***
```C#
public static void OutputAnArray()
        {
            Random rand = new Random();
            int number = 20;
            int[] aNumber = new int[number];
            int[] bNumber = new int[number];
            for (int i = 0; i < number; ++i)
            {
                aNumber[i] = rand.Next(10, 51);
                bNumber[i] = rand.Next(10, 51);
            }
            Array.Sort(aNumber);
            foreach (var i in aNumber) Console.Write(" " + i);            
            Array.Sort(bNumber);
            Console.WriteLine();
            foreach (var i in bNumber) Console.Write(" " + i);
            Console.WriteLine();
            object item;
            int index;
            for (int i = 0; i < number; ++i)
            {
                item = aNumber[i];
                if (i > 0 && item == (object)aNumber[i - 1]) continue;
                index = Array.BinarySearch(bNumber, item);
                if (index >= 0) Console.Write(" " + aNumber[i]);
            }
           
        }
```
## ***Задача 6***

>Написать метод, который в консоль выводит таблицу умножения. На вход метод получает число, до которого выводит таблицу умножения. В консоли должна появиться таблица. >Например, если на вход пришло число 5, то получим:
>
>***Важно:***
> 
> + В последней строке между числами ровно по одному пробелу должно выводиться. 
>
> + В каждом столбце числа должны быть выровнены по правому краю.

```C#
public static void OutputOfTheMultiplicationTable(int number)
        {
            var table = new int[10, 10];
            for (int i = 1; i <= number; ++i)
            {
                for (int j = 1; j <= number; ++j)
                {
                    table[i, j] = i * j;
                }
            }
            for (int i = 1; i <= number; ++i)
            {
                for (int j = 1; j <= number; ++j)
                {
                    Console.Write(" {0, 3}", table[i, j]);
                }
                Console.WriteLine();
            }

        }
```
