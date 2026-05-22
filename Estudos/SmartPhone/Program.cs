using SmartPhone.models;

Console.WriteLine("Smartphone Iphome: ");
Smartphone iphome = new Iphome("123456789", "Iphome 15", "12345543", 260);

iphome.ligar();
iphome.ligar("234567843");
iphome.RecebendoLigação();
iphome.RecebendoLigação("234567894");
iphome.InstalarAplicativo("Whatsapp");


Console.WriteLine();


Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia("345678123", "lumia", "23412", 32);

nokia.ligar();
nokia.ligar("234567843");
nokia.RecebendoLigação();
nokia.RecebendoLigação("234567894");
nokia.InstalarAplicativo("Whatsapp");

