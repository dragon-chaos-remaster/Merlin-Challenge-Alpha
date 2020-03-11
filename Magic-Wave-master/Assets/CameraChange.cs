using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] Animator camerasAnimator;

    //[SerializeField] bool trocarIlha = true;

    [SerializeField] int nIlha;


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            camerasAnimator.SetInteger("nIlha", nIlha);

            //camerasAnimator.SetBool("trocarDeIlha", trocarIlha);
            //StartCoroutine(TempoPraTrocar());
        }

    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "player")
    //    {
    //        camerasAnimator.SetInteger("nIlha", 0);
    //    }
    //}

    //IEnumerator TempoPraTrocar()
    //{
    //    yield return new WaitForSeconds(1f);
    //    trocarIlha = false;

    //}

}
