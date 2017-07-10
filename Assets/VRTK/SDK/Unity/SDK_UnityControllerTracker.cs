namespace VRTK
{
    using UnityEngine;
    using UnityEngine.VR;

    public class SDK_UnityControllerTracker : MonoBehaviour
    {
        public VRNode nodeType;
        public uint index;
        public string triggerAxisName = "";
        public string gripAxisName = "";
        public string touchpadHorizontalAxisName = "";
        public string touchpadVerticalAxisName = "";

        protected virtual void OnEnable()
        {
            CheckAxisIsValid(triggerAxisName, "triggerAxisName");
            CheckAxisIsValid(gripAxisName, "gripAxisName");
            CheckAxisIsValid(touchpadHorizontalAxisName, "touchpadHorizontalAxisName");
            CheckAxisIsValid(touchpadVerticalAxisName, "touchpadVerticalAxisName");
        }

        protected virtual string GetVarName<T>(T item) where T : class
        {
            return typeof(T).GetProperties()[0].Name;
        }

        protected virtual void CheckAxisIsValid(string axisName, string varName)
        {
            try
            {
                Input.GetAxis(axisName);
            }
            catch (System.ArgumentException ae)
            {
                VRTK_Logger.Warn(ae.Message + " on index [" + index + "] variable [" + varName + "]");
            }
        }

        protected virtual void FixedUpdate()
        {
            transform.localPosition = InputTracking.GetLocalPosition(nodeType);
            transform.localRotation = InputTracking.GetLocalRotation(nodeType);
        }
    }
}