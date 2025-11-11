using NUnit.Framework.Constraints;
using Unity.IntegerTime;
using UnityEngine;
using UnityEngine.UI;

public class logoResize : MonoBehaviour
{
    private Texture texture;         // Assign in Inspector
    private RawImage rawImage;      // Internal reference
    private AspectRatioFitter ratioFilter;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
        ratioFilter = GetComponent<AspectRatioFitter>();

        texture = rawImage.texture;
        ratioFilter.aspectRatio = (float)texture.width / texture.height;

    }
}
