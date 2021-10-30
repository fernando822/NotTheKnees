using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class PlayerTest
{
    [OneTimeSetUp]
    public void LoadScene()
    {
        SceneManager.LoadScene("AventuraGrafica");
    }
    
    [UnityTest]
    public IEnumerator TestPlayerMovementX()
    {
        GameObject player = GameObject.Find("Player");
        AdventureGraphicMovement script = player.GetComponent<AdventureGraphicMovement>();
        float initialXPos = player.transform.position.x;
        float initialZPos = player.transform.position.z;
        script.SetNewHorizontalPosition(1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(player.transform.position.x, initialXPos);
    }
    [UnityTest]
    public IEnumerator TestPlayerMovementZ()
    {
        GameObject player = GameObject.Find("Player");
        AdventureGraphicMovement script = player.GetComponent<AdventureGraphicMovement>();
        float initialZPos = player.transform.position.z;
        script.SetNewVerticalPosition(1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(player.transform.position.z, initialZPos);
    }
    
}
