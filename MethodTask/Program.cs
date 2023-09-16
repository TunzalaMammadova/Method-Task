
//static void ShowText()
//{
//    Console.WriteLine("Hello world");
//}

//ShowText();


//static void Sum()
//{
//    Console.WriteLine(5 + 10);
//}

//Sum();




//static void Sum()
//{
//    int a = 5;
//    int b = 6;
//    int Sum = a + b;
//
//   Console.WriteLine(Sum);
//}

//Sum();



//Sum(5);

//static void Sum(int num1)
//{
//    Console.WriteLine(num1);
//}


//Sum(5);

//static void Sum(int num1)
//{
//    Console.WriteLine(num1+200);
//}


//sum(100);

//static void sum(int num1)
//{
//    int sum = num1 + 100;
//
//    Console.WriteLine(sum);
//}


//static void SumOfNums(int a, int b)
//{
//    int sum = a + b;

//    Console.WriteLine(sum);
//}

//SumOfNums(5, 6);

//SumOfNums(34, 54);



//static void Sum(int m)
//{
//    int sum = 0;

//    for (int i = 0; i < m; i++)
//    {
//        sum += i;
//    }

//    Console.WriteLine(sum);
//}

//Sum(20);

//Sum(40);

//Sum(50);



//static void GetNumsOfArray()
//{
//    int[] nums = { 2, 5, 6, 7, 8 };

//    foreach (var item in nums)

//    {
//        Console.WriteLine(item);
//    }
//}

//GetNumsOfArray();



//static void GetNumsOfArray(int[]numbers)
//{

//    foreach (var item in numbers)

//    {
//        Console.WriteLine(item);
//    }
//}

//int[] nums = { 2, 5, 6, 7, 8 };


//GetNumsOfArray(nums);


//static void CheckMarried(bool isMarried, int age)
//{
//    if (isMarried)
//    {
//        Console.WriteLine("is Evlidir - " + age);
//    }
//    else
//    {
//        Console.WriteLine("Subaydir - " + age);
//    }
//}


//bool isMarried = true;




//static void GetAge(int age)
//{
//    bool isMarried = false;

//    CheckMarried(isMarried, age);

//}

//GetAge(40);



//static int GetNumber()
//{
//    int number = 200;

//    return number;

//}

//Console.WriteLine(GetNumber());

//static int GetNumber()
//{
//    return 200;
//}

//int result = 10 + GetNumber();


//Console.WriteLine(result);


//static int GetNumber()
//{
//    return 200;

//}

//int result = GetNumber();
//{
//    if (result > 20)
//    {
//        Console.WriteLine(result);
//    }
//}


//static string GetTemp(int temp)
//{
//    if (temp < 20)
//    {
//        return "Cold";
//    }
//    else
//    {
//        return "Hot";
//    }
//}

//string result = GetTemp(30);

//Console.WriteLine(result);


//static bool IsSuccess(string employeeName)
//{
//    string[] employees = {"Semed" , "Tunzale","Meryem","Aqshin"};

//    foreach(var employee in employees)
//    {
//        if (employee == employeeName)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//bool result = IsSuccess("Tunzale");

//if (result)
//{
//    Console.WriteLine("Ugurludur");
//}
//else
//{
//    Console.WriteLine("Ugur deyil");
//}



//static int GetSumOddNumbers(int a ,int b)
//{
//    int sum = 0;

//    for (int i = a; i <= b; i++)
//    {

//        if( i % 2 != 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;

//}

//int result = GetSumOddNumbers(10, 17);

//Console.WriteLine(result);


//static bool Login(string username, string password)
//{
//    if (username =="semed111" && password == "semed123")
//    {
//        return true;
//    }
//    return false;
//}

//Console.WriteLine("Add your username:");

//string username = Console.ReadLine();

//Console.WriteLine("Add your password :");

//string password = Console.ReadLine();


//if (Login(username, password))
//{
//    Console.WriteLine("Login is success");
//}
//else
//{
//    Console.WriteLine("Login or password is wrong");
//}



//static bool Search(string studentName)
//{
//    string[] students = { "Semed", "Meryem", "Aqshin" };

//    foreach (string student in students)
//    {
//        if(student == studentName)
//        {
//            return true;

//        }
//    }
//    return false;

//}

//Console.WriteLine("Ad daxil edin: ");

//string name = Console.ReadLine();

//bool result = Search(name);

//if (result)
//{
//    Console.WriteLine("Name is found");
//}
//else
//{
//    Console.WriteLine("Name is not found");
//}


//static void Test()
//{
//    bool isTrue = true;
//    if (isTrue)
//    {
//        Console.WriteLine("Meryem");
//        return;
//    }
//    Console.WriteLine("false");
//}

//Test();



//static void FindOddNums(int[] nums)
//{
//    foreach (var item in nums)
//    {
//        if (item % 2 == 1)
//        {
//            return;

//        }
//    }

//    Console.WriteLine("Hello P418");
//}

//FindOddNums(new int[] { 1, 2, 3, 4, 5 });