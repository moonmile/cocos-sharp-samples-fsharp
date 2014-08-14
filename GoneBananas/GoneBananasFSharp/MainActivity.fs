namespace GoneBananasFSharp

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget
open CocosSharp
open Microsoft.Xna.Framework
open GoneBananas


[<Activity(
    Label = "GoneBananas",
    AlwaysRetainTaskState = true,
    Icon = "@drawable/ic_launcher",
    Theme = "@android:style/Theme.NoTitleBar",
    ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait,
    LaunchMode = Android.Content.PM.LaunchMode.SingleInstance,
    ConfigurationChanges = (Android.Content.PM.ConfigChanges.Keyboard ||| Android.Content.PM.ConfigChanges.KeyboardHidden),
    MainLauncher = true )>]
type MainActivity () =
    inherit AndroidGameActivity ()

    let mutable count:int = 1

    override this.OnCreate (bundle) =

        base.OnCreate (bundle)
        let application = new CCApplication()
        application.ApplicationDelegate <- new GoneBananasApplicationDelegate()
        this.SetContentView(application.AndroidContentView)
        application.StartGame()

