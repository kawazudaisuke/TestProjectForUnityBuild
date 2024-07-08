using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class AlternataImage : MonoBehaviour
{
    [SerializeField] Image TargetImage;
    [SerializeField]Sprite originImage;
    [SerializeField]Sprite alternateImage;
    public  bool isChanged;


    // Start is called before the first frame update
    void Start()
    {
        isChanged = false;
    }

    public void ChangeImage()
    {
        if (!isChanged) 
        { 
            TargetImage.sprite =  alternateImage;
            isChanged = true;
            
        }
        else
        {
            TargetImage.sprite = originImage;
            isChanged = false;
        }
    }
}
