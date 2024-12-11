namespace C__TYPE_INTRO;

class Program
{
    static void Main(string[] args)
    {
        //For å definere en variabel, må vi først fortelle maskinen vilken type denne skal være. 
        //Så gir vi variabelen et navn slik at vi kan referere til den senere.
        //Så gir vi variabelen en verdi, etter liketstegnet.
        string myString = "Hello, World!"; //en string represterer en tesk. 
        Console.WriteLine(myString);
        //hele tall representeres via en type som heter int.
        int myWholeNumber = 10; //en int, har en minimumverdi på -2^31 og en maks verdi på 2^31
        /* int tooLargeNumber = 08387345897349857398475938475; */ //Vi må passe på at vi ikke assigner en for stor verdi for datatypen vi har valgt.
        Console.WriteLine(myWholeNumber);
        float myFloat = 14.6f; //En gammel måte å representere et desimaltall på, generelt unøyaktig og blir lite brukt.
        Console.WriteLine(myFloat);
        double myDouble = 18.9; //Standardmetoden å representere et desimaltall i C#. 
        //Fremdeles ikke nøyaktig nok, for finanssektoren.

        decimal myDecimal = 24.5m; //En veldig nøyaktig måte å representere et desimaltall på, men krever mye av datamaskinen.

        long myLong = 8723483823445234; //Long er en datatype, som får tildelt dobbelt så stor plass enn en int. 

        char myChar = 'a'; //En char, er en talltype hvor hvert tall representerer en karakter i UTF-16 encoding tabellen. 
        //for karakteren over vil det se noe som dette ut: UTF-16 LOOKUP [97 = 'a'];
        Console.WriteLine(myChar);
        //vi kan se dette i praksis, ved å ta en karakter minus et helt tall, og få ut en tallverdi som resultat. 
        Console.WriteLine(myChar - myWholeNumber);
        //Kan vi gjøre det samme med en string?
        Console.WriteLine(myString + myWholeNumber);
        //Nei, en string er bare en samling av tekst, og hvis man prøver å plusse på en verdi, blir verdien gjort om til en string.
        //Så lagt til i enden av den orginale strengen. 
    }
}
