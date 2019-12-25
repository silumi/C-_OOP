public abstract class Writer: IVlogger{

   private string FirstName;
   private string LastName;

   public string AutoBio{
       get{
           return string.Format("Hi my Name is {0} {1}.", this.FirstName, this.LastName);
       }
   }
    public Writer(string fName, string lName){

    }
    public abstract void vlog();
    

    public abstract void Write();
}