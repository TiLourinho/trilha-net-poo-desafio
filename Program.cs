using DesafioPOO.Models;

Console.WriteLine("Nokia NK026:");
Nokia nk026 = new("99632-1880", "NK026", "861536030196001", 128);
nk026.Ligar();
nk026.InstalarAplicativo("Instagram");

Console.WriteLine("\niPhone 14 Pro Max:");
IPhone proMax14 = new("98749-4176", "iPhone 14 Pro Max", "537203707863778", 1024);
proMax14.ReceberLigacao();
proMax14.InstalarAplicativo("Spotify");