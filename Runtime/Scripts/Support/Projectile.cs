using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TestTools;

[ExcludeFromCoverage]
public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    public float initialVelocity;
    public Key FireKey;

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard[FireKey].wasPressedThisFrame)
        {
            // Remove other projectiles from the scene
            foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Projectile"))
            {
                GameObject.Destroy(obj);
            }

            var projectileInstance = GameObject.Instantiate(projectile, this.transform.position, Quaternion.identity);
            projectileInstance.GetComponent<Rigidbody>().linearVelocity = initialVelocity * this.transform.forward;
        }
    }
}
