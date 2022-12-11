using FreshMvvm.Maui;
using Magpie.Models;
using Magpie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.ViewModels
{
    internal class ConcertPageModel : FreshBasePageModel
    {
		private IConcertService concertService;
		public ConcertPageModel(IConcertService service)
		{
			concertService= service;
		}


        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
			var concertData = await concertService.GetDataAsync();
			Concerts = new ObservableCollection<Concert>(concertData);
        }



        private ObservableCollection<Concert> _concerts;
		public ObservableCollection<Concert> Concerts
		{
			get { return _concerts; }
			set 
			{ 
				_concerts = value; 
				RaisePropertyChanged(nameof(Concerts));
			}
		}

	}
}
