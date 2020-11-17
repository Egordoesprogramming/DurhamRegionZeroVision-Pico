using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighlightAtGaze : MonoBehaviour
{
    public Color HighlightColor = Color.red;
    public float AnimationTime = 0.1f;
    public Text countText;

    private int count;
    private Renderer myRenderer;
    private Color originalColor;
    private Color targetColor;
    private Pvr_UnitySDKAPI.EyeTrackingGazeRay gazeRay;

    private void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
        targetColor = originalColor;
        count = 0;
        countText.text = count.ToString(); 
    }

    private void Update()
    {
        Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingGazeRay(ref gazeRay);
        Ray ray = new Ray(gazeRay.Origin, gazeRay.Direction);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == transform.name)
            {
                if (targetColor != HighlightColor)
                {
                    targetColor = HighlightColor;
                    count = count + 1;
                    countText.text = count.ToString();
                }

            }
            else
            {
                if (targetColor != originalColor)
                    targetColor = originalColor;
            }               

        }
        else
        {
            if (targetColor != originalColor)
                targetColor = originalColor;
        }

        /*if (timer == true)
        {
            theTime += Time.deltaTime;
            string seconds = (theTime % 60).ToString("0");
            text.text = seconds;
        }*/

        myRenderer.material.color = Color.Lerp(myRenderer.material.color, targetColor, Time.deltaTime * (1 / AnimationTime));
    }
}