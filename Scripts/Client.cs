using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public float HoursOfSun;
    public bool Flower;
    public bool Thorns;

    public SpriteRenderer agarita;
    public Text agaritadesc;
    public GameObject agaritatext;
    public SpriteRenderer cactus;
    public Text cactusdesc;
    public GameObject cactustext;
    public SpriteRenderer lambsear;
    public Text lambseardesc;
    public GameObject lambseartext;
    public SpriteRenderer sunflower;
    public Text sunflowerdesc;
    public GameObject sunflowertext;
    public SpriteRenderer holly;
    public Text hollydesc;
    public GameObject hollytext;
    public SpriteRenderer firethorn;
    public Text firethorndesc;
    public GameObject firethorntext;
    public SpriteRenderer carrots;
    public Text carrotsdesc;
    public GameObject carrotstext;
    public SpriteRenderer viola;
    public Text violadesc;
    public GameObject violatext;
    public SpriteRenderer barberry;
    public Text barberrydesc;
    public GameObject barberrytext;
    public SpriteRenderer rhododendron;
    public Text rhododendrondesc;
    public GameObject rhododendrontext;
    public SpriteRenderer inkberry;
    public Text inkberrydesc;
    public GameObject inkberrytext;
    public SpriteRenderer fuchsia;
    public Text fuchsiadesc;
    public GameObject fuchsiatext;

    void UpdateFlowers()
    {
        agarita.enabled = false;
        agaritadesc.enabled = false;
        cactus.enabled = false;
        cactusdesc.enabled = false;
        lambsear.enabled = false;
        lambseardesc.enabled = false;
        sunflower.enabled = false;
        sunflowerdesc.enabled = false;
        holly.enabled = false;
        hollydesc.enabled = false;
        firethorn.enabled = false;
        firethorndesc.enabled = false;
        carrots.enabled = false;
        carrotsdesc.enabled = false;
        viola.enabled = false;
        violadesc.enabled = false;
        barberry.enabled = false;
        barberrydesc.enabled = false;
        rhododendron.enabled = false;
        rhododendrondesc.enabled = false;
        inkberry.enabled = false;
        inkberrydesc.enabled = false;
        fuchsia.enabled = false;
        fuchsiadesc.enabled = false;
    }

    void Start()
    {
        UpdateFlowers();

        HoursOfSun = Mathf.Max(HoursOfSun, HoursOfSun);
    }

    void Update()
    {
        PlantRequirements requirements = new PlantRequirements();
        requirements.HoursOfSun = HoursOfSun;
        requirements.Flower = Flower;
        requirements.Thorns = Thorns;

        if (Input.GetKeyDown(KeyCode.F))
        {
            Flower = !Flower;
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            Thorns = !Thorns;
        }
        if(Input.GetKey("1"))
        {
            HoursOfSun = 1;
        }
        if(Input.GetKey("2"))
        {
            HoursOfSun = 4;
        }
        if(Input.GetKey("3"))
        {
            HoursOfSun = 6;
        }

        UpdateFlowers();

        IPlant p = GetPlant(requirements);
        Debug.Log(p);

        if (HoursOfSun >= 6)
        {
            if (Flower)
            {
                if (Thorns)
                {
                    cactus.enabled = true;
                    cactusdesc.enabled = true;
                }
                else
                {
                    sunflower.enabled = true;
                    sunflowerdesc.enabled = true;
                }
            }
            else
            {
                if (Thorns)
                {
                    agarita.enabled = true;
                    agaritadesc.enabled = true;
                }
                else
                {
                    lambsear.enabled = true;
                    lambseardesc.enabled = true;
                }
            }
        }
        else if (HoursOfSun < 6 && HoursOfSun >= 3)
        {
            if (Flower)
            {
                if (Thorns)
                {
                    firethorn.enabled = true;
                    firethorndesc.enabled = true;
                }
                else
                {
                    viola.enabled = true;
                    violadesc.enabled = true;
                }
            }
            else
            {
                if (Thorns)
                {
                    holly.enabled = true;
                    hollydesc.enabled = true;
                }
                else
                {
                    carrots.enabled = true;
                    carrotsdesc.enabled = true;
                }
            }
        }
        else
        {
            if (Flower)
            {
                if (Thorns)
                {
                    rhododendron.enabled = true;
                    rhododendrondesc.enabled = true;
                }
                else
                {
                    fuchsia.enabled = true;
                    fuchsiadesc.enabled = true;
                }
            }
            else
            {
                if (Thorns)
                {
                    barberry.enabled = true;
                    barberrydesc.enabled = true;
                }
                else
                {
                    inkberry.enabled = true;
                    inkberrydesc.enabled = true;
                }
            }
        }
    }

    private static IPlant GetPlant(PlantRequirements requirements)
    {
        PlantFactory factory = new PlantFactory(requirements);
        return factory.Create();
    }
}