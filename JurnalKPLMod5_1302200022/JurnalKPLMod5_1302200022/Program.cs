// See https://aka.ms/new-console-template for more information
using JurnalKPLMod5_1302200022;

string praktikan = "Naufal Chairurrijal Alifaza";

SayaTubeUser user1 = new SayaTubeUser(praktikan);
SayaTubeVideo video1 = new SayaTubeVideo("ice age");
SayaTubeVideo video2 = new SayaTubeVideo("naruto");
SayaTubeVideo video3 = new SayaTubeVideo("bleach");
SayaTubeVideo video4 = new SayaTubeVideo("Gundam");
SayaTubeVideo video5 = new SayaTubeVideo("The Witcher");
SayaTubeVideo video6 = new SayaTubeVideo("Business Proposal");
SayaTubeVideo video7 = new SayaTubeVideo("Terminator");
SayaTubeVideo video8 = new SayaTubeVideo("Doremi");
SayaTubeVideo video9 = new SayaTubeVideo("Doraemon");
SayaTubeVideo video10 = new SayaTubeVideo("Ben 10");

user1.AddVideo(video1);
user1.AddVideo(video2);
user1.AddVideo(video3);
user1.AddVideo(video4);
user1.AddVideo(video5);
user1.AddVideo(video6);
user1.AddVideo(video7);
user1.AddVideo(video8);
user1.AddVideo(video9);
user1.AddVideo(video10);

user1.PrintVideoPlaycount();

Console.WriteLine(" ");


Console.WriteLine("Review Film " + video1.title + " oleh " + user1.username);
video1.IncreasePlayCount(2);
video1.PrintVideoDetail();






