using static System.Runtime.InteropServices.JavaScript.JSType;

namespace funzionic_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {     
                //creo un arrey di numeri utiliando le funzioni 
                //creo prima di tutto una funzio void 

                void virgola()
                {
                    Console.Write(", PARAMETRO ");
                }

                void StampaArray(int[] array)
                {
                    Console.Write("[");

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                        if (i < array.Length - 1)
                        {
                            virgola();
                        }
                    }
                    Console.Write(" ] ");
                }
                int[] numeri = { 2, 6, 7, 5, 3, 9 };
                StampaArray(numeri);

            }


            {
                // che vi restituisca il quadrato del numero passato come parametro.
                //prima faccio un input per prendere il numero
                //poi  richiamo la  funzione per fare il calcolo 


                Console.WriteLine("inserisci un numero");
                


                int Quadrato(int numero)
                {


                    return numero;
                }
                Quadrato(10);






                int NomeFunzione(int numero1 , int numero2)
                {
                    int risultato = numero1 + numero2;
                    return risultato; 
                }

                int somma = NomeFunzione(10, 3);
                Console.WriteLine($"funzione creata per esercitazione {somma}");




              
            }


        }
    }
}

/*
**void StampaArray(int[] array) * *: che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
- **int Quadrato(int numero)**: che vi restituisca il quadrato del numero passato come parametro.
- **int[] ElevaArrayAlQuadrato(int[] array)**: che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
- **int sommaElementiArray(int[] array)**: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
-Stampare l’array di numeri fornito a video
- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
-Stampare la somma di tutti i numeri
- Stampare la somma di tutti i numeri elevati al quadrati

*/