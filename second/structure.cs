using System;

namespace usingStructure {
    struct song {
        public string title;
        public string artist;
        public string albumName;
        public int trackNumber;
    };
    public class songsWord {
        public static void Main(string[] args) {
            song song1; // declare song1 of type song
            song song2; // declare song2 of type song

            // song1 specification
            song1.title = "Onno premer gaan";
            song1.artist = "Nachiketa Chakraborty";
            song1.albumName = "Best of Nachiketa";
            song1.trackNumber = 04;

            // song2 specification
            song2.title = "Amar sonar moyna pakhi";
            song2.artist = "Kanak Chapa";
            song2.albumName = "Best of Kanak Chapa";
            song2.trackNumber = 08;

            // print song1 info
            Console.WriteLine("Song1 Title: {0}", song1.title);
            Console.WriteLine("Song1 Artist: {0}", song1.artist);
            Console.WriteLine("Song1 AlbumName: {0}", song1.albumName);
            Console.WriteLine("Song1 TrackNumber: {0}", song1.trackNumber);

            // print song2 info
            Console.WriteLine("Song2 Title: {0}", song2.title);
            Console.WriteLine("Song2 Artist: {0}", song2.artist);
            Console.WriteLine("Song2 AlbumName: {0}", song2.albumName);
            Console.WriteLine("Song2 TrackNumber: {0}", song2.trackNumber);

            Console.ReadKey();
        }
    }
}