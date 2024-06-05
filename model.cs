public class Person
{
  private int id = 0; // field
  private string name = ""; // field

  public int Id{
    get{return id;}
    set{id=value;}
  }
  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}