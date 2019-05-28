using System;
namespace Rectangle.classes
{   
    public class PointIn3D : I3dPoint
    {
        private float _x;
        private float _y;
        private float _z;

        public float GetX(){}

        public float GetY(){}

        public float GetZ(){}
    }

    public class AngleMeasurer : IAngleMeasurer
    {

    }

    public class VectorIn3D : PointIn3D, I3dVector
    {

    }

    public class VectorIn3DScalable: VectorIn3D, I3dVectorScalable
    {
        public void scale(float multplier){}
    }

    public class Rectangle : IRectangle
    {
        private I3dPoint _startPoint;
        private I3dVectorScalable _vector1;
        private I3dVectorScalable _vector2;

        private void checkRep(){}
    }

    public class RectangleScalable : Rectangle, IRectangleScalable
    {
        public void scaleRectangle(float multplier){}
    }

}
