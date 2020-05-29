using System;
using System.Threading;

public class CLpara{
    
    int count;
    public method_para(){
        Thread.Sleep(1000);
        for (count = 0; count < 10; count++){
            Console.WriteLine(count);
        }
    }

    public static main(){

    }

}

main();
method_para();

Console.WriteLine("ok");