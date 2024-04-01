using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElementCheck_Manager : MonoBehaviour
{
    public string selectedElement;

    GameObject element;

    public GameObject[] FinalElements;  
    public GameObject checkYES;
    public GameObject checkNO;

    public Animator anim;

    public TMP_Text checkText;

    public CheckingElement checkElement;
    public bool[] elementChecked;



    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("inRange", true);

        if (other.gameObject.GetComponent<ExperimentBool>() != null)
        {
            // Check if the name is in the list of elements
            string[] validNames = { "Aluminum1", "Calcium1", "Lithium1", "Magnesium1", "Sodium1", "Potassium1", "Nitrogen1", "Oxygen1", "Fluorine1", "Chlorine1", "Phosphorus1", "Sulfur1" };

            if (ArrayContains(validNames, other.gameObject.name))
            {
                if(other.gameObject.GetComponent<ExperimentBool>().hasBeenExperimentedOn == true)
                {
                    selectedElement = other.gameObject.name;

                    element = other.gameObject;

                    Debug.Log("Valid element selected");
                }
                else
                {
                    Debug.Log("Invalid element selected. Make sure you have experimented with it beforehand.");
                }
            }
            else
            {
                // Object has "ExperimentBool" script but an invalid name
                Debug.Log("Invalid element selected.");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //selectedElement = "";

        anim.SetBool("inRange", false);

        checkYES.SetActive(false);
        checkNO.SetActive(false);
    }

    // Helper method to check if an array contains a specific value
    private bool ArrayContains(string[] array, string value)
    {
        foreach (string element in array)
        {
            if (element.Equals(value))
            {
                return true;
            }
        }
        return false;
    }

    public void LiButton()
    {
        if (!elementChecked[4])
        {
            if (selectedElement == "Lithium1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[4], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[4] = true;
                checkElement.particle[2].StopParticle();
                checkText.text = "Li";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }
    }

    public void NaButton()
    {
        if (!elementChecked[10])
        {
            if (selectedElement == "Sodium1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[10], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[10] = true;
                checkElement.particle[5].StopParticle();
                checkText.text = "Na";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }
        }

    }

    public void MgButton()
    {
        if (!elementChecked[5])
        {
            if (selectedElement == "Magnesium1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[5], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[5] = true;
                checkElement.particle[3].StopParticle();
                checkText.text = "Mg";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }
        }

    }

    public void AlButton()
    {
        if (!elementChecked[0])
        {
            if (selectedElement == "Aluminum1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[0], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[0] = true;
                checkElement.particle[0].StopParticle();
                checkText.text = "Al";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }
    }

    public void KButton()
    {
        if (!elementChecked[9])
        {
            if (selectedElement == "Potassium1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[9], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[9] = true;
                checkElement.particle[4].StopParticle();
                checkText.text = "K";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }
    }

    public void CaButton()
    {
        if (!elementChecked[1])
        {
            if (selectedElement == "Calcium1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[1], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[1] = true;
                checkElement.particle[1].StopParticle();
                checkText.text = "Ca";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }
        }

    }

    public void NButton()
    {
        if (!elementChecked[6])
        {
            if (selectedElement == "Nitrogen1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[6], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[6] = true;

                checkText.text = "N";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }

    }

    public void OButton()
    {
        if (!elementChecked[7])
        {
            if (selectedElement == "Oxygen1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[7], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[7] = true;

                checkText.text = "O";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }
    }

    public void FButton()
    {
        if (!elementChecked[3])
        {
            if (selectedElement == "Fluorine1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[3], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[3] = true;

                checkText.text = "F";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }

    }

    public void ClButton()
    {
        if (!elementChecked[2])
        {
            if (selectedElement == "Chlorine1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[2], transform.position, Quaternion.Euler(0, 0, 0));

                elementChecked[2] = true;

                Destroy(element);

                checkText.text = "Cl";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }

    }

    public void SButton()
    {
        if (!elementChecked[11])
        {
            if (selectedElement == "Sulfur1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[11], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[11] = true;

                checkText.text = "S";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }

    }

    public void PButton()
    {
        if (!elementChecked[8])
        {
            if (selectedElement == "Phosphorus1")
            {
                checkNO.SetActive(false);
                checkYES.SetActive(true);

                Instantiate(FinalElements[8], transform.position, Quaternion.Euler(0, 0, 0));

                Destroy(element);

                elementChecked[8] = true;

                checkText.text = "P";
            }
            else
            {
                checkNO.SetActive(true);
                checkYES.SetActive(false);
            }

        }

    }




}
