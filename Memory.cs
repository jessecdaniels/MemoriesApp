using System;

namespace MemoriesApp
{
    public class Memory
    {
    public DateTime Occurs { get; set; }
    public string Text { get; set; }

    public Memory (DateTime occurs, string text)
    {
        Occurs = occurs;
        Text = text;
    }

    public override string ToString()
    {
        return Occurs + " " + Text;
    }
}
    }