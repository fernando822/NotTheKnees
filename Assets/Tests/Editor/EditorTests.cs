using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditorTests
{
    [Test]
    public void TestControlPanelClosed()
    {
        GameObject gameManager = new GameObject();
        GameManager GM = gameManager.AddComponent<GameManager>();
        GM.PlayerShowControls();
        Assert.IsFalse(Estados.DevolverEstado("isUiOpen"));
    }
    
}
