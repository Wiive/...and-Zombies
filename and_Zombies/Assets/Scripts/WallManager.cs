using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public GameObject[] walls;

    StoreSectionBehavior section;

    private int currentWall = 0;

    private void Start()
    {
        section = walls[0].GetComponent<StoreSectionBehavior>();
        section.mainSection = true;
    }

    private void Update()
    {
        if (section.mainSection)
        {
            if (!section.CheckLeftPointVisibility())
            {
                MoveWallsBack(walls[currentWall]);
            }
        }
    }
            

public void MoveWallsBack(GameObject wall)
    {
        GameObject wallLeftside = wall.GetComponent<StoreSectionBehavior>().leftPoint;
        if ((currentWall + 2) < walls.Length)
        {
            wall.transform.position = walls[currentWall + 2].GetComponent<StoreSectionBehavior>().rightPoint.transform.position; //Moving the selected wall to the end of the line

            if ((currentWall + 1) < walls.Length)
            {
                walls[currentWall + 1].GetComponent<StoreSectionBehavior>().mainSection = true;
            }
            else
            {
                walls[currentWall + 1].GetComponent<StoreSectionBehavior>().mainSection = true;
            }

            currentWall++;
        }
        else
        {
            currentWall = 0;
            wall.transform.position = walls[0].GetComponent<StoreSectionBehavior>().rightPoint.transform.position;
        }
    }
}
