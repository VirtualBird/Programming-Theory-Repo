using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodSpearResource : Resource // INHERITANCE
{
    public Text StatusText;

    //Need to know what resources are required
    public WoodResource wood;
    public StoneResource stone;

    const int REQUIRED_WOOD = 5;
    const int REQUIRED_STONE = 1;

    //  Instead of just adding a resource, this resource needs to use other resources to be created
    public override void MakeResource()// POLYMORPHISM
    {
        //If stone and wood is available, consume stone and wood and make Wood Spear

        if (stone.amount >= REQUIRED_STONE &&
            wood.amount >= REQUIRED_WOOD)
        {
            //Consume the stone and wood
            wood.ReduceAmount(REQUIRED_WOOD);
            stone.ReduceAmount(REQUIRED_STONE);

            //Make a spear
            AddAmount(1);
            StatusText.text = "Created Wood Spear!";
        }
        else //If some resources are not available
        {
            if (stone.amount < REQUIRED_STONE)
            {
                Debug.Log("Not enough stone! You need " + REQUIRED_STONE + " stone");
                StatusText.text = "Not enough stone! You need " + REQUIRED_STONE + " stone";
            }
            if (wood.amount < REQUIRED_WOOD)
            {
                Debug.Log("Not enough wood! You need " + REQUIRED_WOOD + " wood");
                StatusText.text = "Not enough wood! You need " + REQUIRED_WOOD + " wood";
            }
        }
    }
}
