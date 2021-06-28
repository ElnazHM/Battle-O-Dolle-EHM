using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackPotRewards 
{
  
    
    private string[] rewards = {"AdWatchReuse","CommonChest","Give10Gold","Give20Gold", "Give30Gold","GiveHeroCard" };
    public string currentReward;

    public string[] Rewards
    {
        get
        {
            return rewards;
        }
        set
        {
            rewards = value;
        }
    }
    public JackPotRewards(int rewardInex)
    {
        this.currentReward = Rewards[rewardInex];
    }
    
}
