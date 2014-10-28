var target : Transform; //the enemy's target 
var moveSpeed : float = 10; //move speed 
var rotationSpeed : float = 5; //speed of turning

//var myTransform : Transform; //current transform data of this enemy

function Awake() { //myTransform = transform; //cache transform data for easy access/preformance 
				}

function Start() { //target = GameObject.FindWithTag("Player").transform; //target the player

}

function FixedUpdate () { 
//rotate to look at the player 
//myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);

 //move towards the player
 //myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
     transform.transform.LookAt(Vector3(target.position.x, transform.position.y, target.position.z));
   //  myTransform.transform.localEulerAngles = Vector3(0,transform.localEulerAngles.y,0);
   transform.position = Vector3.Lerp(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
 
}