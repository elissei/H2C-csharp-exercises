namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
          if (this == compared)
          {
            return true;
          }          
          if ((compared == null) || !this.GetType().Equals(compared.GetType()))
          {
            return false;
          }
          else
          {
            Book comparedBook = (Book)compared;
            if(this.name.Equals(comparedBook.name) &&
                    this.publicationYear.Equals(comparedBook.publicationYear))
                {
                    return true;
                }
                return false;
          }
      
    }
    // END SOLUTION
  }


}