//First task 
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a>b){
//     Console.WriteLine("max = " + Convert.ToString(a));
// }else{
//     Console.WriteLine("max = " + Convert.ToString(b));
// }
//Second task
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if ((a>b)&(a>c)){
    Console.WriteLine(Convert.ToString(a));
}else if((b>c)&(b>a)){
    Console.WriteLine(Convert.ToString(b));
}
else{
    Console.WriteLine(Convert.ToString(c));
}