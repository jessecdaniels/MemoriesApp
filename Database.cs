using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriesApp

    // Represents in-memory database for journal
{
    class Database
    {
        // Journal memories
        private List<Memory> memories;

        // Initializes instance
        public Database()
        {
            memories = new List<Memory>();
        }

        // Adds new memory
        public void AddMemory(DateTime occurs, string text)
        {
            memories.Add(new Memory(occurs, text));
        }

        public List<Memory> FindMemories(DateTime date, bool byTime)
        {
            List<Memory> found = new List<Memory>();
            foreach (Memory memory in memories)
            {
                if (((byTime) && (memory.Occurs == date)) // by time and date
                ||
                ((!byTime) && (memory.Occurs.Date == date.Date))) // by date only
                    found.Add(memory);
            }
            return found;
        }

        // Removes memories occurring on specified date and time
        public void DeleteMemories(DateTime date)
        {
            List<Memory> found = FindMemories(date, true);
            foreach (Memory memory in found)
                memories.Remove(memory);
        }

    }
}
