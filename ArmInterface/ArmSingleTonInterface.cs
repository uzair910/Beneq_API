using System;

namespace ArmInterface
{
    public sealed class ArmSingletonInterface
    {
        private ArmSingletonInterface() { }
        private static ArmSingletonInterface _obj = null;
        private static bool isPicked = true;
        public static ArmSingletonInterface Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ArmSingletonInterface();
                    isPicked = false;
                }
                return _obj;
            }
        }
        public bool PickObject()
        {
            if (!isPicked)
            {
                isPicked = true;
                return true;
            }
            else
                return false;
        }
        public bool DropObject()
        {
            if (isPicked)
            {
                isPicked = false;
                return true;
            }
            else
                return false;
        }

        public bool MoveObject(int iDir)
        {
            try
            {
                Direction dir = iDir.ToDirectionEnum<Direction>();
                if (isPicked) // Object can be moved to any direction aslong as the arm is holding the object (isPicked = true)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
           
          

        }


    }
}



