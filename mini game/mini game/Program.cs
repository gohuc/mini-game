namespace minigame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Просыпаюсь от резкой боли в виске.\nПол холодный, бетонный, пыльный.\nДаже имени своего вспомнить не могу. Как же меня зовут?\n");
            string name = Console.ReadLine();
            Console.WriteLine("\nA точно! " + name + "\nЧто это за комната? Где я? Нужно как-то выбраться отсюда.");

            string one = "Белый Артефакт";
            string two = "Синий Артефакт";
            string three = "Красный Артефакт";
            string four = "Отмычка";
            int TryNum = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            

            
                   


            while (true)
            {
                Console.WriteLine("\nGame: Выберите действие:\n a. Открыть дверь\n b. Заглянуть под кровать\n c. Открыть ящик в углу комнаты\n d. Открыть вентиляцию\n e. Взглянуть на тумбочку\n f. Взглянуть на статую рядом с дверью\n ");

                string variant = Console.ReadLine();

                switch (variant)
                {
                    case "a" or "а" or "A" or "А":
                        
                        if (counter4 == 0)
                        {
                            Console.WriteLine("\nGame: Дверь закрыта.\nPlayer: Я заперт. Посмотрим что тут ещё есть\n");
                        }
                        else if (counter4 >0)
                        {
                            Console.WriteLine("\nGame: Дверь открыта.\nPlayer: Ура я свободен\n");
                            Console.WriteLine("\nGame: Игра пройдена. Вы выбрались. Поздравляем!! ставь лайк если если Альцгеймер топи топ");
                            return;
                        }
                        break;





                    case "b" or "B" or "И" or "и":
                        counter1++;
                        if (counter1 == 1)
                        {
                            Console.WriteLine("\nGame:" + name + ", Вы нашли " + one);

                            if (counter2 == 0 && counter3 == 0)
                            {
                                Console.WriteLine("Player: Что это такое?\n");
                            }
                            else if (counter2 > 0 || counter3 > 0)
                            {
                                Console.WriteLine("Player: О ещё один камень. Для чего они нужны?\n");
                            }
                            else
                            {
                                Console.WriteLine("Player: Мне кажется я нашёл все камни. нужно попробовать их применить\n");
                            }
                        }
                        else if (counter1 > 1)
                        {
                            Console.WriteLine("\nGame: Идиот, зачем ты сюда ещё раз смотришь, ты уже забрал отсюда " + one + "или у тебя Альцгеймер?\n");
                        }

                        break;

                    case "с" or "С" or "c" or "C":
                        if (counter4 == 0)
                        {


                            if (counter5 == 0)
                            {
                                Console.WriteLine("\nGame: Ящик закрыт.\nPlayer: Чёрт, Нужен ключ");
                            }
                            else if (counter5 == 1)
                            {
                                counter4++;
                                Console.WriteLine("\nGame: " + name + ", Вы нашли " + four);
                                Console.WriteLine("Player: Отмычка!! Может с её помощью получится открыть дверь\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame: тут пусто");
                        }
                            break;
                    
                    case "D" or "d" or "В" or "в":
                        TryNum++;
                        
                        if (TryNum == 1)
                        {
                            Console.WriteLine("\nPlayer: Хм, вентиляция держится на соплях. Может попробовать ещё раз?\n");
                        }
                        else if (TryNum == 3)
                        {
                            counter2++;
                            Console.WriteLine("\nGame: " + name + ", Вы нашли " + two);
                            
                            if (counter1 > 0 || counter3 == 0)
                            {
                                Console.WriteLine("Player: О ещё один камень.\n");
                            }
                            else if (counter1 == 0 && counter3 == 0)
                            {
                                Console.WriteLine("Player: Что это такое?\n");
                            }
                            else
                            {
                                Console.WriteLine("Player: Мне кажется я нашёл все камни. нужно попробовать их применить\n");
                            }

                        }
                        else if (TryNum == 2)
                        {
                            Console.WriteLine("\nPlayer: Почти получилось, нужно попробовать ещё\n");
                        }
                        else
                        {
                            Console.WriteLine("\nGame: Вы уже нашли артефакт. Тут пусто\n");
                        }
                           

                
                        break;
                    case "e" or "E" or "У" or "у":
                        {

                            counter3++;
                            if (counter3 > 1)
                            {
                                Console.WriteLine("\nGame: Зачем ты снова сюда смотришь? ты же только забрал отсюда Артефакт");
                            }
                            else
                            {


                                Console.WriteLine("\nGame: " + name + ", Вы нашли " + three);

                                if (counter1 == 0 && counter2 == 0)
                                {
                                    Console.WriteLine("Player: Что это такое?\n");
                                }
                                else if (counter1 == 0 || counter2 == 0)
                                {
                                    Console.WriteLine("Player: О ещё один камень.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Player: Мне кажется я нашёл все камни. нужно попробовать их применить\n");
                                }
                            }
                        }
                        break;
                    
                    case "f" or "F" or "а" or "А":
                        {
                            if (counter1 == 0 && counter2 ==0 && counter3 ==0)
                            {
                                Console.WriteLine("\nPlayer: Хм.. тут три отверстия как будто нужно что-то вставить (камни!! прочь свои пошлые мыслишки)\n");
                            }
                            else if (counter1 ==0 || counter2 ==0 || counter3 ==0)
                            {
                                Console.WriteLine("\nPlayer: Я нашел ещё не все артифакты");
                            }
                            else
                            {
                                counter5++;
                                Console.WriteLine("\nGame:" + name + " Активировал статую.Статуя поднясла руку к груди и заиграл гимн РФ"+"\nGame:" + name + " Тоже поднёс руку к груди и начал подпевать\nPlayer: Как хорошо быть русским ууу я крутой дадада\n"+"\nGame:" + name + ", Вы нашли ключ\n");
                                
                            }
                        }

                        break;




                }
                
            }
        }
    }
}

