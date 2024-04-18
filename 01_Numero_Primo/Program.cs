Console.WriteLine("Introdusca el numero que desea evaluar si es numero primo");
String numberEvaluar = Console.ReadLine();
int numericValue;
bool isNumber = int.TryParse(numberEvaluar, out numericValue);

if(isNumber){
    int a = 0;
    for(int i = 1;i <= numericValue;i++){
        if(numericValue % i == 0){
            a++;
        }
    }
    if(a != 2){
        Console.WriteLine("El numero ['" + numberEvaluar + "'] no es primo");    
    }else{
        Console.WriteLine("El numero ['" + numberEvaluar + "'] es primo");    
    }
}
else{
    Console.WriteLine("El dato introducido ['" + numberEvaluar + "'] no es un numero valido");
}

