// Código feito para o Lap Time -> tempo de cada volta na corrida
// Atualiza o tempo em millisegundos, segundos e minutos no Text Box da UI (painel do canto superior direito)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    void Update()
    {
        // Atualiza valor de millisegundo no box de texto da UI
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if(MilliCount >= 10){
            MilliCount = 0;
            SecondCount += 1; // conta 1 segundo
        }
        
        // Atualiza segundos
        if(SecondCount <= 9){
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ":";
        }
        else{
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ":";
        }

        if(SecondCount >= 60){
            SecondCount = 0;
            MinuteCount += 1; // conta 1 minuto
        }

        // Atualiza minutos
        if(MinuteCount <= 9){
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else{
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }

    }
}
