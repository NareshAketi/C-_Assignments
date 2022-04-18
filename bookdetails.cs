using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookdetails
{
//struct of the given book details
   struct book
    {
        int bookId;
        string Title;
        double Price;
        

        enum BookType
        {
            Novel,
            Magazine,
		 Miscellaneous,
            ReferenceBook
            
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter bookId:");
            BookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title of book:");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the Price :");
            Price = Convert.ToDouble(Console.ReadLine());
            
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Select Booktype:  Novel or Magazine or Miscellaneous or ReferenceBook");
            string c = Console.ReadLine();
            if (c == "Novel")//if-else-if loop statement.
            {
                Console.WriteLine("The bookId:" + bookId);
                Console.WriteLine("The Title Of book :" + Title);
                Console.WriteLine("The Book price :" + Price);
                Console.WriteLine("The BookType :" + BookType.Novel);
            }
            else if (c=="Magazine")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title of book :" + Title);
                Console.WriteLine("The book price :" + Price);
                Console.WriteLine("The BookType :" + BookType.Magazine);
            }
            else if (c == "Miscellaneous")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title Of book :" + Title);
                Console.WriteLine("The book price :" + Price);
                Console.WriteLine("The BookType :" + BookType.Miscellaneous);
            }
            else if (c == "ReferenceBook")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title Of book :" + Title);
                Console.WriteLine("The book price:" + Price);
                Console.WriteLine("The BookType :" + BookType.ReferenceBook);
            }
            else
            {
                Console.WriteLine("Check the Spelling of BookType");
                    }
        }

        public static void Main()
        {
            book b1 = new book();
            b1.AcceptDetails();
            b1.DisplayDetails();
            Console.ReadKey();
        }
    }
    
}