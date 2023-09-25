using Note.Backend.Domain.Common.Enums;

namespace Note.Backend.Infrastructure.Common.Exceptions;

public class InfrastructureException : Exception
{
    public ErrorCode ErrorCode { get; init; }
    public InfrastructureException(string message, ErrorCode errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
}