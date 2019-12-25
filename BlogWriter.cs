using System;

public class BlogWriter : Writer, IVlogger
{
    public BlogWriter(string fName, string lName) : base(fName, lName)
    {
    }

    public override void vlog()
    {
        Console.WriteLine("Hello blog writter.Vlog");
    }

    public override void Write()
    {
        Console.WriteLine("Hello blog writter.write");
    }
}