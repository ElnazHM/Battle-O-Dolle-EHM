using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpinJackPot : MonoBehaviour
{
    int jackpotTicket;
    int itemNum;
    int rewardIndex;
    public GameObject spinBtn;
    public Text prizeTxt;
    Animator handleAnimator;
    public GameObject handle;



    void Start()
    {
        jackpotTicket = 1;
        handleAnimator = handle.GetComponent<Animator>();
    }


    void Update()
    {
        if (jackpotTicket >= 1)
        {
            spinBtn.SetActive(true);
        }
        else if (jackpotTicket < 1)
        {
            spinBtn.SetActive(false);
        }
    }

    public void OnSpinClicked()
    {
       // handleAnimator.GetBool("JackPotHandle") = true;
        jackpotTicket = jackpotTicket - 1;
        itemNum = Random.Range(1, 11);
        if (itemNum == 1)
        {
            rewardIndex = 0;
            jackpotTicket = jackpotTicket + 1;
        }
        else if (itemNum == 2)
        {
            rewardIndex = 1;
        }
        else if (itemNum == 3 || itemNum ==4)
        {
            rewardIndex = 4;
        }
        else if (itemNum == 5 || itemNum == 6)
        {
            rewardIndex = 5;
        }
        else if (itemNum >6)
        {
            int rnd = Random.Range(1, 3);
            if (rnd==1)
            {
                rewardIndex = 2;
            }
            else
            {
                rewardIndex = 3;
            }
        }
        JackPotRewards myReward = new JackPotRewards(rewardIndex);
        prizeTxt.text = myReward.currentReward;
    }
}
