using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(CreateRoom))]
public class EditorManager : Editor
{
    public override void OnInspectorGUI()
    {
        //display the inspector Gui for the room object
        base.OnInspectorGUI();
        CreateRoom room = (CreateRoom)target;
        //button that generates a room with all options
        if(GUILayout.Button("Generate Room"))
        {
            Debug.Log("Generated Room with all options");
            room.GenerateRoom();
        }
        //button that generates a room colors
        if (GUILayout.Button("Set Only Colors"))
        {
            Debug.Log("Set Colors");
            room.GenerateColors();
        }
        //button that generates a room with a different size
        if (GUILayout.Button("Set Only Size"))
        {
            Debug.Log("Set Size");
            room.GenerateSize();
        }//button that changes the name of the room
        if (GUILayout.Button("Set Room Name"))
        {
            Debug.Log("Set Room Name");
            room.GenerateName();
        }

    }
}
