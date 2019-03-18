using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareTweet : MonoBehaviour
{
    private const string _twitterAddress = "https://twitter.com/intent/tweet";

    public void ShareToTwitter()
    {
        if (ScoreManager.SCORE > ScoreManager.HIGH_SCORE)
        {
            Application.OpenURL(_twitterAddress + "?text=" + WWW.EscapeURL("Congratulations! You earned a high score of " + ScoreManager.SCORE));
        }
        else
        {
            Application.OpenURL(_twitterAddress + "?text=" + WWW.EscapeURL("Congratulations! You earned a score of " + ScoreManager.SCORE));
        }
    }
}
