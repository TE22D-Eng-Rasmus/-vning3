
static void Hello32(){
    for (int i = 0; i <= 32; i++)
{
  Console.WriteLine("Hello World");
}
}
Hello32();

static void interger(int nummer){
Console.WriteLine($"Kvardraten av {nummer} är {nummer*nummer}");
}
interger(4);

static void multi(float nummer1, float nummer2){
Console.WriteLine($"{nummer1} gånger {nummer2} är {nummer1*nummer2}");
}

multi(3,8);

static void RightTriangleArea(float n1, float n2){
  Console.WriteLine($"En rätvinklig triangel men basen {n1} och höjden {n2} har arean {(n1*n2)/2}");
}
RightTriangleArea(5,8);

static void circle(float r){
  Console.WriteLine($"Circkelns area är radien som är {r} upphöjt i 2, gånger pi vilket vlir {r*r*3.1415}");
}

circle(7);


Console.ReadLine();