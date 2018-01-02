﻿using Android.Content;
using MarvelApp.Droid.Services;
using MarvelApp.Service;
using Xamarin.Forms;


[assembly: Dependency(typeof(OpenWebService))]
namespace MarvelApp.Droid.Services
{
    public class OpenWebService : IOpenWebService
    {
        #region IOpenWebService implementation

        public void OpenUrl(string url)
        {
            var uri = Android.Net.Uri.Parse(url);
            var intent = new Intent(Intent.ActionView, uri);
            intent.SetFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
        }

        #endregion

    }
}