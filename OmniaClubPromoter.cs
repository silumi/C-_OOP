using System;

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string fName, string lName, long phone) : base(fName, lName, phone)
    {
    }

    protected override void shareWithInnerCircle()
    {
        Console.WriteLine("Hello omniaClubPromoter.shareWithInnerCircle");
    }

    protected override void usePaidAds()
    {
        Console.WriteLine("Hello omniaClubPromoter.usePaidAds");
    }
}