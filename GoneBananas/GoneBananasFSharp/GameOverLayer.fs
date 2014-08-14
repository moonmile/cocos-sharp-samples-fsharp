namespace GoneBananas
open System
open System.Collections.Generic
open CocosSharp
(* Move to GameLayer.fs 
type GameOverLayer(score:int) as this =
    inherit CCLayerColor()

    let mutable scoreMessage = System.String.Empty

    do 
        let touchListener = new CCEventListenerTouchAllAtOnce ()
        touchListener.OnTouchesEnded <- fun touches ccevent -> this.Window.DefaultDirector.ReplaceScene (GameLayer.GameScene (this.Window))
        this.AddEventListener (touchListener, this)
        scoreMessage <- String.Format ("Game Over. You collected {0} bananas!", score)
        this.Color <- new CCColor3B (CCColor4B.Black)
        this.Opacity <- byte 255

    member this.AddMonkey () =
        let spriteSheet = new CCSpriteSheet ("animations/monkey.plist")
        let frame = spriteSheet.Frames.Find ( fun x -> x.TextureFilename.StartsWith ("frame"))
           
        let monkey = 
            new CCSprite (frame, 
                Position = 
                    new CCPoint (this.VisibleBoundsWorldspace.Size.Center.X + 20.f, 
                        this.VisibleBoundsWorldspace.Size.Center.Y + 300.f),
                Scale = 0.5f )
        this.AddChild (monkey)

    override this.AddedToScene () =
        base.AddedToScene ()
        this.Scene.SceneResolutionPolicy <- CCSceneResolutionPolicy.ShowAll

        let scoreLabel = 
            new CCLabelTtf (scoreMessage, "arial", 22.f, 
                Position = new CCPoint (this.VisibleBoundsWorldspace.Size.Center.X, this.VisibleBoundsWorldspace.Size.Center.Y + 50.f),
                Color = new CCColor3B (CCColor4B.Yellow),
                HorizontalAlignment = CCTextAlignment.Center,
                VerticalAlignment = CCVerticalTextAlignment.Center,
                AnchorPoint = CCPoint.AnchorMiddle,
                Dimensions = this.ContentSize )
        this.AddChild (scoreLabel);

        let playAgainLabel = 
            new CCLabelTtf ("Tap to Play Again", "arial", 22.f, 
                Position = this.VisibleBoundsWorldspace.Size.Center,
                Color = new CCColor3B (CCColor4B.Green),
                HorizontalAlignment = CCTextAlignment.Center,
                VerticalAlignment = CCVerticalTextAlignment.Center,
                AnchorPoint = CCPoint.AnchorMiddle,
                Dimensions = this.ContentSize )

        this.AddChild (playAgainLabel);

        this.AddMonkey ()

    static member SceneWithScore ((mainWindow:CCWindow), (score:int))  =
        let scene = new CCScene (mainWindow)
        let layer = new GameOverLayer (score)
        scene.AddChild (layer)
        scene;
*)