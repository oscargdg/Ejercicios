Console.WriteLine("Presiona 'Esc' para salir de la aplicación");

while(true){
    Console.WriteLine("Introdusca el numero que desea evaluar si es numero primo");
    String expresionEvaluar = Console.ReadLine();

    if(expresionEvaluar == "exit"){
        Console.WriteLine("\nSaliendo de la aplicación...");
        break;
    }else{
        
        int numericValue;
        bool isNumber = int.TryParse(expresionEvaluar, out numericValue);

        if(isNumber){
            int a = 0;
            for(int i = 1;i <= numericValue;i++){
                if(numericValue % i == 0){
                    a++;
                }
            }
            if(a == 2){
                Console.WriteLine("El numero ['" + expresionEvaluar + "'] es primo");    
            }else{
                Console.WriteLine("El numero ['" + expresionEvaluar + "'] no es primo");    
            }
        }
        else{
            Console.WriteLine("El dato introducido ['" + expresionEvaluar + "'] no es un numero valido");
        }
    }
    
}

