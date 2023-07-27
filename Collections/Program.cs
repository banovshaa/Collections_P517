bool isFinished  = false;
Library library = new Library();

while (!isFinished)
{
    Console.WriteLine("\nMenu");
    Console.WriteLine("1.Add Book");
    Console.WriteLine("2.Remove Book");
    Console.WriteLine("3.Display Books");
    Console.WriteLine("4.Exit");

    Console.Write("Enter your choice:");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);

    switch (choice)
    {
        case 1:
            newBookTitle:
            Console.WriteLine("Type book name:");
            string title = Console.ReadLine();   
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Enter title correctly");
                goto newBookTitle;
            }
            newBookAuthor:
            Console.WriteLine("Type book author:");
            string author = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Enter author correctly");
                goto newBookAuthor;
            }
             newBookYear:
            Console.WriteLine("Type book year:");
            int year;
            if (int.TryParse(Console.ReadLine(), out year))
            {
                
                    library.AddBook(title, author, year);
                
            }
            else
            {
                    Console.WriteLine("Enter correctly");
                    goto newBookYear;
               
            }
            
          
            break;
            case 2:
            Console.WriteLine("Enter book index you want to remove:");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                library.RemoveBook(index+1);
            }
            else
            {
                Console.WriteLine("Enter correctly");
            }
           
            break;
            case 3:
            library.DisplayBook();
            break;
            case 4:
            isFinished = true;
            break;
        default:
            Console.WriteLine("Enter correct choice");
            break;
    }
}