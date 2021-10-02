public class BookShelf
{
    final static string MANUFACTURE;
    final static string SIZE;
    final static TYPE;
    final static SOLD;
    string state = MANUFACTURE;
    int count = 0;
    public BookShelf(int count)
    {
        this.count = count;
        if (count > 0)
        {
            state = SIZE;
        }
    }
    public void typeShelf()
    {
        if (state == TYPE)
        {
            System.out.println("The material for bookshelf is made of different kinds!");
        }
        else if (state == SOLD)
        {
            System.out.println("The respective book is sold!");
        }
    }
    public void bookDetails()
    {
        if (state = TYPE)
        {
            System.out.println("There are new books arrived!");
        }
        else if (state == SOLD)
        {
            System.out.println("The books are sold out");
        }
    }
    public void factoryDetails()
    {
        if (state == TYPE)
        {
            System.out.println("The shelf is processed for billing!");
        }
        else if (state == SOLD)
        {
            System.out.println("The bookshelf is sold");
        }
        state = SOLD;
        dispense();
    }
    public void dispense()
    {
        if (state == SOLD)
        {
            System.out.println("The item is sold!");
            count = count - 1;
            if (count == 0)
            {
                System.out.println("Sorry we are out of Bookshelfs!");
                state == SOLDOUT;
            }
            else
            {
                state = MANUFACTURE;
            }
        }
    }
}