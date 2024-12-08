using Microsoft.Extensions.Logging;

namespace Temp.Components.Logging;

[ProviderAlias("File")]
public class FileLoggerProvider : ILoggerProvider
{
    private ILogger Logger { get; }

    public FileLoggerProvider(String path, Int64 rollSize)
    {
        Logger = new FileLogger(path, rollSize);
    }

    public ILogger CreateLogger(String categoryName)
    {
        return Logger;
    }

    public void Dispose()
    {
    }
}
