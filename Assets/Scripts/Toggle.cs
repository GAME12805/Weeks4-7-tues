using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleShape()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        ////if the game object is inactive (turned off): call SetActive passing true
        //if(gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}
        //else if(gameObject.activeInHierarchy == true)
        //{
        //    //otherwise (the game object is active, turned on): call SetActive and pass false
        //    gameObject.SetActive(false);
        //}

    }
}
