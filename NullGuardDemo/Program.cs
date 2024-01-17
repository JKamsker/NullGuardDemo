using NullGuard.CodeAnalysis;

using System.Diagnostics.CodeAnalysis;

namespace NullGuardDemo;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var runner = new Runner();
        var res = await runner.AnotherMethod(null);
        Console.WriteLine(res);
    }
}

public class Runner
{
    public async Task<SomeResult> AnotherMethod([AllowNull] string arg)
    {
        // arg may be null here
        await Task.Delay(-1);
        return Method(arg);
    }

    public SomeResult Method([AllowNull] string arg)
    {
        // arg may be null here
        return null;
    }
}

public class SomeResult
{
}