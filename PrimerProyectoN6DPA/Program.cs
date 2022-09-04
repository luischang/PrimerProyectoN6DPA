// See https://aka.ms/new-console-template for more information
using PrimerProyectoN6DPA;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de ambiente web";
int edad = 30;
double salario = 1550.50;
bool esActivo = false;

var nuevoCurso = "Desarrollo de ambiente web 2022-02";
var nuevaEdad = 30;
var nuevoSalario = 1620.40;
var esInactivo = true;

var persona = new Persona();
persona.dni = 44093892;
persona.nombreCompleto = "Luis Chang";
persona.edad = 30;

var persona2 = new Persona()
{
    dni = 99388834,
    nombreCompleto = "Juan Perez",
    edad = 44
};

var persona3 = new Persona(28839388, "Eduardo Bardalez", 34);

var personas = new List<Persona>();
personas.Add(persona);
personas.Add(persona2);
personas.Add(persona3);

foreach (var item in personas)
{
    Console.WriteLine(item.dni + " | " + item.nombreCompleto);
}

var personaBuscada = personas.Find(luis => luis.dni == 99388834);
if (personaBuscada != null)
{
    Console.WriteLine("La persona buscada es: " + personaBuscada.dni + " | " + personaBuscada.nombreCompleto);
}
else {
    Console.WriteLine("DNI no encontrado");
}

