using Note.Backend.Domain.Common.Enums;

namespace Note.Backend.Domain.Common.Exceptions;

public class DomainException : Exception
{
    public ErrorCode ErrorCode { get; init; }
    public DomainException(string message, ErrorCode errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
}