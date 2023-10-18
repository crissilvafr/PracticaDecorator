using System;
public class MagoDecorador : PersonajeDecorador
{
    private int _dmg;
    public MagoDecorador(IPersonaje personaje, int dmg) : base(personaje)
    {
        _dmg = dmg;
    }

    public override string MostrarTipo()
    {
        return $"{base.MostrarTipo()} de tipo Mago!";
    }

    public override string Atacar()
    {
        return $"{base.Atacar()} con magia y causa {_dmg} de daño magico!!";
    }
}