using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class WandLogic : MonoBehaviour
{
    public Vector2 leftWand01 = new Vector2 (-4, -4);
    public Vector2 rightWand01 = new Vector2(4, -4);
    public Vector2 leftWand02 = new Vector2(0, 0);
    public Vector2 rightWand02 = new Vector2(0, 0);
    public GameObject spellPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            CastSpell(leftWand01);
        }

        if (Input.GetKeyDown("d"))
        {
            CastSpell(rightWand01);
        }

        if (Input.GetKeyDown("j"))
        {
            CastSpell(leftWand02);
        }

        if (Input.GetKeyDown("l"))
        {
            CastSpell(rightWand02);
        }
    }

    public void CastSpell(Vector2 wandPos)
    {
        GameObject newSpell = Instantiate(spellPrefab, wandPos, Quaternion.identity);
    }
}
