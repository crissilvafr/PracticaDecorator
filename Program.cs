// See https://aka.ms/new-console-template for more information
IPersonaje jugador = new Personaje();
Console.WriteLine($"Tipo: {jugador.MostrarTipo()}");
Console.WriteLine(jugador.Atacar());

jugador = new MagoDecorador(jugador, 150);
Console.WriteLine($"Tipo: {jugador.MostrarTipo()}");
Console.WriteLine(jugador.Atacar());