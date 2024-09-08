using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Model.Store
{
    public interface INoteStore
    {
        Task<IReadOnlyList<Note>> GetAll();

        Task<Note> GetById(long id);

        Task Create(string title, string description);

        Task Complete(long id);
    }
}
