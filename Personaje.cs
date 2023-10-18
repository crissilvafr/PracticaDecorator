public class Personaje : IPersonaje
{
    public string MostrarTipo()
    {
        return "Jugador";
    }

    public string Atacar()
    {
        return "El jugador esta atacando";
    }
}
