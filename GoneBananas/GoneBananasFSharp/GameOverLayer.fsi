namespace GoneBananas

open System
open System.Collections.Generic
open CocosDenshion
open CocosSharp
open System.Linq

open Box2D.Common
open Box2D.Dynamics
open Box2D.Collision.Shapes

[<Class>]
type GameOverLayer =
    inherit CCLayerColor 
    new : score : int -> GameOverLayer
    static member SceneWithScore : CCWindow * int -> CCScene


