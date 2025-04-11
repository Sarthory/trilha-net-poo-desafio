using DesafioPOO.Models;

Smartphone nokia = new Nokia("123", "3310", "123321", 256);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Smartphone iPhone = new Iphone("666", "15 Pro", "545897", 128);
iPhone.ReceberLigacao();
iPhone.Ligar();
iPhone.InstalarAplicativo("Instagram");
