using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
	private Renderer cubeRenderer;
	private Color[] colors = { Color.red, Color.blue, Color.yellow };
	
	private int currentIndex = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
		cubeRenderer.material.color = colors[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			ChangeColor();
		}
    }
	
	void ChangeColor()
	{
		currentIndex = (currentIndex + 1) % colors.Length;
		cubeRenderer.material.color = colors[currentIndex];
	}
}
