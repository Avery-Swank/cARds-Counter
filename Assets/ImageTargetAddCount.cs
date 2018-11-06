using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetAddCount : MonoBehaviour, ITrackableEventHandler {

    private TrackableBehaviour m_behavior;

    public int m_countValue;

    void Start()
    {
        m_behavior = GetComponent<TrackableBehaviour>();

        // Register if found
        if (m_behavior)
            m_behavior.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        // Update running count when an image is found
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            RunningCount.PlusValue(m_countValue);
        }
    }
}
