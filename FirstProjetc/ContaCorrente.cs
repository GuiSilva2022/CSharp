    public class ContaCorrente
{
    public string Titular;
    public int Agencia; 
    public int Numero;
    public double Saldo; 


 public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo){   

    this.Titular = Titular;
    this.Agencia = Agencia;
    this.Numero = Numero;
    this.Saldo = Saldo;

}
    public bool Sacar (double valorSaque){
           if (this.Saldo >= valorSaque){
               this.Saldo = this.Saldo - valorSaque;
            return true;
        }
            return false;

        }
         public bool Depositar (double valorDeposito){
           if (this.Depositar >= valorDepositar){
               this.Depositar = this.Depositar - valorDeposito;
            return true;
        }
            return false;

        }
       
}

//String Construtor, This representa o objeto


 