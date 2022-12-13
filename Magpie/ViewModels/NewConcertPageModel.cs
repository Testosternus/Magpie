using FreshMvvm.Maui;
using Magpie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magpie.ViewModels
{
    public class NewConcertPageModel : FreshBasePageModel
    {
        private Concert newConcert; // class member to allocate new data to
        public NewConcertPageModel()
        {

        }

        #region PROPERTIES

        private string title;
        public string Title
        {
            get { return title; }
            set 
            {
                title = value; 
                RaisePropertyChanged(nameof(Title));
            }
        }

        private DateTime date = DateTime.Now;
        public DateTime Date
        {
            get { return date; }
            set 
            {
                date = value;
                RaisePropertyChanged(nameof(Date));
            }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set 
            {
                location = value;
                RaisePropertyChanged(nameof(Location));
            }
        }

        private string album;
        public string Album
        {
            get { return album; }
            set 
            {
                album = value;
                RaisePropertyChanged(nameof(Album));
            }
        }

        #endregion PROPERTIES

        public ICommand SaveAndReturn => new Command(
            async () =>
            {
                newConcert = new Concert { Title= Title, Date = Date, Location = Location, Album = Album  };

                await MauiProgram.Database.SaveConcertAsync(newConcert);
                await CoreMethods.PopPageModel(true, true);
            });
    }
}
