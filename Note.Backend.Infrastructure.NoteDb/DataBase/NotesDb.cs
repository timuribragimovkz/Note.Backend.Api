// using Note.Backend.Domain.Recipe.Models;
// using Note.Backend.Infrastructure.NoteDb.Common;
// using Note.Backend.Infrastructure.NoteDb.Models;
// using Note.Backend.Infrastructure.NoteDb.Utilities;
//
// namespace Note.Backend.Infrastructure.NoteDb.DataBase;
//
// public class NotesDb : INotesDb, ISingletonService
// {
//     private readonly List<NoteDto> _notes = NotesInitializer.GenerateSampleNotes().ToList();
//
//     public IEnumerable<DomainNote> GetAllNotes()
//     {
//         var domainNotes = _notes.Select(x => x.FromDto());
//         
//         return domainNotes;
//     }
//     
//     public DomainNote GetRequiredById(string id)
//     {
//         var domainNote = GetById(id);
//
//         if (domainNote == null)
//         {
//             throw new Exception("Model not found");
//         }
//
//         return domainNote;
//     }
//
//     public void AddNote(DomainNote domainNote)
//     {
//         if (domainNote == null)
//         {
//             throw new Exception("Model not provided");
//         }
//
//         var noteDto = NoteDto.ToDto(domainNote);
//         
//         _notes.Add(noteDto);
//     }
//
//     public void Update(DomainNote domainNote)
//     {
//         var foundNote = GetRequiredById(domainNote.Id);
//         
//         var index = _notes.FindIndex(x => x.Id == domainNote.Id);
//
//         _notes[index] =  NoteDto.ToDto(domainNote);
//     }
//
//     public void DeleteById(string id)
//     {
//         var foundNote = _notes.FirstOrDefault(x => x.Id == id);
//         
//         if (foundNote != null)
//         {
//             _notes.Remove(foundNote);
//         }
//     }
//     
//     private DomainNote GetById(string id)
//     {
//         if (string.IsNullOrEmpty(id))
//         {
//             throw new Exception("Id not provided");
//         }
//         
//         var domainNote = _notes.FirstOrDefault(x => x.Id == id)?.FromDto();
//
//         return domainNote;
//     }
//
//     
// }