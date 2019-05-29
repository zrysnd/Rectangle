using System;
namespace Rectangle.classes
{

    public interface Iangle
    {
        float getAngle();
    }

    public interface ILengthGettable
    {
        float GetLength();
    }

    public interface IScalable
    {
        void scale(float multiplier);
    }

    public interface IRelocatable 
    {
        void Relocate(float x, float y, float z);
        void MoveAlongX(float distance);
        void MoveAlongY(float distance);
        void MoveAlongZ(float distance);
    }

    public interface IPointNotMovableIn3D
    {
        float GetX();
        float GetY();
        float GetZ();
    }

    public interface Ilocatable
    {
        IPointNotMovableIn3D GetLocation();
    }

    public interface IPointIn3D: IPointNotMovableIn3D, IRelocatable
    {
    }

    public interface IVectorLengthFixedIn3D: IPointNotMovableIn3D, ILengthGettable
    {
    }

    public interface IVectorIn3D : IVectorLengthFixedIn3D, IScalable
    {
        void SetLength(float length);
    }

    public interface IRectangleAccessable: Ilocatable
    {
        // I think GetVector is necessary to measure angles.
        IVectorLengthFixedIn3D GetVector1();
        IVectorLengthFixedIn3D GetVector2();
        //return float or ILengthGettable? If returning interface, it's easier to change
        //which primitive type to use for length, but makes client code longer, need to add
        //call .GetLength() to get real length data.
        ILengthGettable GetLongerEdgeLength();
        ILengthGettable GetShorterEdgeLength();
    }

    public interface IRotatable
    {
        void RotateAlongAxis(Iangle angle, IVectorLengthFixedIn3D axis);
    }

    public interface IRectangle: IRectangleAccessable, IRelocatable, IScalable, IRotatable
    {
        void SetVectors(IVectorIn3D vector1, IVectorIn3D vector2);
    }

    public interface IAngleMeasurer
    {
        /*tried to think of a way making vectors and rectangles the same type, and 
        have only one function here, but couldn't do it*/
        Iangle messureAngle(IVectorLengthFixedIn3D vector1, IVectorLengthFixedIn3D vector2);
        Iangle messureAngle(IVectorLengthFixedIn3D vector, IRectangleAccessable rectangle);
        Iangle messureAngle(IRectangleAccessable rectangle1, IRectangleAccessable rectangle2);
    }








}
