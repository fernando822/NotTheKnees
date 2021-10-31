using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class PlaymodeTest
{
    [OneTimeSetUp]
    public void LoadScene()
    {
        SceneManager.LoadScene("AventuraGrafica nueva");
        GameObject gameManager = new GameObject();
        GameManager GM = gameManager.AddComponent<GameManager>();
    }

    [UnityTest]
    public IEnumerator PlayerMoveX()
    {
        GameObject player = GameObject.Find("Player");
        AdventureGraphicMovement script = player.GetComponent<AdventureGraphicMovement>();
        float initialXPos = player.transform.position.x;
        script.SetNewHorizontalPosition(1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(player.transform.position.x, initialXPos);
    }
    [UnityTest]
    public IEnumerator PlayerMoveZ()
    {
        GameObject player = GameObject.Find("Player");
        AdventureGraphicMovement script = player.GetComponent<AdventureGraphicMovement>();
        float initialZPos = player.transform.position.z;
        script.SetNewVerticalPosition(1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(player.transform.position.z, initialZPos);
    }
}
