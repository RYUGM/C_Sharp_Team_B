using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0308_liblary
{
    public class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        const string BOOK = "book";
        const string USER = "user";
        const string ISBN = "isbn";
        const string NAME = "name";
        const string PUBLISHER = "publisher";
        const string PAGE = "page";
        const string ISBORROWED = "isBorrowed";
        const string BORROWEDAT = "borroweAt";
        const string USERID = "userId";
        const string USERNAME = "username";

        //유저용
        const string UNAME = "name";
        const string UID = "id";

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement BooksXElement = XElement.Parse(booksOutput);

                Books = (from item in BooksXElement.Descendants(BOOK)
                         select new Book()
                         {
                             Isbn=item.Element(ISBN).Value,
                             Name=item.Element(NAME).Value,
                             Publisher=item.Element(PUBLISHER).Value,
                             Page=int.Parse(item.Element(PAGE).Value),
                             UserId = int.Parse(item.Element(USERID).Value),
                             UserName=item.Element(USERNAME).Value, 
                             BorrowedAt= DateTime.Parse(item.Element(BORROWEDAT).Value),
                             isBorrowed=item.Element(ISBORROWED).Value!="0" ? true : false

                            

                         }).ToList<Book>();

                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users.Clear();
                foreach (var item in usersXElement.Descendants(USER))
                {
                    User temp = new User();
                    temp.Name = item.Element(UNAME).Value;
                    temp.Id = int.Parse(item.Element(UID).Value);
                    Users.Add(temp);
                }
            }
            catch (Exception e)
            {
                Save();
                Load();
                
            }
           
        }
        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach (var item in Books)
            {
                booksOutput += $"\t<{BOOK}>\n";
                booksOutput += $"\t\t<{ISBN}>{item.Isbn}</{ISBN}>\n";
                booksOutput += $"\t\t<{NAME}>{item.Name}</{NAME}>\n";
                booksOutput += $"\t\t<{PUBLISHER}>{item.Publisher}</{PUBLISHER}>\n";
                booksOutput += $"\t\t<{PAGE}>{item.Page}</{PAGE}>\n";
                booksOutput += $"\t\t<{BORROWEDAT}>{item.BorrowedAt}</{BORROWEDAT}>\n";
                booksOutput += $"\t\t<{ISBORROWED}>"+(item.isBorrowed ? 1 : 0)+$"</{ISBORROWED}>\n";
                booksOutput += $"\t\t<{USERID}>{item.UserId}</{USERID}>\n";
                booksOutput += $"\t\t<{USERNAME}>{item.UserName}</{USERNAME}>\n";
                

                booksOutput += $"\t</{BOOK}>\n";

            }

            booksOutput += "</books>";
            Console.WriteLine(booksOutput);
            File.WriteAllText(@"./Books.xml", booksOutput);

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)

            {
                usersOutput += $"\t<{USER}>\n";
                usersOutput += $"\t\t<{UID}>{item.Id}</{UID}>\n";
                usersOutput += $"\t\t<{UNAME}>{item.Name}</{UNAME}>\n";


                usersOutput += $"\t</{USER}>\n";
            }
            usersOutput += "</users>";

            Console.WriteLine(usersOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);

        }
    }
}
