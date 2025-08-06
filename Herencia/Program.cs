using Herencia;

Carro carro = new Carro();
carro.Marca = "Toyota";
carro.Año = 2020;
carro.Modelo = "Corolla";
carro.NumeroPuertas = 4;
carro.TipoCombustible = "Gasolina";
carro.MostrarInformacion();

Carro carro1 = new Carro();
carro1.Marca = "Kia";
carro1.Año = 2024;
carro1.Modelo = "Sorento";
carro1.NumeroPuertas = 4;
carro1.TipoCombustible = "Gasolina";
carro1.MostrarInformacion();

Moto moto = new Moto();
moto.Marca = "Suzuki";
moto.Año = 2024;
moto.Modelo = "GIXXER DF 155";
moto.Cilindrada = 155;
moto.TieneMaletero = false;
moto.MostrarInformacion();

Moto moto1 = new Moto();
moto1.Marca = "Honda";
moto1.Año = 2021;
moto1.Modelo = "NT1100";
moto1.Cilindrada = 1084;
moto1.TieneMaletero = true;
moto1.MostrarInformacion();


Console.ReadLine();