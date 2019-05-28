using System;
namespace Rectangle.classes
{   
    public class Rectangle : IRectangle
    {
        private I3dPoint _startPoint;
        private I3dVector _vector1;
        private I3dVector _vector2;

        public Rectangle()
        {
        }
         
        public I3dPoint getPosition()
        {
            return _startPoint;
        }

        public I3dVector getVector1()
        {
            throw new NotImplementedException();
        }

        public I3dVector getVector2()
        {
            throw new NotImplementedException();
        }

        public void SetPosition()
        {
            throw new NotImplementedException();
        }

        public void SetVectors()
        {
            throw new NotImplementedException();
        }
    }

    public class PointIn3D : I3dPoint
    {
        private float _x;
        private float _y;
        private float _z;

        public PointIn3D()
        {
        }

        public float GetX()
        {
            throw new NotImplementedException();
        }

        public float GetY()
        {
            throw new NotImplementedException();
        }

        public float GetZ()
        {
            throw new NotImplementedException();
        }
    }

    public class VectorIn3D : PointIn3D, I3dVector
    {
        public void scale(float multplier)
        {

        }
    }


}
