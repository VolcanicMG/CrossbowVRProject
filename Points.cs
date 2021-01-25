using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class Points : MonoBehaviour
{
    public Text PointDisplay;
    public Text TextObject;
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        TextObject.text = null;

    }

    // Update is called once per frame
    void Update()
    {
            check();
            //Invoke("check", 0.2f);
            TextObject.text = null;

        

    }

    void check()
    {
        if (TextObject.text.Equals("WOW!"))
        {
            points += 10;

        }
        else if (TextObject.text.Equals("COOL!"))
        {
            points += 5;

        }
        else if (TextObject.text.Equals("INSANE!"))
        {
            points += 30;

        }
        else if (TextObject.text.Equals("CRAZY!"))
        {
            points += 15;

        }
        else if (TextObject.text.Equals("MADMAN!"))
        {
            points += 25;

        }
        else if (TextObject.text.Equals("KILLIN IT!"))
        {
            points += 10;

        }
        else if (TextObject.text.Equals("YUCK!"))
        {
            points += 1;

        }
        else if (TextObject.text.Equals("POOR!"))
        {
            points += 5;

        }
        else if (TextObject.text.Equals("EH NOT BAD!"))
        {
            points += 15;

        }
        else if (TextObject.text.Equals("COULD BE BETTER!"))
        {
            points += 10;

        }
        else if (TextObject.text.Equals("TRY AGAIN!"))
        {
            points += 5;

        }
        else if (TextObject.text.Equals("HMMM!"))
        {
            points += 2;

        }
        else if (TextObject.text.Equals("YOU DID IT!"))
        {
            points += 15;

        }
        else if (TextObject.text.Equals("A TRUE HERO!"))
        {
            points += 120;

        }
        else if (TextObject.text.Equals("HOLY BUCKETS!"))
        {
            points += 30;

        }
        else if (TextObject.text.Equals("WOO HOO!"))
        {
            points += 75;

        }
        else if (TextObject.text.Equals("GOT EM!"))
        {
            points += 30;

        }
        else if (TextObject.text.Equals("WINNER!"))
        {
            points += 20;

        }
        else if (TextObject.text.Equals("WOAH!"))
        {
            points += 10;

        }


        PointDisplay.text = points + "";
    }

}
