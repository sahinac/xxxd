using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace xxxd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //considerar que si derriba 10 en la primera, ya no tiene un segundo spiel
            // el segundo tiro tiene que ser numeros entre 10- spiel 1
            //Console.WriteLine("Bowling game");
            //int players;
            //Console.WriteLine("Wie viele Players");
            //players = Convert.ToInt32(Console.ReadLine());
            //int[] spiel1 = new int[players];
            //int[] spiel2 = new int[players];

            //Random x = new Random();

            //string[] name = new string[players];
            //for (int i = 0; i < players; i++)
            //{
            //    Console.WriteLine("IHRE NAMEN:");
            //    name[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Name" + "\t\t" + "Spiel1" + "\t\t" + "Spiel2" + "\t\t" + "Gesamt");
            //Console.WriteLine("------------------------------------------------------------");
            //for (int i = 0; i < name.Length; i++)
            //{
            //    spiel1[i] = x.Next(0, 11);
            //    int y = 10 - spiel1[i];
            //    for (int j = 0; j < name.Length; j++)
            //    {
            //        spiel2[j] = x.Next(0, y + 1);
            //    }
            //}
            //int[] gesamt = new int[players];
            //for (int i = 0; i < name.Length; ++i)
            //{
            //    gesamt[i] = spiel1[i] + spiel2[i];
            //    Console.WriteLine(name[i] + "\t\t" + spiel1[i] + "\t\t" + spiel2[i] + "\t\t" + gesamt[i]);
            //}
            //int max = gesamt.Max();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (gesamt[i] == max)
            //        Console.WriteLine("Gewinner ist/sind" + "\n" + name[i]);

            //}
            //Console.ReadLine();

            //dos examenes aprobados con 50%. Si no aprueba uno de los dos
            //con 50 , tiene que dar otro examen y este se aprueba con 30

            Console.WriteLine("Notas");
            int alumnos;
            Console.WriteLine("Wie viele Studenten");
            alumnos = Convert.ToInt32(Console.ReadLine());
            int[] note1 = new int[alumnos];
            int[] note2 = new int[alumnos];
            string[] veredicto = new string[alumnos];

            Random x = new Random();

            string[] name = new string[alumnos];
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("IHRE NAMEN:");
                name[i] = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Name" + "\t\t" + "Note1" + "\t\t" + "Note2" + "\t\t" + "Note3" + "\t\t" + "vEREDICTO");
            //int jalados = 0;
            for (int i = 0; i < name.Length; i++)
            {
                note1[i] = x.Next(0, 101);

                for (int j = 0; j < name.Length; j++)
                {
                    note2[j] = x.Next(0, 101);
                }
            }
            int[] jaladosarray = new int[alumnos];
            for (int i = 0; i < name.Length; i++)
            {
                if ((note1[i]+note2[i])/2 >= 50)
                {
                    jaladosarray[i] = 0;
                    veredicto[i] = "Aprobado";
                }
                else
                {
                    jaladosarray[i] = x.Next(0, 101);
                    if (jaladosarray[i] > 80)
                    {
                        veredicto[i] = "Aprobado";
                    }
                    else
                    {
                        veredicto[i] = "Jalado";
                    }
                }
                Console.WriteLine(name[i] + "\t\t" + note1[i] + "\t\t" + note2[i] + "\t\t" + jaladosarray[i] + "\t\t" + veredicto[i]);

            }
            Console.WriteLine();
            Console.ReadLine();
        }




    }
}




    





    

