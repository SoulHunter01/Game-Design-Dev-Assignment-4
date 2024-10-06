using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{

    [SerializeField] Transform launchPoint;
    [SerializeField] GameObject bulletPreFab;

    public void onFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            GameObject bullet =  Instantiate(bulletPreFab, launchPoint.position, bulletPreFab.transform.rotation);
            Vector3 origScale = bullet.transform.localScale;

            bullet.transform.localScale = new Vector3(
                origScale.x * transform.localScale.x > 0 ? 0.2f : -0.2f,
                origScale.y,
                origScale.z
                );
        }
    }
}
