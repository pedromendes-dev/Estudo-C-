 // Data e Hora em C# em tempo real 

DateTime dataAtual = DateTime.Now;  // Obtém a data e hora atuais (now = agora)
Console.WriteLine("Data e Hora Atuais: " + dataAtual);


DateTime dataAtual = DateTime.Now.AddDays(5);  // Adiciona 5 dias à data atual (5 dias a mais)
Console.WriteLine("Data e Hora Atuais: " + dataAtual);


DateTime dataAtual = DateTime.Now   // Add seria para adicionar algo
    .AddHours(3)  // Adiciona 3 horas à data atual (3 horas a mais)
    .AddMinutes(30);  // Adiciona 30 minutos à data atual (30 minutos a mais)
Console.WriteLine("Data e Hora Atuais: " + dataAtual);


DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// O ToString() é um método que converte um valor para texto (string).