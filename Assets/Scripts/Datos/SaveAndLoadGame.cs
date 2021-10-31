using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SaveAndLoadGame{
    public static void SaveData(){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        FileStream stream = new FileStream(path + "/Data.ntk", FileMode.Create);
        GameData data = new GameData();
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static GameData LoadData(){
        string path = Application.persistentDataPath + "/data";
        if (File.Exists(path + "/Data.ntk")){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path + "/Data.ntk", FileMode.Open);
            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();
            return data;
        }else{
            Debug.Log("No se encontraron datos");
            return null;
        }
    }
    public static void SaveScene(){
        string nombreEscena = SceneManager.GetActiveScene().name;
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        FileStream stream = new FileStream(path + "/Scene.ntk", FileMode.Create);
        GameData data = new GameData();
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static GameData LoadScene(){
        string path = Application.persistentDataPath + "/data";
        if (File.Exists(path + "/Scene.ntk")){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path + "/Scene.ntk", FileMode.Open);
            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();
            return data;
        }else{
            Debug.Log("No se encontraron datos");
            return null;
        }
    }
    public static void SaveConfig(OptionMenu settings){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        FileStream stream = new FileStream(path + "/Config.ntk", FileMode.Create);
        ConfigData data = new ConfigData(settings);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static ConfigData LoadConfig(){
        string path = Application.persistentDataPath + "/data";
        if (File.Exists(path + "/Config.ntk")){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path + "/Config.ntk", FileMode.Open);
            ConfigData data = formatter.Deserialize(stream) as ConfigData;
            stream.Close();
            return data;
        }else{
            Debug.Log("No se encontro configuracion");
            return null;
        } 
    }
}
