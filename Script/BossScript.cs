using UnityEngine;

public class BossScript : MonoBehaviour 
{
	    void OnTriggerEnter(Collider other)
    {
        // if the player or their bullet hits you....
        if (other.tag == "Player")
        {
			Die(other.gameObject);
        }
    }

	public void Die(GameObject other)
    {
        GameObject explode = GameObject.Instantiate(Resources.Load("Prefab/explode")) as GameObject;
        explode.transform.position = other.gameObject.transform.position;
        Destroy(other);
    }
}
