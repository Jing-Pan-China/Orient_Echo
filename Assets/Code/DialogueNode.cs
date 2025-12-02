using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Dialogue/Node")]
public class DialogueNode : ScriptableObject 
{    
    
    // Start is called before the first frame update

    [TextArea]
    public string text;
    public DialogueNode nextNode;

}


