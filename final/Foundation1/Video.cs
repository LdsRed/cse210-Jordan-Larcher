using System;
using System.Diagnostics.Contracts;

class Video
{

    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comment;



    public Video(string author, string title, int length)
    {
        SetAuthor(author);
        SetTitle(title);
        SetLength(length);
        _comment = new List<Comment>();
    }
   


    public string GetAuthor()
    {
        return _author;
    }
    
    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetAuthor(string author) 
    {
        this._author = author;
    }
    
    public void SetTitle(string title)
    {
        this._title = title;
    }

    public void SetLength(int length)
    {
        this._length = length;
    }

    
    public int GetNumberOfComments()
    {
        return _comment.Count;
    }



    public void AddComment(string name, string comment)
    {
        Comment newComment = new Comment(name, comment);
        _comment.Add(newComment);
    }
    
    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        if (GetNumberOfComments() > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Comments:");
            foreach (Comment comment in _comment)
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetComment()}");
                
            }            
        }
    }

     

}