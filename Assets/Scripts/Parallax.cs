using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float startpos;    
    public GameObject cam;    
    public float parallaxEffect;


   
    void Start()
    {
        startpos = transform.position.x;        
    }

   
    void FixedUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect;

        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);        
    }
}
