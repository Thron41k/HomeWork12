using HomeWork12;

List<User> users =
[
    new( "Tom",  "Tom", true),
    new( "Alice","Alice" ),
    new( "Bob", "Bob", true ),
    new( "Kate", "Kate" ),
    new( "Sam", "Sam", true )
];
GreetingUsers(users);
return;

static void GreetingUsers(List<User> users)
{
    foreach (var user in users)
    {
        Console.WriteLine($"Приветствую, {user.Name}!");
        if (user.IsPremium) continue;
        ShowAds();
    }
}

static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}
