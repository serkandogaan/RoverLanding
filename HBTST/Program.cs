using System;
using System.Collections.Generic;
using System.Linq;

namespace HBTST
{
    internal class Program
    {


        static List<Rover> RVRList = new List<Rover>();
        static int[] RoverLastPost = new int[2];
        static RoverArea area;
        static void Main(string[] args)
        {
            int Choose = 10;

        DuzlemAreaWrong:

            try
            {
                Console.WriteLine("Düzlem alanını (X Y) giriniz : ");
                string DuzlemArea = Console.ReadLine();
                var DuzlemXY = DuzlemArea.Split(' ');
                if (DuzlemXY.Length < 2 || DuzlemXY.Length > 2 || int.Parse(DuzlemXY[0]) < 0 || int.Parse(DuzlemXY[1]) < 0)
                {
                    Console.WriteLine("Düzlem alanını X, Y şeklinde arasında boşluk bırakarak girmelisiniz. ");
                    goto DuzlemAreaWrong;
                }

                area = new RoverArea(int.Parse(DuzlemXY[0]), int.Parse(DuzlemXY[1]));

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
                            Console.WriteLine(lists.GetLocation());
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı veri girişi");
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
            Rover NewRover = new Rover(RVRList.Count() + 1, int.Parse(ConsoleXY[0]), int.Parse(ConsoleXY[1]), ConsoleXY[2]);
            if (NewRover.LandingArea(area) == false)
            {
                Console.WriteLine("Rover Alan Dışına konuşlanamaz");
                goto RoverWrongPosition;
            }
            foreach (var item in RVRList)
            {
                if (NewRover.CheckOtherRover(item) == false)
                {
                    Console.WriteLine("O konumda zaten bir Rover var, başka yere konuşlandır");
                    goto RoverWrongPosition;
                }
            }
        RoverWrongMove:

            Console.WriteLine("Rover'ın hareketini giriniz : ");
            string ConsoleRoverMoveInput = Console.ReadLine();
            char[] ConsoleRoverCoordinate = ConsoleRoverMoveInput.ToCharArray();
           
            RVRList.Add(NewRover);

            for (int i = 0; i < ConsoleRoverCoordinate.Length; i++)
            {
                if (NewRover.Move(ConsoleRoverCoordinate[i].ToString().ToUpper()) == false)
                {
                    Console.WriteLine("Rover hareketi sadece L,R,M harflerinden oluşur. Tekrar deneyin.");
                    goto RoverWrongMove;
                }
            }
        }
    }
}