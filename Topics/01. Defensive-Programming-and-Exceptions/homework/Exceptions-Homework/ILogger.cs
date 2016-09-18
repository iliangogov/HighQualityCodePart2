using System.Collections.Generic;

public interface ILogger
{
    IEnumerable<string> Messages { get; }

    void Log(string message);
}
