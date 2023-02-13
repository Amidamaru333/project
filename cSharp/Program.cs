// First task 
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>b){
    Console.WriteLine("max = " + Convert.ToString(a));
}else{
    Console.WriteLine("max = " + Convert.ToString(b));
}
// Second task
int max=0;
for (int i = 0; i < 3; i++){
    int user = Convert.ToInt32(Console.ReadLine());
    if (i == 0 || user > max){
        max = user;
    }
} 
Console.WriteLine(Convert.ToString(max));
// Third task
int number0 = Convert.ToInt32(Console.ReadLine());
if (number0%2 == 0){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}
// Fourth task
int number = Convert.ToInt32(Console.ReadLine());
string output = "";
if (number >= 0){
    for (int i = 0; i <= number; i+=2){
        output += i + ", ";
    }
}else{
    for (int i = 0; i >= number; i-=2){
        output += i + ", ";
    }
}
if (number>-2 && number<2){
    Console.WriteLine(" ");
}else{
    Console.WriteLine((output.Remove(output.Length - 2)).Remove(0,3));
}