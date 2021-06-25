using GoogleMobileAds.Api;
using UnityEngine;

public class Ads : MonoBehaviour
{

    public void Start()
    {
        // Initialize the Mobile Ads SDK.
        MobileAds.Initialize((initStatus) =>
        {
            // SDK initialization is complete
        });
    }

    public void OnBannerAdFailedToLoad(string reason)
    {
        Debug.Log("Banner ad failed to load: " + reason);
    }
}
