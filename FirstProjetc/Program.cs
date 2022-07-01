        using System;
        namespace FirstProjetc
{
        class Program
    {
        static void Main(String[] args)
        {
            ContaCorrente conta_first1= new ContaCorrente("Guilherme", 155,55,360);
            ContaCorrente conta_first2= new ContaCorrente("Eduardo", 682,66,157);
            ContaCorrente conta_first3= new ContaCorrente("Matheus", 452,88,740);


            Console.WriteLine("A conta é do (a) " + conta_first1.Titular + ", a agência é " + conta_first1.Agencia + " e o número é " + conta_first1.Numero + ".");
            Console.WriteLine("A conta é do (a) " + conta_first2.Titular + ", a  agência é " + conta_first2.Agencia + " e o número é " + conta_first2.Numero + ".");
            Console.WriteLine("A conta é do (a) " + conta_first3.Titular + ", a agência é "  + conta_first3.Agencia + " e o número é " + conta_first3.Numero + ".");
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
