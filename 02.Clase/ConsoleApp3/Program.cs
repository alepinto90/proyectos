//Variables

int pass = 123456789;
int passIngresado;

Console.WriteLine("Ingrese su perfil");

Console.WriteLine("Ingrese su contraseña");
passIngresado = Convert.ToInt32(Console.ReadLine());

if(pass = passIngresado)
{
    string perfilIngresado = Console.ReadLine();
    switch (perfilIngresado)
    {
        case "A":
            Console.WriteLine("Bienvenido Administrador");
            break;
        case "U":
            Console.WriteLine("Bienvenido Usuario");
            break;
        default:
            Console.WriteLine("Bienvenido sin perfil definido");
            break;

    }
}
else
{
    Console.WriteLine("DEBE REINICIAR EL SISTEMA");
}
