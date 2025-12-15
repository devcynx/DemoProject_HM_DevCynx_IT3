//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class platformscript : MonoBehaviour
//{
//    public int scenename;
//    public int nextscene;
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        GetComponent<Rigidbody>().AddForce(Vector3.left * UnityEngine.Random.Range(01.1f, 2f), ForceMode.VelocityChange);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//    private void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.CompareTag("candy"))
//            SceneManager.LoadScene(nextscene);

//        if (collision.gameObject.CompareTag("Respawn"))
//            SceneManager.LoadScene(scenename);
//    }
//}
