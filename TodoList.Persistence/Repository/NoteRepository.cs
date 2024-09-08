using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Model;
using TodoList.Model.Store;

namespace TodoList.Persistence.Repository
{
    public class NoteRepository : INoteStore
    {
        private readonly ApplicationContext _context;

        public NoteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Complete(long id)
        {
            await _context.Notes.ExecuteUpdateAsync(s => s
            .SetProperty(n => n.IsComplited, n => true));
        }

        public async Task Create(string title, string description)
        {
            var note = new Note { Title = title, Description = description };

            await _context.Notes.AddAsync(note);

            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Note>> GetAll()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note> GetById(long id)
        {
            var note = await _context.Notes.FirstOrDefaultAsync(n => n.Id == id)
                ?? throw new Exception();

            return note;
        }
    }
}
