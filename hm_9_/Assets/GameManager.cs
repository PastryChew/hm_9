using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text textballCount;
    int ballcount;
    
    
    public void Counter()
    {
        ballcount++;
        textballCount.text = $"Забито шаров: {ballcount}";
       
        
    }
}
