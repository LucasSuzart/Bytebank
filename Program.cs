﻿using bytebank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 123;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;
//------------------------------------------------
ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

//----------------------------------

ContaCorrente conta3 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;


//-------------------------------------------------------------------

Console.WriteLine("Titular :" + conta1.titular);
Console.WriteLine("Conta :" + conta1.conta);
Console.WriteLine("Número Agência :" + conta1.numero_agencia);
Console.WriteLine("Nome Agência :" + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);
//------------------------------------------------------------------


Console.WriteLine("Titular :" + conta2.titular);
Console.WriteLine("Conta :" + conta2.conta);
Console.WriteLine("Número Agência :" + conta2.numero_agencia);
Console.WriteLine("Nome Agência :" + conta2.nome_agencia);
Console.WriteLine("Saldo: " + conta2.saldo);
//=======================================================

Console.WriteLine("Titular :" + conta3.titular);
Console.WriteLine("Conta :" + conta3.conta);
Console.WriteLine("Número Agência :" + conta3.numero_agencia);
Console.WriteLine("Nome Agência :" + conta3.nome_agencia);
Console.WriteLine("Saldo: " + conta3.saldo);
Console.WriteLine("Verificador: " + conta3.verificador);

//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.nome_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");



Console.ReadKey();