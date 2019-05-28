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


    public interface IRectangleAccessable
    {
        I3dPoint getPosition();
        Iangle AngleWithXYPlane();
        Iangle AngleWithXZPlane();
        Iangle AngleWithYZPlane();
        Iangle AngleWithGivenVector(I3dVector vector );
    }

    public interface IRectangleChangable
    {
        void SetPosition();
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
