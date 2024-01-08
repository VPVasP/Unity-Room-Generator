using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateRoom : MonoBehaviour
{
    //fields for our walls
    [SerializeField] private Transform leftWall;
    [SerializeField] private Transform rightWall;
    [SerializeField] private Transform FrontWall;
    [SerializeField] private Transform backWall;
    [SerializeField] private Transform ground;
    //fields for our colors
    [SerializeField] private Color leftWallColor;
    [SerializeField] private Color rightWallColor;
    [SerializeField] private Color upWallColor;
    [SerializeField] private Color downWallColor;
    [SerializeField] private Color groundColor;
    //our size with initiale size to fit the room scale
    [SerializeField] private Vector3 size= new Vector3(10f,2.5f,1f);//what i reccomend
    //the name of the object
    [SerializeField] private string objectName;
    #region Generators

    //generating a room with colors,size and a name
    public void GenerateRoom()
    {
        SetColors(leftWall, leftWallColor);
        SetColors(rightWall, rightWallColor);
        SetColors(FrontWall, upWallColor);
        SetColors(backWall, groundColor);
        SetColors(ground, groundColor);
        SetSize(leftWall, size);
        SetSize(rightWall, size);
        SetSize(backWall, size);
        SetSize(FrontWall, size);
        this.name = objectName;
    }
    //generates colors for the walls and the floor
    public void GenerateColors()
    {
        SetColors(leftWall, leftWallColor);
        SetColors(rightWall, rightWallColor);
        SetColors(FrontWall, upWallColor);
        SetColors(backWall, downWallColor);
        SetColors(ground, groundColor);
    }
    //generates sizes for walls and ground
    public void GenerateSize()
    {
        SetSize(leftWall, size);
        SetSize(rightWall, size);
        SetSize(backWall, size);
        SetSize(FrontWall, size);
        SetSize(FrontWall, size);
        SetSize(ground, size);
    }
    //generates name for the gameobject
    public void GenerateName()
    {
        this.name = objectName;
    }
    #endregion Generators
    #region SetValues
    //seting the values of the colors
    private void SetColors(Transform wall,Color color)
    {
        Renderer wallRenderer = wall.GetComponent<Renderer>();
        wallRenderer.sharedMaterial.color = color;
    }
    //seting the sizes of the walls and floor
    private void SetSize(Transform wall,Vector3 size)
    {
        wall.localScale = size;
    }
    
   
}
    #endregion SetValues

