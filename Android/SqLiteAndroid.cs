using System;
using System.IO;
using Xamarin.Forms;
using FormSample.Droid;
using FormSample.Helpers;

[assembly: Dependency(typeof(SQLite_Android))]
namespace FormSample.Droid
{

    public class SQLite_Android : ISqLite
    {
        public SQLite_Android()
        {
        }

        #region ISQLite implementation
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var finalPath = Path.Combine(documentsPath, Settings.GeneralSettings);
            if (!Directory.Exists(finalPath))
            {
                Directory.CreateDirectory(finalPath);
            }
            var path = Path.Combine(finalPath, sqliteFilename);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);

            // Return the database connection 
            return conn;
        }
        #endregion
    }
}

