using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;

namespace App5
{
    [Activity(Label = "App5", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        string[] items;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = items[position];
            Toast.MakeText(this, t, ToastLength.Short).Show();
        }
    }
}

