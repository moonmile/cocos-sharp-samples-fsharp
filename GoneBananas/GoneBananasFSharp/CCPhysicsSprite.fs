namespace GoneBananas
open System
open Box2D.Common
open Box2D.Dynamics
open CocosSharp

type CCPhysicsSprite(f:CCTexture2D, r:Nullable<CCRect>, ptm:float)  =
    inherit CCSprite(f, r)

    let ptmRatio = float32 ptm 

    member val PhysicsBody:b2Body = null with get, set
    override this.AffineLocalTransform
        with get() = 
            if this.PhysicsBody = null then
                base.AffineLocalTransform
            else
                let pos = this.PhysicsBody.Position
                let mutable x = pos.x * ptmRatio
                let mutable y = pos.y * ptmRatio

                if this.IgnoreAnchorPointForPosition then
                    x <- x + this.AnchorPointInPoints.X
                    y <- x + this.AnchorPointInPoints.Y
                // Make matrix
                let radians = float this.PhysicsBody.Angle
                let c = float32 (Math.Cos (radians))
                let s = float32 (Math.Sin (radians))

                if this.AnchorPointInPoints.Equals(CCPoint.Zero) = false then
                    x <- x + c * -this.AnchorPointInPoints.X + -s * -this.AnchorPointInPoints.Y
                    y <- y + s * -this.AnchorPointInPoints.X + c * -this.AnchorPointInPoints.Y
                // Rot, Translate Matrix
                new CCAffineTransform (c, s, -s, c, x, y)
                                                                      