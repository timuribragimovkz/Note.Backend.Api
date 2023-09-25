// using Note.Backend.Domain.Recipe.Models;
// using Note.Backend.Infrastructure.Common.Models;
// using Note.Backend.Infrastructure.NoteDb.Common;
//
// namespace Note.Backend.Infrastructure.NoteDb.Models;
//
// public class NoteDto : BaseDto
// {
//     public string Text { get; set; }
//     public AuthorDto Author { get; set; }
//
//     public DomainNote FromDto()
//     {
//         var authorDto = new AuthorDto()
//         {
//             Name = Author.Name
//         };
//         var domainAuthor = authorDto.FromDto();
//         var note = new DomainNote(domainAuthor, Id);
//         note.EditText(Text);
//         return note;
//     }
//
//     public static NoteDto ToDto(DomainNote domainNote)
//     {
//         return new NoteDto()
//         {
//             Id = domainNote.Id,
//             Author = AuthorDto.ToDto(domainNote.Author),
//             Text = domainNote.Text ?? string.Empty
//         };
//     }
// }