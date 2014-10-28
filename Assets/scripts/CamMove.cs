using UnityEngine;
using System.Collections;


public class CamMove : MonoBehaviour {
    float distance = 40.0f;
    bool flag = false;
   
	// Update is called once per frame
	void Update () {
		Debug.Log("Y: "+rigidbody.position.y);
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click.");
            flag = true;
        }

        if (flag)
        {
            transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
			rigidbody.AddForce (Physics.gravity);

			if(rigidbody.position.y < 2)
			{

				flag = false;
				rigidbody.velocity = new Vector3(0.0f,0.0f ,0.0f);
				transform.position = transform.position;
				
			}
			//flag = false;

		}
		if(!flag)
		{
				/*rigidbody.AddForce (Physics.gravity);
				if(rigidbody.position.y < 5)
				{
					Debug.Log("Pressed right click.");
					//flag = false;
					rigidbody.velocity = new Vector3(0.0f,0.0f ,0.0f);
					
				}*/

			
		}
        if (Input.GetMouseButtonDown(1))
        {
			if(rigidbody.position.y > 0){
				Debug.Log("Pressed right click.");
				flag = false;
				rigidbody.AddForce (Physics.gravity);
				
			}
			rigidbody.AddForce (-(Physics.gravity));
			//rigidbody.AddForce (0.0f , -3.0f , 0.0f);
			//Physics.gravity = new Vector3( 0.0f, -3.0f, 0.0f);
        }

}
}