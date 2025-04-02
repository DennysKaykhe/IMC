decimal altura;
decimal peso;
decimal imc;

Console.Clear();

Console.WriteLine("--- CALCULO DE ICM ---");

Console.Write("Altura (m)..: ");
altura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Peso (kg)...: ");
peso = Convert.ToDecimal(Console.ReadLine());

imc = peso / (altura * altura);

Console.Write(@$"
IMC: {imc} kg/m²");