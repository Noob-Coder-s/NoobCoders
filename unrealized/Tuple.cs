namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                (double, double) parallelogram;         //объявление кортежа
                parallelogram = (10.0, 20.0);           //присвоение кортежу значений   
                //parallelogram = (10.0, 20.0, 30.0);     //ошибка, значений должно быть столько же, сколько указано при создании

                Console.WriteLine($"{parallelogram} - вывод кортежа \"как есть\"");

                return;

            }//пример 1. Объявление, присвоение и вывод кортежа.


            {
                (double, double) parallelogram = (57.5, 20.5); //инициализация

                var parallelogram2 = (10, 20);                 //инициализация без явного указания типов, тут типы будут int

                //Console.WriteLine($"Вывод первого элемента {parallelogram2.Item0}");// нумерация начинается не с нуля

                Console.WriteLine($"Вывод первого элемента - {parallelogram2.Item1}");

                Console.WriteLine($"Вывод второго элемента - {parallelogram2.Item2}");

                Console.WriteLine($"площадь - {parallelogram2.Item1 * parallelogram2.Item2}");

                return;
            }//пример 2. Инициализация, var, использование значений по отдельности  


            {
                (double, double, string) parallelogram;

                parallelogram.Item1 = 10;
                parallelogram.Item2 = double.Parse(Console.ReadLine()); //Запрашиваем длину стороны
                parallelogram.Item3 = Console.ReadLine(); //Запрашиваем цвет

                Console.WriteLine($"{parallelogram.Item3} параллелограмм имеет стороны {parallelogram.Item1}см и {parallelogram.Item2}см.");
                return;
            }//пример 3. Кортеж с разными типами значений. Присвоение значений по отдельности.


            {
                (double length, double width, string color) parallelogram; //именуем элементы сами

                parallelogram.color = "Белый"; //обращаемся по заданному имени
                parallelogram.length = 13.0;
                parallelogram.width = 15.0;

                Console.WriteLine(parallelogram);
                Console.WriteLine($"{parallelogram.color} параллелограмм имеет длину {parallelogram.length}см и ширину {parallelogram.width}см.");

                return;
            }//Пример 4. Именованные поля

            {
                var parallelogram = (length: 7.0, width: 10.0);

                var (width2, length2) = parallelogram; //присваиваем значения кортежа отдельным переменным

                Console.WriteLine($"parallelogram - {parallelogram}");

                Console.WriteLine($"length2 - {length2}");
                Console.WriteLine($"width2 - {width2}");

                length2 = 235.0;

                Console.WriteLine($"parallelogram - {parallelogram}");

                return;
            }//Пример 5. Инициализация кортежа с именованием полей и использования var. Декомпозиция на отдельные переменные.


            {
                var parallelogram = (5, 4);

                var parallelogram2 = parallelogram; //Тут происходит копирование значений кортежа, а не ссылки на объект.

                parallelogram2.Item1 = 30;
                parallelogram2.Item2 = 10;

                Console.WriteLine(parallelogram); //Кортеж не изменился.
                return;

            }//Пример 6. Кортежи - это значимый тип данных


            {
                Console.WriteLine($"{GetSumDifferenceProduct(10, 15)} - (сумма, разница, произведение) чисел 10 и 15\n");

                (double, double, double) foo = GetSumDifferenceProduct2(10, 15);
                Console.WriteLine(foo + " - результат идентичен прошлому.\n");
                
                (double sum, double defference, double product) = GetSumDifferenceProduct2(10, 15); // Возвращаем значение и декомпозируем/разделяем на отдельные переменные
                Console.WriteLine(sum);
                Console.WriteLine(defference);
                Console.WriteLine(product);

                
                return;
            }//Пример 7 Кортеж как возвращаемое значение.

            (double, double, double) GetSumDifferenceProduct(int a, int b)
            {
                (double, double, double) tuple;

                tuple.Item1 = a + b;
                tuple.Item2 = a - b;
                tuple.Item3 = a * b;

                return tuple;
            }

            (double, double, double) GetSumDifferenceProduct2 (int a, int b)//результат идентичен прошлому методу
            {
                return (a + b, a - b, a * b);
            }//результат идентичен прошлому методу


            {
                (double, double, double) foo = GetSumDifferenceProduct3(10, 15); //Название полей таким образом не передастся
                Console.WriteLine(foo.Item1); //придётся обращаться по стандартному имени

                var bar = GetSumDifferenceProduct3(16, 15); 
                Console.WriteLine(bar.sum);

                Console.WriteLine(GetSumDifferenceProduct3(30, 15).difference); //Не используя промежуточные переменные, обращаемся сразу к именованному полю

                return;
            }//Пример 8. Именование полей при возврате значения.

            (double sum, double difference, double product) GetSumDifferenceProduct3(int a, int b)
       //именуем тут^^^             ^^^                ^^^
            {
                {
                    return (a + b, a - b, a * b);
                }
            }


            {
                var vasyaHouse = (16, 5, 5.25);

                PrintVolume(vasyaHouse);

                return;
            }//Пример 9. Кортеж как параметр метода

            void PrintVolume((double, double, double) House)
            {
                Console.WriteLine("Объём дома Васи : " + (House.Item1 * House.Item2 * House.Item3) + "куб.м");
            }


            {
                (string product, double weight)[]pantry = new (string, double)[2];
                
                pantry[0] = ("Рис", 58.3);

                pantry[1].product = "Гречка";
                pantry[1].Item2 = 666;          //Даже при самостоятельном именовании полей, мы всё ещё можем обращаться по стандартному имени

                // Console.WriteLine(pantry); //Что же тут выйдет?

                Console.Write($"Содержимое кладовки: {pantry[0]}, {pantry[1]}");

                return;
            }//Пример 10. Массивы из кортеже


            {
                var tuple = (1, 43, 657, 234);

                //foreach (var i in tuple)
                {
                    //Console.WriteLine(i);
                }
                return;
            }//Пример 11. Это вам не пайтон


            {
                var tuple = (1, 456, 222);

                var tuple2 = (1, 456, 222);

                var tuple3 = (value1: 1, value2: 456, value3: 222); //Дополнительно задаём имена полей

                var tuple4 = (1, 456, 667);

                if (tuple == tuple2) // также можно использовать !=, но нельзя < > <= >=
                {
                    Console.WriteLine("Кортежи можно сравнивать");

                    if (tuple3 == tuple2)
                        Console.WriteLine("На сравнение не влияет именование полей");
                    else
                        Console.WriteLine("На сравнение влияет именование полей");

                    if (tuple4 == tuple)
                    {
                        Console.WriteLine("Для истины не требуется равенство всех полей кортежа");
                    }
                    else
                    {
                        Console.WriteLine("Для истины требуется равенство всех полей кортежа");
                    }
                }
                else
                {
                    Console.WriteLine("Кортежи нельзя сравнивать");
                }
                return;

            }//Пример 12. Сравнение кортежей


            {
                int a = 42;
                int b = 666;

                (a, b) = (b, a);

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                return;
            }//Пример 13. Использование кортежей для обмена значений переменных


            {
                ( int[], Shape, (int, int) ) uberTuple = ( new int[] { 5, 4 , 3}, Shape.Circle, (5, 7) ); //говнокод, лучше уж создать класс или структуру

                uberTuple.Item1[0] = 1;

                Console.WriteLine(uberTuple.Item1[0]);

                Console.WriteLine(uberTuple.Item2);

                Console.WriteLine(uberTuple.Item3.Item1);

                Console.WriteLine(uberTuple);

                return;

            }//Пример 14. Кортеж может содержать любой тип данных, в том числе массивы, перечисления, классы, и даже сами кортежи.


            {

                (int[], Shape, (int, string, int))[] ultraTuple = new (int[], Shape, (int, string, int))[666]; //ещё больший говнокод, это вам не понадобится.

                ultraTuple[0] = (new int[] { 6, 1, 6 }, Shape.Circle, (6,"июня", 2006));

                ultraTuple[0].Item1[0] = 1;

                Console.WriteLine(ultraTuple[0].Item1[0]);

                Console.WriteLine(ultraTuple[0].Item2);

                Console.WriteLine(ultraTuple[0].Item3.Item1);

            }//Кортеж Дяди Васи


        }

        enum Shape
        {
            Circle,
            Ellipse,
            Triangle,
            Parallelogram,
        }

    }
}