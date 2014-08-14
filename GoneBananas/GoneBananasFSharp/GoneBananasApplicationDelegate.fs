namespace GoneBananas
open System
open CocosDenshion
open CocosSharp

type GoneBananasApplicationDelegate() =
    inherit CCApplicationDelegate()

    override this.ApplicationDidFinishLaunching(application:CCApplication, mainWindow:CCWindow) =
        application.PreferMultiSampling <- false
        application.ContentRootDirectory <- "Content"
        mainWindow.SupportedDisplayOrientations <- CCDisplayOrientation.Portrait
        application.ContentSearchPaths.Add("hd")
        CCSimpleAudioEngine.SharedEngine.PreloadEffect ("Sounds/tap")
        let scene = GameStartLayer.GameStartLayerScene(mainWindow)
        mainWindow.RunWithScene (scene)

    override this.ApplicationDidEnterBackground ( application:CCApplication) =
        // stop all of the animation actions that are running.
        application.Paused <- true
        // if you use SimpleAudioEngine, your music must be paused
        CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic ()

    override this.ApplicationWillEnterForeground ( application:CCApplication) =
        application.Paused <- false;
        // if you use SimpleAudioEngine, your background music track must resume here. 
        CCSimpleAudioEngine.SharedEngine.ResumeBackgroundMusic ()
