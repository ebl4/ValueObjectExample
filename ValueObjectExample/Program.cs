using ValueObjectExample;

Console.WriteLine("Hello, World!");

Address addressOne = new Address("Rua Henrique Dias", "Pesqueira", "Pernambuco", "Brazil", "55200000");
Address addressTwo = new Address("Rua Henrique Dias", "Pesqueira", "Pernambuco", "Brazil", "55200000");

Console.WriteLine(EqualityComparer<Address>.Default.Equals(addressOne, addressTwo));
Console.WriteLine(object.Equals(addressOne, addressTwo));
Console.WriteLine(addressOne.Equals(addressTwo));
Console.WriteLine(addressOne == addressTwo); // True
Console.WriteLine(addressOne != addressTwo); // False