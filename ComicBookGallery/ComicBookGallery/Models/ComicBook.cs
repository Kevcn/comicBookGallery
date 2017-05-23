using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {

        //attributes or behaviour

        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public List<Artist> Artists { get; set; }
        public bool Favorite { get; set; }


     


        //read only properties
        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;

            }
        }

        public string CoverPageImage
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }




    }
}