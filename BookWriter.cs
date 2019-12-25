using System;

public class BookWriter : Writer, IVlogger
{
    public BookWriter(string fName, string lName) : base(fName, lName)
    {
    }

    public override void vlog()
    {
        Console.WriteLine("Hello book writter.Vlog");
    }

    public override void Write()
    {
        Console.WriteLine("Hello book writter.write");
    }
}