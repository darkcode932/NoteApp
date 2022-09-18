using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://github.com/darkcode932";
        public string Message => "This app is written in XAML and C# with .NET MAUI By Atebede Russel alias Okokbatonmanioc.";
    }
}
