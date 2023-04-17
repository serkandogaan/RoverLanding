using System;
using System.Collections.Generic;

namespace HBTST
{
    internal class Program
    {
        static int RoverPositionX = 0;
        static int RoverPositionY = 0;
        static int[] RoverLastPost = new int[2];
        static string RoverCompassFaceing;
        static string[] DuzlemXY;
        static List<String> RoverCoordinateList = new List<string>();
        static void Main(string[] args)
        {
            int Choose = 10;

        DuzlemAreaWrong:

            try
            {
                Console.WriteLine("Düzlem alanını (X Y) giriniz : ");
                string DuzlemArea = Console.ReadLine();
                DuzlemXY = DuzlemArea.Split(' ');
                if (DuzlemXY.Length < 2 || DuzlemXY.Length > 2 || int.Parse(DuzlemXY[0]) < 0 || int.Parse(DuzlemXY[1]) < 0)
                {
                    Console.WriteLine("Düzlem alanını X, Y şeklinde arasında boşluk bırakarak girmelisiniz. ");
                    goto DuzlemAreaWrong;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı Düzlem alanı girişi");
                goto DuzlemAreaWrong;
            }

        WrongChoose:

            while (Choose != 0)

            {
                try
                {
                    Console.WriteLine("1 - ) Rover Konuşlandır\n2 - ) Rover'ları Sırasıyla hareket ettir");
                    Choose = Convert.ToInt32(Console.ReadLine());

                    if (Choose == 1)
                    {
                        RoverAdd();
                    }

                    if (Choose == 2)
                    {
                        foreach (var lists in RoverCoordinateList)
                        {
                            Console.WriteLine(lists);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı veri girişi");
                    //if (Choose == 1)
                    //{
                    //    RoverAdd();
                    //}
                    goto WrongChoose;

                }
            }

            Console.ReadKey();

        }
        public static void RoverAdd()
        {
        RoverWrongPosition:
            Console.WriteLine("Rover'ın Sırasıyla X, Y ve PUSULA (N,S,W,E) kordinatlarını giriniz :");
            string ConsoleCoordinateInput = Console.ReadLine();
            string[] ConsoleXY = ConsoleCoordinateInput.Split(' ');
            if (int.Parse(ConsoleXY[0]) > int.Parse(DuzlemXY[0]) || int.Parse(ConsoleXY[1]) > int.Parse(DuzlemXY[1]) || ConsoleXY[2].ToUpper() != "N" && ConsoleXY[2].ToUpper() != "S" && ConsoleXY[2].ToUpper() != "W" && ConsoleXY[2].ToUpper() != "E")
            {
                Console.WriteLine("Rover Alan Dışına konuşlanamaz veya Rover'ın pusula yönünü doğru giriniz");
                goto RoverWrongPosition;
            }
        RoverWrongMove:
            RoverCompassFaceing = ConsoleXY[2];
            Console.WriteLine("Rover'ın hareketini giriniz : ");
            string ConsoleRoverMoveInput = Console.ReadLine();
            char[] ConsoleRoverCoordinate = ConsoleRoverMoveInput.ToCharArray();

            RoverLastPost[0] = int.Parse(ConsoleXY[0]);
            RoverLastPost[1] = int.Parse(ConsoleXY[1]);


            for (int i = 0; i < ConsoleRoverCoordinate.Length; i++)
            {
                if (ConsoleRoverCoordinate[i].ToString().ToUpper() != "L" && ConsoleRoverCoordinate[i].ToString().ToUpper() != "M" && ConsoleRoverCoordinate[i].ToString().ToUpper() != "R")
                {
                    Console.WriteLine("Rover hareketi sadece L,R,M harflerinden oluşur. Tekrar deneyin.");
                    goto RoverWrongMove;
                }
                //RoverPositionX = RoverLastPost[0];
                //RoverPositionY = RoverLastPost[1];

                if (ConsoleRoverCoordinate[i].ToString().ToUpper() == "M")
                {
                    RoverPositionX = RoverLastPost[0];
                    RoverPositionY = RoverLastPost[1];

                    

                    if (RoverCompassFaceing.ToUpper() == "N")
                    {
                        RoverLastPost[1] = RoverLastPost[1] + 1;



                        if (RoverLastPost[1] > int.Parse(DuzlemXY[1]))
                        {
                            RoverLastPost[1] = int.Parse(DuzlemXY[1]);
                        }
                    }
                    else if (RoverCompassFaceing.ToUpper() == "E")
                    {
                        RoverLastPost[0] = RoverLastPost[0] + 1;

                        if (RoverLastPost[0] > int.Parse(DuzlemXY[0]))
                        {
                            RoverLastPost[0] = int.Parse(DuzlemXY[0]);
                        }
                    }
                    else if (RoverCompassFaceing.ToUpper() == "W")
                    {
                        RoverLastPost[0] = RoverLastPost[0] - 1;

                        if (RoverLastPost[0] < 0)
                        {
                            RoverLastPost[0] = 0;
                        }
                    }
                    else if (RoverCompassFaceing.ToUpper() == "S")
                    {
                        RoverLastPost[1] = RoverLastPost[1] - 1;

                        if (RoverLastPost[1] < 0)
                        {
                            RoverLastPost[1] = 0;
                        }
                    }

                    // Burayı daha optimal nasıl yazılabilir
                    // rover haret edebiliyor mu diye kontrol edilip hareket edebiliyor ise ilgili kutuya ilerlemeli
                    foreach (var item in RoverCoordinateList)
                    {
                        // TODO string dışında nasıl yapılabilir düşün.
                        if (RoverLastPost[0] + " " + RoverLastPost[1] + " " + RoverCompassFaceing.ToUpper() == item)
                        {
                            if (RoverCompassFaceing.ToUpper() == "N")
                            {
                                RoverLastPost[1] = RoverLastPost[1] - 1;
                            }
                            else if (RoverCompassFaceing.ToUpper() == "S")
                            {
                                RoverLastPost[1] = RoverLastPost[1] + 1;
                            }
                            else if (RoverCompassFaceing.ToUpper() == "E")
                            {
                                RoverLastPost[0] = RoverLastPost[0] - 1;
                            }
                            else if (RoverCompassFaceing.ToUpper() == "W")
                            {
                                RoverLastPost[0] = RoverLastPost[0] + 1;
                            }
                            
                        }
                    }
                }

                else if (ConsoleRoverCoordinate[i].ToString().ToUpper() == "L")
                {

                    if (RoverCompassFaceing.ToUpper() == "N")
                    {
                        RoverCompassFaceing = "W";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "W")
                    {
                        RoverCompassFaceing = "S";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "S")
                    {
                        RoverCompassFaceing = "E";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "E")
                    {
                        RoverCompassFaceing = "N";
                    }
                }
                else if (ConsoleRoverCoordinate[i].ToString().ToUpper() == "R")
                {

                    if (RoverCompassFaceing.ToUpper() == "N")
                    {
                        RoverCompassFaceing = "E";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "E")
                    {
                        RoverCompassFaceing = "S";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "S")
                    {
                        RoverCompassFaceing = "W";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "W")
                    {
                        RoverCompassFaceing = "N";
                    }
                }
            }
            RoverCoordinateList.Add(RoverLastPost[0] + " " + RoverLastPost[1] + " " + RoverCompassFaceing.ToUpper());
        }

    }
}


//public static void Left90Degrees()
//{
//    RoverLastPost[0] = RoverPositionY * -1;
//    RoverLastPost[1] = RoverPositionX * 1;
//}
//public static void Right90Degrees()
//{
//    RoverLastPost[0] = RoverPositionY * 1;
//    RoverLastPost[1] = RoverPositionX * -1;
//}



//static void Main(string[] args)
//{
//    int Choose = 10;

//DuzlemAreaWrong:

//    try
//    {
//        Console.WriteLine("Düzlem alanını giriniz : ");
//        string DuzlemArea = Console.ReadLine();
//        DuzlemXY = DuzlemArea.Split(' ');
//        if (DuzlemXY.Length < 2 || DuzlemXY.Length > 2 || int.Parse(DuzlemXY[0]) < 0 || int.Parse(DuzlemXY[1]) < 0)
//        {
//            Console.WriteLine("Düzlem alanını X, Y şeklinde arasında boşluk bırakarak girmelisiniz. ");
//            goto DuzlemAreaWrong;
//        }
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Hatalı Düzlem alanı girişi");
//        goto DuzlemAreaWrong;
//    }

//WrongChoose:

//    while (Choose != 0)

//    {
//        try
//        {
//            Console.WriteLine("1 - ) Rover Konuşlandır\n2 - ) Rover'ları Sırasıyla hareket ettir");
//            Choose = Convert.ToInt32(Console.ReadLine());

//            if (Choose == 1)
//            {
//                RoverAdd();
//            }

//            if (Choose == 2)
//            {
//                foreach (var lists in RoverCoordinateList)
//                {
//                    Console.WriteLine(lists);
//                }
//            }
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Hatalı veri girişi");
//            goto WrongChoose;
//        }
//    }

//    Console.ReadKey();

//}