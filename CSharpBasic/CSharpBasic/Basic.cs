using System;
using System.Collections;
using System.ComponentModel;
class Basic
{
    public static void CalNum()
    {
        int a = 10;
        int b = a;
        int c = a++ + ++b;
        int d = c-- - b-- + a;
        Console.WriteLine($"a={a},b={b},c={c},d={d}"); // 11 10 20 21
        System.Console.WriteLine();
        Console.WriteLine("a={0},b={1},c={2},d={3}", a, b, c, d); // 11 10 20 21
    }

    public static void TestOper()
    {
        Console.WriteLine(typeof(int));

        Console.WriteLine(sizeof(int));

        var a = 11 == 12 ? true : false;
        System.Console.WriteLine(a);

        object obj = 3.14m;
        if (obj is decimal d)
        {
            System.Console.WriteLine(d.GetType());
        }

        string path = "E:\\p\v\\c";
        string path2 = @"E:\p\v\c";
        System.Console.WriteLine(path);
        System.Console.WriteLine(path2);

        System.Console.WriteLine("\a\tHello\r\nWorld");
        //Console.Read();

    }

    public static void TypeConverter()
    {
        float a = 3.14f;
        int b = Convert.ToInt32(a);
        System.Console.WriteLine(b);

        string c = 3 + "4"; // 装箱 ，会调用tostring方法
        System.Console.WriteLine(c);

        object aa = 3;
        int aai = Convert.ToInt32(aa); // 拆箱
        System.Console.WriteLine(aai);

    }

    /// <summary>
    /// get max number
    /// </summary>
    /// <param name="a">num1</param>
    /// <param name="b">num2</param>
    /// <returns><max number/returns>
    public static int FindMax(int a, int b)
    {
        return a > b ? a : b;
    }

    public static void ParamRef(ref int a)
    {
        a += 1;
    }

    public static double ParamOut(int a, out int b)
    {
        b = a + 1;
        return a + 0.1;
    }

    // override
    public static void FindMax(double a, double b)
    {

    }

    public static void FindMax(float a, float b)
    {

    }
    public static void FindMax(int a, int b, int c)
    {

    }

    public static void TestSwitch()
    {
        int day = 4;
        switch (day)
        {
            case 1:
                System.Console.WriteLine("monday");
                break;
            case 2:
                System.Console.WriteLine("Tuesday");
                break;
            case 4:
                System.Console.WriteLine("Thursday");
                break;
            default:
                System.Console.WriteLine("not support");
                break;
        }
    }

    // only in c# 8.0
    public static void TestSwitch2()
    {
        int day = 4;
        string res = day switch
        {
            1 => "monday",
            2 => "Tuesday",
            4 => "Thursday",
            _ => "not support" // default
        };
        System.Console.WriteLine(res);
    }

    // only c# 9,modern match 模式匹配
    public static void TestSwitchAndModenMatch(){
        int score=88;
        string res=score switch{
            >0 and <=60=> "bad",
            >60 and <=80=> "good",
            >80 => "great",
            _=>"not support"
        };
        System.Console.WriteLine(res);
    }

    public static void TestWhile(){
        int sum=0;
        int i=1;
        while(i<=1000){
            sum+=i;
            i++;
        }
        System.Console.WriteLine(sum);
    }
    public static void TestFor(){
        int sum=0;
        for (int i = 1; i <=1000 ; i++){
            sum+=i;
        }
        System.Console.WriteLine(sum);
    }

    public static void Array(){
        /*
        int[] arr=new int[10];
        arr[0]=100;
        arr[1]=101;
        */
        // double[] arr=new double[3]{1.1,2.2,3.3};
        //float[] arr=new float[]{3.14f,22.2f};
        float[] arr={3.14f,22.2f};
        foreach(var i in arr){
            System.Console.WriteLine(i);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine(arr[i]);
        }

        arr[0]=6.66f;
         foreach(var i in arr){
            System.Console.WriteLine(i);
        }

        int[,] arr2=new int[2,3]{
            {1,2,3},
            {4,5,6}
        };
        System.Console.WriteLine(arr2.Length+" "+arr2.Rank+" "+arr2[0,1]);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.WriteLine(arr2[i,j]);
            }
        }
    }

    public static void TestArrayList(){
        ArrayList arr=new ArrayList();
        arr.Add(1);
        arr.Add(1);
        arr.Add(1);
        arr.AddRange(new int[]{2,3});
        System.Console.WriteLine(arr.Count+" "+arr.Capacity);
        arr.Remove(3);
        arr.RemoveAt(0);
        foreach (var item in arr)
        {
            System.Console.WriteLine(item);   
        }
    }
}

