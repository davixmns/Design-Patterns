namespace Design_Patterns.ScatterAndGatter;

public class ScatterAndGatter
{
    public static void Run()
    {
        var tasks = new List<Task<int>>
        {
            Task.Run(() => DoWork(1)),
            Task.Run(() => DoWork(2)),
            Task.Run(() => DoWork(3)),
            Task.Run(() => DoWork(4))
        };

        Task.WhenAll(tasks).ContinueWith(t =>
        {
            var results = t.Result;
            int sum = results.Sum();
            Console.WriteLine($"Soma dos resultados: {sum}");
        }).Wait();
    }
    
    private static int DoWork(int input)
    {
        Task.Delay(1000).Wait();
        Console.WriteLine($"Tarefa {input} concluída.");
        return input * 2;
    }
}