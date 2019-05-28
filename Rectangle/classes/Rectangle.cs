using System;
namespace Rectangle.classes
{   
    // Implemented two classes by accident.. 
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

        public void setPositon(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public float GetX()
        {
            return _x;
        }
        public float GetY()
        {
            return _y;
        }
        public float GetZ()
        {
            return _z;
        }
    }

    public class VectorIn3D : I3dVector
    {
        private float _compenentX;
        private float _compenentY;
        private float _compenentZ;

        public void SetVector(float x, float y, float z)
        {
            _compenentX = x;
            _compenentY = y;
            _compenentZ = z;
        }

        public float getXComponent()
        {
            return _compenentX;
        }
        public float getYComponent()
        {
            return _compenentY;
        }
        public float getZComponent()
        {
            return _compenentZ;
        }

    }


}
