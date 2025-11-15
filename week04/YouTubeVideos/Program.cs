using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video yt1 = new Video();
        yt1._title = "Choosing the perfect Red";
        yt1._author = "MU Queen";
        yt1._length = 765;

        Comments wc1 = new Comments();
        wc1._name = "sunny.smile";
        wc1._text = "This was so helpful, Thank you!";
        yt1._comments.Add(wc1);
        Comments wc2 = new Comments();
        wc2._name = "colourQueen";
        wc2._text = "That read looks so good on you!";
        yt1._comments.Add(wc2);
        Comments wc3 = new Comments();
        wc3._name = "masscara2.0";
        wc3._text = "Could you show a dube of this colour?";
        yt1._comments.Add(wc3);

        videos.Add(yt1);

        Video yt2 = new Video();
        yt2._title = "My trip to Thailand";
        yt2._author = "bored and broke";
        yt2._length = 1700;

        Comments wc4 = new Comments();
        wc4._name = "up.in.the.air";
        wc4._text = "Can you please write down the name of the hotel?";
        yt2._comments.Add(wc4);
        Comments wc5 = new Comments();
        wc5._name = "peaches212";
        wc5._text = "Can you take me next time!!";
        yt2._comments.Add(wc5);
        Comments wc6 = new Comments();
        wc6._name = "gary.18";
        wc6._text = "Looks Amazing!";
        yt2._comments.Add(wc6);

        videos.Add(yt2);

        Video yt3 = new Video();
        yt3._title = "Best ever Chocolate Cake";
        yt3._author = "Budget Baking";
        yt3._length = 800;

        Comments wc7 = new Comments();
        wc7._name = "SweetTooth";
        wc7._text = "Can I replace butter for oil?";
        yt3._comments.Add(wc7);
        Comments wc8 = new Comments();
        wc8._name = "rose678";
        wc8._text = "Made my mouth water!";
        yt3._comments.Add(wc8);
        Comments wc9 = new Comments();
        wc9._name = "mouseman11";
        wc9._text = "Yummy! Yummy!";
        yt3._comments.Add(wc9);

        videos.Add(yt3);

        foreach (Video vid in videos)
        {
            vid.DisplayVideo();
            vid.GetCommentCount();
            foreach (Comments c in vid._comments)
            {
                c.DisplayComment();
            }
            Console.WriteLine();
        }





    }
}