using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    //public GameObject slider;
    public Slider slider;

    public GameObject mountain;

    void Start()
    {
        mountain.transform.position = new Vector3(mountain.transform.position.x, gameObject.gameObject.transform.position.y, mountain.transform.position.z);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.transform.position.y < 2.015f && other.gameObject.transform.position.y > 0.884f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, other.gameObject.transform.position.y, gameObject.transform.position.z);
            slider.value = 1-(gameObject.transform.position.y-.884f) /(2.015f - .884f);
            mountain.transform.position = new Vector3(mountain.transform.position.x, gameObject.gameObject.transform.position.y, mountain.transform.position.z);
        }
    }
}
