        using System;
        namespace FirstProjetc
{
        class Program
    {
        static void Main(String[] args)
        {
            ContaCorrente conta_first1= new ContaCorrente("Roger Guedes", 155,55,360);
            ContaCorrente conta_first2= new ContaCorrente("William", 682,66,157);
            ContaCorrente conta_first3= new ContaCorrente("Cassio", 452,88,740);

        Console.WriteLine("A conta é do (a) " + conta_first1.Titular + ", a agência é " + conta_first1.Agencia + " e o número é " + conta_first1.Numero + "Saldo" + conta_first1.Saldo);
        Console.WriteLine("A conta é do (a) " + conta_first2.Titular + ", a agência é " + conta_first2.Agencia + " e o número é " + conta_first2.Numero + "Saldo" + conta_first2.Saldo);
        Console.WriteLine("A conta é do (a) " + conta_first3.Titular + ", a agência é "  + conta_first3.Agencia + " e o número é " + conta_first3.Numero+ "Saldo" + conta_first3.Saldo);


            bool sacar_conta  = conta_first1.Sacar(100);
            bool sacar_conta1 = conta_first2.Sacar(100);
            bool sacar_conta2 = conta_first3.Sacar(100);

        Console.WriteLine("A conta é do (a) " + conta_first1.Titular + ", a agência é " + conta_first1.Agencia + " e o número é " + conta_first1.Numero +  " Saldo: " + conta_first1.Saldo);
        Console.WriteLine("A conta é do (a) " + conta_first2.Titular + ", a agência é " + conta_first2.Agencia + " e o número é " + conta_first2.Numero +  " Saldo: " + conta_first2.Saldo);
        Console.WriteLine("A conta é do (a) " + conta_first3.Titular + ", a agência é "  + conta_first3.Agencia + " e o número é " + conta_first3.Numero+  " Saldo: " + conta_first3.Saldo);
        }
    }
}


 


// string Titular = "Guilherme_CS";
// int Agencia = 123;
// int Numero = 456;
// double Saldo = 100;

//             Console.WriteLine("Nome do Titular " + Titular);
//             Console.WriteLine("Numero do Agencia " + Agencia);
//             Console.WriteLine("Valor do Numero " + Numero);
//             Console.WriteLine("Valor do Saldo " + Saldo);
//   }
//  }  
// }
// Console.WriteLine("Salve, Seres humanos aqui quem fala é o EduKof!");
// Console.WriteLine("Esse é o meu primeiro programa C#");
// Console.WriteLine("Um beijo pra quem quer, um abraço pra quem nao quer vlw, flw e Fui");
//    }
//   }
//  }
