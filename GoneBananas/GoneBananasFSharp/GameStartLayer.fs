namespace GoneBananas
open System
open System.Collections.Generic
open CocosSharp

type GameStartLayer() as this =
    inherit CCLayerColor()

    do
        let touchListener = new CCEventListenerTouchAllAtOnce ()
        touchListener.OnTouchesEnded <- fun touches ccevent-> this.Window.DefaultDirector.ReplaceScene (GameLayer.GameScene (this.Window))
        this.AddEventListener (touchListener, this)
        this.Color <- CCColor3B.Black
        this.Opacity <- byte 255

    override this.AddedToScene () =
        base.AddedToScene ()
        this.Scene.SceneResolutionPolicy <- CCSceneResolutionPolicy.ShowAll
        let label = new CCLabelTtf ("Tap Screen to Go Bananas!", "arial", 22.f,
                                        Position = this.VisibleBoundsWorldspace.Center,
                                        Color = CCColor3B.Green,
                                        HorizontalAlignment = CCTextAlignment.Center,
                                        VerticalAlignment = CCVerticalTextAlignment.Center,
                                        AnchorPoint = CCPoint.AnchorMiddle,
                                        Dimensions = this.ContentSize  )
        this.AddChild (label)

    static member GameStartLayerScene (mainWindow:CCWindow):CCScene =
        let scene = new CCScene (mainWindow)
        let layer = new GameStartLayer ()
        scene.AddChild (layer)
        scene;
