using DemoExam.ADOApp;
using System.Windows;

namespace DemoExam
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly LanguageSchoolEntities _connection = new LanguageSchoolEntities();
        public static LanguageSchoolEntities Connection => _connection;
        public static bool IsAdministratorMode { get; set; } = false;
        public static Visibility AdminVisibility => IsAdministratorMode ? Visibility.Visible : Visibility.Collapsed;
    }
}
