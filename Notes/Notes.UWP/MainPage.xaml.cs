using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Notes.Storage;
using Notes.Storage.Model;

namespace Notes.UWP
{
    public sealed partial class MainPage : Page
    {
        public static readonly DependencyProperty UsersProperty = DependencyProperty.Register(
            "Users", typeof(IEnumerable<User>), typeof(MainPage), new PropertyMetadata(default(IEnumerable<User>)));

        public IEnumerable<User> Users
        {
            get => (IEnumerable<User>) GetValue(UsersProperty);
            set => SetValue(UsersProperty, value);
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void CreateUser(object sender, RoutedEventArgs e)
        {
            using (var context = new NotesContext())
            {
                var user = new User{Name = UserName.Text};
                context.Users.Add(user);
                context.SaveChanges();
                Users = context.Users;

            }
        }
    }
}