//void ShowText()
//{
//    Console.WriteLine("salam");
//}
//ShowText();


// void sum()
//{
//    int a = 10;
//    int b=10;
//    int sum=a+b;
//    Console.WriteLine(sum);
//}
//sum();



//sum();



//sum();


//int SumOFNumbers()
//{
//    int a = 5;
//    int b = 20;
//    int sum = a + b;
//    return sum;
//}
//    int result = SumOFNumbers();

//    Console.WriteLine(result);



//string SumOFNumbers()
//{
//    int a = 5;
//    int b = 20;
//    int sum = a + b;
//    string res = $"Sum of numbers is - {sum}";
//    return res;
//}
//string result = SumOFNumbers();

//Console.WriteLine(result);



//void SumOFEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 5, 6 };

//    int sum = 0;

//    foreach (int item in elems)

//    {
//        if(item%2 == 0)
//        {
//            sum += item;
//        }
//    }

//    Console.WriteLine(sum);
//}
//SumOFEvenNumbers();





//void ShowText(string text)
//{
//    Console.WriteLine(text);    
//}

//ShowText("hello");
//ShowText("world");


//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//bool isMarried=true;


//if(isMarried)
//{
//    ShowText("salam");
//}
//else
//{
//    ShowText("World");
//}


//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//bool isMarried = false;


//if (isMarried)
//{
//    ShowText("salam");
//}
//else
//{
//    ShowText("World");
//}


//using System.Security.Cryptography;

//void Sum(int a1, int a2)
//{
//    int sum = a1 + a2;
//    Console.WriteLine(sum); 
//}

//Sum(100,200);

//Sum(500, 600);


//void SumOFNumbers(int[] nums)
//{

//    int sum = 0;
//    foreach(int item in nums)
//    {
//        if (item %2==1)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}

//int[] nums = { 1, 2, 3, 4, 5};

//SumOFNumbers(nums);



//void SumOFNumbers(int[] nums,int number)
//{

//    int sum = 0;
//    foreach (int item in nums)
//    {
//        if (item % 2 == 1)
//        {
//            sum += item;
//        }
//    }
//    int result = sum + number;
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5 };

//SumOFNumbers(nums,4);











//using System.Security.Authentication;

//int[] GetDatas(int num1, int num2,params int[] nums)
//{
//    return nums;
//}


//var result = GetDatas(1,2,3,4,5,6);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}






//int SumOFDatas(int num1, int num2, params int[] nums)
//{
//    int sumNumbers = num1 + num2;

//    int sumOFArrayItems = 0;

//    foreach (var item in nums)
//    {
//        sumOFArrayItems += item;
//    }

//    int result = sumNumbers + sumOFArrayItems;
//    return result;
//}

//var result = SumOFDatas(1, 2, 3, 4, 5, 6);

//Console.WriteLine(result);





//string GetName()
//{
//    return "Hacker";
//}

//Console.WriteLine(GetName());



//string GetName(string name)
//{
//    return name;
//}

//Console.WriteLine(GetName("Hacker"))




//string GetName(string name ="XXX")
//{
//    return name;
//}

//string name = "";

//Console.WriteLine(Console.ReadLine());









//string GetName(string name = "XXX")
//{
//    return name;
//}

//string name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine(GetName());
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}









//string GetName(string name = "XXX")
//{
//    return name;
//}

//Name: string name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}






//string Login(string username, string password)
//{
//    if (username == "Admin123" && password == "Admin123")

//    {
//        return "login successful";
//    }
//    else
//    {
//        return "Username or password is wrong";
//    }
//}

//Console.WriteLine("Username:");
//string username = Console.ReadLine();


//Console.WriteLine("Password:");
//string password = Console.ReadLine();   


//string result = Login(username, password);

//Console.WriteLine(result);