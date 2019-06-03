using System;
namespace Rectangle.classes
{

    public interface Iangle
    {
        float Angle { get; }
    }

    public interface ILengthGettable
    {
        float Length { get; }//use property (look up in C#), instead of function getter  -> changed to property.
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
        float X { get; } //use property (look up in C#), instead of function getter -> changed to property.
        float Y { get; }
        float Z { get; }
    }

    public interface Ilocatable
    {
        IPointNotMovableIn3D Location { get; }//use property (look up in C#), instead of function getter
    }

    public interface IPointIn3D: IPointNotMovableIn3D, IRelocatable
    {
    }

    public interface IVectorImmutableIn3D: IPointNotMovableIn3D, ILengthGettable // not only its length is fixed, by your construction its everything is fixed -> interface name changed.
    {
    }

    /*
    public interface IVectorIn3D : IVectorImmutableIn3D, IScalable
    // IVectorIn3D is lengthfixed is not movable, but it is scalable? scale is move
    //^ Realized that I don't need this interface, so removed it. 
    {
        void SetLength(float length);
    }
    */

    public interface IRectangleAccessable: Ilocatable
    {
        IVectorImmutableIn3D Vector1 { get; } //use property (look up in C#), instead of function getter
        IVectorImmutableIn3D Vector2 { get; }
        ILengthGettable GetLongerEdgeLength();
        ILengthGettable GetShorterEdgeLength();
    }

    public interface IRotatable
    {
        void RotateAlongAxis(Iangle angle, IVectorImmutableIn3D axis);
    }

    public interface IRectangle: IRectangleAccessable, IRelocatable, IScalable, IRotatable
    {
        //you're exposing its implementation too early -> setVectors() removed.
    }

    /*
    public interface IAngleMeasurer //??????? -> removed.
    {   
        Iangle messureAngle(IVectorImmutableIn3D vector1, IVectorImmutableIn3D vector2);
        Iangle messureAngle(IVectorImmutableIn3D vector, IRectangleAccessable rectangle);
        Iangle messureAngle(IRectangleAccessable rectangle1, IRectangleAccessable rectangle2);
    }
    */








}
