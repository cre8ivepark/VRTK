// Unity System|SDK_Unity|001
namespace VRTK
{
    /// <summary>
    /// The Unity System SDK script provides a bridge to the Unity SDK.
    /// </summary>
    [SDK_Description("Unity (Oculus)", null, "Oculus", "Standalone")]
    [SDK_Description("Unity (OpenVR)", null, "OpenVR", "Standalone", 1)]
    [SDK_Description("Unity (Daydream)", null, "Daydream", "Android", 2)]
    [SDK_Description("Unity (GearVR)", null, "Oculus", "Android", 3)]
    public class SDK_UnitySystem : SDK_BaseSystem
    {
        /// <summary>
        /// The IsDisplayOnDesktop method returns true if the display is extending the desktop.
        /// </summary>
        /// <returns>Returns true if the display is extending the desktop</returns>
        public override bool IsDisplayOnDesktop()
        {
            return false;
        }

        /// <summary>
        /// The ShouldAppRenderWithLowResources method is used to determine if the Unity app should use low resource mode. Typically true when the dashboard is showing.
        /// </summary>
        /// <returns>Returns true if the Unity app should render with low resources.</returns>
        public override bool ShouldAppRenderWithLowResources()
        {
            return false;
        }

        /// <summary>
        /// The ForceInterleavedReprojectionOn method determines whether Interleaved Reprojection should be forced on or off.
        /// </summary>
        /// <param name="force">If true then Interleaved Reprojection will be forced on, if false it will not be forced on.</param>
        public override void ForceInterleavedReprojectionOn(bool force)
        {
        }
    }
}