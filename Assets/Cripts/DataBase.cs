using UnityEngine;

public static class DataBase
{
    public static int AltinSayisi;
    public static Vector3 SpawnPosition;
    public static void LoadData()
    {
        AltinSayisi = PlayerPrefs.GetInt("AltinYasisi");
    }
    public static void SaveData()
    {
        PlayerPrefs.SetInt("AltinYasisi", AltinSayisi);
    }
}
