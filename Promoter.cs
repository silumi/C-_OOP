public abstract class Promoter{

    private string FirstName;
   private string LastName;
   private long phone;

   public string MyBusinessCard{
       get{
           return string.Format(" {0} {1} {2} ", this.FirstName, this.LastName, this.phone);
       }
   }
    public Promoter(string fName, string lName, long phone){
      this.FirstName=fName;
      this.LastName=lName;
      this.phone=phone;
    }
    public void Promote(){
        this.shareWithInnerCircle();
        this.usePaidAds();
    }

    protected abstract void shareWithInnerCircle();
    protected abstract void usePaidAds();

}