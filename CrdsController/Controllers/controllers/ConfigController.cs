using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrdsController.Controllers
{
    public class ConfigController
    {
        public static ConfigController @Instance
        {
            get => SingleTon<ConfigController>.Instance;
        }

        private bool bSearchLightControl = false;
        private bool bEOIRCameraControl = true;
        private bool bSpeakerControl = false;
        private bool bCCTVControl = false;
        private bool bParachuteControl = false;
        private bool bVirtualJoystickControl = false;
        private int MapIndex = 0; //"http://localhost/Coast3857/" + "{z}/{x}/{y}.png";

        public void SetSearchLightControl(bool bEnable)
        {
            bSearchLightControl = bEnable;
        }

        public bool GetSearchLightControl()
        {
            return bSearchLightControl;
        }

        public void SetEOIRCameraControl(bool bEnable)
        {
            bEOIRCameraControl = bEnable;
        }

        public bool GetEOIRCameraControl()
        {
            return bEOIRCameraControl;
        }

        public void SetSpeakerControl(bool bEnable)
        {
            bSpeakerControl = bEnable;
        }

        public bool GetSpeakerControl()
        {
            return bSpeakerControl;
        }

        public void SetCCTVControl(bool bEnable)
        {
            bCCTVControl = bEnable;
        }

        public bool GetCCTVControl()
        {
            return bCCTVControl;
        }

        public void SetParachuteControl(bool bEnable)
        {
            bParachuteControl = bEnable;
        }

        public bool GetParachuteControl()
        {
            return bParachuteControl;
        }

        public void SetVirtualJoystickControl(bool bEnable)
        {
            bVirtualJoystickControl = bEnable;
        }

        public bool GetVirtualJoystickControl()
        {
            return bVirtualJoystickControl;
        }

        public void SetCustomMapIndex(int mapIndex)
        {
            MapIndex = mapIndex;
        }

        public int GetCustomMapIndex()
        {          
            return MapIndex;
        }
    }
}
