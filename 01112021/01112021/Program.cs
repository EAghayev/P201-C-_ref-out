using System;
using System.Text;

namespace _01112021
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 45;
            //Console.WriteLine($"num: {num}");
            //Add(ref num, 4);
            //Console.WriteLine($"num: {num}");


            //int[] numbers = { 3, 10, 5 };
            //Console.WriteLine($"0-ci index: {numbers[0]}");
            //SetZero(numbers);
            //Console.WriteLine($"0-ci index: {numbers[0]}");

            //string name = "Abbas";
            //Console.WriteLine($"name {name}");
            //ChangeStr(out name);
            //Console.WriteLine($"name {name}");

            //Product product = new Product();
            //Console.WriteLine($"product info: count - {product.Count}  name - {product.Name}");
            //ChangeProduct(ref product);
            //Console.WriteLine($"product info: count - {product.Count}  name - {product.Name}");


            //int inputNum;
            //bool check;
            //do
            //{
            //    Console.WriteLine("Eded daxil edin:");
            //    string inputNumStr = Console.ReadLine();


            //    //Method(inputNum,inputNumStr);
            //    //check = TryToConvert(inputNumStr,out inputNum);
            //    check = int.TryParse(inputNumStr, out inputNum);
            //    //try
            //    //{
            //    //    inputNum = Convert.ToInt32(inputNumStr);
            //    //}
            //    //catch (Exception)
            //    //{
            //    //    inputNum = -1;
            //    //    Console.WriteLine("Xeta bas verdi, tekrar daxil edin!");
            //    //}

            //} while (inputNum<0 || !check);

            //int num2 = 50;
            //Console.WriteLine($"Daxil edilmis deyer: {inputNum}");

            //try
            //{
            //    Console.WriteLine($"{num2}/{inputNum}={num2 / inputNum}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Xeta bas verdi! Daha sonra tekrar yoxlayin");
            //}

            //Console.WriteLine("test1");
            //Console.WriteLine("test2");


            #region String methods

            string nameStr = "Hikmet-Abbasovka-salam2";

            Console.WriteLine(nameStr.ToLower());
            Console.WriteLine(nameStr.ToUpper());
            Console.WriteLine(nameStr.EndsWith("ov"));
            Console.WriteLine(nameStr.ToLower().StartsWith("hi"));
            Console.WriteLine(nameStr.Contains("met"));
            Console.WriteLine(nameStr.TrimStart());
            Console.WriteLine(nameStr.Replace('b','p'));
            Console.WriteLine(nameStr.IndexOf('k'));
            Console.WriteLine(nameStr.LastIndexOf('k'));
            Console.WriteLine(nameStr.Substring(4,5));
            Console.WriteLine(nameStr.Trim().Substring(nameStr.Trim().IndexOf(' ')+1));
            Console.WriteLine(nameStr.Remove(4,5));

            var strArr = nameStr.Split('-');
            foreach (var item in strArr)
            {
                Console.WriteLine(item);
            }

            var joinedStr = String.Join("-soz-", strArr);
            Console.WriteLine($"joinedArr: {joinedStr}");
            #endregion

            #region ArraMethods
            Array.Resize(ref strArr, strArr.Length + 1);
            strArr[strArr.Length - 1] = "yeni";



            string[] coppiedArr = { "salam1", null,"salam2", "salam3" };
            Array.Copy(strArr,strArr.Length-2, coppiedArr,coppiedArr.Length-2, 2);


            Console.WriteLine($"salam index: {Array.IndexOf(strArr, "salam")}");

            Array.Sort(coppiedArr);
            Array.Reverse(coppiedArr);


            //Array.Reverse(coppiedArr);
            Console.WriteLine("Array elements:");
            foreach (var item in coppiedArr)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        static void Sum(int num)
        {
            num = 10;
        }

        static void SetZero(int[] arr)
        {
            arr[0] = 0;
        }

        static void ChangeStr(out string name)
        {
            name = "Hikmet";
        }

        static void ChangeProduct(ref Product product)
        {
            product = new Product
            {
                Count = 40,
                Name = "Kitab1"
            };
        }

        static void Add(ref int num1,int num2)
        {
            num1+=num2;
        }

        static bool TryToConvert(string numStr, out int num)
        {
            try
            {
                num = Convert.ToInt32(numStr);
                return true;
            }
            catch (Exception)
            {
                num = 0;
                return false;
            }
        }
    }
}
