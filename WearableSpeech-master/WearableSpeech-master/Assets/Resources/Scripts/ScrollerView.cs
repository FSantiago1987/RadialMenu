using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollerView : MonoBehaviour
{
    public GameObject Button_Template;
    GameObject Scroller_Title;
    private List<string> NameList = new List<string>();
    private List<string> Food_Beverages_List = new List<string>();
    GameObject go;
    void Start()
    {
        Scroller_Title = GameObject.Find("ScrollerTwoTitleText");


        NameList.Add("Food & Beverages");
        NameList.Add("Driver");
        NameList.Add("Text Message");
        NameList.Add("Contacts");
        NameList.Add("Reminders");
        NameList.Add("Dominos");
        NameList.Add("Starbucks");
        NameList.Add("Pizza Nova");
        NameList.Add("Pizza Hut");
        NameList.Add("Pizza Pizza");
        NameList.Add("Tim Hortons");
        NameList.Add("McDonald's");
        NameList.Add("Wendy's");
        NameList.Add("Popeyes");
        NameList.Add("A&W");
        NameList.Add("Burger King");
        NameList.Add("Burger Priest");
        NameList.Add("Chipotle");


        foreach (string str in NameList)
        {
           go = Instantiate(Button_Template) as GameObject;
            go.SetActive(true);
           ScrollerButton TB = go.GetComponent<ScrollerButton>();
            TB.SetName(str);
           go.transform.SetParent(Button_Template.transform.parent);

        }


  }
 
     public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");

        if (str == "Food & Beverages")
        {
            Scroller_Title.GetComponent<Text>().text = "Food & Beverages";

            // go.SetActive(false);

            // Now pass the list of buttons to the Food & Beverages Scroller.... In child Script

        }

    }
}
