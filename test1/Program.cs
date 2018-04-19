using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將視窗標題設為BMI計算機
            Console.Title = "BMI計算機";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("BMI計算機"+"\n");

            // 輸入身高體重
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("請輸入體重(公斤):");        
            string kg = Console.ReadLine();
            Console.Write("請輸入身高(公分):");
            string tall = Console.ReadLine();

            // 將身高單位轉換為公尺
            double newTall = double.Parse(tall)/100;

            // 計算BMI結果並顯示 
            double BMI = Math.Round(double.Parse(kg) / newTall,2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n"+"BMI值為:" + BMI+"\n");

            // 判斷BMI是否過重或符合免兵役標準
            if (BMI < 18.5)
            {
                if (BMI < 16.5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("※符合免兵役標準");
                }                   
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("您的體重過輕!:OOOOOOOO"+"\n"+"快多吃點飯飯!");
            }                

            else if (BMI >= 18.5 && BMI < 24)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("您的BMI指數正常:)");                
            }
                

            else if (BMI >= 24 && BMI < 27)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("您過重囉!");                
            }

            else if (BMI >= 27 && BMI < 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("您屬於【輕度肥胖】:(");                
            }

            else if (BMI >= 30 && BMI < 35)
            {
                if (BMI > 31.5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("※符合免兵役標準");
                }                    
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("您屬於【中度肥胖】:((");                
            }

            else if (BMI >= 35)
            {
                if (BMI > 31.5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("※符合免兵役標準");
                }                    
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("您屬於【重度肥胖】:(((" + "\n" + "☆聰明吃-正確飲食觀：請搜尋衛生福利部國民健康署");                
            }                    

            // 讀取
            Console.ReadLine();            

           
        }
    }
}
