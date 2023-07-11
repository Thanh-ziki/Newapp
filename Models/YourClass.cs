namespace Newapp.Models
{
    public class YourClass
    {
        public int studentID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public void Input()
        {
            System.Console.Write("StudentID: ");
            studentID = Convert.toInt32(Console.ReadLine());
            System.Console.Write("Ho Ten Sinh Vien: ");
            FullName = Console.ReadLine();
            System.Console.Write("Age: ");
            Age = Convert.toInt16(Console.ReadLine());
        }
        public void Output()
        {
            System.Console.WriteLine("Ma Sinh Vien: {0} - Ho va ten: {1} - Tuoi: {2}", studentID,FullName,Age);
        }
        
    }
    
}