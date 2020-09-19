using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    public Camera playerCamera;
    public string objectMask;
    LongSword longSword = new LongSword();
    int inc;

    // Start is called before the first frame update
    void Start()
    {
        inc = 2;

        //for (int i = 0; i < GameManager.weaponinventory.Length; i++)
        //{
        //    inc++;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = playerCamera.ViewportPointToRay(Vector3.one / 2f);
        LayerMask mask = LayerMask.GetMask("Block");

        if (Physics.Raycast(ray, out hit, 10f, mask))
        {
            if (hit.collider.tag == "LSword")
            {

                if (Input.GetKeyUp(KeyCode.E))
                {

                    GameManager.storeWeapon(longSword, inc);
                    Debug.Log("Picked up Long Sword...");
                    inc++;

                }

            }
        }


    }
}
