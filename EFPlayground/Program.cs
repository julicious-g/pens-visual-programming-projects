// See https://aka.ms/new-console-template for more information

using EFPlayground;

Console.WriteLine("Hello, World!");

using (var context = new GameContext())
{
    context.Players.Add(Player.New("Test"));
    context.SaveChanges();
}