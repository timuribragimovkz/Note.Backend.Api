// using Note.Backend.Infrastructure.NoteDb.Models;
//
// namespace Note.Backend.Infrastructure.NoteDb.Utilities;
//
// public class NotesInitializer
// {
//     public static List<NoteDto> GenerateSampleNotes()
//     {
//         var result = new List<NoteDto>();
//
//         var note1 = new NoteDto()
//         {
//             Author = new AuthorDto()
//             {
//                 Id = Guid.NewGuid().ToString(),
//                 Name = "Tim"
//             },
//             Id = Guid.NewGuid().ToString(),
//             Text = "Don't forget to eat your vitamins today!"
//         };
//         result.Add(note1);
//
//         var note2 = new NoteDto()
//         {
//             Author = new AuthorDto()
//             {
//                 Id = Guid.NewGuid().ToString(),
//                 Name = "Yuri"
//             },
//             Id = Guid.NewGuid().ToString(),
//             Text = "Don't forget to drink your water today!"
//         };
//         result.Add(note2);
//
//         return result;
//     }
// }