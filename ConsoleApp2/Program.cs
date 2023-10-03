namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Дружочек-пирожочек, кажется ты ошибся БД. Введи свое имя!");
                string name = Console.ReadLine();
            int tryingLaba = 0;
            bool isGotKey = false;
            while (true)
            {
               
                Console.WriteLine("Выбери действия. 1) Подписаться на базы данных; 2) Попытаться сделать лабу Смирнова; 3) Просить прощение на коленях");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    if (isGotKey)
                    {
                        Console.WriteLine("Ты подписчик Смирнова");
                    }
                    else
                    {
                        Console.WriteLine("Ты кто такой давай досвидания");


                    }
                    //Console.WriteLine("Смирнов гордится вами)");
                }
                if (action == 2)
                {
                    if (tryingLaba == 3)
                    {
                   
                        Console.WriteLine("ТЫ СДЕЛАЛ ЭТО");
                    }
                    else
                    {
                        tryingLaba++;
                        Console.WriteLine("Вы получили много боли");
                    }
                   
                }
                if (action == 3) 
                {
                    Console.WriteLine("Ты получил ключ!");
                    isGotKey = true;
                }
            }

        }
    }
}