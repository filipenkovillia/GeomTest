using System;
using System.Dynamic;

namespace GeomTest
{
    class Program
    {
        public static float[][][] GetInput()
        {
            Console.WriteLine("Enter number of vertices: ");
            int num = Int32.Parse(Console.ReadLine());
            float[][][] pol = new float[1][][];
            pol[0] = new float[num + 1][];

            Console.WriteLine("Enter vertices coordinates:");
            for(int i = 0; i < num; i++)
            {
                string st = Console.ReadLine();
                string[] stArr = st.Split(" ");
                
                float x = float.Parse(stArr[0]);
                float y = float.Parse(stArr[1]);
                pol[0][i] = new float[2] { x, y };
            }
            pol[0][num] = new float[2] { pol[0][0][0], pol[0][0][1] };

            return pol;
        }
        static void Main(string[] args)
        {
            float[] p = PolyLabel.GetPolyLabel(GetInput());
            Console.WriteLine("Circle centre coordinates:");
            Console.WriteLine(p[0].ToString() + " " + p[1].ToString());
            Console.WriteLine("Circle radius:");
            Console.WriteLine(p[2].ToString());
            //Console.ReadLine();
            //PolyLabel p = new PolyLabel();
            //float[][][] pol = new float[1][][];
            //float[][][] pol = { { { 30, 10 }, { 40, 40 }, { 20, 40 }, { 10, 20 }, { 30, 10 } } };
            //PolyLabel.GetPolyLabel()
        }
    }
}
