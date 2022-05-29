using System;
using ConsoleAppProject.Helpers;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void Run()
        {
            ConsoleHelper.OutputHeading("    Leighton's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Remove Post", "Display All Posts", "Display Posts by Author", "Display Posts by Date", "Add Comment", "Like Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Create Message Post");

            string author = InputName();

            Console.Write("Enter Message > ");
            string text = Console.ReadLine();

            MessagePost post = new MessagePost(author, text);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("Your new Message Post is published:");
            post.Display();
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Create Image Post");

            string author = InputName();

            Console.Write("Enter File Name > ");
            string filename = Console.ReadLine();

            Console.Write("Enter Caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("Your new Image Post is published:");
            post.Display();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Remove Post");
            int id = (int)ConsoleHelper.InputNumber("Enter Post ID > ");
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void DisplayByAuthor()
        {
            string author = InputName();
            // To Complete
        }

        private void DisplayByDate()
        {
            Console.Write("Enter Date > ");
            string date = Console.ReadLine();
            // To Complete
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }
        private void LikePosts()
        {
            throw new NotImplementedException();
        }
        private string InputName()
        {
            Console.WriteLine("Enter Author Name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
