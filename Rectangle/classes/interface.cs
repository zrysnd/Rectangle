using System;
namespace Rectangle.classes
{

    public interface Iangle
    {
        float getAngle();
    }

    public interface I3dPoint
    {   
        float GetX();
        float GetY();
        float GetZ();
    }

    public interface I3dVector : I3dPoint
    {
    }

    public interface I3dVectorScalable : I3dVector
    {
        void scale(float multplier);
    }

    public interface IAngleMessurer
    {
        /*tried to think of a way making vectors and rectangles the same type, and 
        have only one function here, but couldn't do it*/
        Iangle messureAngle(I3dVector vector1, I3dVector vector2);
        Iangle messureAngle(I3dVector vector, IRectangleAccessable rectangle);
        Iangle messureAngle(IRectangleAccessable rectangle1, IRectangleAccessable rectangle2);
    }

    public interface IRectangleAccessable
    {
        I3dPoint getPosition();
        I3dVector GetVector1();
        I3dVector GetVector2();
    }

    public interface IRectangleChangable
    {
        void SetPosition( I3dPoint startPoint );
        void SetVectors(I3dVector vector1, I3dVector vector2);
        /*not sure whether following functions are good*/
        void SetAngleWithXYPlane(Iangle angle);
        void SetAngleWithXZPlane(Iangle angle);
        void SetAngleWithYZPlane(Iangle angle);
        void SetAngleWithGivenVector(I3dVector vector, Iangle angle);
    }

    public interface IRectangle : IRectangleChangable, IRectangleAccessable
    {
    }

    public interface IRectangleScalable: IRectangle
    {
        void scaleRectangle(float multplier);
    }
}
