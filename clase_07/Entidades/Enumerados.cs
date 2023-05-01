namespace Entidades
{
    // No hace falta asignarlo a una clase. Va a pertenecer al espacio de nombre (Entidades)
    // Como es un enum, los valores que le quiero asignar a los tipos deben ser de tipo entero.
    public enum ETipo // despues va a ser reemplazado por herencia
    {
        PRECEPTOR,       // por defecto vale: 0 || Si le asigno valor, en este ejemplo vale: 0
        ALUMNO = 23,     // por defecto vale: 2 || Si le asigno valor, en este ejemplo vale: 23
        PROFESOR         // por defecto vale: 3 || Si le asigno valor, en este ejemplo vale: 24
    };
}
