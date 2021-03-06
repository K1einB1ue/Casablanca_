using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogOut : MonoBehaviour
{
    public GameObject Instance;
    public Queue<DialogOutNode> DialogOutNodes = new Queue<DialogOutNode>();

    private void OnEnable() {
        EventManager.StoryChannelManager.OnSelectDialog.AddListenerOnce(this.UpdateNewDialog); 
    }

    public void UpdateNewDialog(string Dialog) {
        var temp = GameObject.Instantiate(Instance, this.transform).GetComponent<DialogOutNode>();
        temp.Text = Dialog;
        DialogOutNodes.Enqueue(temp);
        while(DialogOutNodes.Count > 10) {
            GameObject.Destroy(DialogOutNodes.Dequeue().gameObject);
        }

    }

    

}
