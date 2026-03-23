int grade = int.Parse(Console.ReadLine());
if (grade >= 90 && grade <=100)
{

    Console.WriteLine("excellent");

}
else  if (grade >=80 &&  grade < 90)
{
    Console.WriteLine("very good");

}
else if(grade >=  70 && grade < 80)
{

    Console.WriteLine("good");
        }
else if (grade >= 50 && grade < 70)
{

    Console.WriteLine("pass");
}
else { Console.WriteLine("fail"); }

//----------------------------------------------------
int day = int.Parse(Console.ReadLine());
switch(day)
{
    case 1:
        Console.WriteLine("saturday"); 
        break;
    case 2:
        Console.WriteLine("sunday");
        break;
    case 3:
        Console.WriteLine("MONDAY");
        break;
    case 4:
        Console.WriteLine("tuesday") ; 
        break;
    case 5:
        Console.WriteLine("wednesday");
        break;
    case 6:
        Console.WriteLine("thursday");
        break;
    case 7:
        Console.WriteLine("friday");
        break;
    default:
        Console.WriteLine("invaliad number");
        break;
            }
