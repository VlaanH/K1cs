using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1Csv1
{
    class Program
    {
        public static void x()
        {
            Console.WriteLine("+ Для выхода введите \"777\" +"); 
        }
        public static void sleh()
        {
            Console.WriteLine("-----------------------------------------------"); 
        }
        public static void min()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("+------------------------------------+");
            Console.Write("|           Program:K1Cs");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  V1.3.1");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("C    ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("| ");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1 - подсчет стоимости комплектующих");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" | ");

            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2 - калькулятор доли ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("               |");
            
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2<- exit ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                           |");
            Console.WriteLine("+------------------------------------+"); 
        }
        public static void prs()
        {

            Console.Write("Стоимость комплектующих на данный момент: ");
            

        }





        static void Main(string[] args)
        {
          

            string a1;
            
            int pp = 0;//выхлд для hdd
           //выхлд для ssd
            min();
            Console.ForegroundColor = ConsoleColor.White;
            a1 = Console.ReadLine();
            int a;
            a = Convert.ToInt32(a1);



            
            int XHDD = 0 ;
            int XSSD = 0;
            int[] arr;
            arr = new int[5];
            int[] arr1;
            arr1 = new int[5];


            while (a < 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                switch (a)
                {
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("+----------------+");
                        Console.WriteLine("|Калькулятор доли|");
                        Console.WriteLine("+----------------+");
                        Console.ForegroundColor = ConsoleColor.White;


                        Console.WriteLine("Стоимость сборки: ");
                        string b1 = Console.ReadLine();
                        double b = double.Parse(b1);



                        Console.WriteLine("Стоимость сборки НА Avito:  ");
                        string h1 = Console.ReadLine();
                        double h = double.Parse(h1);


                        Console.WriteLine("Твоя Доля в русиан рубл: ");
                        string a12 = Console.ReadLine();
                        double a3 = double.Parse(a12);

                        
                        Console.WriteLine($"Доля:  {a3 / b * 100}%");
                        Console.WriteLine($"Профит: {(h / b) * a3}р");
                        
                        
                        break;



                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|Подсчет стоимости комплектующих|");
                        Console.WriteLine("+-------------------------------+");
                        Console.ForegroundColor = ConsoleColor.White;
                        x();
                        Console.WriteLine("Стоимость процессора:  ");
                       
                        int cpu = int.Parse(Console.ReadLine());

                        if (cpu==777)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                            
                            int Y = int.Parse(Console.ReadLine()); 

                            if (Y == 1)
                            {
                                break;
                            }
                            if (Y>1)
                            {
                                Console.Write($"Процессор стоит:{cpu}? ДА(1)/НЕТ(2):");
                                string Y2 = Console.ReadLine();
                                int YY = int.Parse(Y2);
                                if (YY>1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Стоимость процессора:  ");
                                     
                                     cpu = int.Parse(Console.ReadLine());


                                }
                            }
                        }

                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu);

                        Console.WriteLine("Стоимость материнской платы :  ");
                        
                        int mat = int.Parse(Console.ReadLine());

                        if (mat == 777)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                            
                            int Y = int.Parse(Console.ReadLine());

                            if (Y == 1)
                            {
                                break;
                            }
                            if (Y > 1)
                            {
                                Console.Write($"Материнка стоит:{mat}? ДА(1)/НЕТ(2):");
                                string Y2 = Console.ReadLine();
                                int YY = int.Parse(Y2);
                                if (YY > 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Стоимость материнской платы :  ");
                                    
                                    mat = int.Parse(Console.ReadLine());


                                }
                            }
                        }
                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu+mat);

                        Console.WriteLine("Стоймость видеокарты: ");
                        string gpu1 =Console.ReadLine();
                        int gpu = int.Parse(gpu1);
                        
                        if (gpu == 777)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                            string Y1 = Console.ReadLine();
                            int Y = int.Parse(Y1);

                            if (Y == 1)
                            {
                                break;
                            }
                            if (Y > 1)
                            {
                                Console.Write($"Видеокарта стоит:{gpu}? ДА(1)/НЕТ(2):");
                                string Y2 = Console.ReadLine();
                                int YY = int.Parse(Y2);
                                if (YY > 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Стоймость видеокарты: ");
                                    gpu1 = Console.ReadLine();
                                    gpu = int.Parse(gpu1);

                                }
                            }
                        }
                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu+mat+gpu);
                        
                        Console.WriteLine("Стоймость КулерCPU: ");
                        string cpufan1 = Console.ReadLine();
                        int cpufan = int.Parse(cpufan1);

                        if (cpufan == 777)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                            string Y1 = Console.ReadLine();
                            int Y = int.Parse(Y1);

                            if (Y == 1)
                            {
                                break;
                            }
                            if (Y > 1)
                            {
                                Console.Write($"КулерCPU стоит:{cpufan}? ДА(1)/НЕТ(2):");
                                string Y2 = Console.ReadLine();
                                int YY = int.Parse(Y2);
                                if (YY > 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Стоймость КулерCPU: ");
                                     cpufan1 = Console.ReadLine();
                                     cpufan = int.Parse(cpufan1);
                                }
                            }
                        }
                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu+mat+gpu+cpufan);

                        Console.WriteLine("Стоймость ОЗУ: ");
                        string ram1 = Console.ReadLine();
                        int ram = int.Parse(ram1);
                        
                        if (ram == 777)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                            string Y1 = Console.ReadLine();
                            int Y = int.Parse(Y1);

                            if (Y == 1)
                            {
                                break;
                            }
                            if (Y > 1)
                            {
                                Console.Write($"ОЗУ стоит:{ram}? ДА(1)/НЕТ(2):");
                                string Y2 = Console.ReadLine();
                                int YY = int.Parse(Y2);
                                if (YY > 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Стоймость ОЗУ: ");
                                    ram1 = Console.ReadLine();
                                    ram = int.Parse(ram1);
                                }
                            }
                        }
                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu+mat+gpu+cpufan+ram);

                        Console.WriteLine("Стоймость корпуса: ");
                        string kor1 = Console.ReadLine();
                        int kor = int.Parse(kor1);

                        if (kor == 777)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                            string Y1 = Console.ReadLine();
                            int Y = int.Parse(Y1);

                            if (Y == 1)
                            {
                                break;
                            }
                            if (Y > 1)
                            {

                                Console.Write($"Корпус стоит:{ram}? ДА(1)/НЕТ(2):");
                                string Y2 = Console.ReadLine();
                                int YY = int.Parse(Y2);
                                if (YY > 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Стоймость корпуса: ");
                                    kor1 = Console.ReadLine();
                                    kor = int.Parse(kor1);
                                }
                            }
                        }
                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu + mat + gpu + cpufan + ram + kor);


                        for (int i = 0; i == 0;)
                        {
                            string kk1;
                            int kk;

                            Console.WriteLine("Количество HDD");
                            kk1 = Console.ReadLine();
                            kk = int.Parse(kk1);

                            if (kk==777)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                                string Y1 = Console.ReadLine();
                                int Y = int.Parse(Y1);
                                Console.ForegroundColor = ConsoleColor.White;
                                if (Y == 1)
                                {
                                    pp += Y;
                                    break;
                                }
                                if (Y > 1)
                                {
                                    i = 0;
                                    for (i = 0; i == 0;)
                                    {
                                        
                                        Console.WriteLine("Количество HDD");
                                       
                                        kk = int.Parse(Console.ReadLine());
                                        if (kk < 6)
                                        {
                                            for (int q = 0; kk > q; q++)
                                            {
                                                Console.WriteLine($"Стоймость HDD {q + 1}");

                                                arr[q] = int.Parse(Console.ReadLine());
                                            }
                                           
                                            for (int q = 0; q < kk; q++)
                                            {
                                                XHDD += arr[q];
                                            }
             
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("не более 5");
                                        }
                                    }
                                }
                                break;
                            }
                            if (kk < 6)
                            {
                                for (int q = 0; kk > q; q++)
                                {
                                    Console.WriteLine($"Стоймость HDD {q + 1}");

                                    arr[q] = int.Parse(Console.ReadLine());
                                }
                                for (int q11 = 0; q11 < kk; q11++)
                                {
                                    XHDD += arr[q11];
                                }

                                break;
                            }
                            else
                            {
                                Console.WriteLine("не более 5");
                            }
                        }
                        if (pp == 1)
                        {
                            pp = 0;
                            break;
                        }
                        sleh();
                        x();
                        prs();
                        Console.WriteLine(cpu + mat + gpu + cpufan + ram + kor + XHDD);
                        //2
                        int pp2 = 0;
                        for (int i = 0; i == 0;)
                        {
                            
                            int kk1;

                            Console.WriteLine("Количество ssd");
                           
                            kk1 = int.Parse(Console.ReadLine());

                            if (kk1 == 777)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Вы уверены что хотите выйти? ДА(1)/НЕТ(2):");
                                
                                int Y = int.Parse(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.White;
                                if (Y == 1)
                                {
                                    pp2 += Y;
                                    break;
                                }
                                if (Y > 1)
                                {
                                    i = 0;
                                    for (; i == 0;)
                                    {
                                        
                                        Console.WriteLine("Количество ssd");
                                        kk1 = int.Parse(Console.ReadLine());
                                        if (kk1 < 6)
                                        {
                                            for (int q = 0; kk1 > q; q++)
                                            {
                                                Console.WriteLine($"Стоймость ssd { q + 1}");
                                                arr[q] = int.Parse(Console.ReadLine());
                                            }
                                            for (int q1 = 0; q1 < kk1; q1++)
                                            {
                                                XSSD += arr[q1];
                                            }

                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("не более 5");
                                        }
                                    }
                                }
                                break;
                            }
                            if (kk1 < 6)
                            {
                                for (int q = 0; kk1 > q; q++)
                                {
                                    Console.WriteLine($"Стоймость ssd { q + 1}");

                                    arr[q] = int.Parse(Console.ReadLine());
                                }
                                for (int q11 = 0; q11 < kk1; q11++)
                                {
                                    XSSD += arr1[q11];
                                }
                                

                                break;

                            }
                            else
                            {
                                Console.WriteLine("не более 5");
                            }
                        }
                        if (pp2 == 1)
                        {
                            pp2 = 0;
                            break;
                        }
                        sleh();
                        prs();
                        Console.WriteLine(cpu + mat + kor + cpufan + ram + XHDD + gpu + XHDD);

                        Console.WriteLine($"Стоймость БП");

                        int bp = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Стоимость ПК: {cpu + mat + kor + cpufan + ram + XHDD + bp + gpu + XHDD}р");
                        break;
                }

               

                min();
                Console.ForegroundColor = ConsoleColor.White;
                a1 = Console.ReadLine();
                XHDD = 0;XSSD = 0;
                a = Convert.ToInt32(a1);
                



                if (a>2)
                {
                break;
                }
                
                
                
            }





            
        }
   
    
    
    }


}
