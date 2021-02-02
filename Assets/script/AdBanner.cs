using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class AdBanner : MonoBehaviour
{
    //readonly string test_unitID = "ca-app-pub-3940256099942544/6300978111";
    readonly string test_deviceID = "F9718320682BFCF6D67E941AFE01270D";

    readonly string unitID = "ca-app-pub-1897076914961848/8036884490";

    BannerView banner;

    public const string AD_ON = "AD";
    public int adOn;
    // Start is called before the first frame update
    public void Init()
    {
        InitAd();
    }

    void InitAd()
    {
        banner = new BannerView(unitID, AdSize.Banner, AdPosition.Top);

        AdRequest.Builder builder = new AdRequest.Builder();
        builder.AddTestDevice(test_deviceID);
        AdRequest request = builder.Build();

        banner.OnAdLoaded += OnAdLoaded;
        banner.OnAdFailedToLoad += OnAdFailedToLoad;
        banner.OnAdOpening += OnAdOpening;
        banner.OnAdClosed += OnAdClosed;
        banner.OnAdLeavingApplication += OnAdLeavingApplication;

        banner.LoadAd(request);
        adOn = 1;
        PlayerPrefs.SetInt(AD_ON, adOn);
        

    }


    public void OnAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("[AdBanner] OnAdLoaded");
    }
    public void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        //args : arguments
        Debug.Log("[AdBanner] OnAdFailedToLoad");
    }
    public void OnAdOpening(object sender, EventArgs args)
    {
        Debug.Log("[AdBanner] OnAdOpening");
    }
    public void OnAdClosed(object sender, EventArgs args)
    {
        Debug.Log("[AdBanner] OnAdClosed");
    }
    public void OnAdLeavingApplication(object sender, EventArgs args)
    {
        Debug.Log("[AdBanner] OnAdLeavingApplication");
    }
    public void DestroyAd()
    {
        banner.Destroy();
        adOn = 0;
        PlayerPrefs.SetInt(AD_ON, adOn);
        
        Debug.Log("광고제거");
    }

    

}