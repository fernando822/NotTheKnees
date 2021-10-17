using UnityEditor;
using UnityEngine;

public class CreateBuild : MonoBehaviour
{
    public static string version = System.Environment.GetEnvironmentVariable("VERSION");
    public static string gameName = System.Environment.GetEnvironmentVariable("GAME_NAME");
    public static void BuildWindows32(){
        string path = ".\\Builds\\" + version + "\\Windows32\\" + gameName + ".exe";

        BuildPipeline.BuildPlayer(
            new string[]{
                "Assets\\Scenes\\MainMenu.unity",
                "Assets\\Scenes\\OptionMenu.unity",
                "Assets\\Scenes\\AventuraGrafica\\AventuraGrafica.unity",
                "Assets\\Scenes\\AventuraGrafica\\Taller.unity",
                "Assets\\Scenes\\AventuraGrafica\\Torneo.unity",
                "Assets\\Scenes\\Carrera\\CarreraDeDemolicion.unity",
                "Assets\\Scenes\\Carrera\\SegundaCarreraDemolicion.unity"
            },
            path,
            BuildTarget.StandaloneWindows,
            BuildOptions.None
        );
    }
    public static void BuildWindows64(){
        string path = ".\\Builds\\" + version + "\\Windows64\\" + gameName + ".exe";

        BuildPipeline.BuildPlayer(
            new string[]{
                "Assets\\Scenes\\MainMenu.unity",
                "Assets\\Scenes\\OptionMenu.unity",
                "Assets\\Scenes\\AventuraGrafica\\AventuraGrafica.unity",
                "Assets\\Scenes\\AventuraGrafica\\Taller.unity",
                "Assets\\Scenes\\AventuraGrafica\\Torneo.unity",
                "Assets\\Scenes\\Carrera\\CarreraDeDemolicion.unity",
                "Assets\\Scenes\\Carrera\\SegundaCarreraDemolicion.unity"
            },
            path,
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
        );
    }
}
