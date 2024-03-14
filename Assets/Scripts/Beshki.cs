using UnityEngine;

public class Beshki : MonoBehaviour
{
    public GameObject[] Particles;
    public Animator Door1, Door2, Door3, Door4;
    public GameObject shtoradel1, shtoradel2;
    public GameObject shtoraadd1, shtoraadd2;
    public GameObject text1, text2;
    public GameObject delShtori, DelBeshka;
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="hand")
        {
            foreach(GameObject particle in Particles)
            {
                particle.SetActive(true);
            }
            shtoraadd1.SetActive(true);
            shtoraadd2.SetActive(true);
            shtoradel1.SetActive(false);
            shtoradel2.SetActive(false);
            text1.SetActive(true);
            text2.SetActive(true);
            Door1.transform.rotation = Quaternion.Euler(90, 0, 90);
            Door2.transform.rotation = Quaternion.Euler(90, 0, 90);
            Door3.transform.rotation = Quaternion.Euler(90, 0, 90);
            Door4.transform.rotation = Quaternion.Euler(90, 0, 90);
            delShtori.SetActive(false);
            DelBeshka.SetActive(false);
        }
    
    }
}
