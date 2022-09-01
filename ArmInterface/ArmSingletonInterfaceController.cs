using System;

namespace ArmInterface
{
    public sealed class ArmSingletonInterfaceController
    {
        private ArmSingletonInterfaceController() { }
        private static ArmSingletonInterfaceController _obj = null;
        private static bool isPicked = true;
        public static ArmSingletonInterfaceController Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ArmSingletonInterfaceController();
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
                // ToDo: Invoke the actual method from the ArmInterface.
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



