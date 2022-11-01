namespace KutuphaneProgrami
{
    public class BookModel
    {
        public string serialNumber;
        public string bookName;

        public BookModel(string serialNumber, string bookName)
        {
            this.serialNumber = serialNumber;
            this.bookName = bookName;
        }
    }
}