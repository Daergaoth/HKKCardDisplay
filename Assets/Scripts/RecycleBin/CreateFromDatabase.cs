using System.IO;
using UnityEngine;
using Vuforia;

public class CreateFromDatabase : MonoBehaviour
{
    string dataSetPath = "Vuforia/HKK_AR_Display.xml";
    string targetName = "Matilda";

    // Start is called before the first frame update
    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaInitialized += OnVuforiaInitialized;
    }

    void OnVuforiaInitialized(VuforiaInitError error)
    {
        if (error == VuforiaInitError.NONE)
            OnVuforiaStarted();
    }

    // Load and activate a data set at the given path.
    void OnVuforiaStarted()
    {
        // Create an Image Target from the database.
        var mImageTarget = VuforiaBehaviour.Instance.ObserverFactory.CreateImageTarget(
            dataSetPath,
            targetName);
        mImageTarget.OnTargetStatusChanged += OnTargetStatusChanged;
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        Debug.Log($"target status: {status.Status}");
    }
}