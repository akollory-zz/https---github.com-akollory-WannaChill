using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace LoginNavigation.Droid
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public string Email { get; internal set; }

        public override string ToString()
        {

            return string.Format("[Person: ID={0}, Username={1}, Password={2}]", ID, Username, Password);

        }
    }
}