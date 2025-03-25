using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertApp
{
    public class ConcertClas
    {
        private string artist;
        private string title;
        private string venue;
        private DateTime startDate;
        private DateTime endDate;
        #region property
        public string Artist { get => artist; set => artist = value; }
        public string Title { get => title; set => title = value; }
        public string Venue { get => venue; set => venue = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate
        {
            get => endDate;
            set
            {
                if (value >= this.StartDate)
                {
                    endDate = value;
                }
                else
                {
                    throw new Exception("End Date harus setelah Start Date");
                }
            }
        }
        #endregion
        #region constructor
        public ConcertClas(string pArtist, string pTitle, string pVenue, DateTime pStart,
            DateTime pEnd)
        {
            this.Artist = pArtist;
            this.Title = pTitle;
            this.Venue = pVenue;
            this.StartDate = pStart;
            this.EndDate = pEnd;
        }
        #endregion
        #region method
        public string Format()
        {
            string display = "Title - " + this.Title + "\n"
                + "Artist - " + this.Artist + "\n"
                + "Venue - " + this.Venue + "\n"
                + "Start Date - " + this.StartDate.ToShortDateString() + "\n"
                + "Days of Concert - " + this.ConcertDuration() + " days" +"\n"
                + "Concert will be started in " + this.DaysBeforeConcertBegin() + "days" + "\n";
            return display;
        }

        public int ConcertDuration()
        {
            int result = (this.EndDate - this.StartDate).Days + 1;
            return result;
        }

        public int DaysBeforeConcertBegin()
        {
            int result = (this.StartDate - DateTime.Now).Days;
            return result;
        }

        public bool IsThisMonth()
        {
            if (this.StartDate.Month == DateTime.Now.Month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConcertIsOver()//cek apakah konser nya sudah kelewat tgl
        {
            if (DateTime.Now.Date <= this.EndDate.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        
    }
}