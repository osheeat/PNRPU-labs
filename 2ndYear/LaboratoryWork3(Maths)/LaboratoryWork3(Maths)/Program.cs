using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LaboratoryWork3_Maths_
{
    class Program
    {
        static int[] vector = new int[16];
        static int[][] TruthTable = new int[16][]; 
        static List<int[]>DNF = new List<int[]>();
        static List<int[]> SkDNF = new List<int[]>();


        static bool CheckInput(int value)
        {
            if (value > 1 || value < 0)
            {
                Console.WriteLine("Элемент не равен 1 или 0");
                return false;
            }
            return true;
        }

        static void FillVector()
        {
            for (int i = 0; i < 16; i++)
            {
                bool IsCorrect;
                do
                {
                    Console.Write("Введите " +(i+1) +" элемент вектора:    ");
                    IsCorrect = int.TryParse(Console.ReadLine(), out vector[i]);
                    if(!IsCorrect)
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                } while (!IsCorrect || !CheckInput(vector[i]));
            }
        }

        static void FillTruthTable ()
        {
            int tmp = 0;

            for (int x1 = 0; x1 < 2; x1++)
            {
                for (int x2 = 0; x2 < 2; x2++)
                {
                    for (int x3 = 0; x3 < 2; x3++)
                    {
                        for (int x4 = 0; x4 < 2; x4++)
                        {
                            int[] row = { x1, x2, x3, x4, vector[tmp] };
                            TruthTable[tmp] = row;
                            tmp++;
                        }
                    }
                }
            }
        }

        static void PrintTruthTable()
        {
            Console.WriteLine("Вывод таблицы истинности");

            Console.WriteLine(" ---------------------");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" |x" + (i+1));
            }
            Console.WriteLine(" | F |");
            Console.WriteLine(" ---------------------");

            for (int i = 0; i < TruthTable.Length; i++)
            {
                for (int j = 0; j < TruthTable[i].Length; j++)
                {
                    Console.Write(" | " +TruthTable[i][j]);
                }
                Console.WriteLine(" |");
            }
            Console.WriteLine(" ---------------------");
        }

        static void CreateDNF()
        {
            for (int i = 0; i < vector.Length; i++) //0 -> 15 = i
            {
                if (vector[i] == 1)
                {
                    int[] row = { TruthTable[i][0], TruthTable[i][1], TruthTable[i][2], TruthTable[i][3] };
                    DNF.Add(row);
                }
            }
        }

        static void PrintDNF(List<int[]> DNF)
        {
            string input = "";
            for (int i = 0; i < DNF.Count; i++)
            {
                if (i == DNF.Count-1)
                {
                    for (int j = 0; j < DNF[i].Length; j++)
                    {
                       
                        Console.Write(DNF[i][j]);
                    }
                }
                else
                {
                    for (int j = 0; j < DNF[i].Length; j++)
                    {
                        Console.Write(DNF[i][j]);
                    }
                    Console.Write(" + \t");
                }
                
            }
        }

        static bool IsMerged(int[] first, int[] second)
        {
            
            int[] minus = new int[first.Length];

            for (int i = 0; i < minus.Length; i++)
            {
                minus[i] = first[i] - second[i];
            }

            int razn = 0;
            for (int i = 0; i < minus.Length; i++)
            {
                if (minus[i] != 0)
                {
                    razn++;
                }
            }
            if (razn == 1)
                return true;
            else
                return false;
                     
        }

        static bool IsContains(List<int[]> list, int[] arr)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][0] == arr[0] && list[i][1] == arr[1] && list[i][2] == arr[2] && list[i][3] == arr[3])
                {
                    return true;
                }               
            }
            return false;
        }

        static void DistinctArrays(ref List<int[]>list)
        {
            List<int[]> sList = new List<int[]>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!IsContains(sList, list[i]))
                {
                    sList.Add(list[i]);
                }
            }
            list = sList;           
        }

        static void CreateSDNF()
        {
            SkDNF = DNF;
            bool mergeFlag = true;
            while (mergeFlag)
            {
                mergeFlag = false;

                SortedSet<int> usedElements = new SortedSet<int>();

                for (int i = SkDNF.Count - 1; i > 0; i--)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (IsMerged(SkDNF[i], SkDNF[j]))
                        {
                            mergeFlag = true;

                            usedElements.Add(i);
                            usedElements.Add(j);

                            DNF.Add(Merge(SkDNF[i], SkDNF[j]));
                        }
                    }
                }

                while (usedElements.Count > 0)
                {
                    SkDNF.RemoveAt(usedElements.Max);
                    usedElements.Remove(usedElements.Max);
                }

                DistinctArrays(ref SkDNF);

                if (mergeFlag)
                    PrintDNF(SkDNF);
                Console.WriteLine();
            }           
        }

        static int[] Merge(int[]first, int[] second)
        {
            int[] result = new int[first.Length];

            for (int i = 0; i < result.Length; i++)
            {
                if (first[i] == second[i])
                {
                    result[i] = first[i];
                }
                else                    
                    result[i] = 2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            //111110000011111001

            FillVector();
            FillTruthTable();
            Console.WriteLine("\n\n\n");
            PrintTruthTable();
            CreateDNF();
            Console.WriteLine("Вывод ДНФ");
            PrintDNF(DNF);
            Console.WriteLine();
            Console.WriteLine("Вывод СкДНФ");
            CreateSDNF();
            
            //Console.ReadKey();
        }
    }
}
