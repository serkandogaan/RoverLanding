using System;
using System.Collections.Generic;
using System.Linq;

namespace HBTST
{
    internal class Program
    {

        class Rover
        {
            public int RoverID;
            public int RoverX;
            public int RoverY;
            public string RoverCompassFace;
        }

        static List<Rover> RVRList = new List<Rover>();

        static int RoverPositionX = 0;
        static int RoverPositionY = 0;
        static int[] RoverLastPost = new int[2];
        static string RoverCompassFaceing;
        static string[] DuzlemXY;
        static void Main(string[] args)
        {

            Rover rvr = new Rover();
            rvr.RoverX = 3;
            rvr.RoverY = 5;
            rvr.RoverID = 1;
            rvr.RoverCompassFace = "N";
            RVRList.Add(rvr);
            Rover rvr2 = new Rover();
            rvr2.RoverX = 5;
            rvr2.RoverY = 7;
            rvr2.RoverID = 2;
            RVRList.Add(rvr2);
            


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
                        foreach (var lists in RVRList)
                        {
                            Console.WriteLine(lists.RoverX + " " + lists.RoverY + " " + lists.RoverCompassFace);
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

            Rover NewRover = new Rover();
        RoverWrongPosition:
            Console.WriteLine("Rover'ın Sırasıyla X, Y ve PUSULA (N,S,W,E) kordinatlarını giriniz :");
            string ConsoleCoordinateInput = Console.ReadLine();
            string[] ConsoleXY = ConsoleCoordinateInput.Split(' ');
            if (int.Parse(ConsoleXY[0]) > int.Parse(DuzlemXY[0]) || int.Parse(ConsoleXY[1]) > int.Parse(DuzlemXY[1]) || ConsoleXY[2].ToUpper() != "N" && ConsoleXY[2].ToUpper() != "S" && ConsoleXY[2].ToUpper() != "W" && ConsoleXY[2].ToUpper() != "E")
            {
                Console.WriteLine("Rover Alan Dışına konuşlanamaz veya Rover'ın pusula yönünü doğru giriniz");
                goto RoverWrongPosition;
            }
            foreach (var item in RVRList)
            {
                if (item.RoverX == int.Parse(ConsoleXY[0]) && item.RoverY == int.Parse(ConsoleXY[1]))
                {
                    Console.WriteLine("O konumda zaten bir Rover var, başka yere konuşlandır");
                    goto RoverWrongPosition;
                }
            }
        RoverWrongMove:
            RoverCompassFaceing = ConsoleXY[2];



            Console.WriteLine("Rover'ın hareketini giriniz : ");
            string ConsoleRoverMoveInput = Console.ReadLine();
            char[] ConsoleRoverCoordinate = ConsoleRoverMoveInput.ToCharArray();

            NewRover.RoverX = int.Parse(ConsoleXY[0]);
            NewRover.RoverY = int.Parse(ConsoleXY[1]);
            NewRover.RoverCompassFace = ConsoleXY[2];
            NewRover.RoverID = RVRList.Count() + 1;
            RVRList.Add(NewRover);

            for (int i = 0; i < ConsoleRoverCoordinate.Length; i++)
            {
                if (ConsoleRoverCoordinate[i].ToString().ToUpper() != "L" && ConsoleRoverCoordinate[i].ToString().ToUpper() != "M" && ConsoleRoverCoordinate[i].ToString().ToUpper() != "R")
                {
                    Console.WriteLine("Rover hareketi sadece L,R,M harflerinden oluşur. Tekrar deneyin.");
                    goto RoverWrongMove;
                }




                if (ConsoleRoverCoordinate[i].ToString().ToUpper() == "M")
                {
                    RoverPositionX = NewRover.RoverX;
                    RoverPositionY = NewRover.RoverY;



                    foreach (var item in RVRList)
                    {

                        if (NewRover.RoverX < item.RoverX && NewRover.RoverY < item.RoverY)
                        {
                            if (RoverCompassFaceing.ToUpper() == "N" && NewRover.RoverY < int.Parse(DuzlemXY[1]))
                            {
                                NewRover.RoverY += 1;
                            }
                        }

                        


                        //if (RoverCompassFaceing.ToUpper() == "N" && NewRover.RoverY < int.Parse(DuzlemXY[1]))
                        //{                           
                        //    NewRover.RoverY = RoverPositionY + 1;                            
                        //}
                        //else if (RoverCompassFaceing.ToUpper() == "E" && NewRover.RoverX < int.Parse(DuzlemXY[0]))
                        //{
                        //    NewRover.RoverX = RoverPositionX + 1;
                        //}
                        //else if (RoverCompassFaceing.ToUpper() == "W" && NewRover.RoverY < int.Parse(DuzlemXY[0]) && NewRover.RoverX > 0)
                        //{
                        //    NewRover.RoverX = RoverPositionX - 1;
                        //}
                        //else if (RoverCompassFaceing.ToUpper() == "S" && NewRover.RoverY < int.Parse(DuzlemXY[1]) && NewRover.RoverY > 0)
                        //{
                        //    NewRover.RoverY = RoverPositionY - 1;
                        //}


                    }

                    //if (RoverCompassFaceing.ToUpper() == "N")
                    //{                      

                    //    NewRover.RoverY = RoverPositionY + 1;                       

                    //    //foreach (var item in RVRList)
                    //    //{
                    //    //    if (NewRover.RoverX == item.RoverX && NewRover.RoverY == item.RoverY)
                    //    //    {
                    //    //        NewRover.RoverY = RoverPositionY;
                    //    //    }
                    //    //}

                    //    if (NewRover.RoverY > int.Parse(DuzlemXY[1]))
                    //    {
                    //        NewRover.RoverY = int.Parse(DuzlemXY[1]);
                    //    }
                    //}
                    //else if (RoverCompassFaceing.ToUpper() == "E")
                    //{
                    //    NewRover.RoverX = RoverPositionX + 1;

                    //    foreach (var item in RVRList)
                    //    {
                    //        if (NewRover.RoverX == item.RoverX && NewRover.RoverY == item.RoverY)
                    //        {
                    //            NewRover.RoverX = RoverPositionX;
                    //        }
                    //    }

                    //    if (NewRover.RoverX > int.Parse(DuzlemXY[0]))
                    //    {
                    //        NewRover.RoverX = int.Parse(DuzlemXY[0]);
                    //    }
                    //}
                    //else if (RoverCompassFaceing.ToUpper() == "W")
                    //{
                    //    NewRover.RoverX = RoverPositionX - 1;

                    //    foreach (var item in RVRList)
                    //    {
                    //        if (NewRover.RoverX == item.RoverX && NewRover.RoverY == item.RoverY)
                    //        {
                    //            NewRover.RoverX = RoverPositionX;
                    //        }
                    //    }

                    //    if (NewRover.RoverX < 0)
                    //    {
                    //        NewRover.RoverX = 0;
                    //    }
                    //}
                    //else if (RoverCompassFaceing.ToUpper() == "S")
                    //{
                    //    NewRover.RoverY = RoverPositionY - 1;

                    //    foreach (var item in RVRList)
                    //    {
                    //        if (NewRover.RoverX == item.RoverX && NewRover.RoverY == item.RoverY)
                    //        {
                    //            NewRover.RoverY = RoverPositionY;
                    //        }
                    //    }

                    //    if (NewRover.RoverY < 0)
                    //    {
                    //        NewRover.RoverY = 0;
                    //    }
                    //}

                    // Burayı daha optimal nasıl yazılabilir
                    // rover haret edebiliyor mu diye kontrol edilip hareket edebiliyor ise ilgili kutuya ilerlemeli
                    //foreach (var item in RVRList)
                    //{
                    //    // TODO string dışında nasıl yapılabilir düşün. (RoverLastPost[0] + " " + RoverLastPost[1] + " " + RoverCompassFaceing.ToUpper() == item)
                    //    if (NewRover.RoverX == item.RoverX && NewRover.RoverY == item.RoverY && NewRover.RoverCompassFace == item.RoverCompassFace)
                    //    {
                    //        if (RoverCompassFaceing.ToUpper() == "N")
                    //        {
                    //            RoverLastPost[1] = RoverLastPost[1] - 1;
                    //        }
                    //        else if (RoverCompassFaceing.ToUpper() == "S")
                    //        {
                    //            RoverLastPost[1] = RoverLastPost[1] + 1;
                    //        }
                    //        else if (RoverCompassFaceing.ToUpper() == "E")
                    //        {
                    //            RoverLastPost[0] = RoverLastPost[0] - 1;
                    //        }
                    //        else if (RoverCompassFaceing.ToUpper() == "W")
                    //        {
                    //            RoverLastPost[0] = RoverLastPost[0] + 1;
                    //        }

                    //    }
                    //}
                }

                else if (ConsoleRoverCoordinate[i].ToString().ToUpper() == "L")
                {

                    if (RoverCompassFaceing.ToUpper() == "N")
                    {
                        NewRover.RoverCompassFace = "W";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "W")
                    {
                        NewRover.RoverCompassFace = "S";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "S")
                    {
                        NewRover.RoverCompassFace = "E";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "E")
                    {
                        NewRover.RoverCompassFace = "N";
                    }
                }
                else if (ConsoleRoverCoordinate[i].ToString().ToUpper() == "R")
                {

                    if (RoverCompassFaceing.ToUpper() == "N")
                    {
                        NewRover.RoverCompassFace = "E";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "E")
                    {
                        NewRover.RoverCompassFace = "S";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "S")
                    {
                        NewRover.RoverCompassFace = "W";
                    }
                    else if (RoverCompassFaceing.ToUpper() == "W")
                    {
                        NewRover.RoverCompassFace = "N";
                    }
                }
            }
            //RVRList.Add(NewRover);



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