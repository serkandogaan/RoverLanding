using HBTST.DataAccess;
using HBTST.Entity.Concrete;
using System;

namespace HBTST
{
    internal class Program
    {

        static RoverArea roverArea;
        static RoverDAL roverDAL = new RoverDAL();

        static void Main(string[] args)
        {
            int Choose = 10;

        roverAreaWrong:

            try
            {
                Console.WriteLine("Düzlem alanını (X Y) giriniz : ");
                string roverArea1 = Console.ReadLine();
                var roverAreaXY = roverArea1.Split(' ');
                if (roverAreaXY.Length < 2 || roverAreaXY.Length > 2 || int.Parse(roverAreaXY[0]) < 0 || int.Parse(roverAreaXY[1]) < 0)
                {
                    Console.WriteLine("Düzlem alanını X, Y şeklinde arasında boşluk bırakarak girmelisiniz. ");
                    goto roverAreaWrong;
                }

                roverArea = new RoverArea(int.Parse(roverAreaXY[0]), int.Parse(roverAreaXY[1]));

            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı Düzlem alanı girişi");
                goto roverAreaWrong;
            }

        wrongChoose:

            while (Choose != 0)

            {
                try
                {
                    Console.WriteLine("1 - ) Rover Konuşlandır\n2 - ) Rover'ları Sırasıyla hareket ettir\n3 - ) Listeden Rover Sil");
                    Choose = Convert.ToInt32(Console.ReadLine());

                    if (Choose == 1)
                    {
                        RoverAdd();
                    }

                    if (Choose == 2)
                    {
                        RoverList();
                    }

                    if (Choose == 3)
                    {
                        RoverList();
                        Console.WriteLine("Yukarıdaki listeden Rover sileceğiniz Rover'ın ID'sini giriniz : ");
                        int selectedRoverID = Convert.ToInt32(Console.ReadLine());
                        roverDAL.Delete(selectedRoverID);
                        Console.WriteLine("Rover başarıyla silindi");
                        RoverList();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı veri girişi");
                    goto wrongChoose;

                }
            }
            Console.ReadKey();
        }

        public static void RoverList()
        {
            foreach (var allRover in roverDAL.Gets())
            {
                Console.WriteLine("Rover ID : " + allRover.ID + " Rover X : " + allRover.X + " Rover Y : " + allRover.Y + " Rover Yön : " + allRover.Direction);
            }
        }
        public static void RoverAdd()
        {

        roverWrongPosition:
            Console.WriteLine("Rover'ın Sırasıyla X, Y ve PUSULA (N,S,W,E) kordinatlarını giriniz :");
            string consoleCoordinateInput = Console.ReadLine();
            string[] consoleXY = consoleCoordinateInput.Split(' ');
            Rover newRover = new Rover(int.Parse(consoleXY[0]), int.Parse(consoleXY[1]), consoleXY[2].ToUpper(), string.Empty);

            if (newRover.LandingArea(roverArea) == false)
            {
                Console.WriteLine("Rover Alan Dışına konuşlanamaz business");
                goto roverWrongPosition;
            }

            foreach (var roverList in roverDAL.Gets())
            {
                if (newRover.CheckOtherRover(roverList) == false)
                {
                    Console.WriteLine("O konumda zaten bir Rover var, başka yere konuşlandır");
                    goto roverWrongPosition;
                }
            }

            

        roverWrongMove:
            if (!roverDAL.Add(newRover))
            {
                Console.WriteLine("Rover eklenemedi.");
                goto roverWrongPosition;
            }
            
            Console.WriteLine("Rover'ın hareketini giriniz : ");
            string consoleRoverMoveInput = Console.ReadLine();
            char[] consoleRoverCoordinate = consoleRoverMoveInput.ToCharArray();


            for (int i = 0; i < consoleRoverCoordinate.Length; i++)
            {
                if (newRover.Move(consoleRoverCoordinate[i].ToString().ToUpper()) == false)
                {
                    Console.WriteLine("Rover hareketi sadece L,R,M harflerinden oluşur. Tekrar deneyin.");
                    goto roverWrongMove;
                }
            }
            
        }
    }
}