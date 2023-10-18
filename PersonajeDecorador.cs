using System;
public abstract class PersonajeDecorador : IPersonaje
{
    protected IPersonaje _personaje;

    public PersonajeDecorador(IPersonaje personaje)
    {
        _personaje = personaje;
    }

    public virtual string MostrarTipo()
    {
        return _personaje.MostrarTipo();
    }

    public virtual string Atacar()
    {
        return _personaje.Atacar();
    }
}