using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInstializerLast : MonoBehaviour
{
#if UNITY_IOS
    private string gameId = "";
#elif UNITY_ANDROID
    private string gameId = "4258797";
#endif

    bool testMode = true;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        
    }

    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        else
        {
            Debug.Log("Interstitial ad not ready at the moment! please try again later!");
        }
    }
}
