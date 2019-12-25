using System;

public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
{
    public XSClubPromoter(string fName, string lName, long phone) : base(fName, lName, phone)
    {
    }

    public void vlog()
    {
        Console.WriteLine("Hello XSClubPromoter.vlog");
    }

    public void workout()
    {
        Console.WriteLine("Hello XSClubPromoter.workout");
    }

    protected override void shareWithInnerCircle()
    {
        Console.WriteLine("Hello XSClubPromoter.shareInnerCircle");
    }

    protected override void usePaidAds()
    {
        Console.WriteLine("Hello XSClubPromoter.usePaidAds");
    }
}