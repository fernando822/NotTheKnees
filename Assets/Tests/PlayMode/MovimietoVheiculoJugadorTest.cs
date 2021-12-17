using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class MovimietoVheiculoJugadorTest
{

    [OneTimeSetUp]
    public void LoadScene()
    {
      //  SceneManager.LoadScene("CarreraDeDemolicion");
        //GameObject gameManager = new GameObject();
        //GameManager GM = gameManager.AddComponent<GameManager>();
    }

    
    [UnityTest]
    public IEnumerator Acereration()
    {
        GameObject Vehiculo = GameObject.Find("PlayerDemolitionRace");
        LogicaMovimientoVehiculo script = Vehiculo.GetComponent<LogicaMovimientoVehiculo>();
        script.Accelerate(1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(script.aceleration, script.torque);
    }

    [UnityTest]
    public IEnumerator Frenado()
    {
        GameObject Vehiculo = GameObject.Find("PlayerDemolitionRace");
        LogicaMovimientoVehiculo script = Vehiculo.GetComponent<LogicaMovimientoVehiculo>();
        script.Accelerate(-1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(script.aceleration, script.freno);
    }

    [UnityTest]
    public IEnumerator Direccion()
    {
        GameObject Vehiculo = GameObject.Find("PlayerDemolitionRace");
        LogicaMovimientoVehiculo script = Vehiculo.GetComponent<LogicaMovimientoVehiculo>();
        script.SetRotation(1f);
        yield return new WaitForSeconds(0.5f);
        Assert.Greater(script.anguloDireccion, script.direccion);
    }




}
