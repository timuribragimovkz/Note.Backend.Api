using Note.Backend.Domain.Common.Enums;

namespace Note.Backend.Application.Features.Exceptions;

public class ApplicationLayerException : Exception
{
    public ErrorCode ErrorCode { get; init; }
    
    public ApplicationLayerException(string message, ErrorCode errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
}