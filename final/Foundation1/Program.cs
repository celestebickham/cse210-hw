using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._commentText = "Great video";
        comment1._commenterName = "Isaac Smith";

        Comment comment2 = new Comment();
        comment2._commentText = "Awesome";
        comment2._commenterName = "Caroline Jones";

        Comment comment3 = new Comment();
        comment3._commentText = "I like it";
        comment3._commenterName = "Peter Johnson";

        Comment comment4 = new Comment();
        comment4._commentText = "Thanks for the video";
        comment4._commenterName = "Everett King";

        Comment comment5 = new Comment();
        comment5._commentText = "Wet";
        comment5._commenterName = "Lila Oregano";

        Comment comment6 = new Comment();
        comment6._commentText = "Refreshing";
        comment6._commenterName = "Arianna Delight";

        Comment comment7 = new Comment();
        comment7._commentText = "Wild";
        comment7._commenterName = "Charles Combine";

        Comment comment8 = new Comment();
        comment8._commentText = "Slick";
        comment8._commenterName = "Adrian Toughguy";

        Comment comment9 = new Comment();
        comment9._commentText = "Dry";
        comment9._commenterName = "Cassandra Curls";

        Comment comment10 = new Comment();
        comment10._commentText = "Bumpy";
        comment10._commenterName = "Bowen Archer";

        Comment comment11 = new Comment();
        comment11._commentText = "Rocky";
        comment11._commenterName = "Alvin Chipmunk";

        Comment comment12 = new Comment();
        comment12._commentText = "Hard";
        comment12._commenterName = "Aspen Grove";

        Comment comment13 = new Comment();
        comment13._commentText = "Fast";
        comment13._commenterName = "Kaylee Baby";

        Comment comment14 = new Comment();
        comment14._commentText = "Windy";
        comment14._commenterName = "David Goliath";

        Comment comment15 = new Comment();
        comment15._commentText = "Cough";
        comment15._commenterName = "Adrian Asthma";

        Comment comment16 = new Comment();
        comment16._commentText = "Breathe";
        comment16._commenterName = "Samantha Aire";

        Video video1 = new Video();
        video1._title = "Sunshine";
        video1._author = "Happy People";
        video1._lengthInSeconds = "68";

        video1._comment.Add(comment1);
        video1._comment.Add(comment2);
        video1._comment.Add(comment3);
        video1._comment.Add(comment4);

        Video video2 = new Video();
        video2._title = "Rain";
        video2._author = "Zander";
        video2._lengthInSeconds = "207";

        video2._comment.Add(comment5);
        video2._comment.Add(comment6);
        video2._comment.Add(comment7);
        video2._comment.Add(comment8);

        Video video3 = new Video();
        video3._title = "Earth";
        video3._author = "Jace";
        video3._lengthInSeconds = "74";

        video3._comment.Add(comment9);
        video3._comment.Add(comment10);
        video3._comment.Add(comment11);
        video3._comment.Add(comment12);

        Video video4 = new Video();
        video4._title = "Oxygen";
        video4._author = "Austin Boston";
        video4._lengthInSeconds = "309";

        video4._comment.Add(comment13);
        video4._comment.Add(comment14);
        video4._comment.Add(comment15);
        video4._comment.Add(comment16);

        video1.Display();
        video2.Display();
        video3.Display();
        video4.Display();
    }
}