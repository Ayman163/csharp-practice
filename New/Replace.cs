using system

namespace My FIrst Program
{
  class Program
  {
  
    static void Main(string[] args)
    {
      String fullName = "Bro Code";
      String phoneNumber = "123-456-7890";
      phoneNumber = phoneNumber.Replace("-","/");
      Console.WriteLine (phoneNumber);
    }
  }
}
