using System;
namespace Rectangle.classes
{


    public interface I3dPoint
    {   
        float GetX();
        float GetY();
        float GetZ();
    }

    public interface I3dVector
    {
        float getXComponent();
        float getYComponent();
        float getZComponent();
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
