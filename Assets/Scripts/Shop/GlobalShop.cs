using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalShop : MonoBehaviour {

    public static string Item01;
    public static string Item02;
    public static string Item03;
    public static string Item04;

    public static int shopNumber;

    void Update () {
		
        if(shopNumber == 1)
        {
            Item01 = "chicken";
            Item02 = "pig";
            Item03 = "cow";
            Item04 = "pigeon";
        }
        if(shopNumber == 2)
        {
            Item01 = "diamond";
            Item02 = "emerald";
            Item03 = "redstone";
            Item04 = "";
        }

	}
}
