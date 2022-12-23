using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using DG.Tweening;
using System.Linq;
using UnityEngine.UI;

public class StepManager : MonoBehaviour
{
    

    #region variable

    RaycastHit hit;
    Ray ray;

    public int step;

    
    




    public static bool key;
    public static int num;
    public static float timer;
    public static bool even;
    public static int step_count;


    public GameObject pencil_obj1;
    public GameObject pencil_obj2;
    public GameObject Disk;
    public GameObject paper1;
    public GameObject paper2;
    public GameObject paper3;

    public GameObject script;

    public GameObject okno;
    [SerializeField] InputField field1;
    [SerializeField] InputField field2;
    [SerializeField] InputField field3;


    #endregion


    void Start()
    {
        step_count = 1;
        key = false;
        timer = 6;
        even = false;
       

    }

void Update()
    {
        
        step = step_count;
        if (!InputManager.isPaused)
        {
            if (key)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    key = false;
                    Step();
                }
            }

            //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit, 3f))
            //{
            //
            //    if (Input.GetKeyDown(KeyCode.Mouse0))
            //    {
            //        hit.collider.gameObject.SetActive(false);
            //        text.SetActive(true);

            //        text.GetComponent<TextMesh>().text = "ХУЙ!!!!";
            //
            //        step_count++;
            //    }
            //
            //}
            if (okno.activeInHierarchy)
            {
                PlayerController.instance.state = PlayerController.State.Stop;
                script.SetActive(false);
                if (Input.GetKey(KeyCode.Escape))
                {
                    okno.SetActive(false);
                    PlayerController.instance.state = PlayerController.State.Move;
                    script.SetActive(true);
                }
            }
            
            
                


            #region Шаг 1
            if (step_count == 1)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("korpus") || hit.collider.gameObject.name.Equals("Pencil_obj") || hit.collider.gameObject.name.Equals("verh") || hit.collider.gameObject.name.Equals("disk_s_pazom"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            okno.SetActive(true);
                        }
                    }
                }
            }
            #endregion

            #region Шаг 1.2
            if (step_count == 102)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("korpus") || hit.collider.gameObject.name.Equals("Pencil_obj") || hit.collider.gameObject.name.Equals("verh") || hit.collider.gameObject.name.Equals("disk_s_pazom"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            pencil_obj1.SetActive(false);

                            //text.SetActive(true);

                            //text.GetComponent<TextMesh>().text = "ХУЙ!!!!";

                            pencil_obj2.SetActive(true);

                            step_count = 2;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 2
            if (step_count == 2)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("korpus") || hit.collider.gameObject.name.Equals("Pencil_obj2") || hit.collider.gameObject.name.Equals("verh") || hit.collider.gameObject.name.Equals("disk_s_pazom"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            //pencil_obj1.SetActive(false);

                            //text.SetActive(true);

                            //text.GetComponent<TextMesh>().text = "ХУЙ!!!!";

                            pencil_obj2.GetComponent<Animator>().Play("Draw");

                            step_count = -300;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 3
            if (step_count == 3)
            {
                Disk.transform.Rotate(Vector3.up, 20f);

                step_count++;
            }
            #endregion

            #region Шаг 4
            if (step_count == 4)
            {
                pencil_obj2.GetComponent<Animator>().Play("Draw2");

                step_count = -300;
            }
            #endregion

            #region Шаг 5
            if (step_count == 5)
            {
                Disk.transform.Rotate(Vector3.up, 20f);

                step_count++;
            }
            #endregion

            #region Шаг 6
            if (step_count == 6)
            {
                pencil_obj2.GetComponent<Animator>().Play("Draw3");

                step_count = -300;
            }
            #endregion

            #region Шаг 7
            if (step_count == 7)
            {
                Disk.transform.Rotate(Vector3.up, 20f);

                step_count++;
            }
            #endregion

            #region Шаг 8
            if (step_count == 8)
            {
                pencil_obj2.GetComponent<Animator>().Play("Draw4");

                step_count = -300;
            }
            #endregion

            #region Шаг 9
            if (step_count == 9)
            {
                Disk.transform.Rotate(Vector3.up, 20f);

                step_count++;
            }
            #endregion

            #region Шаг 10
            if (step_count == 10)
            {
                pencil_obj2.GetComponent<Animator>().Play("Draw5");
                paper1.SetActive(false);
                paper2.SetActive(true);
                step_count++;
            }
            #endregion

            #region Шаг 11
            if (step_count == 11)
            {
                if (hit.collider.gameObject.name.Equals("korpus") || hit.collider.gameObject.name.Equals("Pencil_obj2") || hit.collider.gameObject.name.Equals("verh") || hit.collider.gameObject.name.Equals("disk_s_pazom"))
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        pencil_obj2.SetActive(false);

                        //text.SetActive(true);

                        //text.GetComponent<TextMesh>().text = "ХУЙ!!!!";

                        pencil_obj1.SetActive(true);

                        step_count++;
                    }
                }
            }
            #endregion

            #region Шаг 12
            if (step_count == 12)
            {
                if (hit.collider.gameObject.name.Equals("korpus") || hit.collider.gameObject.name.Equals("Pencil_obj2") || hit.collider.gameObject.name.Equals("verh") || hit.collider.gameObject.name.Equals("disk_s_pazom"))
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        paper2.SetActive(false);
                        paper3.SetActive(true);

                        step_count++;
                    }
                }
            }
            #endregion








            //if (Input.GetKey(KeyCode.E))
            //{
            //    okno.SetActive(!okno.activeInHierarchy);
            //
            //}









            //if (Input.GetKey(KeyCode.E))
            //{
            //
            //    StartCoroutine(doZalupa());
            //}





        }
    }

    //IEnumerator doZalupa()
    //{
    //    Dictionary<float, Vector3> points = new Dictionary<float, Vector3>();
    //
    //    points.Add(1.01f, new Vector3(-0.02965f, 0, 0.0778f));
    //
    //    points.Add(1.02f, new Vector3(-0.15581f, 0, 0));
    //    points.Add(1.03f, new Vector3(-0.0287f, 0, -0.0738f));
    //    points.Add(1.04f, new Vector3(-0.0124f, 0, -0.644f));
    //
    //
    //    //Obj.GetComponent<Animator>().Play("RotateDisk");
    //    int len = points.Count;
    //    for (int i = 0; i < len; i++)
    //    {
    //        pencil.transform.DOMove(pencil.transform.position + points.Values.ElementAt(i), points.Keys.ElementAt(i));
    //
    //        yield return new WaitForSeconds(points.Keys.ElementAt(i));
    //    }
    //
    //    yield return null;
    //}
















    public void Button_click()
    {
        if (field1.text.ToString() == "-10" && field2.text.ToString() == "0" && field3.text.ToString() == "10")
        {
            okno.SetActive(false);
            PlayerController.instance.state = PlayerController.State.Move;
            step_count = 102;
            script.SetActive(true);
        }
    }



    bool IsCouldUse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if(Physics.Raycast(ray, out hit, 15))
        {
               
            return true;
        }
        
        return false;
    }




    public void Step()
    {
        even = false;
        InputManager.isStopedController = false;
        //Time.timeScale = 1f;
        timer = 6;
        
        step_count = 7 + num;
    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
