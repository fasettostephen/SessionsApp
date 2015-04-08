using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ENEI.SessionsApp.Data;
using ENEI.SessionsApp.Interfaces;
using ENEI.SessionsApp.Model;
using Xamarin.Forms;

namespace ENEI.SessionsApp.ViewModels
{
    public class SessionViewModel
    {
        public SessionViewModel()
        {
            Sessions = new ObservableCollection<Session>();
            LikeCommand = new Command(ApplyLike);
            FavoriteCommand = new Command(ApplyFavorite);
            ShareCommand = new Command(Share);
            SessionDetailsCommand = new Command(SeeSessionDetails);
        }

        public ObservableCollection<Session> Sessions { get; set; }
        public ICommand LikeCommand { get; private set; }
        public ICommand FavoriteCommand { get; private set; }
        public ICommand ShareCommand { get; private set; }
        public ICommand SessionDetailsCommand { get; private set; }

        private void ApplyLike(object param)
        {
            var session = param as Session;
            if (session != null)
            {
                session.NumLikes++;
            }
        }

        private void ApplyFavorite(object param)
        {
            var session = param as Session;
            if (session != null)
            {
                session.IsFavorite = !session.IsFavorite;
            }
        }

        private void Share(object param)
        {
            var session = param as Session;
            if (session != null)
            {
                var shareService = DependencyService.Get<IShareService>();
                if (shareService != null)
                {
                    var status = string.Format("Não percas a sessão {0} de {1}.", session.Name, session.Speaker.Name);
                    shareService.ShareLink("ENEI 2015", status, "https://enei.pt/");
                }
            }
        }

        private void SeeSessionDetails(object param)
        {
            var session = param as Session;
            if (session != null)
            {
                MessagingCenter.Send(session, "SeeSessionDetails");
            }
        }

        public async Task LoadDataAsync()
        {
           await Task.Run(() =>
            {
                if (Sessions.Count == 0)
                {
                    var sessions = SessionsDataSource.GetSessions();
                    foreach (var session in sessions)
                    {
                        Sessions.Add(session);
                    }
                }
            });
        }
    }
}
