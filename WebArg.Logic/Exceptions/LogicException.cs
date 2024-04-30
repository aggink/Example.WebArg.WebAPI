namespace WebArg.Logic.Exceptions;

/// <summary>
/// Выброшенная ошибка разработчиком
/// </summary>
public class LogicException : Exception
{
    public LogicException(string message) : base(message) { }

    public LogicException(string message, Exception innerException) : base(message, innerException) { }
}
