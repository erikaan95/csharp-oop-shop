// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//dichiarazioni delle variabili

string Titolo = " Ricominciare da sé";
string Autore = "Osho";
string ISBN = "8804586664";
int numeroDiPagine = 220;
int pesoLibro = 190;

//Misure del libro
float largezza = 12.8f;
float profondità = 2f;
float altezza = 19.5f;

float valutazioneMedia = 4.5f;
int NumeroRecensioni = 364;

//variabili Flag
bool Kindle = true;
bool copertinaFlessibile = true;

//Stampa a video delle informazioni raccolte

Console.WriteLine("---IL LIBRO DI OGGI: " + Titolo + " di " + Autore + " -----\n");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero delle pagine: " + numeroDiPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " g");
Console.WriteLine("Dimensione del libro: " + largezza + " cm x " + altezza + " cm x " + profondità + " cm\n");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di Recensioni: " + NumeroRecensioni + " recensioni");
Console.WriteLine("Valutazione Media: " + valutazioneMedia + " stelline");

if (Kindle)
{
    Console.WriteLine("Kindle disponibile: Si");
}
else
{
    Console.WriteLine("Kindle disponibile: No");
}

if (copertinaFlessibile)
{
    Console.WriteLine("Copertina Flessibile disponibile: Si");
}
else
{
    Console.WriteLine("Copertina Flessibile disponibile: No");
}