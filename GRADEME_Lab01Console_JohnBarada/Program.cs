using SongsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab01SongSearchConsole
{
    public class Program
    {
        const string NOTHINGINPUTTED = "No Value Input for Search Criteria";
        const string NOSONGTITLEFOUND = "No Song Title Matching Search Criteria";
        const string NOSONGARTISFOUND = "No Song Artist Matching Search Criteria";
        const string NOSONGGENREFOUND = "No Song Genre Matching Search Criteria";

        static List<Song> songs = SongManager.LoadData();

        static void Main(string[] args)
        {
            int option;
            bool runAgain = true;

            while (runAgain)
            {
                option = ShowMenu();
                CallCorrectLINQFunction(option);
                runAgain = AnotherTime();

            }
            static int ShowMenu()
            {
                int optionChosenInt = 0;
                string optionChosenStr = "";
                bool result;

                string menuStr = "Please choose one of the follwing options\n:";
                menuStr += "Enter a 1 to show all the songs by title ascending order \n";
                menuStr += "Enter a 2 to show all the songs by artist asciending order\n";
                menuStr += "Enter a 3 to show all songs by genre ascending order\n";
                menuStr += "Enter a 4 to show song(s) that meet title criteria\n";
                menuStr += "Enter a 5 to show song(s) that meet artist criteria\n";
                menuStr += "Enter a 6 to show song(s) that meet genre criteria\n";
                menuStr += "Enter a 7 to exit the program";
                menuStr += "Please Enter a 1,2,3,4,5,6, or 7 now";
                Write(menuStr);
                optionChosenStr = ReadLine();

                result = Int32.TryParse(optionChosenStr, out optionChosenInt);
                if (!result)
                {
                    Write("\n\nYou MUST Enter A Number from 1-7. Hit Any Key To Continue");
                    ReadLine();
                    ShowMenu();
                }
                else if (optionChosenInt < 0 || (optionChosenInt > 7))
                {
                    Write("\n\n You MUST enter a number from 1-7 Hit Any Key to Continue");
                    ReadLine();
                    ShowMenu();
                }

                return optionChosenInt;
            }
            static void CallCorrectLINQFunction(int option)
            {
                switch (option)
                {
                    case 1:
                        ShowSongListByTitleAscending();
                        break;
                    case 2:
                        ShowSongListByArtistAscending();
                        break;
                    case 3:
                        ShowSongListByGenreAscending();
                        break;
                    case 4:
                        ShowSongListByTitleCriteria();
                        break;
                    case 5:
                        ShowSongListByArtistCriteria();
                        break;
                    case 6:
                        ShowSongListByGenreCriteria();
                        break;

                    default:
                        break;
                }

            }

            static void ShowSongListByTitleAscending()
            {
                var titleAscending = from s in songs
                                     orderby s.SongTitle ascending
                                     select s;

                WriteLine("Here is the Song List in Ascending Order by Song Title");
                foreach (var s in titleAscending)
                {
                    WriteLine(s);
                }
                ReadLine();
            }
            static void ShowSongListByArtistAscending()
            {
                var artistAscending = from a in songs
                                      orderby a.SongArtist ascending
                                      select a;

                WriteLine("Here is the Song List in Ascending Order by Song Artist");

                foreach (var s in artistAscending)
                {
                    WriteLine(s);
                }
                ReadLine();
            }
            static void ShowSongListByGenreAscending()
            {
                var genreAscending = from s in songs
                                     orderby s.SongGenre ascending
                                     select s;

                WriteLine("Here is the Song List in Ascending Order by Song Genre");

                foreach (var s in genreAscending)
                {
                    WriteLine(s);
                }
                ReadLine();
            }
            static void ShowSongListByArtistCriteria()
            {
                Clear();

                string artist;

                Write("Enter a Song Title to Search for Now (Full or Partial Title): ");
                artist = ReadLine();

                if (artist.Trim() == "")
                {
                    WriteLine(NOTHINGINPUTTED);
                    ReadLine();
                }
                else
                {
                    var songArtist = from a in songs
                                     orderby a.SongArtist ascending
                                     where a.SongArtist.ToUpper().Contains(artist.ToUpper())
                                     select a;
                    WriteLine("Song Artist Matching Inputted Search Criteria: ");

                    foreach (var sa in songArtist)
                    {
                        WriteLine(sa);
                    }
                    ReadLine();
                }
            }
                
            static void ShowSongListByTitleCriteria()
            {
                Clear();

                string title;

                Write("Enter a Song Title to Search for Now (Full or Partial Title): ");
                title = ReadLine();

                if (title.Trim() == "")
                {
                    WriteLine(NOTHINGINPUTTED);
                    ReadLine();
                }
                else
                {
                    var songTitle = from t in songs
                                    orderby t.SongTitle ascending
                                    where t.SongTitle.ToUpper().Contains(title.ToUpper())
                                    select t;
                    WriteLine("Song Titles Matching Inputted Search Criteria: ");

                    foreach (var st in songTitle)
                    {
                        WriteLine(st);
                    }
                    ReadLine();
                }
            }
                    
            static void ShowSongListByGenreCriteria()
                    {
                        Clear();

                        string genre;

                        Write("Enter a Song Artist to Search for Now (Full or Partial Artist): ");
                        genre = ReadLine();

                        if (genre.Trim() == "")
                        {
                            WriteLine(NOTHINGINPUTTED);
                            ReadLine();
                        }
                        else
                        {
                            var songGenre = from g in songs
                                            orderby g.SongGenre ascending
                                            where g.SongGenre.ToUpper().Contains(genre.ToUpper())
                                            select g;
                            WriteLine("Song Genres Matching Inputted Search Criteria: ");

                            foreach (var sg in songGenre)
                            {
                                WriteLine(sg);
                            }
                            ReadLine();
                        }
                    }
                    
            static bool AnotherTime()
                    {
                        bool retVal = true;
                        string again = "";
                        char firstChar = ' ';

                        Write("Run Program Again? (Y/N): ");
                        again = ReadLine().ToUpper();
                        firstChar = again[0];

                        if (firstChar != 'Y')
                        {
                            retVal = false;
                        }
                        return retVal;
                    }
                }
            }
        }