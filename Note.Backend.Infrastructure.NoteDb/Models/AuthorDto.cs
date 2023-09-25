// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.Common.Models;
// using Note.Backend.Infrastructure.NoteDb.Common;
//
// namespace Note.Backend.Infrastructure.NoteDb.Models;
//
// public class AuthorDto : BaseDto
// {
//     public string Name { get; set; }
//
//     public DomainAuthor FromDto()
//     {
//         var author = new DomainAuthor(Name, Id);
//         return author;
//     }
//
//     public static AuthorDto ToDto(DomainAuthor domainAuthor)
//     {
//         return new AuthorDto()
//         {
//             Id = domainAuthor.Id,
//             Name = domainAuthor.Name
//         };
//     }
// }