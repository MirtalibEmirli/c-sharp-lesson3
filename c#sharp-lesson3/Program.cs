

string[][] menu = new string[][] 
{
    new string[] {"[1] => Start " },
    new string[] { "[2] => Continue " },
    new string[] { "[3] => Game over " },
    new string[] {"[4] => Addd  " },
    new string[] { "[5] => Exit  " },
};


int select = 0;

do
{
    Console.Clear(); 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
                        ~~~~~~~~~Menu~~~~~~~~~          ");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;
    if (select == 1)
    {
        colorr(select);


    }


    else if (select == 2)
    {
        /*Console.ForegroundColor = ConsoleColor.Re d;
        Console.WriteLine(menu[1][0]); 
        Console.ForegroundColor = ConsoleColor.White;*/ 
        colorr( select); 

    }
    else if (select == 3)
    {
        colorr(select);

    }
    else if (select == 4)
    {
        colorr(select);

    }
    else if (select == 0)
    {
        colorr(select);

    }
    ConsoleKeyInfo infos = Console.ReadKey(true);

    if (infos.Key == ConsoleKey.UpArrow)
    {
        if (select == 1)
        {
            select = 4;
        }
        else
            select -= 1;
    }

    else if (infos.Key == ConsoleKey.DownArrow)
    {
        if (select == 4) select = 1;
        else select += 1;
    }

} while (true);



void colorr(int select)
{

   
    for (int i = 0; i < menu.Length; i++)
    {
        if (i == select)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(menu[i][0]); 
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.WriteLine(menu[i][0]);
        }
    }
}
/*String methodlari
 * 
 
 
 
 
 */
//discard operatoru bir deyisenin deyerini discard edr
/*
 meselcun ordan gelen bir deyer Try parse den bize lazm deyilse biz her hansi
stringin int e typecast olb olmadgn yoxlayacaqiqsa ona "_" operatoru vere biliril 
 
string a = "AAA";
bool b = int.TryParse(a, out _);
Console.WriteLine(b);
biz burda sadece yoxlans edrk die deyer lazm deils



eyer biz iki ayri string yaradiriqsa ve eyni deyerler sxalyrlarsa eyni adressde saxlanlr
yere qenaet edmek ucun bele edbler


string a = "Aaa";
string b = "Aaa";
Console
    .WriteLine(a.GetHashCode());  
Console
    .WriteLine(b.GetHashCode());  //adress verir




string a = "Aaa";
string b = "Aaa";

Equals deyerleri
ReferenceEquals adresleri muqayse edb = lyni yoxlayr
 */

/*
string b = "Aaa";
Console.WriteLine(b.CompareTo("A")); //muqayise edb deyer qaytarr
*/



/*string? aba = null;
Console.WriteLine(aba?.ToLower());*/
/*
string? aba2 = null;
string? ab2 = "adf";
string surname = aba2 ?? ab2 ?? "Wroong";
Console.WriteLine(surname);*/
//beleolan halda ise ?? bu operator isleyir ama null deyilse beraber edir null dusa yanindaki deyere
/*string name1 = "aaa";
string? name2 = null;

name2 ??= "ab"; //// bu operator ise deyrki eyer null dursa beraber ed
//// deyilse beraber edme amma ?? "=" olmasa null deuilse mentiqine gore isleyr
Console.WriteLine(name2);
*/


/*Qeydler
 * 
int number, result;
number = -10;
result = -number; //bu zaman - isaresi numbersin deyerini musbet edecek
 * 
 * 
 
 //// safe  => default olaraq olur.
//// unsafe  => etdikde daxilinde pointer ve sair  hershey ishledile bilir.,
//bele edmek lazmdir

static unsafe void foo() 
{
    Console.WriteLine(@"\t  <AllowUnsafeBlocks>true</AllowUnsafeBlocks> unsafe ucun 
     bu aclmalidi
\r\n");  

}
 
metadata da versiyalar
manifestde kitabxana linkleri

 is       => Hem Reference hemde Value type-lar ucun ishleyir. Typecast ede bilirse edecek amma edebilmedikde FALSE verecek.

// is not   =>
// as       => Ancaq Refenrece type-lar ucun ishleyir. Typecast ede bnilirse edecek edebilmedikde NULL verecek. Polimorphism olan class-larda ishledilir.
// -------------------------------------------------------------------
 nullable edmek ucun ? den isdifade olnur
ve bunun bir seyi yaxsidirki biz value typle lari bele
null gondere bilerik ve bu bizim icin cox ela olacax
// Nullabel data types
// reference type-lar default olaraq null ola biulir
// value type-lar default olaraq null ola bilmezler

////int a = null; // Error
//int? a = null; // OK



// !   =>  Prosdu warningi sondurur
// ?   => null conditional operator
// ??

// ----------------------------------------------------------

//string? name = "asdas";
//if(name is not null)
//    Console.WriteLine(name.ToLower());
//Console.WriteLine(name?.ToLower());  // ? isaresi yoxlanis edir
//Console.WriteLine(name!.ToLower());

 */
