using System;
namespace Rectangle.classes
{


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
        I3dVector getVector1();
        I3dVector getVector2();
    }

    public interface IRectangleChangable
    {
        void SetPosition();
        void SetVectors();
    }

    public interface IRectangle : IRectangleChangable, IRectangleAccessable
    {
    }
}
