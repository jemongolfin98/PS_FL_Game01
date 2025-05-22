using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Setup
    public void ChooseHousing()
    {
        if (payHousing == 0)
        {
            housingSelected = "None";
            noHousing = true;
            ucfHousing = false;
            offHousing = false;

            housingSelectScreen01.SetActive(false);
            housingSelectScreenConfirmed.SetActive(true);

        }
        else if (payHousing == 1)
        {
            noHousing = false;

            housingSelectScreen01.SetActive(false);
            housingSelectScreenYES.SetActive(true);
        }
    }
    public void ChooseHousingNo()
    {
        payHousing = 0;
        ChooseHousing();
    }
    public void ChooseHousingYes()
    {
        payHousing = 1;
        ChooseHousing();
    }
    public void ChooseHousingUCF()
    {
        housingSelected = "UCF Housing";
        ucfHousing = true;
        offHousing = false;

        housingSelectScreenYES.SetActive(false);
        housingSelectScreenUCF.SetActive(true);
    }
    public void ChooseHousingUCFPay()
    {
        initialHousingCost = ;
        monthlyHousingCost = 0.00;

        housingSelectScreenUCF.SetActive(false);
        housingSelectScreenConfirmed.SetActive(false);
    }
    public void ChooseHousingOff()
    {
        housingSelected = "Off-Campus Housing";
        ucfHousing = false;
        offHousing = true;

        housingSelectScreenYES.SetActive(false);
        housingSelectScreenOff.SetActive(true);
    }
    public void ChooseHousingOffPay()
    {
        initialHousingCost = 0.00;
        monthlyHousingCost = ;

        housingSelectScreenOff.SetActive(false);
        housingSelectScreenConfirmed.SetActive(true);
    }

    public void ChooseFood()
    {
        if (payFood == 0)
        {
            foodSelected = "None";
            noFood = true;

            foodSelectScreen01.SetActive(false);
            foodSelectScreenConfirmed.SetActive(true);

        }
        else if (payFood == 1)
        {
            noFood = false;

            foodSelectScreen01.SetActive(false);
            foodSelectScreenYES.SetActive(true);
        }
    }
    public void ChooseFoodNo()
    {
        payFood = 0;
        ChooseFood();
    }
    public void ChooseFoodYes()
    {
        payFood = 1;
        ChooseFood();
    }
    public void ChooseFoodUCF()
    {
        foodSelected = "UCF Meal Plan";
        foodMealPlan = true;

        
    }
    public void ChooseFoodNoUCF()
    {

    }
    
    // Transitions
}
