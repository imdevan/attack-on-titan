using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {

        void OnCollisionEnter(Collision col)
        {
		if(col.gameObject.tag == "enemy") 
            {
			//Application.Quit ();    
			//Application.LoadLevel("Exit Menu");

             }
	
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player") 
		{
			//Application.Quit ();    
			Application.LoadLevel("Exit Menu");
			
		}

	}
}
