using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
	public class ComicBookRepository
	{
		private static List<ComicBook> comicBooks = new List<ComicBook>()
		{
			 new ComicBook()
	        {
		        SeriesTitle = "The Amazing Spider-Man",
		        IssueNumber = 700,
		        Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
		        Artists = new List<Artist>
		        {
			        new Artist() { Name = "Dan Slott", Role = "Script" },
			        new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
			        new Artist() { Name = "Victor Olazaba", Role = "Inks" },
			        new Artist() { Name = "Edgar Delgado", Role = "Colors" },
			        new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
		        },
		        Favorite = false
	        },
	        new ComicBook()
	        {
		        SeriesTitle = "The Amazing Spider-Man",
		        IssueNumber = 657,
		        Description = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
		        Artists = new List<Artist>
		        {
			        new Artist() { Name = "Dan Slott", Role = "Script" },
			        new Artist() { Name = "Marcos Martin", Role = "Pencils" },
			        new Artist() { Name = "Marcos Martin", Role = "Inks" },
			        new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
			        new Artist() { Name = "Joe Caramagna", Role = "Letters" }
		        },
		        Favorite = false
	        },
	        new ComicBook()
	        {
		        SeriesTitle = "Bone",
		        IssueNumber = 50,
		        Description = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
		        Artists = new List<Artist>
		        {
			        new Artist() { Name = "Jeff Smith", Role = "Script" },
			        new Artist() { Name = "Jeff Smith", Role = "Pencils" },
			        new Artist() { Name = "Jeff Smith", Role = "Inks" },
			        new Artist() { Name = "Jeff Smith", Role = "Letters" }
		        },
		        Favorite = false
	        }

		}; // end of list of comic books. 

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }

            return comicBookToReturn;
        }

	}
}