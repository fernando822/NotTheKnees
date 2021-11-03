using UnityEditor;
using UnityEngine;

public class CreateBuild : MonoBehaviour
{
    public static string nombreDelJuego = System.Environment.GetEnvironmentVariable("GAME_NAME");
    public static string version = System.Environment.GetEnvironmentVariable("VERSION");
    public static void BuildWindows32(){
        string ruta = ".\\Versiones\\" + version + "\\Windows32\\" + nombreDelJuego + ".exe";

        BuildPipeline.BuildPlayer(
            new string[]{
                "Assets\\Scenes\\Menu\\MainMenu.unity",
                "Assets\\Scenes\\Menu\\OptionMenu.unity",
                "Assets\\Scenes\\AventuraGrafica\\AventuraGrafica.unity",
                "Assets\\Scenes\\AventuraGrafica\\Taller.unity",
                "Assets\\Scenes\\AventuraGrafica\\Torneo.unity",
                "Assets\\Scenes\\Carrera\\CarreraDeDemolicion.unity",
                "Assets\\Scenes\\Carrera\\SegundaCarreraDemolicion.unity",
                "Assets\\Scenes\\Carrera\\TerceraCarreraDemolicion.unity"
            },
            ruta,
            BuildTarget.StandaloneWindows,
            BuildOptions.None
        );
    }
    public static void BuildWindows64(){
        string ruta = ".\\Versiones\\" + version + "\\Windows64\\" + nombreDelJuego + ".exe";

        BuildPipeline.BuildPlayer(
            new string[]{
                "Assets\\Scenes\\Menu\\MainMenu.unity",
                "Assets\\Scenes\\Menu\\OptionMenu.unity",
                "Assets\\Scenes\\AventuraGrafica\\AventuraGrafica.unity",
                "Assets\\Scenes\\AventuraGrafica\\Taller.unity",
                "Assets\\Scenes\\AventuraGrafica\\Torneo.unity",
                "Assets\\Scenes\\Carrera\\CarreraDeDemolicion.unity",
                "Assets\\Scenes\\Carrera\\SegundaCarreraDemolicion.unity",
                "Assets\\Scenes\\Carrera\\TerceraCarreraDemolicion.unity"
            },
            ruta,
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
        );
    }
}
