using System;

namespace MemoriesApp
{
    // all this class does is store data, so it has no methods besides the constructor and ToString
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