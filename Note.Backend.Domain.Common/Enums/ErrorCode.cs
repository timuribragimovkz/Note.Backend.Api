namespace Note.Backend.Domain.Common.Enums;

public enum ErrorCode
{
    //666 - DOMAIN
    IngredientAlreadyExists = 666001,
    
    //888 - INFRASTRUCTURE
    IdNotProvided = 888001,
    ModelNotFound = 888002,
    AuthorNotFound = 888003
    
}