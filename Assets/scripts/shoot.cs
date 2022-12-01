using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if(audio == null) {
          audio = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            Instantiate(arrow, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        }
    }
}
