using UnityEngine;

public class StopPlayer : MonoBehaviour
{
    private SteamVR_TrackedController _controller;
    private PrimitiveType _currentPrimitiveType = PrimitiveType.Sphere;

    

    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();
        _controller.TriggerClicked += HandleTriggerClicked;
    }

    private void OnDisable()
    {
        _controller.TriggerClicked -= HandleTriggerClicked;
    }

    private void HandleTriggerClicked(object sender, ClickedEventArgs e)
    {
        // SpawnCurrentPrimitiveAtController();
        SlowToStop();
    }

    private void SlowToStop()
    {
        Debug.Log("Stopping");
        GM.Me.Stop = true;
    }

   
}